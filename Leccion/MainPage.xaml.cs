using Leccion.Views;
using Xamarin.Forms;


namespace Leccion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PaginaGrid());
            
        }
    }
}
