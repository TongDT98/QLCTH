﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudyProgram.DataContext;
using StudyProgram.Entity;
using StudyProgram.IService;
using StudyProgram.Models;
using StudyProgram.Service;

namespace StudyProgram.Controllers
{
    public class SpecialityController : Controller
    {
        private readonly SPMContext _context;
        private readonly IMapper _mapper;

        public SpecialityController(SPMContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        // GET: Speciality
        public IActionResult Index()
        {
            var _specialityService = new SpecialityService(_context);
            var _courseService = new CourseService(_context);
            var _speDTO = new SpeDTO();
             _speDTO.Specialities= _mapper.Map<List<SpecialityDTO>>(_specialityService.GetAll());
            _speDTO.Courses = _mapper.Map<List<CourseDTO>>(_courseService.GetAll());
            return View(_speDTO);
        }
        //create
        public IActionResult Create(int id = 0)
        {
            Speciality speciality = new Speciality();
            return PartialView("../Speciality/_Create", speciality);
        }
        public IActionResult DoCreate(Speciality model)
        {
            try
            {
                var _specialityService = new SpecialityService(_context);
                var obj = _specialityService.Create(model);
                return Json(new { isSuccess = true, data = obj });
            }
            catch (Exception ex)
            {
                return Json(new { isSuccess = false, message = ex.Message });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecialityId,NameVN,NameEN,Description,Id,Isdeleted")] Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speciality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speciality);
        }

        // GET: Speciality/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = await _context.Speciality
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // GET: Speciality/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = await _context.Speciality.FindAsync(id);
            if (speciality == null)
            {
                return NotFound();
            }
            return View(speciality);
        }

        // POST: Speciality/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpecialityId,NameVN,NameEN,Desciption,Id,Isdeleted")] Speciality speciality)
        {
            if (id != speciality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speciality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialityExists(speciality.Id))
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
            return View(speciality);
        }

        // GET: Speciality/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = await _context.Speciality
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // POST: Speciality/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speciality = await _context.Speciality.FindAsync(id);
            _context.Speciality.Remove(speciality);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialityExists(int id)
        {
            return _context.Speciality.Any(e => e.Id == id);
        }
    }
}
