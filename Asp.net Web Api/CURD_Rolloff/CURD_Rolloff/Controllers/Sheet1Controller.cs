using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CURD_Rolloff.Models;

namespace CURD_Rolloff.Controllers
{
    public class Sheet1Controller : Controller
    {
        private readonly RollOfDatabaseContext _context;

        public Sheet1Controller(RollOfDatabaseContext context)
        {
            _context = context;
        }

        // GET: Sheet1
        public async Task<IActionResult> Index(string empsearch)
        {
            ViewData["GetEmployeeDetails"] = empsearch;
            var empquery = from x in _context.Sheet1s select x;
            if (!String.IsNullOrEmpty(empsearch))
            {
                empquery = empquery.Where(x => x.Email.Contains(empsearch) || x.GlobalGroupId.ToString().Contains(empsearch) || x.EmployeeNo.ToString().Contains(empsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());

        }


        public async Task<IActionResult> Search()
        {

            return View();
        }

        public async Task<IActionResult> RollOff()
        {
            return View();
        }

        // GET: Sheet1/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sheet1 = await _context.Sheet1s
                .FirstOrDefaultAsync(m => m.GlobalGroupId == id);
            if (sheet1 == null)
            {
                return NotFound();
            }

            return View(sheet1);
        }

        // GET: Sheet1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sheet1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Country,GlobalGroupId,EmployeeNo,Name,LocalGrade,MainClient,Email,JoiningDate,ProjectCode,ProjectName,ProjectStartDate,ProjectEndDate,PeopleManagerPerformanceReviewer,Practice,PspName,NewGlobalPractice,OfficeCity")] Sheet1 sheet1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sheet1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sheet1);
        }

        // GET: Sheet1/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sheet1 = await _context.Sheet1s.FindAsync(id);
            if (sheet1 == null)
            {
                return NotFound();
            }
            return View(sheet1);
        }

        // POST: Sheet1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double id, [Bind("Country,GlobalGroupId,EmployeeNo,Name,LocalGrade,MainClient,Email,JoiningDate,ProjectCode,ProjectName,ProjectStartDate,ProjectEndDate,PeopleManagerPerformanceReviewer,Practice,PspName,NewGlobalPractice,OfficeCity")] Sheet1 sheet1)
        {
            if (id != sheet1.GlobalGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sheet1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sheet1Exists(sheet1.GlobalGroupId))
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
            return View(sheet1);
        }

        // GET: Sheet1/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sheet1 = await _context.Sheet1s
                .FirstOrDefaultAsync(m => m.GlobalGroupId == id);
            if (sheet1 == null)
            {
                return NotFound();
            }

            return View(sheet1);
        }

        // POST: Sheet1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double id)
        {
            var sheet1 = await _context.Sheet1s.FindAsync(id);
            _context.Sheet1s.Remove(sheet1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Sheet1Exists(double id)
        {
            return _context.Sheet1s.Any(e => e.GlobalGroupId == id);
        }
    }
}
