using FormLibList;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class Form1 : Form
    {

        List<AccountList> Person = new List<AccountList>();
        List<Account> MainAccnt = new List<Account>();
        

        public Form1()
        {
            InitializeComponent();
            LoadPeopleList();
            var bindingSource1 = new BindingSource();
        
        }

        private void LoadPeopleList()
        {
            Person = SqliteDataAccess.LoadPeople();
            //WireUpPeopleList();
        }

        private void LoadAccountList()
        {
            MainAccnt = SqliteDataAccess.LoadAccount();
        }

        private void LoadAccountText()
        { 
            //Load list data into text fields
        }

        /* Not used in the interface atm, kept for reference and possible re-use.
        private void WireUpPeopleList()
        {
            // Displays contents of the PersonList list.
            //Listbox properties
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = Person;
            listPeopleListBox.DisplayMember = "fullName";
        }

        private void WireUpAccountList()
        {
            // Displays contents of the AccountList list.
            //Listbox properties
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = MainAccnt;
            listPeopleListBox.DisplayMember = "site";
        }
        */

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAccountList();
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Person;
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "fullName";
            comboBox1.ValueMember = "fullName";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AccountList q = new AccountList();
            q = (AccountList)comboBox1.SelectedItem;
            SqliteDataAccess.DeletePerson(q);
            LoadPeopleList();
        }

        private void btnSites_Click(object sender, EventArgs e)
        {
            if (panelSite.Visible == false) panelSite.Visible = true;
            else
                panelSite.Visible = false;
        }
    }
}
