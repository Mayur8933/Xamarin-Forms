using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorPicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["UID"] = MyEntry.Text;
            Navigation.PushAsync(new MainPage());
        }
    }
}