using System;
using Xamarin.Forms;

namespace StockUp
{
    public class AppConstants
    {
        public static string AppId
        {
            get
            {
                switch (Device.RuntimePlatform) {
                    case Device.Android:
                        return string.Empty;
                    default:
                        return "ca-app-pub-9127316987381023~9903489803";
                }
            }
        }

        // Banner Ids
        public  static string BannerId {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-3940256099942544/6300978111";
                    default:
                        return "ca-app-pub-3940256099942544/2934735716";
                }
            }
        }
    }
}
