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
	public partial class LoginPage : ContentPage
	{
        Entry UserName, Password;
        public LoginPage ()
		{
            //InitializeComponent ();
            //this.Title = "Login";
            this.Icon = "Login.png";
            this.BackgroundColor = Color.LightCyan;
            UserName = new Entry {Placeholder= "UserName", StyleId ="UserName" };
             Password = new Entry { Placeholder = "Password", IsPassword = true };
            var LoginButton = new Button { Text= "Login", BackgroundColor=Color.LightSkyBlue, TextColor= Color.Gray};
            //var RegLabel = new Label { Text = "Sign Up", TextColor = Color.Gray, HorizontalOptions = LayoutOptions.Center };
            var RegButton = new Button { Text = "Register", BackgroundColor = Color.LightSkyBlue, TextColor = Color.Gray };
            LoginButton.Clicked += OnLoginClicked;
            RegButton.Clicked += OnRegButtonClicked;
            this.Content = new StackLayout
            {
                Padding = new Thickness(20),
                //Margin = new Thickness(0,80,0,0),
                //HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children ={UserName,Password,LoginButton, RegButton }
                
            };
        }

        private void OnRegButtonClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Register());
            
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("UserModel"))
            {
                UserModel model = (UserModel)Application.Current.Properties["UserModel"];
                if (model.Name == UserName.Text && model.Password == Password.Text)
                {
                    DisplayAlert("Login", "Login Successfull", "Ok");
                    Navigation.PushAsync(new HomePage(model));
                }
                else
                {
                    DisplayAlert("Login", "Wrong Credentials", "Ok");
                }
            }
            else
            {
                DisplayAlert("Login","No User Found","Ok");
            }
                
            
        }
    }
}