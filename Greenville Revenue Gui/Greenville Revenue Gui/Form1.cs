using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenville_Revenue_Gui
{
    public partial class Form1 : Form
    {
        private  int lastYearNum;
        private  int thisYearNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void findOutButton_Click(object sender, EventArgs e)
        {


            lastYearNumberContestantsLabel.Text = lastYearBox.Text;
            thisYearContestantNumberLabel.Text = thisYearBox.Text;
            lastRevenueTotalLabel.Text = ((double.Parse(lastYearBox.Text)) * 25).ToString();
            thisRevenueTotalLabel.Text = ((double.Parse(thisYearBox.Text)) * 25).ToString();

            double lastYearNum = double.Parse(lastYearBox.Text);
           double thisYearNum = double.Parse(thisYearBox.Text);

            if ((lastYearNum) < ((thisYearNum)))
                {
                greaterThanLabel.Text = string.Format("This year is greater with {0} people signed up!", thisYearBox.Text);
            }

            else
            {
                greaterThanLabel.Text = string.Format("Last year is greater with {0} people signed up!", lastYearBox.Text);
            }

        }
    }
}
