
namespace PassKeeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.categoryText = new System.Windows.Forms.TextBox();
            this.siteText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.notesText = new System.Windows.Forms.TextBox();
            this.panelSite = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSites = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 296);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TabStop = false;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // categoryText
            // 
            this.categoryText.Location = new System.Drawing.Point(106, 15);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(136, 23);
            this.categoryText.TabIndex = 0;
            // 
            // siteText
            // 
            this.siteText.Location = new System.Drawing.Point(106, 45);
            this.siteText.Name = "siteText";
            this.siteText.Size = new System.Drawing.Size(136, 23);
            this.siteText.TabIndex = 1;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(106, 75);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(136, 23);
            this.usernameText.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(105, 105);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(137, 23);
            this.passText.TabIndex = 3;
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(106, 135);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(136, 129);
            this.notesText.TabIndex = 4;
            // 
            // panelSite
            // 
            this.panelSite.Controls.Add(this.label5);
            this.panelSite.Controls.Add(this.label4);
            this.panelSite.Controls.Add(this.label3);
            this.panelSite.Controls.Add(this.label2);
            this.panelSite.Controls.Add(this.label1);
            this.panelSite.Controls.Add(this.categoryText);
            this.panelSite.Controls.Add(this.notesText);
            this.panelSite.Controls.Add(this.btnAdd);
            this.panelSite.Controls.Add(this.passText);
            this.panelSite.Controls.Add(this.btnRefresh);
            this.panelSite.Controls.Add(this.usernameText);
            this.panelSite.Controls.Add(this.comboBox1);
            this.panelSite.Controls.Add(this.siteText);
            this.panelSite.Controls.Add(this.btnDelete);
            this.panelSite.Location = new System.Drawing.Point(804, 12);
            this.panelSite.Name = "panelSite";
            this.panelSite.Size = new System.Drawing.Size(350, 375);
            this.panelSite.TabIndex = 13;
            this.panelSite.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Site:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category:";
            // 
            // btnSites
            // 
            this.btnSites.Location = new System.Drawing.Point(1079, 419);
            this.btnSites.Name = "btnSites";
            this.btnSites.Size = new System.Drawing.Size(75, 23);
            this.btnSites.TabIndex = 14;
            this.btnSites.TabStop = false;
            this.btnSites.Text = "Sites";
            this.btnSites.UseVisualStyleBackColor = true;
            this.btnSites.Click += new System.EventHandler(this.btnSites_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(12, 8);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(640, 137);
            this.labelTime.TabIndex = 15;
            this.labelTime.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(375, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "00:00:00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 422);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Enable TimeClock";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.btnSites);
            this.Controls.Add(this.panelSite);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSite.ResumeLayout(false);
            this.panelSite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox categoryText;
        private System.Windows.Forms.TextBox siteText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox notesText;
        private System.Windows.Forms.Panel panelSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSites;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

