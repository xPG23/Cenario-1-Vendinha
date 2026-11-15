namespace Vendinha.Presentation.Desk.Screens
{
    partial class AtualizarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarCliente));
            button1 = new Button();
            textEmail = new TextBox();
            textSobrenome = new TextBox();
            label4 = new Label();
            pickerDataNascimento = new DateTimePicker();
            label3 = new Label();
            mdTextCPF = new MaskedTextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            textNome = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            labelErros = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(496, 377);
            button1.Name = "button1";
            button1.Size = new Size(181, 53);
            button1.TabIndex = 62;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(23, 346);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(228, 27);
            textEmail.TabIndex = 61;
            // 
            // textSobrenome
            // 
            textSobrenome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSobrenome.Location = new Point(258, 146);
            textSobrenome.Name = "textSobrenome";
            textSobrenome.Size = new Size(228, 27);
            textSobrenome.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(99, 203, 250);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(250, 90, 1);
            label4.Location = new Point(23, 255);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 59;
            label4.Text = "Data de Nascimento";
            // 
            // pickerDataNascimento
            // 
            pickerDataNascimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pickerDataNascimento.Format = DateTimePickerFormat.Short;
            pickerDataNascimento.Location = new Point(23, 277);
            pickerDataNascimento.Margin = new Padding(3, 2, 3, 2);
            pickerDataNascimento.Name = "pickerDataNascimento";
            pickerDataNascimento.Size = new Size(219, 27);
            pickerDataNascimento.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(100, 209, 250);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(250, 90, 1);
            label3.Location = new Point(23, 188);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 57;
            label3.Text = "CPF:";
            // 
            // mdTextCPF
            // 
            mdTextCPF.Enabled = false;
            mdTextCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mdTextCPF.Location = new Point(23, 211);
            mdTextCPF.Mask = "000,000,000-00";
            mdTextCPF.Name = "mdTextCPF";
            mdTextCPF.ReadOnly = true;
            mdTextCPF.Size = new Size(149, 29);
            mdTextCPF.TabIndex = 56;
            mdTextCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(100, 210, 250);
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(250, 90, 1);
            label5.Location = new Point(258, 125);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 55;
            label5.Text = "Sobrenome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(100, 219, 250);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(250, 90, 1);
            label2.Location = new Point(23, 125);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 54;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(108, 219, 246);
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(250, 140, 1);
            label1.Location = new Point(98, 45);
            label1.Name = "label1";
            label1.Size = new Size(290, 47);
            label1.TabIndex = 53;
            label1.Text = "Atualizar Usuário";
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(23, 146);
            textNome.Name = "textNome";
            textNome.Size = new Size(228, 27);
            textNome.TabIndex = 52;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 436);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(689, 15);
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(689, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(110, 221, 250);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 63;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(86, 196, 238);
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(250, 90, 1);
            label6.Location = new Point(29, 323);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 64;
            label6.Text = "Email (Opcional):";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 15);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.BackColor = Color.FromArgb(100, 209, 250);
            labelErros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelErros.ForeColor = Color.Red;
            labelErros.Location = new Point(297, 188);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(47, 21);
            labelErros.TabIndex = 66;
            labelErros.Text = "Erros";
            labelErros.Visible = false;
            // 
            // AtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 451);
            Controls.Add(labelErros);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(textEmail);
            Controls.Add(textSobrenome);
            Controls.Add(label4);
            Controls.Add(pickerDataNascimento);
            Controls.Add(label3);
            Controls.Add(mdTextCPF);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNome);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "AtualizarCliente";
            Text = "AtualizarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textEmail;
        private TextBox textSobrenome;
        private Label label4;
        private DateTimePicker pickerDataNascimento;
        private Label label3;
        private MaskedTextBox mdTextCPF;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox textNome;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label6;
        private PictureBox pictureBox1;
        private Label labelErros;
    }
}