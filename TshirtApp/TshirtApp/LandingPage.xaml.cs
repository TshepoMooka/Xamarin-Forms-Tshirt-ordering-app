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
    public partial class LandingPage : TabbedPage
    {
        public LandingPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<TabNavigateMessage>
                (this, "Nav", NavigateToMain);
        }

        private void NavigateToMain(TabNavigateMessage obj)
        {

            SelectedItem = null;
            SelectedItem = Children[0];

        }
       
    }
}