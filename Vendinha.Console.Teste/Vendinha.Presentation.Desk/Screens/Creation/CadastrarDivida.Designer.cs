namespace Vendinha.Presentation.Desk.Screens
{
    partial class CadastrarDivida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarDivida));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            mdTextCPF = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ClienteDataGrid = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            idade = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            labelErros = new Label();
            textValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(200, 230, 192);
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(25, 199);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 39;
            label3.Text = "CPF do Cliente:";
            // 
            // mdTextCPF
            // 
            mdTextCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mdTextCPF.Location = new Point(31, 222);
            mdTextCPF.Mask = "000,000,000-00";
            mdTextCPF.Name = "mdTextCPF";
            mdTextCPF.Size = new Size(149, 29);
            mdTextCPF.TabIndex = 38;
            mdTextCPF.TextAlign = HorizontalAlignment.Center;
            mdTextCPF.TextChanged += mdTextCPF_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(200, 230, 192);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(24, 136);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 36;
            label2.Text = "Valor (R$):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(200, 230, 192);
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(5, 76, 209);
            label1.Location = new Point(106, 44);
            label1.Name = "label1";
            label1.Size = new Size(281, 47);
            label1.TabIndex = 35;
            label1.Text = "Cadastrar Dívida";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(200, 230, 192);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(482, 295);
            button1.Name = "button1";
            button1.Size = new Size(153, 53);
            button1.TabIndex = 48;
            button1.Text = "Cadastar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(213, 237, 198);
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(222, 113);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 49;
            label5.Text = "Cliente:";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(643, 15);
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 354);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(643, 15);
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
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
            ClienteDataGrid.Columns.AddRange(new DataGridViewColumn[] { nome, idade, cpf, status });
            ClienteDataGrid.Location = new Point(222, 136);
            ClienteDataGrid.MultiSelect = false;
            ClienteDataGrid.Name = "ClienteDataGrid";
            ClienteDataGrid.RowHeadersVisible = false;
            ClienteDataGrid.ScrollBars = ScrollBars.None;
            ClienteDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClienteDataGrid.Size = new Size(413, 52);
            ClienteDataGrid.TabIndex = 68;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Resizable = DataGridViewTriState.False;
            nome.Width = 150;
            // 
            // idade
            // 
            idade.HeaderText = "Idade";
            idade.Name = "idade";
            idade.ReadOnly = true;
            idade.Resizable = DataGridViewTriState.False;
            idade.Width = 60;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Resizable = DataGridViewTriState.False;
            cpf.Width = 130;
            // 
            // status
            // 
            status.HeaderText = "Situação";
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.False;
            status.Width = 70;
            // 
            // labelErros
            // 
            labelErros.AutoSize = true;
            labelErros.BackColor = Color.FromArgb(200, 230, 192);
            labelErros.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErros.ForeColor = Color.Red;
            labelErros.Location = new Point(203, 209);
            labelErros.Name = "labelErros";
            labelErros.Size = new Size(44, 20);
            labelErros.TabIndex = 69;
            labelErros.Text = "Erros";
            labelErros.Visible = false;
            // 
            // textValor
            // 
            textValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValor.Location = new Point(31, 159);
            textValor.Name = "textValor";
            textValor.Size = new Size(149, 27);
            textValor.TabIndex = 70;
            textValor.TextAlign = HorizontalAlignment.Center;
            textValor.KeyPress += textBox1_KeyPress;
            // 
            // CadastrarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 369);
            Controls.Add(textValor);
            Controls.Add(labelErros);
            Controls.Add(ClienteDataGrid);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(mdTextCPF);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "CadastrarDivida";
            Text = "CadastrarDivida";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private MaskedTextBox mdTextCPF;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridView ClienteDataGrid;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn idade;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn status;
        private Label labelErros;
        private TextBox textValor;
    }
}