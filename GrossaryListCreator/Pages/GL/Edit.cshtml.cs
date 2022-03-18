using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrossaryListCreator.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GrossaryListCreator.Model;
using Microsoft.EntityFrameworkCore;

namespace GrossaryListCreator.Pages.GL
{
    public class EditModel : PageModel
    {

        private readonly AppDBContext _db;

        public Model.List list { get; set; }

        public EditModel(AppDBContext db)
        {
            _db = db;
        }


        public void OnGet(int id)
        {
            list = _db.GList.Find(id);
        }

        public async Task<IActionResult> OnPost(List list)
        {
            _db.GList.Update(list);

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
    }
}
