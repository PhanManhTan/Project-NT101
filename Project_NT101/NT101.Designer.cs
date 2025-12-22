namespace Project_NT101
{
    partial class Project_NT101
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project_NT101));
            tabcontrol = new TabControl();
            tab_infor = new TabPage();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tab_playfair = new TabPage();
            button_clear_pf = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            richTextBox_result = new RichTextBox();
            richTextBox_key = new RichTextBox();
            button_decrypt = new Button();
            button_encrypt = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label_q_pf = new Label();
            richTextBox_starting = new RichTextBox();
            tab_rsa = new TabPage();
            label_e = new Label();
            label_q = new Label();
            label_p = new Label();
            label10 = new Label();
            label9 = new Label();
            label_publickey = new Label();
            label_privatekey = new Label();
            label_n_phin = new Label();
            button_dersa = new Button();
            button_enrsa = new Button();
            richTextBox_outrsa = new RichTextBox();
            richTextBox_inrsa = new RichTextBox();
            label_q_rsa = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button_random_e = new Button();
            button_random = new Button();
            button_enter = new Button();
            richTextBox_e = new RichTextBox();
            richTextBox_q = new RichTextBox();
            richTextBox_p = new RichTextBox();
            tabcontrol.SuspendLayout();
            tab_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tab_playfair.SuspendLayout();
            tab_rsa.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tab_infor);
            tabcontrol.Controls.Add(tab_playfair);
            tabcontrol.Controls.Add(tab_rsa);
            tabcontrol.Dock = DockStyle.Fill;
            tabcontrol.Location = new Point(0, 0);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(896, 805);
            tabcontrol.TabIndex = 0;
            tabcontrol.SelectedIndexChanged += tabcontrol_SelectedIndexChanged;
            // 
            // tab_infor
            // 
            tab_infor.Controls.Add(pictureBox1);
            tab_infor.Controls.Add(label16);
            tab_infor.Controls.Add(label15);
            tab_infor.Controls.Add(label14);
            tab_infor.Controls.Add(label13);
            tab_infor.Controls.Add(label12);
            tab_infor.Controls.Add(label11);
            tab_infor.Location = new Point(4, 29);
            tab_infor.Name = "tab_infor";
            tab_infor.Size = new Size(888, 772);
            tab_infor.TabIndex = 2;
            tab_infor.Text = "Infor Group";
            tab_infor.UseVisualStyleBackColor = true;
            tab_infor.Click += tab_infor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(305, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F);
            label16.Location = new Point(245, 380);
            label16.Name = "label16";
            label16.Size = new Size(369, 46);
            label16.TabIndex = 5;
            label16.Text = "NHÓM 11 - NT101.Q11";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20F);
            label15.Location = new Point(189, 659);
            label15.Name = "label15";
            label15.Size = new Size(481, 46);
            label15.TabIndex = 4;
            label15.Text = "NGUYỄN VĂN SƠN - 23521357";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F);
            label14.Location = new Point(199, 597);
            label14.Name = "label14";
            label14.Size = new Size(469, 46);
            label14.TabIndex = 3;
            label14.Text = "PHAN MẠNH TÂN - 23521404";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.Location = new Point(227, 522);
            label13.Name = "label13";
            label13.Size = new Size(417, 46);
            label13.TabIndex = 2;
            label13.Text = "DANH SÁCH THÀNH VIÊN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(133, 295);
            label12.Name = "label12";
            label12.Size = new Size(606, 60);
            label12.TabIndex = 1;
            label12.Text = "AN TOÀN MẠNG MÁY TÍNH";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25F);
            label11.Location = new Point(245, 222);
            label11.Name = "label11";
            label11.Size = new Size(369, 57);
            label11.TabIndex = 0;
            label11.Text = "ĐỒ ÁN MÔN HỌC";
            // 
            // tab_playfair
            // 
            tab_playfair.Controls.Add(button_clear_pf);
            tab_playfair.Controls.Add(flowLayoutPanel1);
            tab_playfair.Controls.Add(label4);
            tab_playfair.Controls.Add(label3);
            tab_playfair.Controls.Add(richTextBox_result);
            tab_playfair.Controls.Add(richTextBox_key);
            tab_playfair.Controls.Add(button_decrypt);
            tab_playfair.Controls.Add(button_encrypt);
            tab_playfair.Controls.Add(radioButton2);
            tab_playfair.Controls.Add(radioButton1);
            tab_playfair.Controls.Add(label2);
            tab_playfair.Controls.Add(label_q_pf);
            tab_playfair.Controls.Add(richTextBox_starting);
            tab_playfair.Font = new Font("Segoe UI", 12F);
            tab_playfair.Location = new Point(4, 29);
            tab_playfair.Name = "tab_playfair";
            tab_playfair.Padding = new Padding(3);
            tab_playfair.Size = new Size(888, 772);
            tab_playfair.TabIndex = 0;
            tab_playfair.Text = "Play fair";
            tab_playfair.UseVisualStyleBackColor = true;
            // 
            // button_clear_pf
            // 
            button_clear_pf.Font = new Font("Segoe UI", 12F);
            button_clear_pf.Location = new Point(576, 494);
            button_clear_pf.Name = "button_clear_pf";
            button_clear_pf.Size = new Size(180, 79);
            button_clear_pf.TabIndex = 13;
            button_clear_pf.Text = "Clear";
            button_clear_pf.UseVisualStyleBackColor = true;
            button_clear_pf.Click += button_clear_pf_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(9, 266);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(320, 320);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(8, 587);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 11;
            label4.Text = "Result text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 175);
            label3.Name = "label3";
            label3.Size = new Size(44, 28);
            label3.TabIndex = 10;
            label3.Text = "Key";
            // 
            // richTextBox_result
            // 
            richTextBox_result.Font = new Font("Segoe UI", 12F);
            richTextBox_result.Location = new Point(6, 621);
            richTextBox_result.Name = "richTextBox_result";
            richTextBox_result.ReadOnly = true;
            richTextBox_result.Size = new Size(872, 144);
            richTextBox_result.TabIndex = 9;
            richTextBox_result.Text = "";
            // 
            // richTextBox_key
            // 
            richTextBox_key.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_key.Location = new Point(5, 206);
            richTextBox_key.Name = "richTextBox_key";
            richTextBox_key.Size = new Size(873, 50);
            richTextBox_key.TabIndex = 8;
            richTextBox_key.Text = "";
            richTextBox_key.TextChanged += richTextBox_key_TextChanged;
            // 
            // button_decrypt
            // 
            button_decrypt.Font = new Font("Segoe UI", 12F);
            button_decrypt.Location = new Point(576, 390);
            button_decrypt.Name = "button_decrypt";
            button_decrypt.Size = new Size(180, 79);
            button_decrypt.TabIndex = 7;
            button_decrypt.Text = "Decrypt";
            button_decrypt.UseVisualStyleBackColor = true;
            button_decrypt.Click += button_decrypt_Click;
            // 
            // button_encrypt
            // 
            button_encrypt.Font = new Font("Segoe UI", 12F);
            button_encrypt.Location = new Point(576, 294);
            button_encrypt.Name = "button_encrypt";
            button_encrypt.Size = new Size(180, 79);
            button_encrypt.TabIndex = 6;
            button_encrypt.Text = "Encrypt";
            button_encrypt.UseVisualStyleBackColor = true;
            button_encrypt.Click += button_encrypt_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14F);
            radioButton2.Location = new Point(395, 433);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 36);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "6x6";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 14F);
            radioButton1.Location = new Point(395, 366);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 36);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "5x5";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 2;
            label2.Text = "Starting text";
            // 
            // label_q_pf
            // 
            label_q_pf.AutoSize = true;
            label_q_pf.BackColor = Color.DarkGray;
            label_q_pf.Font = new Font("Segoe UI", 12F);
            label_q_pf.Location = new Point(863, 3);
            label_q_pf.Name = "label_q_pf";
            label_q_pf.Size = new Size(21, 28);
            label_q_pf.TabIndex = 1;
            label_q_pf.Text = "?";
            label_q_pf.Click += label1_Click;
            // 
            // richTextBox_starting
            // 
            richTextBox_starting.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_starting.Font = new Font("Segoe UI", 12F);
            richTextBox_starting.Location = new Point(5, 34);
            richTextBox_starting.Name = "richTextBox_starting";
            richTextBox_starting.Size = new Size(873, 144);
            richTextBox_starting.TabIndex = 0;
            richTextBox_starting.Text = "";
            richTextBox_starting.TextChanged += richTextBox_starting_TextChanged;
            // 
            // tab_rsa
            // 
            tab_rsa.Controls.Add(label_e);
            tab_rsa.Controls.Add(label_q);
            tab_rsa.Controls.Add(label_p);
            tab_rsa.Controls.Add(label10);
            tab_rsa.Controls.Add(label9);
            tab_rsa.Controls.Add(label_publickey);
            tab_rsa.Controls.Add(label_privatekey);
            tab_rsa.Controls.Add(label_n_phin);
            tab_rsa.Controls.Add(button_dersa);
            tab_rsa.Controls.Add(button_enrsa);
            tab_rsa.Controls.Add(richTextBox_outrsa);
            tab_rsa.Controls.Add(richTextBox_inrsa);
            tab_rsa.Controls.Add(label_q_rsa);
            tab_rsa.Controls.Add(label7);
            tab_rsa.Controls.Add(label6);
            tab_rsa.Controls.Add(label5);
            tab_rsa.Controls.Add(button_random_e);
            tab_rsa.Controls.Add(button_random);
            tab_rsa.Controls.Add(button_enter);
            tab_rsa.Controls.Add(richTextBox_e);
            tab_rsa.Controls.Add(richTextBox_q);
            tab_rsa.Controls.Add(richTextBox_p);
            tab_rsa.Font = new Font("Segoe UI", 12F);
            tab_rsa.Location = new Point(4, 29);
            tab_rsa.Name = "tab_rsa";
            tab_rsa.Padding = new Padding(3);
            tab_rsa.Size = new Size(888, 772);
            tab_rsa.TabIndex = 1;
            tab_rsa.Text = "RSA";
            tab_rsa.UseVisualStyleBackColor = true;
            // 
            // label_e
            // 
            label_e.AutoSize = true;
            label_e.Font = new Font("Segoe UI", 12F);
            label_e.Location = new Point(18, 276);
            label_e.Name = "label_e";
            label_e.Size = new Size(0, 28);
            label_e.TabIndex = 21;
            // 
            // label_q
            // 
            label_q.AutoSize = true;
            label_q.Font = new Font("Segoe UI", 12F);
            label_q.Location = new Point(18, 176);
            label_q.Name = "label_q";
            label_q.Size = new Size(0, 28);
            label_q.TabIndex = 20;
            // 
            // label_p
            // 
            label_p.AutoSize = true;
            label_p.Font = new Font("Segoe UI", 12F);
            label_p.Location = new Point(17, 76);
            label_p.Name = "label_p";
            label_p.Size = new Size(0, 28);
            label_p.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 599);
            label10.Name = "label10";
            label10.Size = new Size(102, 28);
            label10.TabIndex = 18;
            label10.Text = "Result text";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 434);
            label9.Name = "label9";
            label9.Size = new Size(119, 28);
            label9.TabIndex = 17;
            label9.Text = "Starting text";
            // 
            // label_publickey
            // 
            label_publickey.AutoSize = true;
            label_publickey.Location = new Point(14, 399);
            label_publickey.Name = "label_publickey";
            label_publickey.Size = new Size(106, 28);
            label_publickey.TabIndex = 16;
            label_publickey.Text = "Public Key:";
            // 
            // label_privatekey
            // 
            label_privatekey.AutoSize = true;
            label_privatekey.Location = new Point(14, 349);
            label_privatekey.Name = "label_privatekey";
            label_privatekey.Size = new Size(118, 28);
            label_privatekey.TabIndex = 15;
            label_privatekey.Text = "Private Key: ";
            // 
            // label_n_phin
            // 
            label_n_phin.AutoSize = true;
            label_n_phin.Location = new Point(14, 304);
            label_n_phin.Name = "label_n_phin";
            label_n_phin.Size = new Size(157, 28);
            label_n_phin.TabIndex = 14;
            label_n_phin.Text = "n =       , φ(n) =   ";
            // 
            // button_dersa
            // 
            button_dersa.Font = new Font("Segoe UI", 12F);
            button_dersa.Location = new Point(639, 385);
            button_dersa.Name = "button_dersa";
            button_dersa.Size = new Size(214, 57);
            button_dersa.TabIndex = 13;
            button_dersa.Text = "Decrypt";
            button_dersa.UseVisualStyleBackColor = true;
            button_dersa.Click += button_dersa_Click;
            // 
            // button_enrsa
            // 
            button_enrsa.Font = new Font("Segoe UI", 12F);
            button_enrsa.Location = new Point(639, 294);
            button_enrsa.Name = "button_enrsa";
            button_enrsa.Size = new Size(214, 57);
            button_enrsa.TabIndex = 12;
            button_enrsa.Text = "Encrypt";
            button_enrsa.UseVisualStyleBackColor = true;
            button_enrsa.Click += button_enrsa_Click;
            // 
            // richTextBox_outrsa
            // 
            richTextBox_outrsa.Font = new Font("Segoe UI", 12F);
            richTextBox_outrsa.Location = new Point(10, 627);
            richTextBox_outrsa.Name = "richTextBox_outrsa";
            richTextBox_outrsa.ReadOnly = true;
            richTextBox_outrsa.Size = new Size(872, 135);
            richTextBox_outrsa.TabIndex = 11;
            richTextBox_outrsa.Text = "";
            // 
            // richTextBox_inrsa
            // 
            richTextBox_inrsa.Font = new Font("Segoe UI", 12F);
            richTextBox_inrsa.Location = new Point(10, 463);
            richTextBox_inrsa.Name = "richTextBox_inrsa";
            richTextBox_inrsa.Size = new Size(872, 135);
            richTextBox_inrsa.TabIndex = 10;
            richTextBox_inrsa.Text = "";
            // 
            // label_q_rsa
            // 
            label_q_rsa.AutoSize = true;
            label_q_rsa.BackColor = Color.DarkGray;
            label_q_rsa.Font = new Font("Segoe UI", 12F);
            label_q_rsa.Location = new Point(863, 3);
            label_q_rsa.Name = "label_q_rsa";
            label_q_rsa.Size = new Size(21, 28);
            label_q_rsa.TabIndex = 9;
            label_q_rsa.Text = "?";
            label_q_rsa.Click += label_q_rsa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(17, 201);
            label7.Name = "label7";
            label7.Size = new Size(22, 28);
            label7.TabIndex = 8;
            label7.Text = "e";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 104);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 7;
            label6.Text = "q";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(17, 4);
            label5.Name = "label5";
            label5.Size = new Size(24, 28);
            label5.TabIndex = 6;
            label5.Text = "p";
            // 
            // button_random_e
            // 
            button_random_e.Font = new Font("Segoe UI", 13.8F);
            button_random_e.Location = new Point(614, 232);
            button_random_e.Name = "button_random_e";
            button_random_e.Size = new Size(245, 41);
            button_random_e.TabIndex = 5;
            button_random_e.Text = "Generate e";
            button_random_e.UseVisualStyleBackColor = true;
            button_random_e.Click += button_random_e_Click;
            // 
            // button_random
            // 
            button_random.Font = new Font("Segoe UI", 12F);
            button_random.Location = new Point(613, 135);
            button_random.Name = "button_random";
            button_random.Size = new Size(245, 41);
            button_random.TabIndex = 4;
            button_random.Text = "Generate p, q ";
            button_random.UseVisualStyleBackColor = true;
            button_random.Click += button_random_Click;
            // 
            // button_enter
            // 
            button_enter.Font = new Font("Segoe UI", 12F);
            button_enter.Location = new Point(614, 35);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(245, 41);
            button_enter.TabIndex = 3;
            button_enter.Text = "Clear";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // richTextBox_e
            // 
            richTextBox_e.Font = new Font("Segoe UI", 13.8F);
            richTextBox_e.Location = new Point(14, 231);
            richTextBox_e.Name = "richTextBox_e";
            richTextBox_e.Size = new Size(577, 44);
            richTextBox_e.TabIndex = 2;
            richTextBox_e.Text = "";
            richTextBox_e.TextChanged += richTextBox_e_TextChanged;
            // 
            // richTextBox_q
            // 
            richTextBox_q.Font = new Font("Segoe UI", 13.8F);
            richTextBox_q.Location = new Point(14, 134);
            richTextBox_q.Name = "richTextBox_q";
            richTextBox_q.Size = new Size(577, 44);
            richTextBox_q.TabIndex = 1;
            richTextBox_q.Text = "";
            richTextBox_q.TextChanged += richTextBox_q_TextChanged;
            // 
            // richTextBox_p
            // 
            richTextBox_p.Font = new Font("Segoe UI", 13.8F);
            richTextBox_p.Location = new Point(14, 34);
            richTextBox_p.Name = "richTextBox_p";
            richTextBox_p.Size = new Size(577, 44);
            richTextBox_p.TabIndex = 0;
            richTextBox_p.Text = "";
            richTextBox_p.TextChanged += richTextBox_p_TextChanged;
            // 
            // Project_NT101
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 805);
            Controls.Add(tabcontrol);
            MaximizeBox = false;
            Name = "Project_NT101";
            Text = "Project NT101";
            Load += Project_NT101_Load;
            tabcontrol.ResumeLayout(false);
            tab_infor.ResumeLayout(false);
            tab_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tab_playfair.ResumeLayout(false);
            tab_playfair.PerformLayout();
            tab_rsa.ResumeLayout(false);
            tab_rsa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tab_playfair;
        private TabPage tab_rsa;
        private Label label2;
        private Label label_q_pf;
        private RichTextBox richTextBox_starting;
        private RichTextBox richTextBox_key;
        private Button button_decrypt;
        private Button button_encrypt;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private RichTextBox richTextBox_result;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_q_rsa;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button_random_e;
        private Button button_random;
        private RichTextBox richTextBox_e;
        private RichTextBox richTextBox_q;
        private RichTextBox richTextBox_p;
        private RichTextBox richTextBox_outrsa;
        private RichTextBox richTextBox_inrsa;
        private Button button_dersa;
        private Button button_enrsa;
        private Button button_enter;
        private Label label_publickey;
        private Label label_privatekey;
        private Label label_n_phin;
        private Label label10;
        private Label label9;
        private Label label_e;
        private Label label_q;
        private Label label_p;
        private TabPage tab_infor;
        private Label label12;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox1;
        private Button button_clear_pf;
    }
}
