using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Globalization;

namespace RSA
{
    public partial class Form1: Form
    {

        private int p, q;
        private int E, n, phi, d;

        public Form1()
        {
            InitializeComponent();
        }

        private bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        private int modInverse(int e, int phi)
        {
            int m0 = phi, t, q;
            int x0 = 0, x1 = 1;

            if (phi == 1) return 0;

            while (e > 1)
            {
                q = e / phi;
                t = phi;
                phi = e % phi;
                e = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;
            return x1;
        }

        private List<int> convertNum(string text)
        {
            List<int> m = new List<int>();
            foreach (char c in text)
                m.Add(c - 'A');
            return m;
        }
        private int randomPrimeNumber(int bits)
        {
            Random rand = new Random();
            int val;
            do
            {
                val = rand.Next((int)Math.Pow(2, bits - 1), (int)Math.Pow(2, bits));
            }
            while (!isPrime(val));
            return val;
        }

        private List<int> encrypt(List<int> m)
        {
            List<int> c = new List<int>();
            foreach (int x in m)
            {
                BigInteger encrypted = BigInteger.ModPow(x, E, n);
                c.Add((int)encrypted);
            }
            return c;
        }

        private List<int> decrypt(List<int> m)
        {
            List<int> p = new List<int>();
            foreach (int x in m)
            {
                BigInteger decrypted = BigInteger.ModPow(x, d, n);
                p.Add((int)decrypted);
            }
            return p;
        }

        private string plaintextFilter(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                    result += char.ToUpper(c);
            }

            string normalForm = result.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalForm)
            {
                UnicodeCategory unicodeCat = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCat != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);

            }
            result = sb.ToString().ToUpper();
            result = result.Replace('Đ', 'D');

            return result;
        }
        
        private string ciphertextFilter(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == ' ')
                    result += c;
            }
            return result;
        }

        private void generateRSAkey()
        {
            p = int.Parse(textBox01.Text);
            q = int.Parse(textBox02.Text);
            E = int.Parse(textBox05.Text);

            n = p * q;
            phi = (p - 1) * (q - 1);
             
            while (GCD(E, phi) != 1)
                E += 2;
            d = modInverse(E, phi);
        }

        private void saveRSAkey(SaveFileDialog sfd, string nameKey, string content)
        {
            string directoryPath = Path.GetDirectoryName(sfd.FileName);
            string baseName = $"{nameKey}.txt";
            string outputPath = Path.Combine(directoryPath, baseName);
            int cnt = 1;

            while (File.Exists(outputPath))
            {
                string newName = $"{nameKey}({cnt}).txt";
                outputPath = Path.Combine(directoryPath, newName);
                cnt++;
            }
            File.WriteAllText(outputPath, content);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox05.Text = "65537";
        }
        
        private void button03_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox01.Text) || string.IsNullOrEmpty(textBox02.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!");
                return;
            }

            if (!isPrime(int.Parse(textBox01.Text)) || !isPrime(int.Parse(textBox02.Text)))
            {
                MessageBox.Show("Không phải là số nguyên tố!");
                return;
            }

            generateRSAkey();

            textBox03.Text = n.ToString();
            textBox04.Text = phi.ToString();
            textBox06.Text = d.ToString();

        }

        private void textBox02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                textBox07.Text = content;

                sr.Close();
                fs.Close();
            }
        }

        private void button06_Click(object sender, EventArgs e)
        {
            textBox01.Clear();
            textBox02.Clear();
            
            textBox03.Clear();
            textBox04.Clear();
            textBox05.Clear();
            textBox06.Clear();
            
            textBox07.Clear();
            textBox08.Clear();
            textBox09.Clear();

        }

        private void button07_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FileName = "Result.txt";
            sfd.Title = "Save Result File";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.Write(textBox09.Text);
                    }
                    
                    string publicKey = "key: " + textBox05.Text + "\n" + "n: " + textBox03.Text;
                    string privateKey = "key: " + textBox06.Text + "\n" + "n: " + textBox03.Text;
                    saveRSAkey(sfd, "public key", publicKey);
                    saveRSAkey(sfd, "private key", privateKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

        private void textBox03_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button02_Click(object sender, EventArgs e)
        {
            p = randomPrimeNumber(10);
            do
            {
                q = randomPrimeNumber(10);
            }
            while (p == q);

            textBox01.Text = p.ToString();
            textBox02.Text = q.ToString();

        }

        private void button04_Click(object sender, EventArgs e)
        {
            List<int> m = convertNum(plaintextFilter(textBox07.Text));
            string number = "";
            
            foreach (int x in m)
                number += x.ToString() + " ";
            textBox08.Text = number;

            List<int> c = encrypt(m);
            string cipherText = "";
            
            foreach (int x in c)
                cipherText += x.ToString() + " ";
            textBox09.Text = cipherText;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            List<int> c = new List<int>();
            string[] s = ciphertextFilter(textBox07.Text).Split(' ');
            
            foreach (string x in s)
            {
                if (int.TryParse(x, out int num))
                    c.Add(num);
            }

            List<int> m = decrypt(c);
            string number = "";
            string plainText = "";

            foreach (int x in m)           
                number += x.ToString() + " ";
            foreach (int x in m)
                plainText += (char)(x + 'A') + " ";

            textBox08.Text = number;
            textBox09.Text = plainText;

        }
    }
}
