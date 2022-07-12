using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDataModel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
            public string Hint { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public Type PageType { get; set; }
            public string Title01 { get; set; }
        }
        public MainPage()
        {
            InitializeComponent();

            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem {Image="eight.png",Title = "八方雲集", Hint="點擊進入菜單", Description="提供各式鍋貼，鍋貼迷的好選擇",PageType=typeof(FirstPage)},
                new ListItem {Image="noodles.png",Title = "雲瀚哨子麵", Hint="點擊進入菜單",Description="提供麵食，飯與紅茶，推薦給喜歡變化的人", PageType=typeof(SecondPage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
                new ListItem {Image="error.png",Title01="櫃位整修",PageType=typeof(NonePage)},
            };
            DataModelList.ItemsSource = ListItems;
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            Page page = (Page)Activator.CreateInstance(item.PageType);
            await this.Navigation.PushAsync(page);
            ((ListView)sender).SelectedItem = null;
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (ListItem)b.CommandParameter;
            await Navigation.PushAsync(new DetailPage(item));
        }
    }
}
