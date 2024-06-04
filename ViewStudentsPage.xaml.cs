using ProjectMaui.Models;
using System;

namespace ProjectMaui
{
    public partial class ViewStudentsPage : ContentPage
    {
        public ViewStudentsPage()
        {
            InitializeComponent();
            LoadStudents();
        }

        private async void LoadStudents()
        {
            List<Student> students = await App.Database.GetStudentsAsync();
            studentsListView.ItemsSource = students;
        }

        private async void OnAddStudentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddStudentPage());
        }
    }
}
