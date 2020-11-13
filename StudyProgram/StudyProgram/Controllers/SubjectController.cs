using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OfficeOpenXml;
using StudyProgram.DataContext;
using StudyProgram.Entity;
using StudyProgram.Service;

namespace StudyProgram.Controllers
{
    public class SubjectController : Controller
    {
        private readonly SPMContext _context;

        public SubjectController(SPMContext context)
        {
            _context = context;

        }

        // GET: Subject
        public IActionResult Index()
        {
            var _subjectService = new SubjectService(_context);
            var data = _subjectService.GetAll();
            return View(data);
        }

        // GET: Subject/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // GET: Subject/Create
        public IActionResult Create(int id = 0)
        {
            Subject subject = new Subject();
            return PartialView("../Subject/_Create", subject);
        }
        public IActionResult DoCreate(Subject model)
        {
            try
            {
                var _subjectService = new SubjectService(_context);
                var obj = _subjectService.Create(model);
                return Json(new { isSuccess = true, data = obj });
            }
            catch (Exception ex)
            {
                return Json(new { isSuccess = false, message = ex.Message });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectId,NameVN,NameEN,Description,Id,Isdeleted")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: Subject/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }
        //Import
        public IActionResult Import()
        {
            return PartialView("../Subject/_Import");
        }
        [HttpPost]
        public async Task<JsonResult> DoImportExcelAsync()
        {
            try
            {
                var _subjectService = new SubjectService(_context);
                var file = HttpContext.Request.Form.Files[0];
                var list = new List<Subject>();
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    using (var package = new ExcelPackage(stream))
                    {
                        ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                        int totalRows = workSheet.Dimension.Rows;
                        for (int i = 2; i <= totalRows; i++)
                        {
                            var subject = new Subject
                            {
                                Id = workSheet.Cells[i, 1].Value != null ? int.Parse(workSheet.Cells[i, 1].Value.ToString().Trim()) : 0,
                                SubjectId = (string)(workSheet.Cells[i, 2]).Text,
                                NameVN = (string)(workSheet.Cells[i, 3]).Text,
                                Credit = int.Parse(workSheet.Cells[i, 4].Value.ToString().Trim()),
                            };
                            list.Add(subject);
                        }
                    }
                }
                if (!list.Any()) return Json(new { status = true });
                _subjectService.Import(list);
                return Json(new { status = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Json(new { });
        }
        // POST: Subject/Edit/5


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubjectId,NameVN,NameEN,Description,Id,Isdeleted")] Subject subject)
        {
            if (id != subject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(subject.Id))
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
            return View(subject);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: Subject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await _context.Subject.FindAsync(id);
            _context.Subject.Remove(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }
    }
}
