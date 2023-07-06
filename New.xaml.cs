using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LangMultiple
{
    /// <summary>
    /// Interaction logic for New.xaml
    /// </summary>
    public partial class New : Window
    {
        public New()
        {

            InitializeComponent();
            Property.Settings settings = new Property.Settings();
            this.Title = settings.AppName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show ("Please close the application and reopen");
        }
    }
}

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            String Languageselection = "en-US";
//            if (rbtamil.IsChecked == true) 
//            {
//                Languageselection = rbtamil.Tag.ToString();
//            }
//            else if (rbtelugu.IsChecked == true)
//            {
//                Languageselection = rbtelugu.Tag.ToString();
//            }
//            else if (rbhindhi.IsChecked == true)
//            {
//                Languageselection = rbhindhi.Tag.ToString();
//            }
//            else if (rbpunjabi.IsChecked == true)
//            {
//                Languageselection = rbpunjabi.Tag.ToString();
//            }
//            Property.Settings settings = new Property.Settings();
//            settings.Language = Languageselection;
//            CultureInfo ci = new CultureInfo(Languageselection);
//            Thread.CurrentThread.CurrentCulture = ci;
//            Thread.CurrentThread.CurrentUICulture = ci;
//        }
//    }
//}
