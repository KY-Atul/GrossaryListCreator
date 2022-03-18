using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrossaryListCreator.Data;
using GrossaryListCreator.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrossaryListCreator.Pages.GL
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext _db;

        public Model.List list { get; set; }

        public CreateModel(Data.AppDBContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(List list)
        {
            await _db.GList.AddAsync(list);

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

    }
}
