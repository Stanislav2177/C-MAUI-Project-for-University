namespace ProjectMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddStudentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddStudentPage());
        }

/*        private async void OnAddUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddUserPage());
        }
*/
        private async void OnViewStudentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewStudentsPage());
        }
    }

}
