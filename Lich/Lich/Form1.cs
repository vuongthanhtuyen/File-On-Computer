using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lich
{
    public partial class Form1 : Form
    {
        int soLuongNgay;
        int month1 = 0;
        public Form1()
        {
            InitializeComponent();
            LoadHienThi(dateTimePicker1.Value.Year,dateTimePicker1.Value.Month);
            month1 = dateTimePicker1.Value.Year;

        }
        
        void LoadHienThi(int year, int month)
        {
            for (int i = 1; i <= GetFirstDayInMonth(year,month); i++)
            {
                Label label = new Label() { Height = 50, Width = 60 };
                flpLich.Controls.Add(label);
            }

            for (int i = 2; i <= 8; i++)
            {
                Button button = new Button() { Height = 30, Width = 60 };
                button.Font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);

                switch (i)
                {
                    case 2:
                        button.Text = "Mo";
                        flpDay.Controls.Add(button);
                        break;
                    case 3:
                        button.Text = "Tu";
                        flpDay.Controls.Add(button);
                        break;
                    case 4:
                        button.Text = "We";
                        flpDay.Controls.Add(button);
                        break;
                    case 5:
                        button.Text = "Th";
                        flpDay.Controls.Add(button);
                        break;
                    case 6:
                        button.Text = "Fi";
                        flpDay.Controls.Add(button);
                        break;
                    case 7:
                        button.Text = "Sa";
                        flpDay.Controls.Add(button);
                        break;
                    case 8:
                        button.Text = "Su";
                        flpDay.Controls.Add(button);
                        break;

                }

            }
            for (int i = 1; i <= GetDayInMonth(year, month); i++)
            {
                Button button = new Button() { Height = 50, Width = 60 };
                button.BackColor = Color.Aqua;
                button.Text = i.ToString();
                flpLich.Controls.Add(button);
            }
        }
        int GetFirstDayInMonth(int year, int month)
        {
            DateTime mydate = new DateTime(year, month, 1);
            string formatteddate = string.Format("{0:dddd}", mydate);
            int day = 0;
            switch (formatteddate)
            {
                case "Tusday":
                    day = 1;
                    break;

                case "Wednesday":
                    day = 2;
                    break;
                case "Thursday":
                    day = 3;
                    break;
                case "Friday":
                    day = 4;
                    break;
                case "Saturday":
                    day = 5;
                    break;
                case "Sunday":
                    day = 6;
                    break;
            }
            return day;
        }
        int GetDayInMonth(int year, int month)
        {
            int soLuongNgay = DateTime.DaysInMonth(year, month);
            return soLuongNgay;
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            if (month1 != month)
            {
                flpLich.Controls.Clear();
                LoadHienThi(year, month);
                month1 = month;
               // Console.WriteLine(year1 +" year: "+year);
            }
           // year1 = year;




        }
        void KiemTraChange()
        {

        }

    }
}
