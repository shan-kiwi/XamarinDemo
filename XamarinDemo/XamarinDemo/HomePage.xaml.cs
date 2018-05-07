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
	public partial class HomePage : ContentPage
	{
        
		public HomePage ()
		{
			InitializeComponent ();
		}
        public HomePage(UserModel model)
        {
            InitializeComponent();
            lblUserName.Text = "Hello " + model.Name;
            lblMobile.Text = model.Mobile;
            lblDOB.Text = model.DOB.ToString("dd MMM yyyy");
            lblTime.Text = model.Time.ToString();
            lblLocation.Text = model.Location;
        }
    }
}