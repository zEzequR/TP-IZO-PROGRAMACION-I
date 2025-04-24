namespace UI.Escritorio.Sections.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            contStatusStrip = new Panel();
            contWinBar = new Panel();
            tableContWinBar = new TableLayoutPanel();
            logoWinBar = new PictureBox();
            winBarTxt = new Label();
            winBarClseBtn = new PictureBox();
            winStatusBtn = new PictureBox();
            winBarMinBtn = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            contPasswrdInp = new TableLayoutPanel();
            passwrdInp = new TextBox();
            passwrdTxt = new Label();
            wlcTxt = new Label();
            inpTxt = new Label();
            sumbitBtn = new Button();
            userImg = new PictureBox();
            passwrdImg = new PictureBox();
            contUserInp = new TableLayoutPanel();
            userTxt = new Label();
            userInp = new TextBox();
            contWinBar.SuspendLayout();
            tableContWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            contPasswrdInp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).BeginInit();
            contUserInp.SuspendLayout();
            SuspendLayout();
            // 
            // contStatusStrip
            // 
            contStatusStrip.BorderStyle = BorderStyle.FixedSingle;
            contStatusStrip.Dock = DockStyle.Bottom;
            contStatusStrip.Location = new Point(0, 388);
            contStatusStrip.Name = "contStatusStrip";
            contStatusStrip.Size = new Size(800, 62);
            contStatusStrip.TabIndex = 2;
            // 
            // contWinBar
            // 
            contWinBar.BorderStyle = BorderStyle.FixedSingle;
            contWinBar.Controls.Add(tableContWinBar);
            contWinBar.Dock = DockStyle.Top;
            contWinBar.Location = new Point(0, 0);
            contWinBar.Name = "contWinBar";
            contWinBar.Size = new Size(800, 62);
            contWinBar.TabIndex = 3;
            // 
            // tableContWinBar
            // 
            tableContWinBar.AutoSize = true;
            tableContWinBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableContWinBar.ColumnCount = 6;
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.91913652F));
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8965683F));
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.8365059F));
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableContWinBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableContWinBar.Controls.Add(logoWinBar, 0, 0);
            tableContWinBar.Controls.Add(winBarTxt, 1, 0);
            tableContWinBar.Controls.Add(winBarClseBtn, 5, 0);
            tableContWinBar.Controls.Add(winStatusBtn, 4, 0);
            tableContWinBar.Controls.Add(winBarMinBtn, 3, 0);
            tableContWinBar.Dock = DockStyle.Fill;
            tableContWinBar.Location = new Point(0, 0);
            tableContWinBar.Name = "tableContWinBar";
            tableContWinBar.RowCount = 1;
            tableContWinBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableContWinBar.Size = new Size(798, 60);
            tableContWinBar.TabIndex = 1;
            tableContWinBar.MouseDown += tableContWinBar_MouseDown;
            // 
            // logoWinBar
            // 
            logoWinBar.Anchor = AnchorStyles.None;
            logoWinBar.Image = (Image)resources.GetObject("logoWinBar.Image");
            logoWinBar.Location = new Point(11, 5);
            logoWinBar.Name = "logoWinBar";
            logoWinBar.Size = new Size(40, 49);
            logoWinBar.SizeMode = PictureBoxSizeMode.StretchImage;
            logoWinBar.TabIndex = 0;
            logoWinBar.TabStop = false;
            // 
            // winBarTxt
            // 
            winBarTxt.AutoSize = true;
            winBarTxt.Dock = DockStyle.Fill;
            winBarTxt.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winBarTxt.Location = new Point(66, 0);
            winBarTxt.Name = "winBarTxt";
            winBarTxt.Size = new Size(136, 60);
            winBarTxt.TabIndex = 1;
            winBarTxt.Text = "Sistema IZO";
            winBarTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winBarClseBtn
            // 
            winBarClseBtn.Anchor = AnchorStyles.None;
            winBarClseBtn.Cursor = Cursors.Hand;
            winBarClseBtn.Image = (Image)resources.GetObject("winBarClseBtn.Image");
            winBarClseBtn.Location = new Point(745, 5);
            winBarClseBtn.Name = "winBarClseBtn";
            winBarClseBtn.Size = new Size(50, 49);
            winBarClseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            winBarClseBtn.TabIndex = 4;
            winBarClseBtn.TabStop = false;
            winBarClseBtn.Click += winBarClseBtn_Click;
            // 
            // winStatusBtn
            // 
            winStatusBtn.Anchor = AnchorStyles.None;
            winStatusBtn.Cursor = Cursors.Hand;
            winStatusBtn.Image = (Image)resources.GetObject("winStatusBtn.Image");
            winStatusBtn.Location = new Point(691, 5);
            winStatusBtn.Name = "winStatusBtn";
            winStatusBtn.Size = new Size(48, 49);
            winStatusBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            winStatusBtn.TabIndex = 5;
            winStatusBtn.TabStop = false;
            winStatusBtn.Click += winStatusBtn_Click;
            // 
            // winBarMinBtn
            // 
            winBarMinBtn.Anchor = AnchorStyles.None;
            winBarMinBtn.Cursor = Cursors.Hand;
            winBarMinBtn.Image = (Image)resources.GetObject("winBarMinBtn.Image");
            winBarMinBtn.Location = new Point(637, 5);
            winBarMinBtn.Name = "winBarMinBtn";
            winBarMinBtn.Size = new Size(48, 49);
            winBarMinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            winBarMinBtn.TabIndex = 6;
            winBarMinBtn.TabStop = false;
            winBarMinBtn.Click += winBarMinBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(contPasswrdInp, 1, 3);
            tableLayoutPanel1.Controls.Add(wlcTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(inpTxt, 0, 1);
            tableLayoutPanel1.Controls.Add(sumbitBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(userImg, 0, 2);
            tableLayoutPanel1.Controls.Add(passwrdImg, 0, 3);
            tableLayoutPanel1.Controls.Add(contUserInp, 1, 2);
            tableLayoutPanel1.Location = new Point(217, 68);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3835049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.25156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.05669F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.05669F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.25156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(327, 314);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // contPasswrdInp
            // 
            contPasswrdInp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            contPasswrdInp.ColumnCount = 1;
            contPasswrdInp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contPasswrdInp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            contPasswrdInp.Controls.Add(passwrdInp, 0, 1);
            contPasswrdInp.Controls.Add(passwrdTxt, 0, 0);
            contPasswrdInp.Location = new Point(136, 187);
            contPasswrdInp.Name = "contPasswrdInp";
            contPasswrdInp.RowCount = 2;
            contPasswrdInp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contPasswrdInp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contPasswrdInp.Size = new Size(185, 88);
            contPasswrdInp.TabIndex = 6;
            // 
            // passwrdInp
            // 
            passwrdInp.AcceptsTab = true;
            passwrdInp.Anchor = AnchorStyles.None;
            passwrdInp.BorderStyle = BorderStyle.FixedSingle;
            passwrdInp.Location = new Point(21, 54);
            passwrdInp.Name = "passwrdInp";
            passwrdInp.PasswordChar = '*';
            passwrdInp.Size = new Size(143, 23);
            passwrdInp.TabIndex = 2;
            // 
            // passwrdTxt
            // 
            passwrdTxt.AutoSize = true;
            passwrdTxt.Dock = DockStyle.Fill;
            passwrdTxt.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwrdTxt.Location = new Point(5, 2);
            passwrdTxt.Name = "passwrdTxt";
            passwrdTxt.Size = new Size(175, 41);
            passwrdTxt.TabIndex = 1;
            passwrdTxt.Text = "Ingrese su contraseña";
            passwrdTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wlcTxt
            // 
            wlcTxt.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(wlcTxt, 2);
            wlcTxt.Dock = DockStyle.Fill;
            wlcTxt.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wlcTxt.Location = new Point(6, 3);
            wlcTxt.Name = "wlcTxt";
            wlcTxt.Size = new Size(315, 51);
            wlcTxt.TabIndex = 0;
            wlcTxt.Text = "Bievenido devuelta";
            wlcTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inpTxt
            // 
            inpTxt.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(inpTxt, 2);
            inpTxt.Dock = DockStyle.Fill;
            inpTxt.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inpTxt.Location = new Point(6, 57);
            inpTxt.Name = "inpTxt";
            inpTxt.Size = new Size(315, 27);
            inpTxt.TabIndex = 1;
            inpTxt.Text = "Ingrese sus datos";
            inpTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sumbitBtn
            // 
            sumbitBtn.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(sumbitBtn, 2);
            sumbitBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sumbitBtn.Location = new Point(106, 284);
            sumbitBtn.Name = "sumbitBtn";
            sumbitBtn.Size = new Size(114, 24);
            sumbitBtn.TabIndex = 2;
            sumbitBtn.Text = "Ingresar";
            sumbitBtn.UseVisualStyleBackColor = true;
            sumbitBtn.Click += sumbitBtn_Click;
            // 
            // userImg
            // 
            userImg.Anchor = AnchorStyles.None;
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(16, 90);
            userImg.Name = "userImg";
            userImg.Size = new Size(100, 88);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 3;
            userImg.TabStop = false;
            // 
            // passwrdImg
            // 
            passwrdImg.Anchor = AnchorStyles.None;
            passwrdImg.Image = (Image)resources.GetObject("passwrdImg.Image");
            passwrdImg.Location = new Point(16, 187);
            passwrdImg.Name = "passwrdImg";
            passwrdImg.Size = new Size(100, 88);
            passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwrdImg.TabIndex = 4;
            passwrdImg.TabStop = false;
            // 
            // contUserInp
            // 
            contUserInp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            contUserInp.ColumnCount = 1;
            contUserInp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contUserInp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            contUserInp.Controls.Add(userTxt, 0, 0);
            contUserInp.Controls.Add(userInp, 0, 1);
            contUserInp.Location = new Point(136, 90);
            contUserInp.Name = "contUserInp";
            contUserInp.RowCount = 2;
            contUserInp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserInp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserInp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contUserInp.Size = new Size(185, 88);
            contUserInp.TabIndex = 5;
            // 
            // userTxt
            // 
            userTxt.AutoSize = true;
            userTxt.Dock = DockStyle.Fill;
            userTxt.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(5, 2);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(175, 41);
            userTxt.TabIndex = 0;
            userTxt.Text = "Ingrese su usuario";
            userTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userInp
            // 
            userInp.AcceptsTab = true;
            userInp.Anchor = AnchorStyles.None;
            userInp.BorderStyle = BorderStyle.FixedSingle;
            userInp.Location = new Point(18, 54);
            userInp.Name = "userInp";
            userInp.Size = new Size(149, 23);
            userInp.TabIndex = 1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(contWinBar);
            Controls.Add(contStatusStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            contWinBar.ResumeLayout(false);
            contWinBar.PerformLayout();
            tableContWinBar.ResumeLayout(false);
            tableContWinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contPasswrdInp.ResumeLayout(false);
            contPasswrdInp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).EndInit();
            contUserInp.ResumeLayout(false);
            contUserInp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contStatusStrip;
        private Panel contWinBar;
        private TableLayoutPanel tableContWinBar;
        private PictureBox logoWinBar;
        private Label winBarTxt;
        private PictureBox winBarClseBtn;
        private PictureBox winStatusBtn;
        private PictureBox winBarMinBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label wlcTxt;
        private Label inpTxt;
        private Button sumbitBtn;
        private PictureBox userImg;
        private PictureBox passwrdImg;
        private TableLayoutPanel contPasswrdInp;
        private TableLayoutPanel contUserInp;
        private TextBox passwrdInp;
        private Label passwrdTxt;
        private Label userTxt;
        private TextBox userInp;
    }
}