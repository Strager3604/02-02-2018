using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grades3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calling the Halt procedure
            Halt();


        }

        //Procedure to Exit
        public static void Halt()
        { //Local variable to store result
            DialogResult dr;

            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

    }
}
