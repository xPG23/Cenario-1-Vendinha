namespace Vendinha.Presentation.Desk.Screens
{
    partial class ListaClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            ClienteDataGrid = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            idade = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            caixaBusca = new TextBox();
            label4 = new Label();
            qtdClientes = new Label();
            label5 = new Label();
            button4 = new Button();
            panel3 = new Panel();
            labelPagInicial = new Label();
            label8 = new Label();
            labelQtdPag = new Label();
            labelPagFinal = new Label();
            btn_AvancarPag = new Button();
            btn_VoltarPag = new Button();
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            ClienteDataGrid.Columns.AddRange(new DataGridViewColumn[] { nome, idade, cpf, status });
            ClienteDataGrid.Location = new Point(18, 161);
            ClienteDataGrid.MultiSelect = false;
            ClienteDataGrid.Name = "ClienteDataGrid";
            ClienteDataGrid.RowHeadersVisible = false;
            ClienteDataGrid.ScrollBars = ScrollBars.None;
            ClienteDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClienteDataGrid.Size = new Size(650, 280);
            ClienteDataGrid.TabIndex = 0;
            ClienteDataGrid.CellDoubleClick += ClienteDataGrid_CellDoubleClick;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Resizable = DataGridViewTriState.False;
            nome.Width = 320;
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
            cpf.Width = 160;
            // 
            // status
            // 
            status.HeaderText = "Situação";
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.False;
            status.Width = 110;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 39);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(684, 22);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 479);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 22);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(78, 52);
            label6.Name = "label6";
            label6.Size = new Size(75, 40);
            label6.TabIndex = 17;
            label6.Text = "Adicionar\nCliente";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(183, 39);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(353, 39);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(249, 52);
            label2.Name = "label2";
            label2.Size = new Size(70, 40);
            label2.TabIndex = 21;
            label2.Text = "Atualizar\r\nCliente\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(419, 52);
            label3.Name = "label3";
            label3.Size = new Size(56, 40);
            label3.TabIndex = 22;
            label3.Text = "Excluir\r\nCliente";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(162, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 67);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(334, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 67);
            panel2.TabIndex = 24;
            // 
            // caixaBusca
            // 
            caixaBusca.Location = new Point(469, 131);
            caixaBusca.Name = "caixaBusca";
            caixaBusca.Size = new Size(199, 23);
            caixaBusca.TabIndex = 25;
            caixaBusca.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 132);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 26;
            label4.Text = "Busca por Nome/CPF:";
            // 
            // qtdClientes
            // 
            qtdClientes.AutoSize = true;
            qtdClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtdClientes.Location = new Point(18, 137);
            qtdClientes.Name = "qtdClientes";
            qtdClientes.Size = new Size(24, 21);
            qtdClientes.TabIndex = 27;
            qtdClientes.Text = "Cl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(576, 52);
            label5.Name = "label5";
            label5.Size = new Size(62, 40);
            label5.TabIndex = 29;
            label5.Text = "Info. do\r\nCliente";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(510, 39);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 28;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(489, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 67);
            panel3.TabIndex = 25;
            // 
            // labelPagInicial
            // 
            labelPagInicial.AutoSize = true;
            labelPagInicial.Font = new Font("Segoe UI", 12F);
            labelPagInicial.Location = new Point(73, 450);
            labelPagInicial.Name = "labelPagInicial";
            labelPagInicial.Size = new Size(19, 21);
            labelPagInicial.TabIndex = 30;
            labelPagInicial.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 450);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 31;
            label8.Text = "Pagina:";
            // 
            // labelQtdPag
            // 
            labelQtdPag.AutoSize = true;
            labelQtdPag.Location = new Point(94, 456);
            labelQtdPag.Name = "labelQtdPag";
            labelQtdPag.Size = new Size(16, 15);
            labelQtdPag.TabIndex = 32;
            labelQtdPag.Text = "...";
            // 
            // labelPagFinal
            // 
            labelPagFinal.AutoSize = true;
            labelPagFinal.Font = new Font("Segoe UI", 12F);
            labelPagFinal.Location = new Point(114, 450);
            labelPagFinal.Name = "labelPagFinal";
            labelPagFinal.Size = new Size(19, 21);
            labelPagFinal.TabIndex = 33;
            labelPagFinal.Text = "0";
            labelPagFinal.Click += labelPagFinal_Click;
            labelPagFinal.MouseEnter += labelPagFinal_MouseEnter;
            labelPagFinal.MouseLeave += labelPagFinal_MouseLeave;
            // 
            // btn_AvancarPag
            // 
            btn_AvancarPag.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AvancarPag.Location = new Point(168, 450);
            btn_AvancarPag.Name = "btn_AvancarPag";
            btn_AvancarPag.Size = new Size(22, 22);
            btn_AvancarPag.TabIndex = 34;
            btn_AvancarPag.Text = ">";
            btn_AvancarPag.TextAlign = ContentAlignment.MiddleLeft;
            btn_AvancarPag.UseVisualStyleBackColor = true;
            btn_AvancarPag.Click += btn_AvancarPag_Click;
            // 
            // btn_VoltarPag
            // 
            btn_VoltarPag.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btn_VoltarPag.Location = new Point(141, 450);
            btn_VoltarPag.Name = "btn_VoltarPag";
            btn_VoltarPag.Size = new Size(22, 22);
            btn_VoltarPag.TabIndex = 35;
            btn_VoltarPag.Text = "<";
            btn_VoltarPag.TextAlign = ContentAlignment.TopCenter;
            btn_VoltarPag.UseVisualStyleBackColor = true;
            btn_VoltarPag.Click += btn_VoltarPag_Click;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 501);
            Controls.Add(btn_VoltarPag);
            Controls.Add(btn_AvancarPag);
            Controls.Add(labelPagFinal);
            Controls.Add(labelQtdPag);
            Controls.Add(label8);
            Controls.Add(labelPagInicial);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(qtdClientes);
            Controls.Add(label4);
            Controls.Add(caixaBusca);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(ClienteDataGrid);
            Name = "ListaClientes";
            Text = "ListaClientes";
            ((System.ComponentModel.ISupportInitialize)ClienteDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ClienteDataGrid;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private TextBox caixaBusca;
        private Label label4;
        private Label qtdClientes;
        private Label label5;
        private Button button4;
        private Panel panel3;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn idade;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn status;
        private Label labelPagInicial;
        private Label label8;
        private Label labelQtdPag;
        private Label labelPagFinal;
        private Button btn_AvancarPag;
        private Button btn_VoltarPag;
    }
}