namespace Телефонна_книжка__WinForms_EF_
{
    partial class PhoneNumbersEntityControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneNumbersEntityControl));
            this.userAvatar_pbx = new System.Windows.Forms.PictureBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // userAvatar_pbx
            // 
            this.userAvatar_pbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userAvatar_pbx.BackgroundImage")));
            this.userAvatar_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAvatar_pbx.ImageLocation = "";
            this.userAvatar_pbx.Location = new System.Drawing.Point(3, 23);
            this.userAvatar_pbx.Name = "userAvatar_pbx";
            this.userAvatar_pbx.Size = new System.Drawing.Size(60, 60);
            this.userAvatar_pbx.TabIndex = 0;
            this.userAvatar_pbx.TabStop = false;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(69, 23);
            this.name_tb.Name = "name_tb";
            this.name_tb.ReadOnly = true;
            this.name_tb.Size = new System.Drawing.Size(164, 27);
            this.name_tb.TabIndex = 4;
            this.name_tb.Text = "\r\n";
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(69, 56);
            this.number_tb.Name = "number_tb";
            this.number_tb.ReadOnly = true;
            this.number_tb.Size = new System.Drawing.Size(164, 27);
            this.number_tb.TabIndex = 5;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(37, 87);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(63, 29);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(136, 87);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(63, 29);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(107, 0);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(22, 20);
            this.id_lbl.TabIndex = 8;
            this.id_lbl.Text = "Id";
            // 
            // PhoneNumbersEntityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.number_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.userAvatar_pbx);
            this.Name = "PhoneNumbersEntityControl";
            this.Size = new System.Drawing.Size(236, 119);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox userAvatar_pbx;
        private TextBox name_tb;
        private TextBox number_tb;
        private Button edit_btn;
        private Button delete_btn;
        private Label id_lbl;
    }
}
