using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDesktopSuite.Properties;

namespace WinFormsDesktopSuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. تغيير عنوان الصورة والـ Link عند كتابة نص
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbTitle.Text = textBox1.Text;
            linkLabel1.Text = textBox1.Text;
        }

        // 2. تغيير لون عنوان الصورة (lbTitle) عند اختيار لون من القائمة
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                lbTitle.ForeColor = Color.FromName(comboBox1.SelectedItem.ToString());
            }
        }

        // قائمة الأذكار التي ستتغير بالتتابع
        private string[] azkar = { "سبحان الله", "الحمد لله", "الله أكبر" };
        private int zikrIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;

            // ضبط التايمر ليعمل كل 30 ثانية (30000 ملي ثانية)
            timer1.Interval = 30000;
            label1.Text = azkar[0]; // الذكر المبدئي "سبحان الله"
        }

        // 3. زر ابدأ التايمر (Start)
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // 4. زر إيقاف التايمر (Stop)
        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // 5. حدث الـ Timer الذي يتغير كل 30 ثانية بالتتابع بين الأذكار
        private void timer1_Tick(object sender, EventArgs e)
        {
            // الانتقال للذكر التالي في المصفوفة (0 -> 1 -> 2 -> 0 ...)
            zikrIndex = (zikrIndex + 1) % azkar.Length;
            label1.Text = azkar[zikrIndex];
        }

        // 6. تغيير صورة الشخصية والعنوان الخاص بها فوق الصورة (lblBoyTitle)
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) return;

            string selectedText = comboBox2.SelectedItem.ToString();
            lblBoyTitle.Text = selectedText;

            switch (selectedText.ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    lbTitle.Text = "Boy";
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    lbTitle.Text = "Girl";
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book;
                    lbTitle.Text = "Book";
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    lbTitle.Text = "Pen";
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(linkLabel1.Text))
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + linkLabel1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                checkedListBox1.Items.Add(comboBox2.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Text + Environment.NewLine;
            label2.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label2.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label2.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label2.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label2.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
        }

        private void lblBoyTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
