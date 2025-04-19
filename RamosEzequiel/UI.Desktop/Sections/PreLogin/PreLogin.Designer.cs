namespace UI.Desktop.Sections.PreLogin
{
    partial class preLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preLogIn));
            statusStrip1 = new StatusStrip();
            lblStatusTxt = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            logInBtn = new ToolStripMenuItem();
            logOutBtn = new ToolStripMenuItem();
            closeAppBtn = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusTxt });
            statusStrip1.Location = new Point(0, 420);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 30);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusTxt
            // 
            lblStatusTxt.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTxt.Name = "lblStatusTxt";
            lblStatusTxt.Size = new Size(197, 25);
            lblStatusTxt.Text = "Sesión no iniciada";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logInBtn, logOutBtn, closeAppBtn });
            archivoToolStripMenuItem.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(93, 27);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // logInBtn
            // 
            logInBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBtn.Image = Properties.Resources.login;
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(216, 24);
            logInBtn.Text = "Iniciar sesión";
            logInBtn.Click += logInBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutBtn.Image = Properties.Resources.logout1;
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(216, 24);
            logOutBtn.Text = "Cerrar sesión";
            logOutBtn.Click += logOutBtn_Click;
            // 
            // closeAppBtn
            // 
            closeAppBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeAppBtn.Image = Properties.Resources.shutdown;
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(216, 24);
            closeAppBtn.Text = "Cerrar aplicación";
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // preLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "preLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IZO";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusTxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem logInBtn;
        private ToolStripMenuItem logOutBtn;
        private ToolStripMenuItem closeAppBtn;
    }
}