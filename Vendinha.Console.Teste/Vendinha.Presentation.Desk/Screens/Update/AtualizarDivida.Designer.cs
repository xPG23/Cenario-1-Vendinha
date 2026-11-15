namespace Vendinha.Presentation.Desk.Screens
{
    partial class AtualizarDivida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarDivida));
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            textValorAntigo = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            mdTextCPF = new MaskedTextBox();
            label5 = new Label();
            textNome = new TextBox();
            pictureBox1 = new PictureBox();
            textValorNovo = new TextBox();
            labelErros = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(200, 230, 180);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(230, 140);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 49;
            label2.Text = "Novo valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 230, 192);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(69, 16);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 48;
            label1.Text = "Atualizar Dívida";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(200, 230, 192);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // textValorAntigo
            // 
            textValorAntigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValorAntigo.Location = new Point(35, 163);
            textValorAntigo.Name = "textValorAntigo";
            textValorAntigo.ReadOnly = true;
            textValorAntigo.Size = new Size(140, 27);
            textValorAntigo.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(200, 230, 192);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(35, 140);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 52;
            label3.Text = "Valor antigo:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(126, 264);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 63;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(220, 240, 200);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(235, 76);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 67;
            label4.Text = "CPF:";
            // 
            // mdTextCPF
            // 
            mdTextCPF.Enabled = false;
            mdTextCPF.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mdTextCPF.Location = new Point(235, 99);
            mdTextCPF.Mask = "000,000,000-00";
            mdTextCPF.Name = "mdTextCPF";
            mdTextCPF.ReadOnly = true;
            mdTextCPF.Size = new Size(140, 25);
            mdTextCPF.TabIndex = 66;
            mdTextCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(200, 230, 192);
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(33, 75);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 65;
            label5.Text = "Cliente:";
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(33, 98);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(177, 27);
            textNome.TabIndex = 64;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // textValorNovo
            // 
            textValorNovo.Font = new Font("Segoe UI", 11F);
            textValorNovo.Location = new Point(235, 163);
            textValorNovo.Name = "textValorNovo";
            textValorNovo.Size = new Size(140, 27);
            textValorNovo.TabIndex = 69;
            textValorNovo.KeyPress += textValorNovo_KeyPress;
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.BackColor = Color.FromArgb(220, 240, 200);
            labelErros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelErros.ForeColor = Color.Red;
            labelErros.Location = new Point(33, 209);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(47, 21);
            labelErros.TabIndex = 70;
            labelErros.Text = "Erros";
            labelErros.Visible = false;
            // 
            // AtualizarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 317);
            Controls.Add(labelErros);
            Controls.Add(textValorNovo);
            Controls.Add(label4);
            Controls.Add(mdTextCPF);
            Controls.Add(label5);
            Controls.Add(textNome);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textValorAntigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "AtualizarDivida";
            Text = "AtualizarDivida";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private TextBox textValorAntigo;
        private Label label3;
        private Button button1;
        private Label label4;
        private MaskedTextBox mdTextCPF;
        private Label label5;
        private TextBox textNome;
        private PictureBox pictureBox1;
        private TextBox textValorNovo;
        private Label labelErros;
    }
}