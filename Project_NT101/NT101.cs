using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using Org.BouncyCastle.Math;
using System.Text;
using System.Security.Cryptography;
//using System.Numerics;

namespace Project_NT101
{
    public partial class Project_NT101 : Form
    {
        public Project_NT101()
        {
            InitializeComponent();
            tab_infor.BackColor = Color.White;
        }


        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox_starting.Text = "";
            richTextBox_key.Text = "";
            richTextBox_result.Text = "";
            richTextBox_q.Text = "";
            richTextBox_p.Text = "";
            richTextBox_e.Text = "";
            richTextBox_inrsa.Text = "";
            richTextBox_outrsa.Text = "";
        }
        char[,] keyMatrix = new char[6, 6];
        char[] data5x5 = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] data6x6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();


        private void Project_NT101_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            CreateMatrix();
            UpdateMatrix();

        }

        private void CreateMatrix()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.BackColor = Color.White;

            int cellSize = flowLayoutPanel1.Width / 6; // 6 ô 1 hàng

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Label lbl = new Label
                    {
                        Width = cellSize - 4,
                        Height = cellSize - 4,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Segoe UI", 18, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White,
                        Name = $"lbl_{row}_{col}",
                        Tag = (row, col),
                        Text = "",
                        Margin = new Padding(2)
                    };

                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
        }



        private void UpdateMatrix()
        {
            bool is6x6 = radioButton2.Checked;
            string key = richTextBox_key.Text.Trim().ToUpper();

            char[] baseData = is6x6 ? data6x6 : data5x5;
            List<char> chars = new List<char>();

            if (string.IsNullOrEmpty(key))
            {
                chars.AddRange(baseData);
            }
            else
            {
                if (!is6x6)
                    key = key.Replace("J", "I");

                foreach (char c in key)
                {
                    if (baseData.Contains(c) && !chars.Contains(c))
                        chars.Add(c);
                }

                foreach (char c in baseData)
                {
                    if (!chars.Contains(c))
                        chars.Add(c);
                }
            }

            int index = 0;
            foreach (Label lbl in flowLayoutPanel1.Controls.OfType<Label>())
            {
                var (row, col) = ((int, int))lbl.Tag;

                if (!is6x6 && (row == 5 || col == 5))
                {
                    lbl.Text = " ";
                    keyMatrix[row, col] = lbl.Text[0];
                    lbl.BackColor = Color.LightGray; // tô xám ô ẩn
                }
                else if (index < chars.Count)
                {
                    lbl.Text = chars[index++].ToString();
                    keyMatrix[row, col] = lbl.Text[0];
                    lbl.BackColor = Color.White;
                }
                else
                {
                    lbl.Text = " ";
                    keyMatrix[row, col] = lbl.Text[0];
                    lbl.BackColor = Color.White;
                }
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMatrix();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox_key.Text = System.Text.RegularExpressions.Regex.Replace(richTextBox_key.Text, "[0-9]", "");
            UpdateMatrix();
        }

        private void richTextBox_key_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox_key.Text != string.Empty)
            {
                if (checklastchar())
                {
                    int lastIndex = richTextBox_key.Text.Length - 1;
                    char x = richTextBox_key.Text[lastIndex];
                    x = char.ToUpper(x);
                    richTextBox_key.Text = richTextBox_key.Text.Substring(0, lastIndex) + x;


                    richTextBox_key.SelectionStart = richTextBox_key.Text.Length;

                }
                else
                {
                    MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox_key.Text = richTextBox_key.Text.Substring(0, richTextBox_key.Text.Length - 1);
                    richTextBox_key.SelectionStart = richTextBox_key.Text.Length;
                }

            }
            UpdateMatrix();

        }
        private bool checklastchar()
        {
            char c = richTextBox_key.Text[richTextBox_key.Text.Length - 1];
            if (radioButton1.Checked)
            {
                if (c < 'A' || (c > 'Z' && c < 'a') || c > 'z')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (c < '0' || (c > '9' && c < 'A') || (c > 'Z' && c < 'a') || c > 'z')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private Tuple<int, int> findPosition(char c)
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    if (keyMatrix[i, j] == c)
                        return Tuple.Create(i, j);
            return Tuple.Create(-1, -1);
        }
        private string FillterInput()
        {
            string s = richTextBox_starting.Text;
            string re = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (radioButton1.Checked)
                {
                    if (s[i] < 'A' || (s[i] > 'Z' && s[i] < 'a') || s[i] > 'z')
                    {
                        //continue;
                    }
                    else
                    {
                        re += s[i];
                    }
                }
                else
                {
                    if (s[i] < '0' || (s[i] > '9' && s[i] < 'A') || (s[i] > 'Z' && s[i] < 'a') || s[i] > 'z')
                    {

                    }
                    else
                    {
                        re += s[i];

                    }
                }
            }
            return re.ToUpper();
        }
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (richTextBox_starting.Text != string.Empty)
            {
                string s = FillterInput();
                if (s.Length % 2 != 0) s += 'X';
                int size = radioButton1.Checked ? 5 : 6;
                string result = "";

                for (int i = 0; i < s.Length; i += 2)
                {
                    char a = s[i];
                    char b = s[i + 1];

                    var (row1, col1) = findPosition(a); // Lấy tọa độ của a
                    var (row2, col2) = findPosition(b); // Lấy tọa độ của b

                    if (row1 == row2) // Cùng hàng
                    {
                        if (radioButton1.Checked)
                        {
                            if (++col1 == 5)
                            {
                                col1 = 0;
                            }

                            if (++col2 == 5)
                            {
                                col2 = 0;
                            }
                        }
                        else
                        {
                            col1 = (col1 + 1) % size;
                            col2 = (col2 + 1) % size;
                        }
                    }
                    else if (col1 == col2) // Cùng cột
                    {
                        if (radioButton1.Checked)
                        {
                            if (++row1 == 5)
                            {
                                row1 = 0;
                            }

                            if (++row2 == 5)
                            {
                                row2 = 0;
                            }
                        }
                        else
                        {
                            row1 = (row1 + 1) % size;
                            row2 = (row2 + 1) % size;
                        }
                    }
                    else // Khác hàng, khác cột
                    {
                        //Hoán đổi col1 và col2
                        int temp = col1;
                        col1 = col2;
                        col2 = temp;
                    }

                    result += keyMatrix[row1, col1];
                    result += keyMatrix[row2, col2];
                    result += " ";
                }

                richTextBox_result.Text = result;
            }

        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            if (richTextBox_starting.Text != string.Empty)
            {
                string s = FillterInput();
                // Không cần thêm 'X' vì decrypt nhận chuỗi đã mã hóa (độ dài chẵn)

                int size = radioButton1.Checked ? 5 : 6;
                string result = "";

                for (int i = 0; i < s.Length; i += 2)
                {
                    char a = s[i];
                    char b = s[i + 1];

                    var (row1, col1) = findPosition(a); // Lấy tọa độ của a
                    var (row2, col2) = findPosition(b); // Lấy tọa độ của b

                    if (row1 == row2) // Cùng hàng - DI CHUYỂN TRÁI (decrypt)
                    {
                        if (radioButton1.Checked)
                        {
                            if (--col1 < 0)  // Giảm cột, nếu < 0 thì quay về 4
                            {
                                col1 = 4;
                            }

                            if (--col2 < 0)
                            {
                                col2 = 4;
                            }
                        }
                        else
                        {
                            col1 = (col1 - 1 + size) % size;
                            col2 = (col2 - 1 + size) % size;
                        }
                    }
                    else if (col1 == col2) // Cùng cột - DI CHUYỂN LÊN (decrypt)
                    {
                        if (radioButton1.Checked)
                        {
                            if (--row1 < 0)  // Giảm hàng, nếu < 0 thì quay về 4
                            {
                                row1 = 4;
                            }

                            if (--row2 < 0)
                            {
                                row2 = 4;
                            }
                        }
                        else
                        {
                            row1 = (row1 - 1 + size) % size; // (row1 - 1) modulo size
                            row2 = (row2 - 1 + size) % size;
                        }
                    }
                    else // Khác hàng, khác cột - VẪN HOÁN ĐỔI CỘT
                    {
                        int temp = col1;
                        col1 = col2;
                        col2 = temp;
                    }

                    result += keyMatrix[row1, col1];
                    result += keyMatrix[row2, col2];
                    // Không thêm khoảng trắng khi decrypt
                }

                richTextBox_result.Text = result;
            }
        }





        // RSA part

        bool state_q = false;
        bool state_p = false;
        bool state_e = false;
        private BigInteger genPrime(int bitLength)
        {
            if (bitLength < 8) bitLength = 8;

            int byteLength = (bitLength + 7) / 8;
            byte[] bytes = new byte[byteLength];

            while (true)
            {
                // DÙNG RandomNumberGenerator THAY CHO RNGCryptoServiceProvider
                RandomNumberGenerator.Fill(bytes);

                // Đặt bit cao nhất = 1 để đảm bảo đúng độ dài bit
                bytes[byteLength - 1] |= 0x80;

                // Đặt bit thấp nhất = 1 để số lẻ (tăng xác suất là prime)
                bytes[0] |= 0x01;

                // Quan trọng: Dùng +1 để BigInteger BouncyCastle luôn dương
                BigInteger candidate = new BigInteger(+1, bytes);

                // Kiểm tra độ dài bit chính xác (tránh trường hợp hiếm bit cao bị 0)
                if (candidate.BitLength != bitLength)
                    continue;

                // BouncyCastle có sẵn IsProbablePrime
                if (candidate.IsProbablePrime(30))  // 30 là đủ an toàn cho demo
                    return candidate;
            }
        }
        private void button_enter_Click(object sender, EventArgs e)
        {
            richTextBox_p.Clear();
            state_p = false;
            richTextBox_q.Clear();
            state_q = false;
            richTextBox_e.Clear();
            state_q = false;
            update_lbl();

            richTextBox_inrsa.Text = "";
            richTextBox_outrsa.Text = "";
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            BigInteger q_val = genPrime(32);
            BigInteger p_val = genPrime(32);
            richTextBox_q.Text = q_val.ToString();
            richTextBox_p.Text = p_val.ToString();

        }

        private void button_random_e_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox_p.Text) || string.IsNullOrWhiteSpace(richTextBox_q.Text))
            {
                MessageBox.Show("Enter p and q first!");
                return;
            }

            BigInteger p_val = new BigInteger(richTextBox_p.Text);
            BigInteger q_val = new BigInteger(richTextBox_q.Text);
            BigInteger phi = (p_val.Subtract(BigInteger.One)).Multiply(q_val.Subtract(BigInteger.One));
            BigInteger e_preferred = BigInteger.ValueOf(65537);

            if (e_preferred.CompareTo(phi) < 0 && e_preferred.Gcd(phi).Equals(BigInteger.One))
            {
                richTextBox_e.Text = "65537";
            }
            else
            {
                // Chỉ fallback khi 65537 không dùng được (rất hiếm)
                BigInteger e_random;
                do
                {
                    e_random = genPrime(16); // e nhỏ là đủ
                } while (e_random.CompareTo(phi) >= 0 || !e_random.Gcd(phi).Equals(BigInteger.One));

                richTextBox_e.Text = e_random.ToString();
            }
        }


        private void button_enrsa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox_inrsa.Text))
            {
                MessageBox.Show("Please enter Input!");
                return;
            }
            if (!state_p || !state_q || !state_e)
            {
                MessageBox.Show("Invalid key! Please check again p, q, e.");
                return;
            }

            try
            {
                BigInteger p_val = new BigInteger(richTextBox_p.Text);
                BigInteger q_val = new BigInteger(richTextBox_q.Text);
                BigInteger n_val = p_val.Multiply(q_val);
                BigInteger e_val = new BigInteger(richTextBox_e.Text);

                byte[] plainBytes = Encoding.UTF8.GetBytes(richTextBox_inrsa.Text);
                int blockSize = (n_val.BitLength - 1) / 8; // Số byte tối đa mỗi block (để m < n)
                List<string> cipherBlocks = new List<string>();

                for (int i = 0; i < plainBytes.Length; i += blockSize)
                {
                    int currentBlockSize = Math.Min(blockSize, plainBytes.Length - i);
                    byte[] block = new byte[currentBlockSize];
                    Array.Copy(plainBytes, i, block, 0, currentBlockSize);
                    BigInteger m = new BigInteger(+1, block);
                    BigInteger c = m.ModPow(e_val, n_val);

                    cipherBlocks.Add(c.ToString(10)); // Chuyển sang base 10 (số thập phân)
                }
                string separator = " # "; // Giống ảnh bạn gửi
                richTextBox_outrsa.Text = string.Join(separator, cipherBlocks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encrypt: " + ex.Message);
            }
        }

        private void button_dersa_Click(object sender, EventArgs e)
        {
            string cipherInput = richTextBox_outrsa.Text.Trim();
            if (string.IsNullOrWhiteSpace(cipherInput) && !string.IsNullOrWhiteSpace(richTextBox_inrsa.Text))
                cipherInput = richTextBox_inrsa.Text.Trim();

            if (string.IsNullOrWhiteSpace(cipherInput))
            {
                MessageBox.Show("Please enter Input!");
                return;
            }
            if (!state_p || !state_q || !state_e)
            {
                MessageBox.Show("Invalid key! Please check again p, q, e.");
                return;
            }

            try
            {
                BigInteger p_val = new BigInteger(richTextBox_p.Text);
                BigInteger q_val = new BigInteger(richTextBox_q.Text);
                BigInteger n_val = p_val.Multiply(q_val);
                BigInteger phi_val = p_val.Subtract(BigInteger.One).Multiply(q_val.Subtract(BigInteger.One));
                BigInteger e_val = new BigInteger(richTextBox_e.Text);
                BigInteger d_val = e_val.ModInverse(phi_val);

                string[] separators = { " # ", " ", "#" };
                string[] cipherBlocks = cipherInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<byte> plainBytesList = new List<byte>();

                foreach (string blockStr in cipherBlocks)
                {
                    BigInteger c = new BigInteger(blockStr); // Tự động nhận base 10
                    BigInteger m = c.ModPow(d_val, n_val);

                    byte[] blockBytes = m.ToByteArray();
                    // Bỏ byte 0 thừa ở đầu (nếu có)
                    if (blockBytes.Length > 1 && blockBytes[0] == 0)
                    {
                        byte[] temp = new byte[blockBytes.Length - 1];
                        Array.Copy(blockBytes, 1, temp, 0, temp.Length);
                        blockBytes = temp;
                    }

                    plainBytesList.AddRange(blockBytes);
                }

                string plainText = Encoding.UTF8.GetString(plainBytesList.ToArray());
                richTextBox_outrsa.Text = plainText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                                  $"Decryption error:\n{ex.Message}\n\n" +
                                  $"Please check:\n- Is the ciphertext in correct decimal format?\n- Are the blocks separated by spaces or #?",
                                 "Error"
                                 );

            }
        }
        private void richTextBox_p_TextChanged(object sender, EventArgs e)
        {
            label_p.ForeColor = Color.White;
            label_p.Text = "";

            string s = richTextBox_p.Text;
            string qText = richTextBox_q.Text;

            if (!string.IsNullOrWhiteSpace(s))
            {
                try
                {
                    BigInteger pVal = new BigInteger(s);

                    if (!string.IsNullOrWhiteSpace(qText))
                    {
                        BigInteger qVal = new BigInteger(qText);
                        if (pVal.Equals(qVal))
                        {
                            label_p.ForeColor = Color.Red;
                            label_p.Text = "p and q cannot be the same";
                            state_p = false;
                            return;
                        }
                    }

                    if (!pVal.IsProbablePrime(100))
                    {
                        label_p.ForeColor = Color.Red;
                        label_p.Text = "p is not a prime number";
                        state_p = false;
                    }
                    else
                    {
                        label_p.ForeColor = Color.LightGreen;
                        label_p.Text = "p is a prime number";
                        state_p = true;
                    }
                }
                catch
                {
                    label_p.ForeColor = Color.Red;
                    label_p.Text = "Invalid input (not a number)";
                    state_p = false;
                }
            }
            else state_p = false;

            update_lbl();
        }

        private void richTextBox_q_TextChanged(object sender, EventArgs e)
        {
            label_q.ForeColor = Color.White;
            label_q.Text = "";

            string s = richTextBox_q.Text;
            string pText = richTextBox_p.Text;

            if (!string.IsNullOrWhiteSpace(s))
            {
                try
                {
                    BigInteger qVal = new BigInteger(s);

                    if (!string.IsNullOrWhiteSpace(pText))
                    {
                        BigInteger pVal = new BigInteger(pText);
                        if (qVal.Equals(pVal))
                        {
                            label_q.ForeColor = Color.Red;
                            label_q.Text = "q and p cannot be the same";
                            state_q = false;
                            return;
                        }
                    }

                    if (!qVal.IsProbablePrime(100))
                    {
                        label_q.ForeColor = Color.Red;
                        label_q.Text = "q is not a prime number";
                        state_q = false;
                    }
                    else
                    {
                        label_q.ForeColor = Color.LightGreen;
                        label_q.Text = "q is a prime number";
                        state_q = true;
                    }
                }
                catch
                {
                    label_q.ForeColor = Color.Red;
                    label_q.Text = "Invalid input (not a number)";
                    state_q = false;
                }
            }
            else state_q = false;

            update_lbl();
        }

        private void richTextBox_e_TextChanged(object sender, EventArgs e)
        {
            label_e.ForeColor = Color.White;
            label_e.Text = "";

            string s = richTextBox_e.Text;

            if (!string.IsNullOrWhiteSpace(s))
            {
                try
                {
                    BigInteger eVal = new BigInteger(s);
                    if (string.IsNullOrWhiteSpace(richTextBox_p.Text) || string.IsNullOrWhiteSpace(richTextBox_q.Text))
                    {
                        label_e.ForeColor = Color.Red;
                        label_e.Text = "Enter p and q first";
                        return;
                    }

                    BigInteger pVal = new BigInteger(richTextBox_p.Text);
                    BigInteger qVal = new BigInteger(richTextBox_q.Text);

                    BigInteger phi_n = (pVal.Subtract(BigInteger.One)).Multiply(qVal.Subtract(BigInteger.One));

                    if (eVal.CompareTo(BigInteger.One) <= 0 || eVal.CompareTo(phi_n) >= 0)
                    {
                        label_e.ForeColor = Color.Red;
                        label_e.Text = "e must satisfy 1 < e < φ(n)";
                        state_e = false;
                        return;
                    }

                    if (!eVal.Gcd(phi_n).Equals(BigInteger.One))
                    {
                        label_e.ForeColor = Color.Red;
                        label_e.Text = "gcd(e, φ(n)) ≠ 1 (not coprime)";
                        state_e = false;

                        return;
                    }

                    if (!eVal.IsProbablePrime(100))
                    {
                        label_e.ForeColor = Color.Red;
                        label_e.Text = "Valid e but not prime";
                        state_e = false;
                    }
                    else
                    {
                        label_e.ForeColor = Color.LightGreen;
                        label_e.Text = "e is valid and prime";
                        state_e = true;
                    }
                }
                catch
                {
                    label_e.ForeColor = Color.Red;
                    label_e.Text = "Ivalid input (not a number)";
                    state_e = false;
                }
            }
            else state_e = false;
            update_lbl();
        }
        private void update_lbl()
        {
            if (state_q && state_p)
            {
                BigInteger q_val = new BigInteger(richTextBox_q.Text);
                BigInteger p_val = new BigInteger(richTextBox_p.Text);
                BigInteger n_val = (q_val).Multiply(p_val);
                BigInteger phi_n_val = (q_val.Subtract(BigInteger.One)).Multiply(p_val.Subtract(BigInteger.One));

                label_n_phin.Text = $"n = {n_val}, φ(n) = {phi_n_val} ";
                if (state_e)
                {
                    BigInteger e_val = new BigInteger(richTextBox_e.Text);
                    BigInteger d_val = e_val.ModInverse(phi_n_val);

                    label_publickey.Text = $"Public key (e, n): ({e_val}, {n_val})";
                    label_privatekey.Text = $"Private key (d, n): ({d_val}, {n_val})";
                }
            }
            else
            {
                label_n_phin.Text = $"n = , φ(n) =  ";
                label_publickey.Text = $"Public key (e, n):  ";
                label_privatekey.Text = $"Private key (d, n):  ";
            }

        }

        private void tab_infor_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_pf_Click(object sender, EventArgs e)
        {
            richTextBox_starting.Text = "";
            richTextBox_key.Text = "";
            richTextBox_result.Text = "";   
        }
    }
}
