using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2.Data;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class UniversityStudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UniversityStudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UniversityStudents
        public async Task<IActionResult> Index()
        {
            return View(await _context.universityStudents.ToListAsync());
        }

        // GET: UniversityStudents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityStudent = await _context.universityStudents
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (universityStudent == null)
            {
                return NotFound();
            }

            return View(universityStudent);
        }

        // GET: UniversityStudents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityStudents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,StudentName,StudentAge,StudentCampus,StudentMajor")] UniversityStudent universityStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityStudent);
        }

        // GET: UniversityStudents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityStudent = await _context.universityStudents.FindAsync(id);
            if (universityStudent == null)
            {
                return NotFound();
            }
            return View(universityStudent);
        }

        // POST: UniversityStudents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentID,StudentName,StudentAge,StudentCampus,StudentMajor")] UniversityStudent universityStudent)
        {
            if (id != universityStudent.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityStudentExists(universityStudent.StudentID))
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
            return View(universityStudent);
        }

        // GET: UniversityStudents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityStudent = await _context.universityStudents
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (universityStudent == null)
            {
                return NotFound();
            }

            return View(universityStudent);
        }

        // POST: UniversityStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var universityStudent = await _context.universityStudents.FindAsync(id);
            _context.universityStudents.Remove(universityStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityStudentExists(int id)
        {
            return _context.universityStudents.Any(e => e.StudentID == id);
        }
    }
}
