using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BugApp.Models;
using LiteDB;

namespace BugApp.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Bug Bug { get; set; }

        public IActionResult OnPost(){

            using (var db = new LiteDatabase(@"bug.db"))
            {
                var bugs = db.GetCollection<Bug>();
                bugs.Insert(Bug);

            }

            return RedirectToPage("Index");
            
        }
    }
}