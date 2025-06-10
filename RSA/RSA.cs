using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class RSA : Form
    {
        private int p, q;
        private int E, n, phi, d;
        
        private int from = (int)Math.Pow(2, 9);
        private int to = (int) Math.Pow(2, 10);
        
        public RSA()
        {
            InitializeComponent();
        }

        private bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
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

        private int randomPrimeNumber(int from, int to)
        {
            Random rand = new Random();
            int val;
            do
            {
                val = rand.Next(from, to + 1);
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
            p = int.Parse(tbP.Text);
            q = int.Parse(tbQ.Text);
            E = int.Parse(tbPublicKey.Text);

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

        private void RSA_Load(object sender, EventArgs e)
        {
            tbPublicKey.Text = "65537";
            tbFrom.Text = from.ToString();
            tbTo.Text = to.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFrom.Text) || string.IsNullOrEmpty(tbTo.Text))
            {
                tbFrom.Text = from.ToString();
                tbTo.Text = to.ToString();
            }
            else
            {
                if (!int.TryParse(tbFrom.Text, out from) || !int.TryParse(tbTo.Text, out to))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho khoảng!");
                    return;
                }

                if (from >= to || from < 2)
                {
                    MessageBox.Show("Khoảng không hợp lệ! 'From' phải lớn hơn 2 và nhỏ hơn 'To'.");
                    return;
                }
            }

            p = randomPrimeNumber(from, to);
            do
            {
                q = randomPrimeNumber(from, to);
            }
            while (p == q);

            tbP.Text = p.ToString();
            tbQ.Text = q.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbP.Text) || string.IsNullOrEmpty(tbQ.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!");
                return;
            }

            if (!isPrime(int.Parse(tbP.Text)) || !isPrime(int.Parse(tbQ.Text)))
            {
                MessageBox.Show("Không phải là số nguyên tố!");
                return;
            }

            generateRSAkey();

            tbN.Text = n.ToString();
            tbPhiN.Text = phi.ToString();
            tbPrivateKey.Text = d.ToString();
        }

        private void tbOpenFileText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                tbText.Text = content;

                sr.Close();
                fs.Close();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            List<int> m = convertNum(plaintextFilter(tbText.Text));
            string number = "";

            foreach (int x in m)
                number += x.ToString() + " ";
            tbNumber.Text = number;

            List<int> c = encrypt(m);
            string cipherText = "";

            foreach (int x in c)
                cipherText += x.ToString() + " ";
            tbResult.Text = cipherText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            List<int> c = new List<int>();
            string[] s = ciphertextFilter(tbText.Text).Split(' ');

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

            tbNumber.Text = number;
            tbResult.Text = plainText;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                        writer.Write(tbResult.Text);
                    }

                    string publicKey = "key: " + tbPublicKey.Text + "\n" + "n: " + tbN.Text;
                    string privateKey = "key: " + tbPrivateKey.Text + "\n" + "n: " + tbN.Text;
                    saveRSAkey(sfd, "public key", publicKey);
                    saveRSAkey(sfd, "private key", privateKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbP.Clear();
            tbQ.Clear();

            tbN.Clear();
            tbPhiN.Clear();
            tbPublicKey.Clear();
            tbPrivateKey.Clear();

            tbText.Clear();
            tbNumber.Clear();
            tbResult.Clear();
        }

        private void tbP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}