using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_FINAL
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();

       
            form3.Show();
        }

        private void cekpoin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();


            form4.Show();

        }

        private void sittinginfo_Click(object sender, EventArgs e)
        {
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
