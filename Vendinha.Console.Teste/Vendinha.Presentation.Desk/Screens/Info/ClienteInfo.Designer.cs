namespace Vendinha.Presentation.Desk.Screens
{
    partial class ClienteInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInfo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            label6 = new Label();
            textEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            mdTextCPF = new MaskedTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textNome = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            textIdade = new TextBox();
            textStatus = new TextBox();
            label7 = new Label();
            label9 = new Label();
            mdTextDataNasc = new MaskedTextBox();
            mdDataCadastro = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            textTempoCliente = new TextBox();
            ClienteDataGrid = new DataGridView();
            valor = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            data_criacao = new DataGridViewTextBoxColumn();
            data_pagamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(610, 389);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 63;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(230, 231, 230);
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(366, 83);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 62;
            label6.Text = "Email:";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(366, 105);
            textEmail.Name = "textEmail";
            textEmail.ReadOnly = true;
            textEmail.Size = new Size(231, 27);
            textEmail.TabIndex = 61;
            textEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(230, 231, 230);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(195, 157);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 59;
            label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 231, 230);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 57;
            label3.Text = "CPF:";
            // 
            // mdTextCPF
            // 
            mdTextCPF.Font = new Font("Segoe UI", 11F);
            mdTextCPF.Location = new Point(12, 179);
            mdTextCPF.Mask = "000,000,000-00";
            mdTextCPF.Name = "mdTextCPF";
            mdTextCPF.ReadOnly = true;
            mdTextCPF.Size = new Size(149, 27);
            mdTextCPF.TabIndex = 56;
            mdTextCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 231, 230);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 54;
            label2.Text = "Nome completo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(749, 15);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(12, 105);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(317, 27);
            textNome.TabIndex = 53;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(749, 15);
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(753, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(245, 246, 240);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 65;
            label1.Text = "Informações do cliente";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(250, 225, 195);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(230, 231, 230);
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(632, 83);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 69;
            label8.Text = "Idade";
            // 
            // textIdade
            // 
            textIdade.Enabled = false;
            textIdade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textIdade.Location = new Point(630, 105);
            textIdade.Name = "textIdade";
            textIdade.ReadOnly = true;
            textIdade.Size = new Size(61, 27);
            textIdade.TabIndex = 68;
            textIdade.TextAlign = HorizontalAlignment.Center;
            // 
            // textStatus
            // 
            textStatus.Enabled = false;
            textStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStatus.Location = new Point(632, 179);
            textStatus.Name = "textStatus";
            textStatus.ReadOnly = true;
            textStatus.Size = new Size(93, 27);
            textStatus.TabIndex = 71;
            textStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(230, 231, 230);
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(632, 157);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 72;
            label7.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(240, 241, 240);
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 214);
            label9.Name = "label9";
            label9.Size = new Size(155, 21);
            label9.TabIndex = 73;
            label9.Text = "Historico de dívidas";
            // 
            // mdTextDataNasc
            // 
            mdTextDataNasc.Font = new Font("Segoe UI", 11F);
            mdTextDataNasc.Location = new Point(200, 179);
            mdTextDataNasc.Mask = "00/00/0000";
            mdTextDataNasc.Name = "mdTextDataNasc";
            mdTextDataNasc.ReadOnly = true;
            mdTextDataNasc.Size = new Size(129, 27);
            mdTextDataNasc.TabIndex = 74;
            mdTextDataNasc.TextAlign = HorizontalAlignment.Center;
            mdTextDataNasc.ValidatingType = typeof(DateTime);
            // 
            // mdDataCadastro
            // 
            mdDataCadastro.Font = new Font("Segoe UI", 11F);
            mdDataCadastro.Location = new Point(366, 179);
            mdDataCadastro.Mask = "00/00/0000";
            mdDataCadastro.Name = "mdDataCadastro";
            mdDataCadastro.ReadOnly = true;
            mdDataCadastro.Size = new Size(129, 27);
            mdDataCadastro.TabIndex = 76;
            mdDataCadastro.TextAlign = HorizontalAlignment.Center;
            mdDataCadastro.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(230, 231, 230);
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(366, 157);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 75;
            label10.Text = "Data do Cadastro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(230, 231, 230);
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.ImageAlign = ContentAlignment.BottomCenter;
            label11.Location = new Point(523, 137);
            label11.Name = "label11";
            label11.Size = new Size(74, 40);
            label11.TabIndex = 78;
            label11.Text = "Tempo \r\nde cliente";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textTempoCliente
            // 
            textTempoCliente.Enabled = false;
            textTempoCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTempoCliente.Location = new Point(523, 179);
            textTempoCliente.Name = "textTempoCliente";
            textTempoCliente.ReadOnly = true;
            textTempoCliente.Size = new Size(74, 27);
            textTempoCliente.TabIndex = 77;
            textTempoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // ClienteDataGrid
            // 
            ClienteDataGrid.AllowUserToAddRows = false;
            ClienteDataGrid.AllowUserToResizeColumns = false;
            ClienteDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ClienteDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ClienteDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClienteDataGrid.Columns.AddRange(new DataGridViewColumn[] { valor, status, data_criacao, data_pagamento });
            ClienteDataGrid.Location = new Point(32, 238);
            ClienteDataGrid.MultiSelect = false;
            ClienteDataGrid.Name = "ClienteDataGrid";
            ClienteDataGrid.RowHeadersVisible = false;
            ClienteDataGrid.ScrollBars = ScrollBars.Vertical;
            ClienteDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClienteDataGrid.Size = new Size(553, 202);
            ClienteDataGrid.TabIndex = 79;
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Resizable = DataGridViewTriState.False;
            valor.Width = 180;
            // 
            // status
            // 
            status.HeaderText = "Situação";
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.False;
            status.Width = 110;
            // 
            // data_criacao
            // 
            data_criacao.HeaderText = "Data_Criação";
            data_criacao.Name = "data_criacao";
            data_criacao.ReadOnly = true;
            data_criacao.Resizable = DataGridViewTriState.False;
            data_criacao.Width = 130;
            // 
            // data_pagamento
            // 
            data_pagamento.HeaderText = "Data_Pagamento";
            data_pagamento.Name = "data_pagamento";
            data_pagamento.ReadOnly = true;
            data_pagamento.Width = 130;
            // 
            // ClienteInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 461);
            Controls.Add(ClienteDataGrid);
            Controls.Add(label11);
            Controls.Add(textTempoCliente);
            Controls.Add(mdDataCadastro);
            Controls.Add(label10);
            Controls.Add(mdTextDataNasc);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textStatus);
            Controls.Add(label8);
            Controls.Add(textIdade);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mdTextCPF);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textNome);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "ClienteInfo";
            Text = "ClienteInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private TextBox textEmail;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private MaskedTextBox mdTextCPF;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textNome;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label8;
        private TextBox textIdade;
        private TextBox textStatus;
        private Label label7;
        private Label label9;
        private MaskedTextBox mdTextDataNasc;
        private MaskedTextBox mdDataCadastro;
        private Label label10;
        private Label label11;
        private TextBox textTempoCliente;
        private DataGridView ClienteDataGrid;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn data_criacao;
        private DataGridViewTextBoxColumn data_pagamento;
    }
}