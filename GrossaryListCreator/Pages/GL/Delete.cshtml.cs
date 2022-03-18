using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GrossaryListCreator.Data;
using GrossaryListCreator.Model;

namespace GrossaryListCreator.Pages.GL
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _db;

        public Model.List list { get; set; }

        public DeleteModel(AppDBContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            list = _db.GList.Find(id);
        }

        public async Task<IActionResult> OnPost(List list)
        {
            _db.GList.Remove(list);

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
