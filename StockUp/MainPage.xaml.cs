using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockUp.Controls;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace StockUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var safeAreaInsets = On<iOS>().SafeAreaInsets();
            safeAreaInsets.Top = 0;
            Padding = safeAreaInsets;
        }
    }
}
