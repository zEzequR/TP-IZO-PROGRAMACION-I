namespace UI.Escritorio
{
    partial class frmMainAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdmin));
            contStatusStrip = new Panel();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contMenuStrip = new Panel();
            menuStrip1 = new MenuStrip();
            menuOpc = new ToolStripMenuItem();
            aboutOpc = new ToolStripMenuItem();
            logoutOpc = new ToolStripMenuItem();
            userOpc = new ToolStripMenuItem();
            addUserOpc = new ToolStripMenuItem();
            deleteUserOpc = new ToolStripMenuItem();
            modUserOpc = new ToolStripMenuItem();
            modeOpc = new ToolStripMenuItem();
            contWinBar = new Panel();
            tableContWinBar = new TableLayoutPanel();
            logoWinBar = new PictureBox();
            winBarTxt = new Label();
            winBarClseBtn = new PictureBox();
            winStatusBtn = new PictureBox();
            winBarMinBtn = new PictureBox();
            usersTable = new DataGridView();
            USERNAMEuser = new DataGridViewTextBoxColumn();
            PASSWORDuser = new DataGridViewTextBoxColumn();
            TYPEuser = new DataGridViewTextBoxColumn();
            IDuser = new DataGridViewTextBoxColumn();
            NAMEuser = new DataGridViewTextBoxColumn();
            LASTNAMEuser = new DataGridViewTextBoxColumn();
            EMAILuser = new DataGridViewTextBoxColumn();
            STATUSuser = new DataGridViewTextBoxColumn();
            LASTIMEuser = new DataGridViewTextBoxColumn();
            userDBBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            refreshBtn = new ToolStripMenuItem();
            contStatusStrip.SuspendLayout();
            statusBar.SuspendLayout();
            contMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            contWinBar.SuspendLayout();
            tableContWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // contStatusStrip
            // 
            contStatusStrip.BorderStyle = BorderStyle.FixedSingle;
            contStatusStrip.Controls.Add(statusBar);
            contStatusStrip.Dock = DockStyle.Bottom;
            contStatusStrip.Location = new Point(0, 426);
            contStatusStrip.Name = "contStatusStrip";
            contStatusStrip.Size = new Size(801, 62);
            contStatusStrip.TabIndex = 1;
            // 
            // statusBar
            // 
            statusBar.Dock = DockStyle.Fill;
            statusBar.Items.AddRange(new ToolStripItem[] { statusTxt });
            statusBar.Location = new Point(0, 0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(799, 60);
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
            // contMenuStrip
            // 
            contMenuStrip.BorderStyle = BorderStyle.FixedSingle;
            contMenuStrip.Controls.Add(menuStrip1);
            contMenuStrip.Dock = DockStyle.Top;
            contMenuStrip.Location = new Point(0, 57);
            contMenuStrip.Name = "contMenuStrip";
            contMenuStrip.Size = new Size(801, 44);
            contMenuStrip.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuOpc, userOpc, modeOpc, refreshBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 42);
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
            logoutOpc.Click += cerrarSesiónToolStripMenuItem_Click_1;
            // 
            // userOpc
            // 
            userOpc.DropDownItems.AddRange(new ToolStripItem[] { addUserOpc, deleteUserOpc, modUserOpc });
            userOpc.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userOpc.Image = (Image)resources.GetObject("userOpc.Image");
            userOpc.Name = "userOpc";
            userOpc.Size = new Size(137, 38);
            userOpc.Text = "| Usuarios";
            userOpc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addUserOpc
            // 
            addUserOpc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUserOpc.Image = (Image)resources.GetObject("addUserOpc.Image");
            addUserOpc.Name = "addUserOpc";
            addUserOpc.Size = new Size(233, 26);
            addUserOpc.Text = "| Agregar usuarios";
            addUserOpc.TextAlign = ContentAlignment.MiddleRight;
            addUserOpc.Click += addUserOpc_Click;
            // 
            // deleteUserOpc
            // 
            deleteUserOpc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteUserOpc.Image = (Image)resources.GetObject("deleteUserOpc.Image");
            deleteUserOpc.Name = "deleteUserOpc";
            deleteUserOpc.Size = new Size(233, 26);
            deleteUserOpc.Text = "| Eliminar usuarios";
            deleteUserOpc.TextAlign = ContentAlignment.MiddleRight;
            deleteUserOpc.Click += deleteUserOpc_Click;
            // 
            // modUserOpc
            // 
            modUserOpc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modUserOpc.Image = (Image)resources.GetObject("modUserOpc.Image");
            modUserOpc.Name = "modUserOpc";
            modUserOpc.Size = new Size(233, 26);
            modUserOpc.Text = "| Modificar usuarios";
            modUserOpc.TextAlign = ContentAlignment.MiddleRight;
            modUserOpc.Click += modUserOpc_Click;
            // 
            // modeOpc
            // 
            modeOpc.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeOpc.Image = (Image)resources.GetObject("modeOpc.Image");
            modeOpc.Name = "modeOpc";
            modeOpc.Size = new Size(217, 38);
            modeOpc.Text = "| Cambiar aspecto";
            modeOpc.TextAlign = ContentAlignment.MiddleRight;
            modeOpc.Click += cambiarAspectoToolStripMenuItem_Click;
            // 
            // contWinBar
            // 
            contWinBar.AutoSize = true;
            contWinBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contWinBar.BorderStyle = BorderStyle.FixedSingle;
            contWinBar.Controls.Add(tableContWinBar);
            contWinBar.Dock = DockStyle.Top;
            contWinBar.Location = new Point(0, 0);
            contWinBar.Name = "contWinBar";
            contWinBar.Size = new Size(801, 57);
            contWinBar.TabIndex = 0;
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
            tableContWinBar.Size = new Size(799, 55);
            tableContWinBar.TabIndex = 0;
            tableContWinBar.MouseDown += tableContWinBar_MouseDown;
            // 
            // logoWinBar
            // 
            logoWinBar.Anchor = AnchorStyles.None;
            logoWinBar.Image = (Image)resources.GetObject("logoWinBar.Image");
            logoWinBar.Location = new Point(11, 3);
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
            winBarTxt.Size = new Size(136, 55);
            winBarTxt.TabIndex = 1;
            winBarTxt.Text = "Sistema IZO";
            winBarTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winBarClseBtn
            // 
            winBarClseBtn.Anchor = AnchorStyles.None;
            winBarClseBtn.Cursor = Cursors.Hand;
            winBarClseBtn.Image = (Image)resources.GetObject("winBarClseBtn.Image");
            winBarClseBtn.Location = new Point(746, 3);
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
            winStatusBtn.Location = new Point(692, 3);
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
            winBarMinBtn.Location = new Point(638, 3);
            winBarMinBtn.Name = "winBarMinBtn";
            winBarMinBtn.Size = new Size(48, 49);
            winBarMinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            winBarMinBtn.TabIndex = 6;
            winBarMinBtn.TabStop = false;
            winBarMinBtn.Click += winBarMinBtn_Click;
            // 
            // usersTable
            // 
            usersTable.Anchor = AnchorStyles.None;
            usersTable.AutoGenerateColumns = false;
            usersTable.BackgroundColor = SystemColors.Control;
            usersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Columns.AddRange(new DataGridViewColumn[] { USERNAMEuser, PASSWORDuser, TYPEuser, IDuser, NAMEuser, LASTNAMEuser, EMAILuser, STATUSuser, LASTIMEuser });
            usersTable.DataSource = userDBBindingSource;
            usersTable.Location = new Point(0, 101);
            usersTable.Name = "usersTable";
            usersTable.ReadOnly = true;
            usersTable.Size = new Size(801, 325);
            usersTable.TabIndex = 3;
            // 
            // USERNAMEuser
            // 
            USERNAMEuser.DataPropertyName = "username";
            USERNAMEuser.HeaderText = "Nombre de usuario";
            USERNAMEuser.Name = "USERNAMEuser";
            USERNAMEuser.ReadOnly = true;
            USERNAMEuser.Resizable = DataGridViewTriState.False;
            // 
            // PASSWORDuser
            // 
            PASSWORDuser.DataPropertyName = "password";
            PASSWORDuser.HeaderText = "Contraseña del usuario";
            PASSWORDuser.Name = "PASSWORDuser";
            PASSWORDuser.ReadOnly = true;
            PASSWORDuser.Resizable = DataGridViewTriState.False;
            // 
            // TYPEuser
            // 
            TYPEuser.DataPropertyName = "type";
            TYPEuser.HeaderText = "Tipo";
            TYPEuser.Name = "TYPEuser";
            TYPEuser.ReadOnly = true;
            TYPEuser.Resizable = DataGridViewTriState.False;
            // 
            // IDuser
            // 
            IDuser.DataPropertyName = "id";
            IDuser.HeaderText = "ID";
            IDuser.Name = "IDuser";
            IDuser.ReadOnly = true;
            IDuser.Resizable = DataGridViewTriState.False;
            // 
            // NAMEuser
            // 
            NAMEuser.DataPropertyName = "nombre";
            NAMEuser.HeaderText = "Nombre";
            NAMEuser.Name = "NAMEuser";
            NAMEuser.ReadOnly = true;
            NAMEuser.Resizable = DataGridViewTriState.False;
            // 
            // LASTNAMEuser
            // 
            LASTNAMEuser.DataPropertyName = "apellido";
            LASTNAMEuser.HeaderText = "Apellido";
            LASTNAMEuser.Name = "LASTNAMEuser";
            LASTNAMEuser.ReadOnly = true;
            LASTNAMEuser.Resizable = DataGridViewTriState.False;
            // 
            // EMAILuser
            // 
            EMAILuser.DataPropertyName = "email";
            EMAILuser.HeaderText = "Email";
            EMAILuser.Name = "EMAILuser";
            EMAILuser.ReadOnly = true;
            EMAILuser.Resizable = DataGridViewTriState.False;
            // 
            // STATUSuser
            // 
            STATUSuser.DataPropertyName = "status";
            STATUSuser.HeaderText = "Estado";
            STATUSuser.Name = "STATUSuser";
            STATUSuser.ReadOnly = true;
            STATUSuser.Resizable = DataGridViewTriState.False;
            // 
            // LASTIMEuser
            // 
            LASTIMEuser.DataPropertyName = "lastTime";
            LASTIMEuser.HeaderText = "Registrado en";
            LASTIMEuser.Name = "LASTIMEuser";
            LASTIMEuser.ReadOnly = true;
            LASTIMEuser.Resizable = DataGridViewTriState.False;
            // 
            // userDBBindingSource
            // 
            userDBBindingSource.DataSource = typeof(Datos.UserDB);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entidades.User);
            // 
            // refreshBtn
            // 
            refreshBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Image = (Image)resources.GetObject("refreshBtn.Image");
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(148, 38);
            refreshBtn.Text = "| Actualizar";
            refreshBtn.TextAlign = ContentAlignment.MiddleRight;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // frmMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 488);
            Controls.Add(usersTable);
            Controls.Add(contMenuStrip);
            Controls.Add(contStatusStrip);
            Controls.Add(contWinBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMainAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema IZO (Admin Mode)";
            Load += frmMainAdmin_Load;
            contStatusStrip.ResumeLayout(false);
            contStatusStrip.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            contMenuStrip.ResumeLayout(false);
            contMenuStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contWinBar.ResumeLayout(false);
            contWinBar.PerformLayout();
            tableContWinBar.ResumeLayout(false);
            tableContWinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winStatusBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarMinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel contStatusStrip;
        private Panel contMenuStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userOpc;
        private ToolStripMenuItem addUserOpc;
        private ToolStripMenuItem deleteUserOpc;
        private ToolStripMenuItem modeOpc;
        private Panel contWinBar;
        private TableLayoutPanel tableContWinBar;
        private PictureBox logoWinBar;
        private Label winBarTxt;
        private PictureBox winBarClseBtn;
        private PictureBox winStatusBtn;
        private PictureBox winBarMinBtn;
        private ToolStripMenuItem modUserOpc;
        private DataGridView usersTable;
        private BindingSource userBindingSource;
        private BindingSource userDBBindingSource;
        private DataGridViewTextBoxColumn USERNAMEuser;
        private DataGridViewTextBoxColumn PASSWORDuser;
        private DataGridViewTextBoxColumn TYPEuser;
        private DataGridViewTextBoxColumn IDuser;
        private DataGridViewTextBoxColumn NAMEuser;
        private DataGridViewTextBoxColumn LASTNAMEuser;
        private DataGridViewTextBoxColumn EMAILuser;
        private DataGridViewTextBoxColumn STATUSuser;
        private DataGridViewTextBoxColumn LASTIMEuser;
        private ToolStripMenuItem menuOpc;
        private ToolStripMenuItem aboutOpc;
        private ToolStripMenuItem logoutOpc;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusTxt;
        private ToolStripMenuItem refreshBtn;
    }
}
