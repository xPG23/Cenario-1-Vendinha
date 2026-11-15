namespace Vendinha.Presentation.Desk.Screens
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            labelTitulo = new Label();
            labelListaC = new Label();
            backgroundCirculo = new PictureBox();
            labelListaD = new Label();
            listaDevedoresBtn = new Button();
            backgroundBarraCima = new PictureBox();
            backgroundBarraBaixo = new PictureBox();
            labelCadastrarD = new Label();
            cadastrarDividaBtn = new Button();
            addClienteBtn = new Button();
            labelAcessoR = new Label();
            labelAddC = new Label();
            painelAcesso = new Panel();
            pictureBox4 = new PictureBox();
            listaClientBtn = new Button();
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroundCirculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundBarraCima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundBarraBaixo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(250, 216, 169);
            labelTitulo.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.MenuHighlight;
            labelTitulo.Location = new Point(153, 30);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(480, 68);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Vendinha Control";
            // 
            // labelListaC
            // 
            labelListaC.AutoSize = true;
            labelListaC.BackColor = Color.FromArgb(250, 226, 169);
            labelListaC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListaC.ForeColor = Color.LimeGreen;
            labelListaC.Location = new Point(305, 249);
            labelListaC.Name = "labelListaC";
            labelListaC.Size = new Size(68, 21);
            labelListaC.TabIndex = 2;
            labelListaC.Text = "Clientes";
            // 
            // backgroundCirculo
            // 
            backgroundCirculo.BackColor = Color.FromArgb(250, 216, 169);
            backgroundCirculo.Image = (Image)resources.GetObject("backgroundCirculo.Image");
            backgroundCirculo.Location = new Point(666, 267);
            backgroundCirculo.Name = "backgroundCirculo";
            backgroundCirculo.Size = new Size(170, 220);
            backgroundCirculo.TabIndex = 7;
            backgroundCirculo.TabStop = false;
            // 
            // labelListaD
            // 
            labelListaD.AutoSize = true;
            labelListaD.BackColor = Color.FromArgb(250, 218, 169);
            labelListaD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListaD.ForeColor = Color.Navy;
            labelListaD.Location = new Point(425, 249);
            labelListaD.Name = "labelListaD";
            labelListaD.Size = new Size(89, 21);
            labelListaD.TabIndex = 9;
            labelListaD.Text = "Devedores";
            // 
            // listaDevedoresBtn
            // 
            listaDevedoresBtn.BackColor = Color.Bisque;
            listaDevedoresBtn.FlatAppearance.BorderColor = Color.Black;
            listaDevedoresBtn.FlatStyle = FlatStyle.Popup;
            listaDevedoresBtn.Image = (Image)resources.GetObject("listaDevedoresBtn.Image");
            listaDevedoresBtn.Location = new Point(427, 153);
            listaDevedoresBtn.Name = "listaDevedoresBtn";
            listaDevedoresBtn.Size = new Size(85, 85);
            listaDevedoresBtn.TabIndex = 8;
            listaDevedoresBtn.UseVisualStyleBackColor = false;
            listaDevedoresBtn.Click += ListaDevedoresBtn_Click;
            // 
            // backgroundBarraCima
            // 
            backgroundBarraCima.Dock = DockStyle.Top;
            backgroundBarraCima.Image = (Image)resources.GetObject("backgroundBarraCima.Image");
            backgroundBarraCima.Location = new Point(0, 0);
            backgroundBarraCima.Name = "backgroundBarraCima";
            backgroundBarraCima.Size = new Size(800, 35);
            backgroundBarraCima.TabIndex = 10;
            backgroundBarraCima.TabStop = false;
            // 
            // backgroundBarraBaixo
            // 
            backgroundBarraBaixo.Dock = DockStyle.Bottom;
            backgroundBarraBaixo.Image = (Image)resources.GetObject("backgroundBarraBaixo.Image");
            backgroundBarraBaixo.Location = new Point(0, 374);
            backgroundBarraBaixo.Name = "backgroundBarraBaixo";
            backgroundBarraBaixo.Size = new Size(800, 35);
            backgroundBarraBaixo.TabIndex = 11;
            backgroundBarraBaixo.TabStop = false;
            // 
            // labelCadastrarD
            // 
            labelCadastrarD.AutoSize = true;
            labelCadastrarD.BackColor = Color.LightGray;
            labelCadastrarD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastrarD.ForeColor = Color.OrangeRed;
            labelCadastrarD.Location = new Point(99, 318);
            labelCadastrarD.Name = "labelCadastrarD";
            labelCadastrarD.Size = new Size(93, 15);
            labelCadastrarD.TabIndex = 13;
            labelCadastrarD.Text = "Cadastrar Dívida";
            // 
            // cadastrarDividaBtn
            // 
            cadastrarDividaBtn.BackColor = Color.Bisque;
            cadastrarDividaBtn.BackgroundImage = (Image)resources.GetObject("cadastrarDividaBtn.BackgroundImage");
            cadastrarDividaBtn.FlatAppearance.BorderColor = Color.Black;
            cadastrarDividaBtn.FlatStyle = FlatStyle.Popup;
            cadastrarDividaBtn.Location = new Point(18, 288);
            cadastrarDividaBtn.Name = "cadastrarDividaBtn";
            cadastrarDividaBtn.Size = new Size(75, 75);
            cadastrarDividaBtn.TabIndex = 12;
            cadastrarDividaBtn.UseVisualStyleBackColor = false;
            cadastrarDividaBtn.Click += cadastrarDividaBtn_Click;
            // 
            // addClienteBtn
            // 
            addClienteBtn.BackColor = Color.Bisque;
            addClienteBtn.BackgroundImage = (Image)resources.GetObject("addClienteBtn.BackgroundImage");
            addClienteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            addClienteBtn.FlatAppearance.BorderColor = Color.Black;
            addClienteBtn.FlatStyle = FlatStyle.Popup;
            addClienteBtn.Location = new Point(17, 203);
            addClienteBtn.Name = "addClienteBtn";
            addClienteBtn.Size = new Size(75, 75);
            addClienteBtn.TabIndex = 14;
            addClienteBtn.UseVisualStyleBackColor = false;
            addClienteBtn.Click += addClienteBtn_Click;
            // 
            // labelAcessoR
            // 
            labelAcessoR.AutoSize = true;
            labelAcessoR.BackColor = Color.LightGray;
            labelAcessoR.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcessoR.ForeColor = Color.SteelBlue;
            labelAcessoR.Location = new Point(43, 177);
            labelAcessoR.Name = "labelAcessoR";
            labelAcessoR.Size = new Size(114, 21);
            labelAcessoR.TabIndex = 15;
            labelAcessoR.Text = "Acesso rápido";
            // 
            // labelAddC
            // 
            labelAddC.AutoSize = true;
            labelAddC.BackColor = Color.LightGray;
            labelAddC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddC.ForeColor = Color.OrangeRed;
            labelAddC.Location = new Point(98, 233);
            labelAddC.Name = "labelAddC";
            labelAddC.Size = new Size(68, 15);
            labelAddC.TabIndex = 16;
            labelAddC.Text = "Add Cliente";
            // 
            // painelAcesso
            // 
            painelAcesso.BackColor = Color.LightGray;
            painelAcesso.BorderStyle = BorderStyle.FixedSingle;
            painelAcesso.Location = new Point(0, 169);
            painelAcesso.Name = "painelAcesso";
            painelAcesso.Size = new Size(200, 218);
            painelAcesso.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(800, 418);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // listaClientBtn
            // 
            listaClientBtn.BackColor = Color.Bisque;
            listaClientBtn.FlatAppearance.BorderColor = Color.Black;
            listaClientBtn.FlatStyle = FlatStyle.Popup;
            listaClientBtn.Image = (Image)resources.GetObject("listaClientBtn.Image");
            listaClientBtn.Location = new Point(297, 153);
            listaClientBtn.Name = "listaClientBtn";
            listaClientBtn.Size = new Size(85, 85);
            listaClientBtn.TabIndex = 19;
            listaClientBtn.UseVisualStyleBackColor = false;
            listaClientBtn.Click += ListaClientBtn_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImage = (Image)resources.GetObject("btnInfo.BackgroundImage");
            btnInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnInfo.Location = new Point(743, 41);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(45, 32);
            btnInfo.TabIndex = 20;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 409);
            Controls.Add(btnInfo);
            Controls.Add(listaClientBtn);
            Controls.Add(labelAddC);
            Controls.Add(labelAcessoR);
            Controls.Add(addClienteBtn);
            Controls.Add(labelCadastrarD);
            Controls.Add(cadastrarDividaBtn);
            Controls.Add(backgroundBarraBaixo);
            Controls.Add(backgroundBarraCima);
            Controls.Add(labelListaD);
            Controls.Add(listaDevedoresBtn);
            Controls.Add(labelListaC);
            Controls.Add(labelTitulo);
            Controls.Add(backgroundCirculo);
            Controls.Add(painelAcesso);
            Controls.Add(pictureBox4);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ((System.ComponentModel.ISupportInitialize)backgroundCirculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundBarraCima).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundBarraBaixo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitulo;
        private Label labelListaC;
        private PictureBox backgroundCirculo;
        private Label labelListaD;
        private Button listaDevedoresBtn;
        private PictureBox backgroundBarraCima;
        private PictureBox backgroundBarraBaixo;
        private Label labelCadastrarD;
        private Button cadastrarDividaBtn;
        private Button addClienteBtn;
        private Label labelAcessoR;
        private Label labelAddC;
        private Panel painelAcesso;
        private PictureBox pictureBox4;
        private Button listaClientBtn;
        private Button btnInfo;
    }
}