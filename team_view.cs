using System;

using Xamarin.Forms;

namespace teamapp
{
    public class team_view : ContentView
    {
        public team_view()
        {
            Content = new Label { Text = "Hello ContentView" };
            NavigationPage n = new NavigationPage();
            //n.RootPage = team_appPage;
        }
    }
}

