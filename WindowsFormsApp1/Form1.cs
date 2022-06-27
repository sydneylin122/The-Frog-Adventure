using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void start_Click_1(object sender, EventArgs e)
        {
            this.Hide();     //關閉前言畫面

            /*---開啟遊戲介面---*/

            Form1 f1;
            f1 = new Form1();
            f1.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
