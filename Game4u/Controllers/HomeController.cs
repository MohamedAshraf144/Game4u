using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Game4u.Controllers
{
    public class HomeController : Controller
    {

        
        private readonly IGamesService _gamesService;
        public HomeController(IGamesService gamesService)
        {
            _gamesService = gamesService;
            
        }

        public IActionResult Index(int currentPage = 1)
        {
            var games = _gamesService.GetAll();
            return View(games);
            int totalRecords = games.Count();
            var gameData = new GameFormViewModel();

            int pageSize = 5;
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            games = games.Skip((currentPage - 1) * pageSize).Take(pageSize);
            // current=1, skip= (1-1=0), take=5 
            // currentPage=2, skip (2-1)*5 = 5, take=5 ,
            gameData.Games = games;
            gameData.CurrentPage = currentPage;
            gameData.PageSize = pageSize;
            gameData.TotalPages = totalPages;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


       




    }
}
