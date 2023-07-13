namespace Телефонна_книжка__WinForms_EF_
{
    public partial class Form1 : Form
    {
        List<PhoneContact> contacts;
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
            contacts = new List<PhoneContact>();
            GetAndShowData();
            
        }
        private void GetAndShowData()
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                foreach (var item in context.PhoneContacts)
                {
                    var xd = new PhoneContact { Id =item.Id, Name = item.Name, Number = item.Number };
                    contacts.Add(xd);
                   
                }
                count = 0;
                foreach (var item in contacts)
                {
                    var entity = new PhoneNumbersEntityControl(item);
                    entity.Location = new System.Drawing.Point(entity.Location.X + 3, entity.Location.Y + 3 + entity.Height*count);
                    contacts_pnl.Controls.Add(entity);
                    count++;
                }
            }
        }

        private void addNewContact_btn_Click(object sender, EventArgs e)
        {
            this.addNewName_tb.ReadOnly= false;
            this.addNewNumber_tb.ReadOnly= false;
            this.addNewContact_btn.Visible= false;
            this.saveNewContact_btn.Visible= true;
            this.cancelNewContact_btn.Visible= true;
        }

        private void cancelNewContact_btn_Click(object sender, EventArgs e)
        {
            this.addNewName_tb.Text= string.Empty;
            this.addNewName_tb.ReadOnly= true;
            this.addNewNumber_tb.Text = string.Empty;
            this.addNewNumber_tb.ReadOnly= true;
            this.addNewContact_btn.Visible= true;
            this.saveNewContact_btn.Visible = false;
            this.cancelNewContact_btn.Visible = false;
        }

        private void saveNewContact_btn_Click(object sender, EventArgs e)
        {
            if (this.addNewName_tb.Text != string.Empty && this.addNewNumber_tb.Text != string.Empty)
            {
                using (MyApplicationContext context = new MyApplicationContext())
                {
                   
                    PhoneContact newContact = new PhoneContact(this.addNewName_tb.Text, int.Parse(this.addNewNumber_tb.Text));
                    context.PhoneContacts.Add(newContact);
                    context.SaveChanges();
                }
                this.Controls.Clear();
                InitializeComponent();
                GetAndShowData();
                this.addNewName_tb.Text = "";
                this.addNewNumber_tb.Text = "";
                
            }
            else
            {
                MessageBox.Show("Вы должны заполнить все поля");
            }
        }


        // проверка на написание цифр
        private void addNewNumber_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("В поле номера можно вводить только цифры");
            }
        }
        
    }
}