using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kerekes_Ida_Roberta_Lab2.Data;
using Kerekes_Ida_Roberta_Lab2.Models;
using Kerekes_Ida_Roberta_Lab2.Models.ViewModels;

namespace Kerekes_Ida_Roberta_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Kerekes_Ida_Roberta_Lab2.Data.Kerekes_Ida_Roberta_Lab2Context _context;

        public IndexModel(Kerekes_Ida_Roberta_Lab2.Data.Kerekes_Ida_Roberta_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;


        public CategoriesIndexData CategoryData { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }
        public async Task OnGetAsync(int? bookID, int? id)
        {
            CategoryData = new CategoriesIndexData();
            CategoryData.Categories = await _context.Category
                .Include(i => i.Books)
                    .ThenInclude(c => c.Author)
                .OrderBy(i => i.CategoryName)
                .ToListAsync();

            if(id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value).Single();
                CategoryData.Books = category.Books;
            }
        }
    }
}
