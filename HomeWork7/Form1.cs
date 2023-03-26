using System;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        private DateTime UserBornDay;

        public Form1()
        {
            InitializeComponent();
        }

        private int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                   (((end.Month > start.Month) ||
                   ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }

        private int Days(DateTime start, DateTime end)
        {
            return Convert.ToInt32((end - start).TotalDays);
        }

        private int Month(DateTime start, DateTime end)
        {
            return Convert.ToInt32(((end.Year - start.Year) * 12) + end.Month - start.Month);
        }

        private int Eighteen(DateTime start)
        {
            return start.Year + 18;
        }

        private void CalculateButton_MouseClick(object sender, MouseEventArgs e)
        {
            UserBornDay = DatePicker.Value.Date;

            if (UserBornDay >= DateTime.Now)
            {
                UserInfoLable.Text = "Нажаль, ви ще не народилися!";
                return;
            }
            
            int years = Years(UserBornDay, DateTime.Now);
            int days = Days(UserBornDay, DateTime.Now);
            int month = Month(UserBornDay, DateTime.Now);
            int eighteen = Eighteen(UserBornDay);

            UserInfoLable.Text = $"Повних років: {years}\n" +
                                 $"Ви прожили {days} днів\n" +
                                 $"Ви прожили {month} місяців\n" +
                                 ((years >= 18) ? $"Вам виповнилося 18 в {eighteen} році" : $"Вам виповнеться 18 в {eighteen}");
        }
    }
}
