using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDataModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckoutPage2 : ContentPage
    {
        public CheckoutPage2(SecondPage.ListItem item)
        {
            InitializeComponent();
            BindingContext = item;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
        }
    }
}