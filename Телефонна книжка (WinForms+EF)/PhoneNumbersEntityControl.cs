namespace Телефонна_книжка__WinForms_EF_
{
    public partial class PhoneNumbersEntityControl : UserControl
    {
        public PhoneNumbersEntityControl()
        {
            InitializeComponent();
        }
        public PhoneNumbersEntityControl(PhoneContact contact): this()
        {
            this.id_lbl.Text = contact.Id.ToString(); //sfdgghkl
            this.name_tb.Text = contact.Name;
            this.number_tb.Text = contact.Number.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
#pragma warning disable 8604
                context.PhoneContacts.Remove(context.PhoneContacts.FirstOrDefault(x => x.Id.Equals(int.Parse(id_lbl.Text))));
#pragma warning restore 8604
                context.SaveChanges();
                this.Controls.Clear();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.name_tb.ReadOnly= false;
            this.number_tb.ReadOnly= false;
            this.edit_btn.Visible=false;
            this.save_btn= new Button();
            this.save_btn.Location = new System.Drawing.Point(37, 87);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(63, 29);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += (s, e) =>
            {
                using (MyApplicationContext context = new MyApplicationContext())
                {
                    var editedContact = context.PhoneContacts.FirstOrDefault(x => x.Id.Equals(int.Parse(this.id_lbl.Text)));
#pragma warning disable 8602
                    editedContact.Name = this.name_tb.Text;
#pragma warning restore 8602
                    editedContact.Number = int.Parse(this.number_tb.Text);
                    context.PhoneContacts.Update(editedContact);
                    context.SaveChanges();
                    this.name_tb.ReadOnly= true;
                    this.number_tb.ReadOnly= true;
                }
            };
            this.Controls.Add(this.save_btn);
        }

        Button save_btn;
    }
}
