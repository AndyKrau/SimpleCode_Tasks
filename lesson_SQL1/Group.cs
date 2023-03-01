using System;
using System.Collections.Generic;

namespace lesson_SQL1
{
    public class Group 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int Style { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
