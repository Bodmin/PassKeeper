using FormLibList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class Form1 : Form
    {

        List<AccountList> Person = new List<AccountList>();
        List<Account> MainAccnt = new List<Account>();
        Timer TimeClock = new Timer();
        
        

        public Form1()
        {
            InitializeComponent();
            LoadPeopleList();
            var bindingSource1 = new BindingSource();
            TimeClock.Interval = 1000;
            TimeClock.Tick += TimeClock_Tick;
            //TimeClock.Start(); Not needed with the checkbox on the form, kept if necessary

        
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
            //panelSite.Size = new Size(300, 50);
            if (panelSite.Visible == false)
            { 
                panelSite.Visible = true;
                panelSite.Location = new Point(804, 12);
                panelSite.Size = new Size(350, 375);
            }
            else
            {
                panelSite.Location = new Point(804, 12);
                panelSite.Size = new Size(300, 50);
                panelSite.Visible = false;
            }
        }

        private void TimeClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) TimeClock.Enabled = true;
            else TimeClock.Enabled = false;
        }
    }
}
