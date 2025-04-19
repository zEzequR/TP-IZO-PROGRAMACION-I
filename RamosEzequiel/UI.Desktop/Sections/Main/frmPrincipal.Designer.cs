namespace UI.Desktop.Sections.Main
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuState = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            logoutBtn = new ToolStripMenuItem();
            aboutBtn = new ToolStripMenuItem();
            menuState.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuState
            // 
            menuState.Items.AddRange(new ToolStripItem[] { statusTxt });
            menuState.Location = new Point(0, 428);
            menuState.Name = "menuState";
            menuState.Size = new Size(800, 22);
            menuState.TabIndex = 0;
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
            menuStrip1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutBtn, aboutBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // logoutBtn
            // 
            logoutBtn.AutoToolTip = true;
            logoutBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            logoutBtn.Image = Properties.Resources.logout;
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(40, 32);
            logoutBtn.Text = "Cerrar Sesión";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // aboutBtn
            // 
            aboutBtn.AutoToolTip = true;
            aboutBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            aboutBtn.Image = Properties.Resources.about;
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(40, 32);
            aboutBtn.Text = "Acerca de";
            aboutBtn.Click += aboutBtn_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuState);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IZO - Programación I";
            menuState.ResumeLayout(false);
            menuState.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip menuState;
        private ToolStripStatusLabel statusTxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutBtn;
        private ToolStripMenuItem aboutBtn;
    }
}