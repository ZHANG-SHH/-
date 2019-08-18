using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TeamWork
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int? year = null;
        int month, date;


        private void InputYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            year = int.Parse(this.InputYear.Text);
        }

        private void Assure_Click(object sender, RoutedEventArgs e)
        {
            month = int.Parse(ChooseMonth.Text);
            date = int.Parse(this.ChooseDay.Text);

            //计算距离下次生日的距离
            string datee = DateTime.Now.ToShortDateString();
            string[] date0 = datee.Split('/');
            int[] date1 = new int[3];
            for (int j = 0; j < 3; j++)
            {
                date1[j] = int.Parse(date0[j]);
            }
            DateTime dateTime1 = new DateTime(date1[0], date1[1], date1[2]);


            if (!CompareDate(date1[1], date1[2], month, date))
            {
                DateTime dateTime11 = new DateTime(date1[0], month, date);
                NextBirthday.Text = (dateTime11.DayOfYear - dateTime1.DayOfYear).ToString();
            }
            else
            {
                DateTime dateTime11 = new DateTime(date1[0] + 1, month, date);
                NextBirthday.Text = (YearDays(date1[0]) - dateTime1.DayOfYear + dateTime11.DayOfYear).ToString();
            }
        }


        static int YearDays(int year)
        {
            if (DateTime.IsLeapYear(year))
                return 366;
            else return 365;
        }

        static bool CompareDate(int a, int b, int c, int d)
        {
            if (a > c)
            {
                return true;
            }
            else if (a == c && b > d)
            {
                return true;
            }
            else return false;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
