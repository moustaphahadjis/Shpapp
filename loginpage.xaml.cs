using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShpApp.myDatabase;
using System.Net;

namespace ShpApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loginpage : ContentPage
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void Submit(object o, EventArgs e)
        {
            bool email_empty = string.IsNullOrEmpty(EmailAddress.Text);
            bool password_empty = string.IsNullOrEmpty(Password.Text);

            string Email = EmailAddress.Text;
            string Paswd = Password.Text;
            if (email_empty || password_empty)
            {
                DisplayAlert("Empty Case", "Please Check your informations Again", "Try again");
            }
            else
            {
                //php based database
                //connecting to database


               // string url = "http://192.168.43.191:3306/shpapp/index.php";
                
               // using (WebClient client = new WebClient())
                //{
                  //  client.UploadString(url, Email);
                    //string receive = client.DownloadString("http://192.168.43.191:3306/shpapp/index.php");
                    //Console.WriteLine(receive);

                //}
                //end

                using (SQLiteConnection conn = new SQLiteConnection(App.Dbpath))
                { 
                conn.CreateTable<login>();
                var checking = conn.Table<login>().ToList();
                // if(checking.Contains())
                }
            }
        }


        public string email()
        {
            return EmailAddress.Text;
        }
        public string password()
        {
            return Password.Text;
        }
        public void display(string aa)
        {
            DisplayAlert("Empty Case", aa, aa);
        }
        private void CreateAccount(object o, EventArgs e)
        {
            
            
        }
    }
}