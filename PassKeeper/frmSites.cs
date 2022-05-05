using FormLibList;
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

        List<AccountList> Person = new List<AccountList>();
        List<Account> MainAccnt = new List<Account>();


        public frmSites()
        {
            InitializeComponent();
        }
        private void LoadAccountList()
        {
            MainAccnt = SqliteDataAccess.LoadAccount();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account m = new Account();

            m.category = categoryText.Text;
            m.site = siteText.Text;
            m.username = usernameText.Text;
            m.pass = passText.Text;
            m.notes = notesText.Text;


            SqliteDataAccess.SaveAccount(m);
            //WireUpAccountList();

            categoryText.Text = "";
            siteText.Text = "";
            usernameText.Text = "";
            passText.Text = "";
            notesText.Text = "";
            LoadAccountList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
