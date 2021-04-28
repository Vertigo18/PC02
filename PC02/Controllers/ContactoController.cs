using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PC02.Models;
using PC02.Data;

namespace PC02.Controllers
{
    
    public class Contacto : Controller
    {
        private ContactoContext _context;
        public Contacto(ContactoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Nuevo(ContactoModel p) {
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

    }
}