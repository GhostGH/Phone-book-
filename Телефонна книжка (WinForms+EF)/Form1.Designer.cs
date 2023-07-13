namespace Телефонна_книжка__WinForms_EF_
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
            this.contacts_pnl = new System.Windows.Forms.Panel();
            this.addNewName_tb = new System.Windows.Forms.TextBox();
            this.addNewNumber_tb = new System.Windows.Forms.TextBox();
            this.addNewContact_lbl = new System.Windows.Forms.Label();
            this.addNewContact_btn = new System.Windows.Forms.Button();
            this.saveNewContact_btn = new System.Windows.Forms.Button();
            this.cancelNewContact_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contacts_pnl
            // 
            this.contacts_pnl.AutoScroll = true;
            this.contacts_pnl.BackColor = System.Drawing.Color.Black;
            this.contacts_pnl.Location = new System.Drawing.Point(0, 0);
            this.contacts_pnl.Name = "contacts_pnl";
            this.contacts_pnl.Padding = new System.Windows.Forms.Padding(3);
            this.contacts_pnl.Size = new System.Drawing.Size(242, 341);
            this.contacts_pnl.TabIndex = 0;
            // 
            // addNewName_tb
            // 
            this.addNewName_tb.Location = new System.Drawing.Point(250, 88);
            this.addNewName_tb.Name = "addNewName_tb";
            this.addNewName_tb.ReadOnly = true;
            this.addNewName_tb.Size = new System.Drawing.Size(164, 27);
            this.addNewName_tb.TabIndex = 5;
            this.addNewName_tb.Text = "\r\n";
            // 
            // addNewNumber_tb
            // 
            this.addNewNumber_tb.Location = new System.Drawing.Point(250, 121);
            this.addNewNumber_tb.Name = "addNewNumber_tb";
            this.addNewNumber_tb.ReadOnly = true;
            this.addNewNumber_tb.Size = new System.Drawing.Size(164, 27);
            this.addNewNumber_tb.TabIndex = 6;
            this.addNewNumber_tb.Text = "\r\n";
            this.addNewNumber_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNewNumber_tb_KeyPress);
            // 
            // addNewContact_lbl
            // 
            this.addNewContact_lbl.AutoSize = true;
            this.addNewContact_lbl.BackColor = System.Drawing.Color.SlateGray;
            this.addNewContact_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewContact_lbl.ForeColor = System.Drawing.Color.White;
            this.addNewContact_lbl.Location = new System.Drawing.Point(261, 52);
            this.addNewContact_lbl.Name = "addNewContact_lbl";
            this.addNewContact_lbl.Size = new System.Drawing.Size(143, 20);
            this.addNewContact_lbl.TabIndex = 7;
            this.addNewContact_lbl.Text = "Add a new contact:";
            // 
            // addNewContact_btn
            // 
            this.addNewContact_btn.Location = new System.Drawing.Point(285, 154);
            this.addNewContact_btn.Name = "addNewContact_btn";
            this.addNewContact_btn.Size = new System.Drawing.Size(94, 29);
            this.addNewContact_btn.TabIndex = 8;
            this.addNewContact_btn.Text = "Add";
            this.addNewContact_btn.UseVisualStyleBackColor = true;
            this.addNewContact_btn.Click += new System.EventHandler(this.addNewContact_btn_Click);
            // 
            // saveNewContact_btn
            // 
            this.saveNewContact_btn.Location = new System.Drawing.Point(261, 154);
            this.saveNewContact_btn.Name = "saveNewContact_btn";
            this.saveNewContact_btn.Size = new System.Drawing.Size(62, 29);
            this.saveNewContact_btn.TabIndex = 9;
            this.saveNewContact_btn.Text = "save";
            this.saveNewContact_btn.UseVisualStyleBackColor = true;
            this.saveNewContact_btn.Visible = false;
            this.saveNewContact_btn.Click += new System.EventHandler(this.saveNewContact_btn_Click);
            // 
            // cancelNewContact_btn
            // 
            this.cancelNewContact_btn.Location = new System.Drawing.Point(342, 154);
            this.cancelNewContact_btn.Name = "cancelNewContact_btn";
            this.cancelNewContact_btn.Size = new System.Drawing.Size(62, 29);
            this.cancelNewContact_btn.TabIndex = 10;
            this.cancelNewContact_btn.Text = "cancel";
            this.cancelNewContact_btn.UseVisualStyleBackColor = true;
            this.cancelNewContact_btn.Visible = false;
            this.cancelNewContact_btn.Click += new System.EventHandler(this.cancelNewContact_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(421, 342);
            this.Controls.Add(this.cancelNewContact_btn);
            this.Controls.Add(this.saveNewContact_btn);
            this.Controls.Add(this.addNewContact_btn);
            this.Controls.Add(this.addNewContact_lbl);
            this.Controls.Add(this.addNewNumber_tb);
            this.Controls.Add(this.addNewName_tb);
            this.Controls.Add(this.contacts_pnl);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel contacts_pnl;
        private TextBox addNewName_tb;
        private TextBox addNewNumber_tb;
        private Label addNewContact_lbl;
        private Button addNewContact_btn;
        private Button saveNewContact_btn;
        private Button cancelNewContact_btn;
    }
}