﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kerekes_Ida_Roberta_Lab2.Data;
using Kerekes_Ida_Roberta_Lab2.Models;

namespace Kerekes_Ida_Roberta_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Kerekes_Ida_Roberta_Lab2.Data.Kerekes_Ida_Roberta_Lab2Context _context;

        public IndexModel(Kerekes_Ida_Roberta_Lab2.Data.Kerekes_Ida_Roberta_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
