using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment8
{
    public partial class MainPage : ContentPage
    {
 
        public Shop Shop { get; set; }

        public Order Order { get; set; }

        public MainPage()

        {
            InitializeComponent();

            Shop = new Shop("GetItOnline","0248561234","Home");

            Order = new Order("Anathi","Female");

            BindingContext = this;

            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            CustomerInfo temp = new CustomerInfo();

            //temp.Name = entryname.Text;


            

           




            await Navigation.PushAsync(new Page1());
        }
    }
}
