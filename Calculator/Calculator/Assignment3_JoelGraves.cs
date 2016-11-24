using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdAddition.Checked = false; 
            rdSubtraction.Checked = false;
            rdMulti.Checked = false;
            rdDiv.Checked = false;
            rdRaise.Checked = false;
            rdSquare.Checked = false;

            txtLOp.Clear();
            txtROp.Clear();

            lblExpr.Text = string.Empty;
            lblRes.Text = string.Empty;

            txtLOp.Focus();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double val1, val2, val3;
            try
            {
                if (!(rdAddition.Checked || rdSubtraction.Checked || rdMulti.Checked
              || rdDiv.Checked || rdSquare.Checked || rdRaise.Checked))
                {
                    MessageBox.Show( "Please select an operation.", "My Calculator", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                if (txtLOp.Text == "")
                {
                    MessageBox.Show( "Left Operand is blank.  Please enter a value.", "My Calculator", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLOp.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                if (txtROp.Text == "" && (!(rdSquare.Checked)))
                {
                    MessageBox.Show("Right Opperand is blank.  Please enter a value.", "My Calculator", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtROp.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            if (rdAddition.Checked)
            {
                //move to result & rewrite expression to show algebraic expression
                lblRes.Text = (Convert.ToInt32(txtLOp.Text) + Convert.ToInt32(txtROp.Text)).ToString();
                lblExpr.Text = (Convert.ToInt32(txtLOp.Text) + Convert.ToString(" + ") + Convert.ToInt32(txtROp.Text)).ToString();
            }

            if (rdSubtraction.Checked)
            {
                lblRes.Text = (Convert.ToInt32(txtLOp.Text) - Convert.ToInt32(txtROp.Text)).ToString();
                lblExpr.Text = (Convert.ToInt32(txtLOp.Text) + Convert.ToString(" - ") + Convert.ToInt32(txtROp.Text)).ToString();

            }

            if (rdMulti.Checked)
            {
                lblRes.Text = (Convert.ToInt32(txtLOp.Text) * Convert.ToInt32(txtROp.Text)).ToString();
                lblExpr.Text = (Convert.ToInt32(txtLOp.Text) + Convert.ToString(" * ") + Convert.ToInt32(txtROp.Text)).ToString();

            }

            if (rdDiv.Checked)
            {
                lblRes.Text = (Convert.ToInt32(txtROp.Text) / Convert.ToInt32(txtLOp.Text)).ToString();
                lblExpr.Text = (Convert.ToInt32(txtLOp.Text) + Convert.ToString(" / ") + Convert.ToInt32(txtROp.Text)).ToString();
            }

            if (rdSquare.Checked)
            {
                val1 = Convert.ToInt32(txtLOp.Text);
                val2 = Math.Sqrt(val1);

                lblRes.Text = val2.ToString();
                lblExpr.Text = "The Square Root of " + txtLOp.Text;
               
            }

            if (rdRaise.Checked)
            {
                val1 = Convert.ToInt32(txtLOp.Text);
                val2 = Convert.ToInt32(txtLOp.Text);
                val3 = Math.Pow(val1, val2);

                lblRes.Text = val3.ToString();
                lblExpr.Text = txtLOp.Text + " raised to the " + txtROp.Text + " power".ToString();
               

            }

            // Joel L Graves
            // Calculator application
            // 9/8 - 9/14/16
        }

    }
}
