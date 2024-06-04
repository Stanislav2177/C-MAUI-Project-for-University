using ProjectMaui.Models;
using System;

namespace ProjectMaui
{
    public partial class AddStudentPage : ContentPage
    {
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private async void OnSaveStudentClicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Save Student button clicked");

                if (string.IsNullOrWhiteSpace(nameEntry.Text) ||
                    string.IsNullOrWhiteSpace(ageEntry.Text) ||
                    string.IsNullOrWhiteSpace(classEntry.Text))
                {
                    await DisplayAlert("Error", "Please fill all fields", "OK");
                    return;
                }

                if (!int.TryParse(ageEntry.Text, out int age))
                {
                    await DisplayAlert("Error", "Please enter a valid age", "OK");
                    return;
                }

                var student = new Student
                {
                    Name = nameEntry.Text,
                    Age = age,
                    Class = classEntry.Text
                };

                System.Diagnostics.Debug.WriteLine($"Student Info: {student.Name}, {student.Age}, {student.Class}");

                await App.Database.SaveStudentAsync(student);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error saving student: {ex.Message}");
                await DisplayAlert("Error", "An error occurred while saving the student. Please try again.", "OK");
            }
        }
    }
}
