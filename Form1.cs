namespace mod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            textJawaban.Text = "Haloo " + name;
        }

        private void textJawaban_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
