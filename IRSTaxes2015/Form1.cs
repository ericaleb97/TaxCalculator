using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRSTaxes2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
                var payer = new Taxpayer();
                payer.FilingType = (Taxpayer.filing)Enum.Parse(typeof(Taxpayer.filing), comboBox1.SelectedIndex.ToString());
                var main = new MainForm(payer);
                main.Show();
        }
    }
}
