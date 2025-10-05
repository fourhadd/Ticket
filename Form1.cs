namespace Travel_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String from = comboBox1.SelectedItem.ToString();
            String to = comboBox2.SelectedItem.ToString();
            String date = maskedTextBox1.Text;
            String time = maskedTextBox2.Text;
            String seat = textBox1.Text;
            String name = textBox2.Text;
            String ZipCode = maskedTextBox3.Text;
            String phone = maskedTextBox4.Text;
            String email = textBox3.Text;
            String ticket = ""Haradan: " + from +
                            "\n Haraya: " + to +
                            "\n Tarix: " + date +
                            "\n Saat: " + time +
                            "\n Oturacaq №: " + seat +
                            "\n Ad: " + name +
                            "\n Poçt indeksi: " + ZipCode +
                            "\n Telefon: " + phone +
                            "\n E-poçt: " + email;
            listBox1.Items.Add(ticket);
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string temp = comboBox1.SelectedItem.ToString();
            comboBox1.Text = comboBox2.SelectedItem.ToString();    
            comboBox2.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


