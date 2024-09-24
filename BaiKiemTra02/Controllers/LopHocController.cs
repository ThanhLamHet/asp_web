using Microsoft.AspNetCore.Mvc;
using BaiKiemTra02.Models;
using BaiKiemTra02.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LopHocController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LopHoc
        public IActionResult Index(string searchString)
        {
            var LopHoc = from l in _context.LopHoc select l;

            if (!string.IsNullOrEmpty(searchString))
            {
                LopHoc = LopHoc.Where(s => s.TenLopHoc.Contains(searchString));
            }

            return View(LopHoc.ToList());
        }

        // GET: LopHoc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LopHoc/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lopHoc);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        // GET: LopHoc/Edit/5
        public IActionResult Edit(int id)
        {
            var lopHoc = _context.LopHoc.Find(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return View(lopHoc);
        }

        // POST: LopHoc/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, LopHoc lopHoc)
        {
            if (id != lopHoc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lopHoc);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.LopHoc.Any(e => e.Id == lopHoc.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        // GET: LopHoc/Delete/5
        public IActionResult Delete(int id)
        {
            var lopHoc = _context.LopHoc.Find(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return View(lopHoc);
        }

        // POST: LopHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var lopHoc = _context.LopHoc.Find(id);
            if (lopHoc != null)
            {
                _context.LopHoc.Remove(lopHoc);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: LopHoc/Detail/5
        public IActionResult Detail(int id)
        {
            var lopHoc = _context.LopHoc.Find(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return View(lopHoc);
        }
    }
}
