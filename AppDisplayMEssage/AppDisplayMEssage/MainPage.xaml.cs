using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDisplayMEssage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           // DisplayAlert("Message", "Hope you are doing well.", "Cancel");
        }

        public string UID = "admin", PASS = "admin";

        private void SubmitButton_clicked(object sender, EventArgs e)
        {
            if (UID == UIDEntry.Text && PASS == PASSEntry.Text)
            {
                DisplayAlert("Message","LogIn Successful","Ok");
                UIDEntry.Text = "";
                PASSEntry.Text = "";
                UIDEntry.Focus();
            }
            else
            {
                DisplayAlert("Warning","Invalid LogIn Credentials","Cancel");
            }
        }

    }
}
