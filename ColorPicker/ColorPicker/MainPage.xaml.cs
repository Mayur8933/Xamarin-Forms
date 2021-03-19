using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ColorPicker
{
    public partial class MainPage : ContentPage
    {
        public string Uname;
        public MainPage()
        {
            InitializeComponent();
            Uname = Application.Current.Properties["UID"].ToString();
        }

        private void OrangeButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Orange Color");
        }
        
        private void RedButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Red Color");
        }

        private void GreenButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Green Color");
        }

        private void BlackButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Black Color");
        }

        private void PinkButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Pink Color");
        }

        private void YellowButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Yellow Color");
        }

        private void BlueButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Blue Color");
        }


        private void ChocolateButton_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync($"{Uname},This is Chocolate Color");
        }
    }
}
