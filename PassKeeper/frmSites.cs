using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class frmSites : Form
    {
        public frmSites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
