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

             if (year != null)
            {
                DateTime dateTime2 = new DateTime(Convert.ToInt32(year), month, date);
                if (year != null && year <= date1[0])
                {
                    int sum = 0;
                    if (Convert.ToInt32(year) < date1[0])
                    {
                        sum = dateTime1.DayOfYear + YearDays(Convert.ToInt32(year)) - dateTime2.DayOfYear;
                        for (int j = Convert.ToInt32(year + 1); j < date1[0]; j++)
                        {
                            sum += YearDays(j);
                        }
                    }
                    else sum = dateTime1.DayOfYear - dateTime2.DayOfYear;
                    HasBorn.Text = sum.ToString();
                }

                //一万天判断
                int summ = YearDays(Convert.ToInt32(year)) - dateTime2.DayOfYear;
                int i = Convert.ToInt32(year);
                DateTime dateTime = new DateTime(i, month, date);
                for (i = Convert.ToInt32(year) + 1; 10000 - summ >= YearDays(i) - dateTime.DayOfYear; i++)
                {
                    summ += YearDays(i);
                }

                int dayy = dateTime.DayOfYear + 10000 - summ;
                for (int j = 1; j <= 12; j++)
                {
                    for (int k = 1; k <= MonthDays(i, j); k++)
                    {
                        DateTime dateTime3 = new DateTime(i, j, k);
                        if (dateTime3.DayOfYear == dayy)
                        {
                            万天计划.Text = i.ToString() + "." + j.ToString() + "." + k.ToString();
                            break;
                        }
                    }
                }

            }
        }


        static int YearDays(int year)
        {
            if (DateTime.IsLeapYear(year))
                return 366;
            else return 365;
        }

        static int MonthDays(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    {
                        if (DateTime.IsLeapYear(year))
                            return 29;
                        else return 28;
                    }

            }
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
