namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (password == "0123") { 
            SuccessfulLogin SL = new SuccessfulLogin();
            SL.Show();
        }
            else
                MessageBox.Show("Incorrect Password.");
                        
        }
    }
}