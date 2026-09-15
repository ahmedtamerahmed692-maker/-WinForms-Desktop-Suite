using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopSuite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateCounters();
        }

        // دالة تحديث العدادات
        private void UpdateCounters()
        {
            label1.Text = "Pending : " + (checkedListBox1.Items.Count - checkedListBox1.CheckedItems.Count);
            label2.Text = "Completed : " + checkedListBox1.CheckedItems.Count;
        }

        // إضافة مهمة جديدة
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                checkedListBox1.Items.Add(textBox1.Text.Trim());
                textBox1.Clear();
                textBox1.Focus();
                UpdateCounters();
            }
        }

        // تحديد الكل
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            UpdateCounters();
        }

        // إلغاء تحديد الكل
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            UpdateCounters();
        }

        // حذف المهمة المحددة
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
                UpdateCounters();
            }
        }

        // زر Done: يضع علامة صح على المهمة المحددة ويحدث العدادات
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
                UpdateCounters();
            }
        }

        // عند النقر المباشر بالماوس على مربع الصح
        private async void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            await Task.Delay(10);
            UpdateCounters();
        }
    }
}
