using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaveVers.Models;

namespace SaveVers.Controllers
{
    public class JoinSelect : Controller
    {
        public IActionResult Index()
        {
            using (DB db = new DB()) 
            { 
                var list = db._analyzes.Include("Analyzes").ToList();
                return View(list);
            }
                
        }
    }
}
