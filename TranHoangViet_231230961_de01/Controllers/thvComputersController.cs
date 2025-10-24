using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TranHoangViet_231230961_de01.Models;

namespace TranHoangViet_231230961_de01.Controllers
{
    public class thvComputersController : Controller
    {
        private readonly thvComputerText _context;

        public thvComputersController(thvComputerText context)
        {
            _context = context;
        }

        // GET: thvComputers
        public async Task<IActionResult> thvIndex()
        {
            return View(await _context.thvComputers.ToListAsync());
        }

        // GET: thvComputers/Details/5
        public async Task<IActionResult> thvDetails(string id)
        {
            if (id == null) return NotFound();

            var computer = await _context.thvComputers.FirstOrDefaultAsync(c => c.thvComputersId == id);
            if (computer == null) return NotFound();

            return View(computer);
        }

        // GET: thvComputers/Create
        public IActionResult thvCreate()
        {
            return View();
        }

        // POST: thvComputers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> thvCreate([Bind("thvComputersName,thvComPrice,thvComImgae,thvComStatus")] thvComputers thvComputers)
        {
            if (ModelState.IsValid)
            {
                // 🔥 Tự sinh ID
                thvComputers.thvComputersId = Guid.NewGuid().ToString();

                _context.Add(thvComputers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(thvIndex));
            }
            return View(thvComputers);
        }

        // GET: thvComputers/Edit/5
        public async Task<IActionResult> thvEdit(string id)
        {
            if (id == null) return NotFound();

            var computer = await _context.thvComputers.FindAsync(id);
            if (computer == null) return NotFound();

            return View(computer);
        }

        // POST: thvComputers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> thvEdit(string id, [Bind("thvComputersId,thvComputersName,thvComPrice,thvComImgae,thvComStatus")] thvComputers thvComputers)
        {
            if (id != thvComputers.thvComputersId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thvComputers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.thvComputers.Any(e => e.thvComputersId == thvComputers.thvComputersId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(thvIndex));
            }
            return View(thvComputers);
        }

        // GET: thvComputers/Delete/5
        public async Task<IActionResult> thvDelete(string id)
        {
            if (id == null) return NotFound();

            var computer = await _context.thvComputers.FirstOrDefaultAsync(c => c.thvComputersId == id);
            if (computer == null) return NotFound();

            return View(computer);
        }

        // POST: thvComputers/Delete/5
        [HttpPost, ActionName("thvDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> thvDeleteConfirmed(string id)
        {
            var computer = await _context.thvComputers.FindAsync(id);
            if (computer != null) _context.thvComputers.Remove(computer);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(thvIndex));
        }
    }
}
