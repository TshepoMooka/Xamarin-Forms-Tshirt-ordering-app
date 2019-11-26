using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TshirtApp.Messages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TshirtApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void BlackShirtButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<TabNavigateMessage>(new TabNavigateMessage(), "Nav");
        }

        private void GreenShirtButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<TabNavigateMessage>(new TabNavigateMessage(), "Nav");
        }

        private void RedShirtButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<TabNavigateMessage>(new TabNavigateMessage(),"Nav");
        }
    }
}