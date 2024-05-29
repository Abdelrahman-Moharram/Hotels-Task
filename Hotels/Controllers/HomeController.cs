using AutoMapper;
using Hotels.Constants;
using Hotels.Data;
using Hotels.Models;
using Hotels.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        [BindProperty]
        public List<RoomViewModel> Rooms { get; set; }
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            List<BooksListViewModel> booksListViewModel = _mapper.Map<List<BooksListViewModel>>(await _context.Books.ToListAsync());
            return View(booksListViewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(i=>i.Id == id);
            if (book == null)
                return NotFound();
            BooksListViewModel booksListViewModel = _mapper.Map<BooksListViewModel>(book);
            return View(booksListViewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            ViewBag.Branches = _context.Branches.Select(i=> new {i.Id, i.Name}).ToList();
            return View();
        }

        [HttpPost("create")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateBookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var book =  _mapper.Map<Book>(bookViewModel);
                
                if (book != null)
                {
                    book.Rooms.ForEach(i =>
                    {
                        i.Id = Guid.NewGuid().ToString();
                        i.BookId = book.Id;
                    });
                    book.Branch = null;
                    var customer = _context.Customers.FirstOrDefault(i => i.NationalId == book.Customer.NationalId);
                    if (customer?.Id != null)
                    {
                        book.discount = 5;
                        book.CustomerId = customer.Id;
                        book.Customer = customer;

                        foreach(var room in book.Rooms)
                        {
                            int price = (int)Enum.Parse(typeof(RoomTypes), room.RoomType);
                            book.TotalCost += price;
                        }
                        decimal discountValue = book.TotalCost * (decimal)(5.0 / 100.0);
                        book.TotalCost -= discountValue;
                    }
                    else
                    {
                        foreach (var room in book.Rooms)
                        {
                            int price = (int)Enum.Parse(typeof(RoomTypes), room.RoomType);
                            book.TotalCost += price;
                        }
                        book.CustomerId = book.Customer.Id;
                    }
                    await _context.Books.AddAsync(book);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewBag.Branches = _context.Branches.Select(i => new { i.Id, i.Name }).ToList();
            return View();
        }
        [Route("/home/checkNationalid/{nationalId}")]
        public IActionResult CheckNationalId(string nationalId)
        {
            return Json(new
            {
                exists_before = _context.Customers.Any(i => i.NationalId == nationalId)
            });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
