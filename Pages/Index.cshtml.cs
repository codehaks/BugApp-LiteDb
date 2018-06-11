using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugApp.Models;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugApp.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Bug> Bugs { get; set; }
        public void OnGet()
        {
          
           using (var db = new LiteDatabase(@"bug.db"))
            {
                var bugs = db.GetCollection<Bug>();
                Bugs = bugs.FindAll().ToList();
            }

        }
    }
}