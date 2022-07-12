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
    public partial class NonePage : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
        }
        public NonePage()
        {
            InitializeComponent();
            Title = "櫃位整修中(無內容)";
        }
    }
}