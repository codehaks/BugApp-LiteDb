using System;

namespace BugApp.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}