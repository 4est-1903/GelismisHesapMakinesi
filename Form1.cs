namespace hesapmakinesiv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1, sayi2;
        string islem;
        private void dugme1_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "1";
            }
            else
            {
                txtbox.Text += "1";
            }
        }

        private void dugme2_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "2";
            }
            else
            {
                txtbox.Text += "2";
            }
        }

        private void dugme3_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "3";
            }
            else
            {
                txtbox.Text += "3";
            }
        }

        private void dugme4_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "4";
            }
            else
            {
                txtbox.Text += "4";
            }
        }

        private void dugme5_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "5";
            }
            else
            {
                txtbox.Text += "5";
            }
        }

        private void dugme6_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "6";
            }
            else
            {
                txtbox.Text += "6";
            }
        }

        private void dugme7_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "7";
            }
            else
            {
                txtbox.Text += "7";
            }
        }

        private void dugme8_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "8";
            }
            else
            {
                txtbox.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "9";
            }
            else
            {
                txtbox.Text += "9";
            }
        }

        private void dugme0_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "0";
            }
            else
            {
                txtbox.Text += "0";
            }
        }

        private void virgul_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = ",";
            }
            else
            {
                txtbox.Text += ",";
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtbox.Text) > 0)
            {
                txtbox.Text = txtbox.Text.Remove(txtbox.Text.Length - 1, 1);
                if (txtbox.Text.Length == 0)
                {
                    txtbox.Text = "0";
                }
            }
        }

        private void islemtopla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtbox.Text);
            islem = "toplama";
            lbl.Text = txtbox.Text + " +";
            txtbox.Text = "0";
        }

        private void islemcikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtbox.Text);
            islem = "cikarma";
            lbl.Text = txtbox.Text + " -";
            txtbox.Text = "0";
        }

        private void islemcarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtbox.Text);
            islem = "carpma";
            lbl.Text = txtbox.Text + " X";
            txtbox.Text = "0";
        }

        private void islembol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtbox.Text);
            islem = "bolme";
            lbl.Text = txtbox.Text + " /";
            txtbox.Text = "0";
        }

        private void islemusal_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtbox.Text);
            islem = "us";
            lbl.Text = txtbox.Text + "^";
            txtbox.Text = "0";
            
        }

        private void islemkokal_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(txtbox.Text);
            karekok = Math.Sqrt(karekok);
            txtbox.Text = Convert.ToString(karekok);
            lbl.Text = txtbox.Text;
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            txtbox.Text = "0";

        }

        private void esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(txtbox.Text);
            if (islem == "toplama")
            {
                txtbox.Text = Convert.ToString(sayi1 + sayi2);
                lbl.Text = "";
            }
            if (islem == "cikarma")
            {
                txtbox.Text = Convert.ToString(sayi1 - sayi2);
                lbl.Text = "";
            }
            if (islem == "carpma")
            {
                txtbox.Text = Convert.ToString(sayi1 * sayi2);
                lbl.Text = "";
            }
            if (islem == "bolme")
            {
                txtbox.Text = Convert.ToString(sayi1 / sayi2);
                lbl.Text = "";
            }
            if (islem == "us")
            {
                txtbox.Text = Convert.ToString(Math.Pow(sayi1, sayi2));
                lbl.Text = "";
            }
        }
    }
}