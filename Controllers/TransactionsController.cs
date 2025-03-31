using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentSys.Models.Errors;
using Newtonsoft.Json;
using RentSys.Data;

namespace AspnetCoreMvcFull.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly RentSysContext _context;

        public TransactionsController(RentSysContext context)
        {
            _context = context;
        }

        // Replace default error messages with custom messages
        private void ReplaceErrorMessage(string propertyName, string customErrorMessage)
        {
            if (ModelState.TryGetValue(propertyName, out var entry))
            {
                if (entry.Errors.Any(e => e.ErrorMessage == "The value '' is invalid."))
                {
                    entry.Errors.Clear();
                    entry.Errors.Add(customErrorMessage);
                }
            }
        }

        // Set success toast message

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
         
          return View(await _context.Transactions.ToListAsync());
        }

        // GET: Transactions/Add
        public IActionResult Add()
        {
            return View();
        }



        // GET: Transactions/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactions = await _context.Transactions.FindAsync(id);
            if (transactions == null)
            {
                return NotFound();
            }
            return View(transactions);
        }

        private bool TransactionsExists(int id)
        {
            return _context.Transactions.Any(e => e.Id == id);
        }
    }
}
