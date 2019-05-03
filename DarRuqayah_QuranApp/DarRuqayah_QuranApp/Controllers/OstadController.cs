using DarRuqayah_QuranApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Controllers
{
    public class OstadController : Controller
    {
        private readonly QuranAppContext context;

        public OstadController(QuranAppContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await context.Ostads.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OstadId,Name,Tell,Country,Birthday,CV,Address")]Ostad ostad)
        {
            if (ModelState.IsValid)
            {
                context.Ostads.Add(ostad);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ostad);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            return View(await context.Ostads.FindAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            return View(await context.Ostads.FindAsync(id));
        }

        public async Task<IActionResult> Edit(int id, Ostad ostad)
        {
            if (id != ostad.OstadId)
                return NotFound();
            if (ModelState.IsValid)
            {
                context.Ostads.Update(ostad);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ostad);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            return View(await context.Ostads.FindAsync(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ostad = await context.Ostads.FindAsync(id);
            context.Ostads.Remove(ostad);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





        public async Task<IActionResult> AdvancedSearch(string name)
        {
            var ostadFind = await context.Ostads.Where(c => c.Name.Contains(name)).ToListAsync();
            return PartialView("AdvancedSearch", ostadFind);



        }
    }
}
