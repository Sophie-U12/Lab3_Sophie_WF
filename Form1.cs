using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sophie_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            TripleNumbers tripleNumbers = new TripleNumbers((int)nudA.Value, (int)nudB.Value, (int)nudC.Value);
            lbResult.Text = $"Результат: {tripleNumbers.GetCalculation()}";
        }

        private void btnCalculation2_Click(object sender, EventArgs e)
        {
            try
            {
                SpecifiedInterval specifiedInterval = new SpecifiedInterval((int)nudA2.Value, (int)nudB2.Value);
                lbResult2.Text = $"Результат: {specifiedInterval.GetCalculation()}";
            }
            catch(ArgumentOutOfRangeException ex)
            {   
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
