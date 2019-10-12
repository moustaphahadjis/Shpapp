using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShpApp.myDatabase;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShpApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAccount : ContentPage
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private void Creating(object o, EventArgs e)
        {
            string Fname = (FamilyName.Text);
            string Gname = (GivenName.Text);
            string Email = (NewEmail.Text);
            string NPassword = (NewPassword.Text);
            string CPassword = (ConfirmPassword.Text);


            if (string.IsNullOrEmpty(Fname)
                || string.IsNullOrEmpty(Gname)
                || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(NPassword)
                || string.IsNullOrEmpty(CPassword))
            {
                DisplayAlert("Error", "Please make sure your write all of your informations", "Check again");
            }
            else
            {
                if (NPassword == CPassword)
                {
                    // Send info to database
                    login sending = new login()
                    {
                        email = Email,
                        password = CPassword
                    };
                    SQLiteConnection conn = new SQLiteConnection(App.Dbpath);
                    conn.CreateTable<login>();
                    int row=conn.Insert(sending);
                    conn.Close();
                    if (row > 0)
                        DisplayAlert("Success", "Your account was successfully created", "ok");
                }
                else
                {
                    CPassword = "";
                    DisplayAlert("Error", "the two passwords you've entered don't match", "Check again");
                }
            }
        }
    }
}