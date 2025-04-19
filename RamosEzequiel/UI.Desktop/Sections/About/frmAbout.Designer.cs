namespace UI.Desktop.Sections.About
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
            menuState = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            closeBtn = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            izoLogo1 = new PictureBox();
            izoLogo2 = new PictureBox();
            TP2Txt = new Label();
            profNameTxt = new Label();
            nameTxt = new Label();
            menuState.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)izoLogo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)izoLogo2).BeginInit();
            SuspendLayout();
            // 
            // menuState
            // 
            menuState.Items.AddRange(new ToolStripItem[] { statusTxt });
            menuState.Location = new Point(0, 428);
            menuState.Name = "menuState";
            menuState.Size = new Size(800, 22);
            menuState.TabIndex = 1;
            // 
            // statusTxt
            // 
            statusTxt.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(0, 17);
            statusTxt.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { closeBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // closeBtn
            // 
            closeBtn.AutoToolTip = true;
            closeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            closeBtn.Image = Properties.Resources.close;
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 32);
            closeBtn.Text = "Cerrar";
            closeBtn.Click += closeBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(izoLogo1, 0, 1);
            tableLayoutPanel1.Controls.Add(izoLogo2, 2, 1);
            tableLayoutPanel1.Controls.Add(TP2Txt, 1, 1);
            tableLayoutPanel1.Controls.Add(profNameTxt, 1, 3);
            tableLayoutPanel1.Controls.Add(nameTxt, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(776, 356);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // izoLogo1
            // 
            izoLogo1.Anchor = AnchorStyles.None;
            izoLogo1.Image = Properties.Resources.izologo;
            izoLogo1.Location = new Point(13, 74);
            izoLogo1.Name = "izoLogo1";
            tableLayoutPanel1.SetRowSpan(izoLogo1, 2);
            izoLogo1.Size = new Size(129, 136);
            izoLogo1.SizeMode = PictureBoxSizeMode.StretchImage;
            izoLogo1.TabIndex = 0;
            izoLogo1.TabStop = false;
            // 
            // izoLogo2
            // 
            izoLogo2.Anchor = AnchorStyles.None;
            izoLogo2.Image = Properties.Resources.izologo;
            izoLogo2.Location = new Point(631, 74);
            izoLogo2.Name = "izoLogo2";
            tableLayoutPanel1.SetRowSpan(izoLogo2, 2);
            izoLogo2.Size = new Size(133, 136);
            izoLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            izoLogo2.TabIndex = 1;
            izoLogo2.TabStop = false;
            // 
            // TP2Txt
            // 
            TP2Txt.Anchor = AnchorStyles.None;
            TP2Txt.AutoSize = true;
            TP2Txt.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TP2Txt.Location = new Point(159, 79);
            TP2Txt.Name = "TP2Txt";
            TP2Txt.Size = new Size(457, 55);
            TP2Txt.TabIndex = 2;
            TP2Txt.Text = "Trabajo Práctico 2";
            TP2Txt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profNameTxt
            // 
            profNameTxt.Anchor = AnchorStyles.Top;
            profNameTxt.AutoSize = true;
            profNameTxt.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profNameTxt.Location = new Point(175, 213);
            profNameTxt.Name = "profNameTxt";
            profNameTxt.Size = new Size(424, 24);
            profNameTxt.TabIndex = 4;
            profNameTxt.Text = "Profesor: Mauricio García/Ezequiel Porta";
            profNameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            nameTxt.Anchor = AnchorStyles.Top;
            nameTxt.AutoSize = true;
            nameTxt.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(235, 142);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(304, 28);
            nameTxt.TabIndex = 3;
            nameTxt.Text = "Nombre: Ezequiel Ramos";
            nameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuState);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de";
            menuState.ResumeLayout(false);
            menuState.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)izoLogo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)izoLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip menuState;
        private ToolStripStatusLabel statusTxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem closeBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox izoLogo1;
        private PictureBox izoLogo2;
        private Label TP2Txt;
        private Label nameTxt;
        private Label profNameTxt;
    }
}