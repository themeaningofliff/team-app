using Xamarin.Forms;

namespace teamapp
{
    public partial class team_appPage : ContentPage
    {
        public team_appPage()
        {
            InitializeComponent();
            // Handle padding on iOS to fix date overlap
            if (Device.RuntimePlatform == Device.iOS)
                Padding = new Thickness(0, 20, 0, 0);
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(epScore.Text != null)
                DisplayAlert("Event created for "+eDate.Date.ToString(),
                             "You scored "+epScore.Text.ToString()+". \n"+eoEmail.Text.ToString()+" scored "+eoScore.Text.ToString(),
                             "OK");
        }
    }
}
