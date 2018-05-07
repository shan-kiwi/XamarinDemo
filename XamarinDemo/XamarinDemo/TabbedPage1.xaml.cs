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
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {
            // InitializeComponent();
            Children.Add(new LoginPage());
            Children.Add(new Register());

            var Profile = new ContentPage()
            {
                Icon = "Profile.png",
                Content = new StackLayout {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label() {
                            Text="Profile Goes Here"
                        }
                    }


                }
                
            };
            Children.Add(Profile);
            Children.Add(new ListViewPage());

        }
    }
}