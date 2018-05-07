using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnClicked(Object sender, EventArgs e)
        {
            string Name = Convert.ToString(UserName.Text);
            var Result = await DisplayAlert("Hi!!", "Hi " + Name + "Do You Want to Register", "Yes", "No");
            if (Result)
            {
                lblResult.Text = "Thanks for Register";
                lblResult.IsEnabled = true;
            }
        }


        void OnClickedReset(Object sender, EventArgs e)
        {

            lblResult.Text = "";
            lblResult.IsEnabled = false;
            UserName.Text = "";

        }


    }
}
