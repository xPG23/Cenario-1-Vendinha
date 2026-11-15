namespace Vendinha.Presentation.Desk.Screens
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textNome = new TextBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            labelNome = new Label();
            labelSobrenome = new Label();
            mdTextCpf = new MaskedTextBox();
            labelCPF = new Label();
            pickerData = new DateTimePicker();
            labelData = new Label();
            textSobrenome = new TextBox();
            textEmail = new TextBox();
            labelEmail = new Label();
            button1 = new Button();
            labelErros = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 436);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(689, 15);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(691, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 15);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(23, 146);
            textNome.Name = "textNome";
            textNome.Size = new Size(228, 27);
            textNome.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(255, 197, 19);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 197, 19);
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(98, 45);
            label1.Name = "label1";
            label1.Size = new Size(342, 47);
            label1.TabIndex = 18;
            label1.Text = "Cadastro de Usuário";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.FromArgb(249, 193, 18);
            labelNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.ForeColor = Color.MidnightBlue;
            labelNome.Location = new Point(23, 125);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 20);
            labelNome.TabIndex = 19;
            labelNome.Text = "Nome:";
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.BackColor = Color.FromArgb(251, 203, 19);
            labelSobrenome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSobrenome.ForeColor = Color.MidnightBlue;
            labelSobrenome.Location = new Point(258, 125);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(89, 20);
            labelSobrenome.TabIndex = 25;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // mdTextCpf
            // 
            mdTextCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mdTextCpf.Location = new Point(23, 211);
            mdTextCpf.Mask = "000,000,000-00";
            mdTextCpf.Name = "mdTextCpf";
            mdTextCpf.Size = new Size(149, 29);
            mdTextCpf.TabIndex = 26;
            mdTextCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.FromArgb(248, 190, 17);
            labelCPF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCPF.ForeColor = Color.MidnightBlue;
            labelCPF.Location = new Point(23, 188);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(36, 20);
            labelCPF.TabIndex = 27;
            labelCPF.Text = "CPF:";
            // 
            // pickerData
            // 
            pickerData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(23, 277);
            pickerData.Margin = new Padding(3, 2, 3, 2);
            pickerData.Name = "pickerData";
            pickerData.Size = new Size(219, 27);
            pickerData.TabIndex = 28;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = Color.FromArgb(248, 190, 17);
            labelData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelData.ForeColor = Color.MidnightBlue;
            labelData.Location = new Point(23, 255);
            labelData.Name = "labelData";
            labelData.Size = new Size(145, 20);
            labelData.TabIndex = 29;
            labelData.Text = "Data de Nascimento";
            // 
            // textSobrenome
            // 
            textSobrenome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSobrenome.Location = new Point(258, 146);
            textSobrenome.Name = "textSobrenome";
            textSobrenome.Size = new Size(228, 27);
            textSobrenome.TabIndex = 30;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(23, 346);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(228, 27);
            textEmail.TabIndex = 31;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.FromArgb(243, 183, 17);
            labelEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.MidnightBlue;
            labelEmail.Location = new Point(23, 323);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(123, 20);
            labelEmail.TabIndex = 32;
            labelEmail.Text = "Email (Opcional):";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(501, 376);
            button1.Name = "button1";
            button1.Size = new Size(181, 53);
            button1.TabIndex = 49;
            button1.Text = "Cadastar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.BackColor = Color.FromArgb(248, 190, 17);
            labelErros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelErros.ForeColor = Color.Red;
            labelErros.Location = new Point(282, 211);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(47, 21);
            labelErros.TabIndex = 50;
            labelErros.Text = "Erros";
            labelErros.Visible = false;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 451);
            Controls.Add(labelErros);
            Controls.Add(button1);
            Controls.Add(labelEmail);
            Controls.Add(textEmail);
            Controls.Add(textSobrenome);
            Controls.Add(labelData);
            Controls.Add(pickerData);
            Controls.Add(labelCPF);
            Controls.Add(mdTextCpf);
            Controls.Add(labelSobrenome);
            Controls.Add(labelNome);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(textNome);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textNome;
        private PictureBox pictureBox4;
        private Label label1;
        private Label labelNome;
        private Label labelSobrenome;
        private MaskedTextBox mdTextCpf;
        private Label labelCPF;
        private DateTimePicker pickerData;
        private Label labelData;
        private TextBox textSobrenome;
        private TextBox textEmail;
        private Label labelEmail;
        private Button button1;
        private Label labelErros;
    }
}