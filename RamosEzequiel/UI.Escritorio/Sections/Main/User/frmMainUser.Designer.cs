namespace UI.Escritorio.Sections.Main.User
{
    partial class frmMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUser));
            contStatusStrip = new Panel();
            contWinBar = new Panel();
            tableContWinBar = new TableLayoutPanel();
            logoWinBar = new PictureBox();
            winBarTxt = new Label();
            winBarClseBtn = new PictureBox();
            winStatusBtn = new PictureBox();
            winBarMinBtn = new PictureBox();
            contMenuStrip = new Panel();
            menuStrip1 = new MenuStrip();
            menuOpc = new ToolStripMenuItem();
            aboutOpc = new ToolStripMenuItem();
            logoutOpc = new ToolStripMenuItem();
            modeOpc = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contStatusStrip.SuspendLayout();
            contWinBar.SuspendLayout();
            tableContWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).BeginInit();
            contMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // contStatusStrip
            // 
            contStatusStrip.BorderStyle = BorderStyle.FixedSingle;
            contStatusStrip.Controls.Add(statusBar);
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
            // contMenuStrip
            // 
            contMenuStrip.BorderStyle = BorderStyle.FixedSingle;
            contMenuStrip.Controls.Add(menuStrip1);
            contMenuStrip.Dock = DockStyle.Top;
            contMenuStrip.Location = new Point(0, 62);
            contMenuStrip.Name = "contMenuStrip";
            contMenuStrip.Size = new Size(800, 44);
            contMenuStrip.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuOpc, modeOpc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuOpc
            // 
            menuOpc.DropDownItems.AddRange(new ToolStripItem[] { aboutOpc, logoutOpc });
            menuOpc.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuOpc.Image = (Image)resources.GetObject("menuOpc.Image");
            menuOpc.Name = "menuOpc";
            menuOpc.Size = new Size(117, 38);
            menuOpc.Text = "| Menu";
            menuOpc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // aboutOpc
            // 
            aboutOpc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutOpc.Image = (Image)resources.GetObject("aboutOpc.Image");
            aboutOpc.Name = "aboutOpc";
            aboutOpc.Size = new Size(193, 26);
            aboutOpc.Text = "| Acerca de";
            aboutOpc.Click += acercaDeToolStripMenuItem_Click;
            // 
            // logoutOpc
            // 
            logoutOpc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutOpc.Image = (Image)resources.GetObject("logoutOpc.Image");
            logoutOpc.Name = "logoutOpc";
            logoutOpc.Size = new Size(193, 26);
            logoutOpc.Text = "| Cerrar sesión";
            logoutOpc.TextAlign = ContentAlignment.MiddleRight;
            logoutOpc.Click += logoutOpc_Click;
            // 
            // modeOpc
            // 
            modeOpc.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeOpc.Image = (Image)resources.GetObject("modeOpc.Image");
            modeOpc.Name = "modeOpc";
            modeOpc.Size = new Size(238, 38);
            modeOpc.Text = "| Cambiar aspecto";
            modeOpc.Click += cambiarAspectoToolStripMenuItem_Click;
            // 
            // statusBar
            // 
            statusBar.Dock = DockStyle.Fill;
            statusBar.Items.AddRange(new ToolStripItem[] { statusTxt });
            statusBar.Location = new Point(0, 0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(798, 60);
            statusBar.TabIndex = 0;
            statusBar.Text = "statusStrip1";
            // 
            // statusTxt
            // 
            statusTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(198, 55);
            statusTxt.Text = "toolStripStatusLabel1";
            // 
            // frmMainUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contMenuStrip);
            Controls.Add(contWinBar);
            Controls.Add(contStatusStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IZO (User Mode)";
            contStatusStrip.ResumeLayout(false);
            contStatusStrip.PerformLayout();
            contWinBar.ResumeLayout(false);
            contWinBar.PerformLayout();
            tableContWinBar.ResumeLayout(false);
            tableContWinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).EndInit();
            contMenuStrip.ResumeLayout(false);
            contMenuStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
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
        private Panel contMenuStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuOpc;
        private ToolStripMenuItem logoutOpc;
        private ToolStripMenuItem aboutOpc;
        private ToolStripMenuItem modeOpc;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusTxt;
    }
}