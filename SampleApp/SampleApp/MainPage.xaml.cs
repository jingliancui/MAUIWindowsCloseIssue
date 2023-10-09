namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var secondWin = new Window(new SecondgPage());
            Application.Current.OpenWindow(secondWin);
        }
    }
}