using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrossaryListCreator.Pages.GL
{
    public class IndexModel : PageModel

    {
        private readonly Data.AppDBContext _db;

        public IEnumerable<Model.List> Lists { get; set; }

        public IndexModel(Data.AppDBContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Lists = _db.GList;
        }
    }
}
