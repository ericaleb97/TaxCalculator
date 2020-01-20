using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IRSTaxes2015
{
    public partial class MainForm : Form
    {
        Taxpayer _payer;

        public MainForm(Taxpayer payer)
        {
            _payer = payer;
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (userSalary.Text.Length == 0)
            {
                MessageBox.Show("Please enter a salary before calculating");
            }

            else
            {
                double salary = Convert.ToDouble(userSalary.Text);
                double tax = 0;
                
                var payer = new Taxpayer(salary);

                if (_payer.FilingType == Taxpayer.filing.Single)
                {
                    taxOwed.Text = payer.CalculateTax().ToString();
                    taxedSalary.Text = payer.remainingSalary().ToString();
                }

                else if (_payer.FilingType == Taxpayer.filing.Head)
                {
                    taxOwed.Text = payer.CalculateMarriedFilingJointly().ToString();
                    taxedSalary.Text = payer.remainingSalary().ToString();
                }

                else if (_payer.FilingType == Taxpayer.filing.Jointly)
                {
                    taxOwed.Text = payer.CalculateHeadOfHouseHold().ToString();
                    taxedSalary.Text = payer.remainingSalary().ToString();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (userSalary.Text.Length == 0)
            {
                MessageBox.Show("Please enter the user data before updating");
            }

            else
            {
                double salary = Convert.ToDouble(userSalary.Text);
                double tax = 0;

                var payer = new Taxpayer(salary);
                taxOwed.Text = payer.CalculateTax().ToString();
                taxedSalary.Text = payer.remainingSalary().ToString();
                payer.SSN = SSN.Text;
                payer.Name = name.Text;

                TaxPayerAdaptor.UpdateSingleRecord(payer);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (SSN.Text.Length == 0)
            {
                MessageBox.Show("Please enter the user data before updating");
            }

            else
            {
                double salary = Convert.ToDouble(userSalary.Text);
                double tax = 0;

                var payer = new Taxpayer(salary);
                taxOwed.Text = payer.CalculateTax().ToString();
                taxedSalary.Text = payer.remainingSalary().ToString();

                payer.SSN = SSN.Text;
                payer.Name = name.Text;

                TaxPayerAdaptor.InsertSingleRecord(payer);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            var payer = TaxPayerAdaptor.SelectSingleRecord(searchSSN.Text); 

            SSN.Text = payer.SSN;
            name.Text = payer.Name;
            userSalary.Text = payer.salary.ToString();
            taxOwed.Text = payer.tax.ToString();
            taxedSalary.Text = payer.taxedSalary.ToString();
            searchSSN.Text = String.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SSN.Text = String.Empty;
            name.Text = String.Empty;
            userSalary.Text = String.Empty;
            taxOwed.Text = String.Empty;
            taxedSalary.Text = String.Empty;
            searchSSN.Text = String.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var payer = new Taxpayer();
            payer.SSN = SSN.Text;

            if (SSN.Text.Length == 0)
            {
                MessageBox.Show("Please enter a record before deleting");
            }

            else
            {
                string message = "Do you want to delete this record?";
                string title = "Delete Record";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    TaxPayerAdaptor.DelteSingleRecord(payer.SSN);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void SSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void userSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && Text.Contains("."))
                e.Handled = true;
        }

        private void searchSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}