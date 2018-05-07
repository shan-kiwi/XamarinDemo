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
	public partial class ListViewPage : ContentPage
	{
        List<UserModel> lst = new List<UserModel>
        {
            new UserModel { Name="Shan" , Mobile = "9818353611", UserImage = "User1",ID = 1},
            new UserModel { Name="Shumail" , Mobile = "9818353612", UserImage = "User2",ID = 2},
            new UserModel { Name="Rajesh" , Mobile = "9818353613", UserImage = "User3",ID = 3},
            new UserModel { Name="Hariom" , Mobile = "9818353614", UserImage = "User1",ID = 4},
            new UserModel { Name="Jeeshan" , Mobile = "9818353615", UserImage = "User2",ID = 5}
        };
		public ListViewPage ()
		{
            InitializeComponent ();
            this.Icon = "List.png";
            //var MyList =new ListView();
            //MyList.ItemsSource = new List<string>
            //{
            //    "Noida","Delhi","Gurgaoun","Agra"
            //};
            //Content = MyList;
            MyList.ItemsSource = lst;
		}

        private void OnListItemTapped(object sender,ItemTappedEventArgs e)
        {
            var Data = e.Item as UserModel;
            Navigation.PushAsync(new Register(Data));
        }

    }
}