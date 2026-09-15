using System;
using System.Windows.Forms;

namespace WinFormsDesktopSuite
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // عند فتح الشاشة يتنفذ الحساب تلقائياً
        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateAge();
        }

        // عند تغيير التاريخ في الـ DateTimePicker يطبع النتيجة مباشرة
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateAge();
        }

        // دالة حساب العمر بالسنوات والشهور والأيام
        private void UpdateAge()
        {
            DateTime birthDate = dateTimePicker1.Value;
            DateTime today = DateTime.Now;

            // 1. حساب عدد الأيام الكلية
            int days = (today - birthDate).Days;

            // 2. حساب عدد الشهور الكلية
            int months = (today.Year - birthDate.Year) * 12 + (today.Month - birthDate.Month);

            // 3. حساب عدد السنوات
            int years = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(years))
            {
                years--;
            }

            // التأكد من عدم اختيار تاريخ مستقبلي
            if (days < 0)
            {
                lblYears.Text = "عمرك بالسنوات : 0";
                lblMonths.Text = "عمرك بالشهور : 0";
                lblDays.Text = "عمرك بالأيام : 0";
                return;
            }

            // طباعة النتائج في الـ Labels
            lblYears.Text = "عمرك بالسنوات : " + years;
            lblMonths.Text = "عمرك بالشهور : " + months;
            lblDays.Text = "عمرك بالأيام : " + days;
        }

       
    }
}
