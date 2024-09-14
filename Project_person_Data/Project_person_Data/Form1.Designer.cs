namespace Project_person_Data
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Exite = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddNew
            // 
            this.AddNew.BackColor = System.Drawing.Color.Purple;
            this.AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNew.ForeColor = System.Drawing.Color.White;
            this.AddNew.Location = new System.Drawing.Point(31, 353);
            this.AddNew.Margin = new System.Windows.Forms.Padding(6);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(159, 49);
            this.AddNew.TabIndex = 15;
            this.AddNew.Text = "Add New";
            this.toolTip1.SetToolTip(this.AddNew, "Click To Add New Person");
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Person Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(192, 143);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(548, 35);
            this.txtID.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtID, "Enter Person ID.");
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(192, 212);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(548, 35);
            this.txtName.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtName, "Enter Person Name");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(192, 273);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(548, 35);
            this.txtAddress.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtAddress, "Enter Person Address");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address:";
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.Purple;
            this.Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(238, 353);
            this.Find.Margin = new System.Windows.Forms.Padding(6);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(159, 49);
            this.Find.TabIndex = 25;
            this.Find.Text = "Find";
            this.toolTip1.SetToolTip(this.Find, "Click To Find Person");
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.BackColor = System.Drawing.Color.Purple;
            this.ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAll.ForeColor = System.Drawing.Color.White;
            this.ShowAll.Location = new System.Drawing.Point(439, 353);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(6);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(159, 49);
            this.ShowAll.TabIndex = 26;
            this.ShowAll.Text = "Show All";
            this.toolTip1.SetToolTip(this.ShowAll, "Click To Show All Persons");
            this.ShowAll.UseVisualStyleBackColor = false;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Exite
            // 
            this.Exite.BackColor = System.Drawing.Color.Purple;
            this.Exite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exite.ForeColor = System.Drawing.Color.White;
            this.Exite.Location = new System.Drawing.Point(636, 353);
            this.Exite.Margin = new System.Windows.Forms.Padding(6);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(159, 49);
            this.Exite.TabIndex = 27;
            this.Exite.Text = "Exite";
            this.toolTip1.SetToolTip(this.Exite, "Click To Exite");
            this.Exite.UseVisualStyleBackColor = false;
            this.Exite.Click += new System.EventHandler(this.Exite_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 471);
            this.Controls.Add(this.Exite);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Exite;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

