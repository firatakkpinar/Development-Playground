namespace proje_bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasapara = 0;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, su, cay, misir,toplam;
            bilet = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);
            misir = Convert.ToInt16(textBox4.Text);
            toplam = (bilet * 70 + su * 5 + cay * 10 + misir * 30);
            label6.Text = toplam + "TL";
            kasapara = kasapara + toplam;
            label9.Text = kasapara.ToString();
        }
    }
}