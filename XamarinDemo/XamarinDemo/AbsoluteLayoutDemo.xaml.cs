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
	public partial class AbsoluteLayoutDemo : ContentPage
	{
		public AbsoluteLayoutDemo ()
		{
            //InitializeComponent ();
            var Layout = new AbsoluteLayout();
            var Box = new BoxView() { BackgroundColor= Color.LightSeaGreen};
            AbsoluteLayout.SetLayoutBounds(Box, new Rectangle(0, 0, 1, .3));
            AbsoluteLayout.SetLayoutFlags(Box, AbsoluteLayoutFlags.All);

            var Box1 = new BoxView() { BackgroundColor = Color.Pink };
            AbsoluteLayout.SetLayoutBounds(Box1, new Rectangle(0, 1, 1, .7));
            AbsoluteLayout.SetLayoutFlags(Box1, AbsoluteLayoutFlags.All);

            var Box2 = new BoxView() { BackgroundColor = Color.White };
            AbsoluteLayout.SetLayoutBounds(Box2, new Rectangle(0.5, .2, 100, 100));
            AbsoluteLayout.SetLayoutFlags(Box2, AbsoluteLayoutFlags.PositionProportional);

            Layout.Children.Add(Box);
            Layout.Children.Add(Box1);
            Layout.Children.Add(Box2);
            Content = Layout;
        }

        private void Logout(object sender, EventArgs e)
        {
            
        }
    }
}