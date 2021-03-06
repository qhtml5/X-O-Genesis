﻿namespace PetvetPOS_Inventory_System
{
    partial class CustomerInformationView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerInfo_panel = new System.Windows.Forms.Panel();
            this.updateContacts_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDiscardUpdate = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.txtUpdateMobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newClient_tab = new System.Windows.Forms.TabPage();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.existingClient_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgExistingClients = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customerInfo_panel.SuspendLayout();
            this.updateContacts_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.newClient_tab.SuspendLayout();
            this.existingClient_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExistingClients)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInfo_panel
            // 
            this.customerInfo_panel.BackColor = System.Drawing.Color.White;
            this.customerInfo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerInfo_panel.Controls.Add(this.updateContacts_panel);
            this.customerInfo_panel.Controls.Add(this.tabControl1);
            this.customerInfo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerInfo_panel.Location = new System.Drawing.Point(0, 0);
            this.customerInfo_panel.Name = "customerInfo_panel";
            this.customerInfo_panel.Size = new System.Drawing.Size(870, 583);
            this.customerInfo_panel.TabIndex = 0;
            // 
            // updateContacts_panel
            // 
            this.updateContacts_panel.Controls.Add(this.label10);
            this.updateContacts_panel.Controls.Add(this.btnDiscardUpdate);
            this.updateContacts_panel.Controls.Add(this.btnSaveUpdate);
            this.updateContacts_panel.Controls.Add(this.txtUpdateMobile);
            this.updateContacts_panel.Controls.Add(this.label13);
            this.updateContacts_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateContacts_panel.Location = new System.Drawing.Point(585, 0);
            this.updateContacts_panel.Name = "updateContacts_panel";
            this.updateContacts_panel.Size = new System.Drawing.Size(279, 583);
            this.updateContacts_panel.TabIndex = 2;
            this.updateContacts_panel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(14, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Update Contact Information:";
            // 
            // btnDiscardUpdate
            // 
            this.btnDiscardUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscardUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDiscardUpdate.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Cancel;
            this.btnDiscardUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscardUpdate.Location = new System.Drawing.Point(149, 285);
            this.btnDiscardUpdate.Name = "btnDiscardUpdate";
            this.btnDiscardUpdate.Size = new System.Drawing.Size(116, 62);
            this.btnDiscardUpdate.TabIndex = 50;
            this.btnDiscardUpdate.Text = "Cancel";
            this.btnDiscardUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscardUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveUpdate.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Save;
            this.btnSaveUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUpdate.Location = new System.Drawing.Point(17, 285);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(117, 62);
            this.btnSaveUpdate.TabIndex = 49;
            this.btnSaveUpdate.Text = "Save";
            this.btnSaveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // txtUpdateMobile
            // 
            this.txtUpdateMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUpdateMobile.Location = new System.Drawing.Point(17, 195);
            this.txtUpdateMobile.MaxLength = 13;
            this.txtUpdateMobile.Name = "txtUpdateMobile";
            this.txtUpdateMobile.Size = new System.Drawing.Size(248, 26);
            this.txtUpdateMobile.TabIndex = 46;
            this.txtUpdateMobile.TextChanged += new System.EventHandler(this.filterContacts);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(14, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Mobile No:";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.newClient_tab);
            this.tabControl1.Controls.Add(this.existingClient_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 583);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // newClient_tab
            // 
            this.newClient_tab.Controls.Add(this.btnDiscard);
            this.newClient_tab.Controls.Add(this.btnSave);
            this.newClient_tab.Controls.Add(this.txtEmail);
            this.newClient_tab.Controls.Add(this.txtMobile);
            this.newClient_tab.Controls.Add(this.txtAdd1);
            this.newClient_tab.Controls.Add(this.txtMname);
            this.newClient_tab.Controls.Add(this.txtFname);
            this.newClient_tab.Controls.Add(this.txtLname);
            this.newClient_tab.Controls.Add(this.label9);
            this.newClient_tab.Controls.Add(this.label8);
            this.newClient_tab.Controls.Add(this.label5);
            this.newClient_tab.Controls.Add(this.label4);
            this.newClient_tab.Controls.Add(this.label3);
            this.newClient_tab.Controls.Add(this.label2);
            this.newClient_tab.Controls.Add(this.label1);
            this.newClient_tab.Location = new System.Drawing.Point(4, 32);
            this.newClient_tab.Name = "newClient_tab";
            this.newClient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.newClient_tab.Size = new System.Drawing.Size(577, 547);
            this.newClient_tab.TabIndex = 0;
            this.newClient_tab.Text = "Add New Client Information";
            this.newClient_tab.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDiscard.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Cancel;
            this.btnDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscard.Location = new System.Drawing.Point(374, 457);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(146, 55);
            this.btnDiscard.TabIndex = 44;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSave.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(222, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(83, 372);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 26);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextChanged += new System.EventHandler(this.filterEmail);
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMobile.Location = new System.Drawing.Point(83, 320);
            this.txtMobile.MaxLength = 13;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(411, 26);
            this.txtMobile.TabIndex = 40;
            this.txtMobile.TextChanged += new System.EventHandler(this.textChanged_Numeric);
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdd1.Location = new System.Drawing.Point(83, 214);
            this.txtAdd1.Multiline = true;
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(411, 78);
            this.txtAdd1.TabIndex = 37;
            this.txtAdd1.TextChanged += new System.EventHandler(this.filterParagraph);
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMname.Location = new System.Drawing.Point(392, 133);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(149, 26);
            this.txtMname.TabIndex = 36;
            this.txtMname.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFname.Location = new System.Drawing.Point(211, 133);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(149, 26);
            this.txtFname.TabIndex = 35;
            this.txtFname.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLname.Location = new System.Drawing.Point(34, 133);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(149, 26);
            this.txtLname.TabIndex = 34;
            this.txtLname.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(31, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(30, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Contact No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(389, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(208, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client Information:";
            // 
            // existingClient_tab
            // 
            this.existingClient_tab.Controls.Add(this.panel1);
            this.existingClient_tab.Location = new System.Drawing.Point(4, 32);
            this.existingClient_tab.Name = "existingClient_tab";
            this.existingClient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.existingClient_tab.Size = new System.Drawing.Size(577, 547);
            this.existingClient_tab.TabIndex = 1;
            this.existingClient_tab.Text = "Update Client Contact Information";
            this.existingClient_tab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 541);
            this.panel1.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgExistingClients);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(571, 444);
            this.panel4.TabIndex = 47;
            // 
            // dgExistingClients
            // 
            this.dgExistingClients.AllowUserToAddRows = false;
            this.dgExistingClients.AllowUserToDeleteRows = false;
            this.dgExistingClients.AllowUserToResizeColumns = false;
            this.dgExistingClients.AllowUserToResizeRows = false;
            this.dgExistingClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExistingClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgExistingClients.BackgroundColor = System.Drawing.Color.White;
            this.dgExistingClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgExistingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExistingClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExistingClients.Location = new System.Drawing.Point(20, 20);
            this.dgExistingClients.MultiSelect = false;
            this.dgExistingClients.Name = "dgExistingClients";
            this.dgExistingClients.ReadOnly = true;
            this.dgExistingClients.RowHeadersVisible = false;
            this.dgExistingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExistingClients.Size = new System.Drawing.Size(531, 404);
            this.dgExistingClients.TabIndex = 0;
            this.dgExistingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExistingClients_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtClientName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 97);
            this.panel3.TabIndex = 46;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClientName.Location = new System.Drawing.Point(20, 41);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(531, 26);
            this.txtClientName.TabIndex = 44;
            this.txtClientName.TextChanged += new System.EventHandler(this.filterNames);
            this.txtClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientName_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Search By Name:";
            // 
            // CustomerInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customerInfo_panel);
            this.Name = "CustomerInformationView";
            this.Size = new System.Drawing.Size(870, 583);
            this.customerInfo_panel.ResumeLayout(false);
            this.updateContacts_panel.ResumeLayout(false);
            this.updateContacts_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.newClient_tab.ResumeLayout(false);
            this.newClient_tab.PerformLayout();
            this.existingClient_tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExistingClients)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerInfo_panel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newClient_tab;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage existingClient_tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgExistingClients;
        private System.Windows.Forms.Panel updateContacts_panel;
        private System.Windows.Forms.Button btnDiscardUpdate;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox txtUpdateMobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
    }
}
