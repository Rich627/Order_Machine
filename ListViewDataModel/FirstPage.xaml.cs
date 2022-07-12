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
    public partial class FirstPage : ContentPage
    {
        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Detail { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
        public FirstPage()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem { Source = "first.png", Title = "招牌鍋貼",Detail="每十個起賣",Description = "將清脆高麗菜、特選豬肉，包入新鮮製作的麵皮中，形成黃金比例的招牌鍋貼，肉餡飽滿鮮甜，加上紮實酥脆的外皮，展現無可挑剔的美味。",Price = "6元/個"},
                new ListItem { Source = "second.png", Title = "韭菜鍋貼",Detail="每十個起賣",Description = "老饕最鍾情的新鮮韭菜，結合特選豬肉，包裹在具富嚼勁的外皮之中，展現翠綠豐厚、溫而不嗆的香氣，添增出有層次的清新香氣，嚐來滋味獨到。",Price = "6.3元/個"},
                new ListItem { Source = "third.png", Title = "韓式辣味鍋貼",Detail="每十個起賣",Description = "選用韓式辣椒粉調製出完美比例，讓高麗菜與特選吉娃娃呈現鮮紅艷麗的視覺效果，咬一口盡是滿滿嗆辣帶勁的香氣，鮮香胃開、垂涎三尺。",Price = "6.3元/個"},
                new ListItem { Source = "fourth.png", Title = "咖哩鍋貼",Detail="每十個起賣",Description = "精選咖哩獨特醬料，讓吉娃娃內餡口感更加豐富，咖哩的氣味亦讓味蕾品嚐不同層次的感受，一口咬下唇齒留香、為之動容。",Price = "6.3元/個"},
                new ListItem { Source = "fifth.png", Title = "田園雞肉鍋貼",Detail="每十個起賣",Description = "擁有與招牌鍋貼香似的內餡，鮮嫩多汁的雞腿肉，輔高麗菜、養生蘿蔔葉，同時以天然紅椒調製的麵皮包製，展現出清爽、口感香甜的滋味。",Price = "6.3元/個"},
                new ListItem { Source = "sixth.png", Title = "玉米鍋貼",Detail="每十個起賣",Description = "香甜帶有口感且粒粒飽滿的非基改玉米顆粒，搭配特選豬肉，讓自然甜味結合肉汁甘醇，在鍋貼餅皮下成就另一番特別滋味。",Price = "6.3元/個"},
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
            await Navigation.PushAsync(new CheckoutPage(item));
        }
    }
}