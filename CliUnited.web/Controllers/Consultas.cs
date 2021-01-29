using Microsoft.AspNetCore.Mvc;
using CliUnited.web.Data;
using CliUnited.web.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CliUnited.web.Controllers
{
    public class Consultas : Controller
    {

        private readonly ConsultaContext _context;
        public Consultas(ConsultaContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Consulta consulta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(consulta);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Create));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            
            return View();
        }
    }
}
