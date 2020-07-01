using NotestoMe.Models;
using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace NotestoMe.ViewModels
{
    public class NoteViewModel
    {
        public string Today { get; set; }

        public ObservableCollection<Note> Notes { get; set; }

        public NoteViewModel()
        {
            Today = DateTime.Now.ToString($"ddd d MMM", CultureInfo.CreateSpecificCulture($"{CultureInfo.CurrentCulture.Name}"));

            Notes = new ObservableCollection<Note>();
        }
    }
}
