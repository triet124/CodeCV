﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Data;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CustomersController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Admin/Customers
        public async Task<IActionResult> Index()
        {
              return _context.Customers != null ? 
                          View(await _context.Customers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Customers'  is null.");
        }

        // GET: Admin/Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: Admin/Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,HoTen,DiaChi,Email,SoDienThoai,MatKhau,PhanQuyen")] Customers customers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customers);
        }

        // GET: Admin/Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        // POST: Admin/Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,HoTen,DiaChi,Email,SoDienThoai,MatKhau,PhanQuyen")] Customers customers)
        {
            if (id != customers.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersExists(customers.CustomerID))
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
            return View(customers);
        }

        // GET: Admin/Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Admin/Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Customers'  is null.");
            }
            var customers = await _context.Customers.FindAsync(id);
            if (customers != null)
            {
                _context.Customers.Remove(customers);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersExists(int id)
        {
          return (_context.Customers?.Any(e => e.CustomerID == id)).GetValueOrDefault();
        }
    }
}
