namespace UI.Escritorio.Sections.About
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            contStatusStrip = new Panel();
            closeMenuBtn = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            aboutDiv = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            izoLogo = new PictureBox();
            tpTxt = new Label();
            nameTxt = new Label();
            profTxt = new Label();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contStatusStrip.SuspendLayout();
            menuStrip3.SuspendLayout();
            aboutDiv.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)izoLogo).BeginInit();
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
            // closeMenuBtn
            // 
            closeMenuBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeMenuBtn.Image = (Image)resources.GetObject("closeMenuBtn.Image");
            closeMenuBtn.ImageAlign = ContentAlignment.MiddleRight;
            closeMenuBtn.Name = "closeMenuBtn";
            closeMenuBtn.Size = new Size(101, 28);
            closeMenuBtn.Text = "Cerrar";
            closeMenuBtn.Click += closeMenuBtn_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new ToolStripItem[] { closeMenuBtn });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(800, 32);
            menuStrip3.TabIndex = 3;
            menuStrip3.Text = "menuStrip1";
            // 
            // aboutDiv
            // 
            aboutDiv.Controls.Add(tableLayoutPanel1);
            aboutDiv.Location = new Point(0, 32);
            aboutDiv.Name = "aboutDiv";
            aboutDiv.Size = new Size(800, 356);
            aboutDiv.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0030346F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.77997F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2169952F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel1.Controls.Add(izoLogo, 0, 0);
            tableLayoutPanel1.Controls.Add(tpTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(nameTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(profTxt, 1, 2);
            tableLayoutPanel1.Location = new Point(66, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3919306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.4668579F));
            tableLayoutPanel1.Size = new Size(659, 347);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // izoLogo
            // 
            izoLogo.Anchor = AnchorStyles.None;
            izoLogo.Image = (Image)resources.GetObject("izoLogo.Image");
            izoLogo.Location = new Point(23, 3);
            izoLogo.Name = "izoLogo";
            izoLogo.Size = new Size(99, 109);
            izoLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            izoLogo.TabIndex = 3;
            izoLogo.TabStop = false;
            // 
            // tpTxt
            // 
            tpTxt.Anchor = AnchorStyles.None;
            tpTxt.AutoSize = true;
            tpTxt.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpTxt.Location = new Point(188, 39);
            tpTxt.Name = "tpTxt";
            tpTxt.Size = new Size(275, 36);
            tpTxt.TabIndex = 0;
            tpTxt.Text = "Trabajo Práctico 3";
            tpTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            nameTxt.AutoSize = true;
            nameTxt.Dock = DockStyle.Top;
            nameTxt.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(148, 115);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(355, 30);
            nameTxt.TabIndex = 1;
            nameTxt.Text = "Nombre: Ezequiel Ramos";
            nameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profTxt
            // 
            profTxt.AutoSize = true;
            profTxt.Dock = DockStyle.Top;
            profTxt.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profTxt.Location = new Point(148, 157);
            profTxt.Name = "profTxt";
            profTxt.Size = new Size(355, 24);
            profTxt.TabIndex = 2;
            profTxt.Text = "Profesor: Ezequiel Porta";
            profTxt.TextAlign = ContentAlignment.MiddleCenter;
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
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aboutDiv);
            Controls.Add(contStatusStrip);
            Controls.Add(menuStrip3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip3;
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca De";
            contStatusStrip.ResumeLayout(false);
            contStatusStrip.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            aboutDiv.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)izoLogo).EndInit();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel contStatusStrip;
        private ToolStripMenuItem closeMenuBtn;
        private MenuStrip menuStrip3;
        private Panel aboutDiv;
        private TableLayoutPanel tableLayoutPanel1;
        private Label tpTxt;
        private Label nameTxt;
        private Label profTxt;
        private PictureBox pictureBox1;
        private PictureBox izoLogo;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusTxt;
    }
}