using FormLibList;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class Form1 : Form
    {

        List<AccountList> Person = new List<AccountList>();
        

        public Form1()
        {
            InitializeComponent();
            LoadPeopleList();
            var bindingSource1 = new BindingSource();
        
        }

        private void LoadPeopleList()
        {
            Person = SqliteDataAccess.LoadPeople();
            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            // Displays contents of the PersonList list.
            //Listbox properties
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = Person;
            listPeopleListBox.DisplayMember = "fullName";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountList p = new AccountList();

            p.fName = firstNameText.Text;
            p.lName = lastNameText.Text;

            // TODO - do something with this item
            SqliteDataAccess.SavePerson(p);
            WireUpPeopleList();

            firstNameText.Text = "";
            lastNameText.Text = "";
            LoadPeopleList();
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
    }
}
