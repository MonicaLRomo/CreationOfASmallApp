using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace IT391_Leyva_Romo_Unit9
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var names = typeof(MainPage).Assembly.GetManifestResourceNames();
            foreach (var name in names)
            {
                Debug.WriteLine(name);
            }
        }
             public void Button_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Thank you for clicking me 😊";
            return;

        }
        public void ButtonClick(object sender, EventArgs e)
        {
            imgLogo.Source = "img_2023.png";
            return;

        }
        public void ThirdButtonClick(object sender, EventArgs e)
        {
            MessageLabel.Text = "Have a great week!😁";
            return;
        }


    }
}

