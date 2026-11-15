namespace Vendinha.Presentation.Desk.Screens
{
    partial class ListarDividas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarDividas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            labelTotalDividas = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button4 = new Button();
            label7 = new Label();
            ClienteDataGrid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            data_criacao = new DataGridViewTextBoxColumn();
            btn_VoltarPag = new Button();
            btn_AvancarPag = new Button();
            labelPagFinal = new Label();
            labelQtdPag = new Label();
            label8 = new Label();
            labelPagInicial = new Label();
            caixaBusca = new TextBox();
            qtdClientes = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(334, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 67);
            panel2.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(162, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 67);
            panel1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(419, 43);
            label3.Name = "label3";
            label3.Size = new Size(55, 40);
            label3.TabIndex = 33;
            label3.Text = "Excluir\r\nDívida";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(249, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 40);
            label2.TabIndex = 32;
            label2.Text = "Atualizar\r\nDívida";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(353, 30);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(183, 30);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 30;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(78, 43);
            label6.Name = "label6";
            label6.Size = new Size(75, 40);
            label6.TabIndex = 29;
            label6.Text = "Adicionar\r\nDívida\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalDividas
            // 
            labelTotalDividas.AutoSize = true;
            labelTotalDividas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            labelTotalDividas.ForeColor = Color.Red;
            labelTotalDividas.Location = new Point(-1, 6);
            labelTotalDividas.Name = "labelTotalDividas";
            labelTotalDividas.Size = new Size(160, 25);
            labelTotalDividas.TabIndex = 28;
            labelTotalDividas.Text = "Total em dividas : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 479);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 22);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(12, 30);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(713, 22);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(30, 210, 30);
            label4.Location = new Point(608, 48);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 38;
            label4.Text = "Pagar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.BottomCenter;
            button4.Location = new Point(544, 34);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 37;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(383, 117);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 41;
            label7.Text = "Busca por CPF:";
            // 
            // ClienteDataGrid
            // 
            ClienteDataGrid.AllowUserToAddRows = false;
            ClienteDataGrid.AllowUserToResizeColumns = false;
            ClienteDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ClienteDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ClienteDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClienteDataGrid.Columns.AddRange(new DataGridViewColumn[] { id, nome, cpf, valor, data_criacao });
            ClienteDataGrid.Location = new Point(12, 145);
            ClienteDataGrid.MultiSelect = false;
            ClienteDataGrid.Name = "ClienteDataGrid";
            ClienteDataGrid.RowHeadersVisible = false;
            ClienteDataGrid.ScrollBars = ScrollBars.None;
            ClienteDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClienteDataGrid.Size = new Size(691, 280);
            ClienteDataGrid.TabIndex = 43;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Resizable = DataGridViewTriState.False;
            nome.Width = 270;
            // 
            // cpf
            // 
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Resizable = DataGridViewTriState.False;
            cpf.Width = 160;
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 130;
            // 
            // data_criacao
            // 
            data_criacao.HeaderText = "Data_Criação";
            data_criacao.Name = "data_criacao";
            data_criacao.ReadOnly = true;
            data_criacao.Width = 130;
            // 
            // btn_VoltarPag
            // 
            btn_VoltarPag.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btn_VoltarPag.Location = new Point(140, 436);
            btn_VoltarPag.Name = "btn_VoltarPag";
            btn_VoltarPag.Size = new Size(22, 22);
            btn_VoltarPag.TabIndex = 49;
            btn_VoltarPag.Text = "<";
            btn_VoltarPag.TextAlign = ContentAlignment.TopCenter;
            btn_VoltarPag.UseVisualStyleBackColor = true;
            btn_VoltarPag.Click += btn_VoltarPag_Click;
            // 
            // btn_AvancarPag
            // 
            btn_AvancarPag.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AvancarPag.Location = new Point(167, 436);
            btn_AvancarPag.Name = "btn_AvancarPag";
            btn_AvancarPag.Size = new Size(22, 22);
            btn_AvancarPag.TabIndex = 48;
            btn_AvancarPag.Text = ">";
            btn_AvancarPag.TextAlign = ContentAlignment.MiddleLeft;
            btn_AvancarPag.UseVisualStyleBackColor = true;
            btn_AvancarPag.Click += btn_AvancarPag_Click;
            // 
            // labelPagFinal
            // 
            labelPagFinal.AutoSize = true;
            labelPagFinal.Font = new Font("Segoe UI", 12F);
            labelPagFinal.Location = new Point(113, 436);
            labelPagFinal.Name = "labelPagFinal";
            labelPagFinal.Size = new Size(19, 21);
            labelPagFinal.TabIndex = 47;
            labelPagFinal.Text = "0";
            labelPagFinal.Click += labelPagFinal_Click;
            labelPagFinal.MouseEnter += labelPagFinal_MouseEnter;
            labelPagFinal.MouseLeave += labelPagFinal_MouseLeave;
            // 
            // labelQtdPag
            // 
            labelQtdPag.AutoSize = true;
            labelQtdPag.Location = new Point(93, 442);
            labelQtdPag.Name = "labelQtdPag";
            labelQtdPag.Size = new Size(16, 15);
            labelQtdPag.TabIndex = 46;
            labelQtdPag.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 436);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 45;
            label8.Text = "Pagina:";
            // 
            // labelPagInicial
            // 
            labelPagInicial.AutoSize = true;
            labelPagInicial.Font = new Font("Segoe UI", 12F);
            labelPagInicial.Location = new Point(72, 436);
            labelPagInicial.Name = "labelPagInicial";
            labelPagInicial.Size = new Size(19, 21);
            labelPagInicial.TabIndex = 44;
            labelPagInicial.Text = "0";
            // 
            // caixaBusca
            // 
            caixaBusca.Location = new Point(504, 116);
            caixaBusca.Name = "caixaBusca";
            caixaBusca.Size = new Size(199, 23);
            caixaBusca.TabIndex = 50;
            caixaBusca.TextChanged += caixaBusca_TextChanged;
            // 
            // qtdClientes
            // 
            qtdClientes.AutoSize = true;
            qtdClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtdClientes.Location = new Point(11, 121);
            qtdClientes.Name = "qtdClientes";
            qtdClientes.Size = new Size(24, 21);
            qtdClientes.TabIndex = 51;
            qtdClientes.Text = "Cl";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(labelTotalDividas);
            panel3.Location = new Point(368, 431);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 42);
            panel3.TabIndex = 52;
            // 
            // ListarDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 501);
            Controls.Add(qtdClientes);
            Controls.Add(caixaBusca);
            Controls.Add(btn_VoltarPag);
            Controls.Add(btn_AvancarPag);
            Controls.Add(labelPagFinal);
            Controls.Add(labelQtdPag);
            Controls.Add(label8);
            Controls.Add(labelPagInicial);
            Controls.Add(ClienteDataGrid);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel3);
            Name = "ListarDividas";
            Text = "ListarDividas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Label label6;
        private Label labelTotalDividas;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button4;
        private Label label7;
        private DataGridView ClienteDataGrid;
        private Button btn_VoltarPag;
        private Button btn_AvancarPag;
        private Label labelPagFinal;
        private Label labelQtdPag;
        private Label label8;
        private Label labelPagInicial;
        private TextBox caixaBusca;
        private Label qtdClientes;
        private Panel panel3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn data_criacao;
    }
}