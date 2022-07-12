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
    public partial class SecondPage : ContentPage
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
        public SecondPage()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem { Source="hello.png", Title = "哨子麵",Description = "之所以稱為哨子麵是因為好吃的麵讓人一口接一口，當麵夾帶湯汁一口一口吃進嘴裡，少不了番茄、蛋、香菇、肉、洋蔥、青蔥、菜圃，吃過的人都說會上癮，所以輔園才常客滿。",Price = "$70/碗"},
                new ListItem { Source = "byebye.png", Title = "哨子飯",Description = "哨子飯的醬跟麵的醬是一樣的，非常豐富，也有番茄、蛋、香菇、肉、洋蔥、青蔥、菜圃，甜甜洋蔥味和滿滿料，好吃的味道，飯也是一口接著一口，使用的米可是粒粒分明的。",Price = "$70/碗"},
                new ListItem { Source = "redtea.png", Title = "紅茶",Description = "當你口乾舌燥的時候，來杯消暑的頂級高山紅茶吧，選用高級高山茶葉，回甘就像現泡，甜而不膩，涼而解熱。（暑假期間飲料買五送一，歡迎找同學一同前來消暑）。",Price = "$15/杯"},
            };
            DataModelList.ItemsSource = ListItems;
        }
        async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            ListItem item = (ListItem)e.SelectedItem;
            await DisplayAlert(item.Title, item.Description, "返回");
            ((ListView)sender).SelectedItem = null;
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (ListItem)b.CommandParameter;
            await Navigation.PushAsync(new CheckoutPage2(item));
        }
    }
}