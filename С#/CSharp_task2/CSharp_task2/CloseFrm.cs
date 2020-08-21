using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_task2
{
    public partial class CloseFrm : Form
    {
        public CloseFrm()
        {
            InitializeComponent();
        }

        public string ansSave { get; private set; }

        private void btYes_Click(object sender, EventArgs e)
        {
            ansSave = "Yes";
            Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            ansSave = "No";
            Close();
        }
    }
}
