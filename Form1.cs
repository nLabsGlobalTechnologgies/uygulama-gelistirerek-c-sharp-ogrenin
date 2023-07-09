namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bolum;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            fark = sayi1 - sayi2;
            MessageBox.Show("Toplam : " + toplam + "\n" + "Fark : " + fark + "\n" + "Çarpým : " + carpim + "\n" + "Bölüm : " + bolum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            s3 = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + s3) / 3;
            label2.Text = ort.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name, surname;
            int s1, s2, project;
            double centers;

            name = textBox6.Text;
            surname = textBox7.Text;
            s1 = Convert.ToInt16(textBox8.Text);
            s2 = Convert.ToInt16(textBox9.Text);
            project = Convert.ToInt16(textBox10.Text);
            centers = (s1 + s2 + project) / 3;
            listBox1.Items.Add("Adý : " + name + " Soyadý : " + surname + " Ortalama : " + centers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string product = textBox11.Text;
            decimal price = Convert.ToDecimal(textBox12.Text);
            int kdv = Convert.ToInt16(textBox13.Text);
            var result = price + kdv;
            listBox2.Items.Add("Ürün : " + product + " Fiyat : " + price + " Kdv : " + kdv + " Sonuç : " + result);
        }
    }
}