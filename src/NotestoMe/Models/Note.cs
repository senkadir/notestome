using System;
using System.Collections.Generic;

namespace NotestoMe.Models
{
    public class Note
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Taken { get; set; }

        public string Hour => Taken.ToString($"HH mm");

        public List<Tag> Tags { get; set; }


    }
}
