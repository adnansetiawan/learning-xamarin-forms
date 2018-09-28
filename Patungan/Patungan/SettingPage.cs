using System;

using Xamarin.Forms;

namespace Patungan
{
    public class SettingPage : ContentPage
    {
        public SettingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

