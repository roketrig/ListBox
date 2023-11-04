using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ekle = msg_ekle.Text;
            listBox1.Items.Add(ekle);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sil = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(sil);
        }

        private void ben_count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Box count: " + listBox1.Items.Count.ToString());
        }

        private void btn_tem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ListBox Temizlendi.");
            listBox1.Items.Clear();
        }
    }
}
