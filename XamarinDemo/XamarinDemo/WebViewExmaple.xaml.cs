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
	public partial class WebViewExmaple : ContentPage
	{
		public WebViewExmaple ()
		{
			InitializeComponent ();
		}

        private void OpenURL(object sender, EventArgs e)
        {
            var URl ="https://"+ URLEntry.Text;
            Browser.Source = URl;
        }
    }
}