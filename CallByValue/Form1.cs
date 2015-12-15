using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallByValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnMulitply_Click(object sender, EventArgs e)
        {
            int numberEntered;
            if(int.TryParse(txtBoxEnterNum.Text, out numberEntered))
            {
                lblB4Call.Text = numberEntered.ToString();
                Methods defs = new Methods();
                lblRes.Text = (defs.MultiplyNumBy5(numberEntered)).ToString();
                lblB4Call.Visible = true;
                lblAfterCall.Visible = true;
                lblRes.Visible = true;
                lblAfterCall.Text = numberEntered.ToString();
            }  
            else
            {
                lblRes.Text = "Please enter a valid number";
            }


        }

        private void btn_ResetForm(object sender, EventArgs e)
        {
            txtBoxEnterNum.Clear();
            lblRes.Text = "";
            lblB4Call.Text = "";
            lblAfterCall.Text = "";
        }
    }
}
