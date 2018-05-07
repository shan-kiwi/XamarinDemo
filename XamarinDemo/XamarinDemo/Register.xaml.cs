using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        List<string> lstCountry = new List<string>();
        public Register()
        {
            lstCountry.Add("INDIA");
            lstCountry.Add("USA");
            lstCountry.Add("UK");
            lstCountry.Add("CHINA");
            InitializeComponent();
            //this.BackgroundColor = Color.LightGreen;
            //var DateP = new DatePicker() { MinimumDate = DateTime.Now };
            //var TimeP = new TimePicker();
            //var Picker = new Picker() { Title = "Select Location" };
            //Picker.ItemsSource = lstCountry;
            //Picker.SelectedIndex = 1;

            //this.Content = new StackLayout() { Padding = new Thickness(20), Children = {DateP,TimeP,Picker } };
            Location.ItemsSource = lstCountry;
        }

        public Register(UserModel data)
        {
            lstCountry.Add("INDIA");
            lstCountry.Add("USA");
            lstCountry.Add("UK");
            lstCountry.Add("CHINA");
            InitializeComponent();
            //this.BackgroundColor = Color.LightGreen;
            //var DateP = new DatePicker() { MinimumDate = DateTime.Now };
            //var TimeP = new TimePicker();
            //var Picker = new Picker() { Title = "Select Location" };
            //Picker.ItemsSource = lstCountry;
            //Picker.SelectedIndex = 1;

            //this.Content = new StackLayout() { Padding = new Thickness(20), Children = {DateP,TimeP,Picker } };
            Location.ItemsSource = lstCountry;

            UserName.Text = data.Name;
            Mobile.Text = data.Mobile;
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            UserModel objModel = new UserModel
            {
                //Name = UserName.Text,
                //Mobile = Mobile.Text,
                //DOB = DOB.Date,
                //Time = TP.Time,
                //Password = Password.Text,
                //Location = Location.SelectedItem.ToString(),
            };
            Application.Current.Properties["UserModel"] = objModel;
            Navigation.PushAsync(new HomePage(objModel), true);
        }
    }
}