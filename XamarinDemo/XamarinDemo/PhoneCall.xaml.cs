using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Interface;

namespace XamarinDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhoneCall : ContentPage
	{
		public PhoneCall ()
		{
			InitializeComponent ();
		}
        private void MakeCall(object Sender, EventArgs e)
        {
            DependencyService.Get<IMakeCall>().MakeCall(PhoneNumber.Text.ToString());
        }

    }
}