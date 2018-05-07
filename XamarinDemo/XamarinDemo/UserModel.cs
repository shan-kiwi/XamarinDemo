using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mobile{ get; set; }
        public DateTime DOB{ get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
        public string UserImage { get; set; }
    }
}
