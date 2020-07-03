using NotestoMe.Models;
using NotestoMe.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotestoMe.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        private NoteViewModel _model;

        public NotesPage()
        {
            InitializeComponent();

            _model = new NoteViewModel();

            BindingContext = _model;
        }

        private void NewNote_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewNote.Text))
            {
                return;
            }

            _model.Notes.Add(new Note
            {
                Title = "New Note",
                Description = txtNewNote.Text,
                Taken = DateTime.Now
            });

            txtNewNote.Text = string.Empty;
        }
    }
}