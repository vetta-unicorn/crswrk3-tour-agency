namespace crswrk_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // �����������
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        // ���� ��� �������
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
        }

        // ���� ��� ���������
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var man_log = new manager_log();
            man_log.Show();
        }
    }
}