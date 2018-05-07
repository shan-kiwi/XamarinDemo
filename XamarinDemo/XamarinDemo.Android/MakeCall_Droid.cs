using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinDemo.Droid;
using XamarinDemo.Interface;

[assembly: Dependency(typeof(MakeCall_Droid))]
namespace XamarinDemo.Droid
{
    public class MakeCall_Droid : IMakeCall
    {
        public void MakeCall(string PhoneNumber)
        {
            var URI = Android.Net.Uri.Parse(String.Format( "tel:{0}", PhoneNumber));
            var intent = new Intent(Intent.ActionCall, URI);
            Forms.Context.StartActivity(intent);
        }
    }
}