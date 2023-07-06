using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LangMultiple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Property.Settings settings = new Property.Settings();
            CultureInfo ci = new CultureInfo(settings.Language);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            InitializeComponent();
            this.Title = settings.AppName;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string pass = pwdpass.Password;
            //string cpass = pwdcpass.Password;
            //if (pass != cpass)
            //{
            //    lblpass.Content = "INVALID PASSWORD";
            //}
            String email = txtmail.Text.ToString();
            char[] chars1 = email.ToCharArray();
            for (int i = 0; i > chars1.Length; i++)
            {
                if (chars1[i] == '@' || chars1[i] == '.')
                {
                    lblresult.Content = "INVALID Email ID";
                    txtmail.Clear();

                }
            }
            if (txtname.Text == "")
            {
                lblerror.Content = "ENTER THE NAME";
                txtname.Clear();
            }
            int age = Convert.ToInt32(txtage.Text.ToString());
            if (age < 25)
            {
                lblval.Content = "AGE MUST 25 ABOVE";
                txtage.Clear();
            }
            String Languageselection = "en-US";
            if (rbtamil.IsChecked == true)
            {
                Languageselection = rbtamil.Tag.ToString();
            }
            else if (rbtelugu.IsChecked == true)
            {
                Languageselection = rbtelugu.Tag.ToString();
            }
            else if (rbhindhi.IsChecked == true)
            {
                Languageselection = rbhindhi.Tag.ToString();
            }
            else if (rbpunjabi.IsChecked == true)
            {
                Languageselection = rbpunjabi.Tag.ToString();
            }
            if (rbrem.IsChecked== true)
            {
                MessageBox.Show("YOUR PASSWORD IS 1234", "PASSWORD");
            }
            Property.Settings settings = new Property.Settings();
            settings.Language = Languageselection;
            settings.Save();
            if ((txtname.Text != "") && (txtage.Text != "") && (txtmail.Text != "" && pwdcpass.Password != "" && pwdpass.Password != ""))
            {
                New oNew = new New();
                oNew.Show();

            }

        }
    }
}
           


    



        //        MessageBox.Show("REGISTRATION SUCCESSFUL", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

        //    }
        //    else
        //    {
        //        MessageBox.Show("INVALID INPUTS", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }


        
        
    


