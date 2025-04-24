namespace UI.Desktop.Sections.Main.Admin.AddUser
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            contWinBar = new Panel();
            tableContWinBar = new TableLayoutPanel();
            logoWinBar = new PictureBox();
            winBarTxt = new Label();
            winBarClseBtn = new PictureBox();
            contStatusStrip = new Panel();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contAddUser = new TableLayoutPanel();
            contUserLastname = new TableLayoutPanel();
            newUserLastnameTxt = new Label();
            newUserLastnameInp = new TextBox();
            contUserName = new TableLayoutPanel();
            newUserNameTxt = new Label();
            newUserNameInp = new TextBox();
            contUserPasswrd = new TableLayoutPanel();
            newUserPasswrdTxt = new Label();
            newUserPasswrdInp = new TextBox();
            contNewUser = new TableLayoutPanel();
            newUserInp = new TextBox();
            newUserTxt = new Label();
            userImg = new PictureBox();
            nameImg = new PictureBox();
            passwrdImg = new PictureBox();
            typeImg = new PictureBox();
            contUserType = new TableLayoutPanel();
            newUserTypeTxt = new Label();
            newUserTypeComBox = new ComboBox();
            contUserEmail = new TableLayoutPanel();
            newUserEmailInp = new TextBox();
            newUserEmailTxt = new Label();
            emailImg = new PictureBox();
            userRegistrerBtn = new Button();
            contWinBar.SuspendLayout();
            tableContWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).BeginInit();
            contStatusStrip.SuspendLayout();
            statusBar.SuspendLayout();
            contAddUser.SuspendLayout();
            contUserLastname.SuspendLayout();
            contUserName.SuspendLayout();
            contUserPasswrd.SuspendLayout();
            contNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nameImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeImg).BeginInit();
            contUserType.SuspendLayout();
            contUserEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailImg).BeginInit();
            SuspendLayout();
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
            contWinBar.Size = new Size(800, 57);
            contWinBar.TabIndex = 1;
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
            tableContWinBar.Controls.Add(winBarClseBtn, 5, 0);
            tableContWinBar.Controls.Add(logoWinBar, 0, 0);
            tableContWinBar.Controls.Add(winBarTxt, 1, 0);
            tableContWinBar.Dock = DockStyle.Fill;
            tableContWinBar.Location = new Point(0, 0);
            tableContWinBar.Name = "tableContWinBar";
            tableContWinBar.RowCount = 1;
            tableContWinBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableContWinBar.Size = new Size(798, 55);
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
            winBarTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winBarTxt.Location = new Point(66, 0);
            winBarTxt.Name = "winBarTxt";
            winBarTxt.Size = new Size(136, 55);
            winBarTxt.TabIndex = 1;
            winBarTxt.Text = "Agregar usuario";
            winBarTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winBarClseBtn
            // 
            winBarClseBtn.Anchor = AnchorStyles.None;
            winBarClseBtn.Cursor = Cursors.Hand;
            winBarClseBtn.Image = (Image)resources.GetObject("winBarClseBtn.Image");
            winBarClseBtn.Location = new Point(745, 3);
            winBarClseBtn.Name = "winBarClseBtn";
            winBarClseBtn.Size = new Size(50, 49);
            winBarClseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            winBarClseBtn.TabIndex = 4;
            winBarClseBtn.TabStop = false;
            winBarClseBtn.Click += winBarClseBtn_Click;
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
            // contAddUser
            // 
            contAddUser.AutoSize = true;
            contAddUser.ColumnCount = 6;
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53063F));
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2921734F));
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0864716F));
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.2679167F));
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2921734F));
            contAddUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53063F));
            contAddUser.Controls.Add(contUserLastname, 2, 4);
            contAddUser.Controls.Add(contUserName, 2, 3);
            contAddUser.Controls.Add(contUserPasswrd, 2, 2);
            contAddUser.Controls.Add(contNewUser, 2, 1);
            contAddUser.Controls.Add(userImg, 1, 1);
            contAddUser.Controls.Add(nameImg, 1, 3);
            contAddUser.Controls.Add(passwrdImg, 1, 2);
            contAddUser.Controls.Add(typeImg, 3, 3);
            contAddUser.Controls.Add(contUserType, 4, 3);
            contAddUser.Controls.Add(contUserEmail, 4, 2);
            contAddUser.Controls.Add(emailImg, 3, 2);
            contAddUser.Controls.Add(userRegistrerBtn, 2, 5);
            contAddUser.Dock = DockStyle.Fill;
            contAddUser.Location = new Point(0, 57);
            contAddUser.Name = "contAddUser";
            contAddUser.RowCount = 6;
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 9.839248F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2416916F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9395771F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9395771F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3353481F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7824774F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contAddUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contAddUser.Size = new Size(800, 331);
            contAddUser.TabIndex = 3;
            // 
            // contUserLastname
            // 
            contUserLastname.ColumnCount = 1;
            contUserLastname.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserLastname.Controls.Add(newUserLastnameTxt, 0, 0);
            contUserLastname.Controls.Add(newUserLastnameInp, 0, 1);
            contUserLastname.Dock = DockStyle.Fill;
            contUserLastname.Location = new Point(281, 231);
            contUserLastname.Name = "contUserLastname";
            contUserLastname.RowCount = 2;
            contUserLastname.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserLastname.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserLastname.Size = new Size(146, 57);
            contUserLastname.TabIndex = 9;
            // 
            // newUserLastnameTxt
            // 
            newUserLastnameTxt.AutoSize = true;
            newUserLastnameTxt.Dock = DockStyle.Fill;
            newUserLastnameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserLastnameTxt.Location = new Point(3, 0);
            newUserLastnameTxt.Name = "newUserLastnameTxt";
            newUserLastnameTxt.Size = new Size(140, 28);
            newUserLastnameTxt.TabIndex = 4;
            newUserLastnameTxt.Text = "Apellido";
            newUserLastnameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newUserLastnameInp
            // 
            newUserLastnameInp.AcceptsTab = true;
            newUserLastnameInp.Anchor = AnchorStyles.None;
            newUserLastnameInp.BorderStyle = BorderStyle.FixedSingle;
            newUserLastnameInp.Location = new Point(13, 31);
            newUserLastnameInp.Name = "newUserLastnameInp";
            newUserLastnameInp.Size = new Size(120, 23);
            newUserLastnameInp.TabIndex = 3;
            // 
            // contUserName
            // 
            contUserName.ColumnCount = 1;
            contUserName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserName.Controls.Add(newUserNameTxt, 0, 0);
            contUserName.Controls.Add(newUserNameInp, 0, 1);
            contUserName.Dock = DockStyle.Fill;
            contUserName.Location = new Point(281, 166);
            contUserName.Name = "contUserName";
            contUserName.RowCount = 2;
            contUserName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserName.Size = new Size(146, 59);
            contUserName.TabIndex = 8;
            // 
            // newUserNameTxt
            // 
            newUserNameTxt.AutoSize = true;
            newUserNameTxt.Dock = DockStyle.Fill;
            newUserNameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserNameTxt.Location = new Point(3, 0);
            newUserNameTxt.Name = "newUserNameTxt";
            newUserNameTxt.Size = new Size(140, 29);
            newUserNameTxt.TabIndex = 3;
            newUserNameTxt.Text = "Nombre";
            newUserNameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newUserNameInp
            // 
            newUserNameInp.AcceptsTab = true;
            newUserNameInp.Anchor = AnchorStyles.None;
            newUserNameInp.BorderStyle = BorderStyle.FixedSingle;
            newUserNameInp.Location = new Point(13, 32);
            newUserNameInp.Name = "newUserNameInp";
            newUserNameInp.Size = new Size(120, 23);
            newUserNameInp.TabIndex = 2;
            // 
            // contUserPasswrd
            // 
            contUserPasswrd.ColumnCount = 1;
            contUserPasswrd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserPasswrd.Controls.Add(newUserPasswrdTxt, 0, 0);
            contUserPasswrd.Controls.Add(newUserPasswrdInp, 0, 1);
            contUserPasswrd.Dock = DockStyle.Fill;
            contUserPasswrd.Location = new Point(281, 101);
            contUserPasswrd.Name = "contUserPasswrd";
            contUserPasswrd.RowCount = 2;
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contUserPasswrd.Size = new Size(146, 59);
            contUserPasswrd.TabIndex = 7;
            // 
            // newUserPasswrdTxt
            // 
            newUserPasswrdTxt.AutoSize = true;
            newUserPasswrdTxt.Dock = DockStyle.Fill;
            newUserPasswrdTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserPasswrdTxt.Location = new Point(3, 0);
            newUserPasswrdTxt.Name = "newUserPasswrdTxt";
            newUserPasswrdTxt.Size = new Size(140, 29);
            newUserPasswrdTxt.TabIndex = 2;
            newUserPasswrdTxt.Text = "Contraseña";
            newUserPasswrdTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newUserPasswrdInp
            // 
            newUserPasswrdInp.AcceptsTab = true;
            newUserPasswrdInp.Anchor = AnchorStyles.None;
            newUserPasswrdInp.BorderStyle = BorderStyle.FixedSingle;
            newUserPasswrdInp.Location = new Point(13, 32);
            newUserPasswrdInp.Name = "newUserPasswrdInp";
            newUserPasswrdInp.PasswordChar = '*';
            newUserPasswrdInp.Size = new Size(120, 23);
            newUserPasswrdInp.TabIndex = 1;
            // 
            // contNewUser
            // 
            contNewUser.ColumnCount = 1;
            contNewUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contNewUser.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            contNewUser.Controls.Add(newUserInp, 0, 1);
            contNewUser.Controls.Add(newUserTxt, 0, 0);
            contNewUser.Dock = DockStyle.Fill;
            contNewUser.Location = new Point(281, 35);
            contNewUser.Name = "contNewUser";
            contNewUser.RowCount = 2;
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contNewUser.Size = new Size(146, 60);
            contNewUser.TabIndex = 6;
            // 
            // newUserInp
            // 
            newUserInp.AcceptsTab = true;
            newUserInp.Anchor = AnchorStyles.None;
            newUserInp.BorderStyle = BorderStyle.FixedSingle;
            newUserInp.Location = new Point(13, 33);
            newUserInp.Name = "newUserInp";
            newUserInp.Size = new Size(120, 23);
            newUserInp.TabIndex = 0;
            // 
            // newUserTxt
            // 
            newUserTxt.AutoSize = true;
            newUserTxt.Dock = DockStyle.Fill;
            newUserTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTxt.Location = new Point(3, 0);
            newUserTxt.Name = "newUserTxt";
            newUserTxt.Size = new Size(140, 30);
            newUserTxt.TabIndex = 1;
            newUserTxt.Text = "Nombre de usuario";
            newUserTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userImg
            // 
            userImg.Anchor = AnchorStyles.None;
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(184, 35);
            userImg.Name = "userImg";
            userImg.Size = new Size(65, 60);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 0;
            userImg.TabStop = false;
            // 
            // nameImg
            // 
            nameImg.Anchor = AnchorStyles.None;
            nameImg.Image = (Image)resources.GetObject("nameImg.Image");
            nameImg.Location = new Point(182, 198);
            nameImg.Name = "nameImg";
            contAddUser.SetRowSpan(nameImg, 2);
            nameImg.Size = new Size(70, 58);
            nameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            nameImg.TabIndex = 2;
            nameImg.TabStop = false;
            // 
            // passwrdImg
            // 
            passwrdImg.Anchor = AnchorStyles.None;
            passwrdImg.Image = (Image)resources.GetObject("passwrdImg.Image");
            passwrdImg.Location = new Point(183, 101);
            passwrdImg.Name = "passwrdImg";
            passwrdImg.Size = new Size(67, 59);
            passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwrdImg.TabIndex = 1;
            passwrdImg.TabStop = false;
            // 
            // typeImg
            // 
            typeImg.Anchor = AnchorStyles.None;
            typeImg.Image = (Image)resources.GetObject("typeImg.Image");
            typeImg.Location = new Point(440, 167);
            typeImg.Name = "typeImg";
            typeImg.Size = new Size(70, 56);
            typeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            typeImg.TabIndex = 4;
            typeImg.TabStop = false;
            // 
            // contUserType
            // 
            contUserType.ColumnCount = 1;
            contUserType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserType.Controls.Add(newUserTypeTxt, 0, 0);
            contUserType.Controls.Add(newUserTypeComBox, 0, 1);
            contUserType.Dock = DockStyle.Fill;
            contUserType.Location = new Point(523, 166);
            contUserType.Name = "contUserType";
            contUserType.RowCount = 2;
            contUserType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserType.Size = new Size(116, 59);
            contUserType.TabIndex = 11;
            // 
            // newUserTypeTxt
            // 
            newUserTypeTxt.AutoSize = true;
            newUserTypeTxt.Dock = DockStyle.Fill;
            newUserTypeTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTypeTxt.Location = new Point(3, 0);
            newUserTypeTxt.Name = "newUserTypeTxt";
            newUserTypeTxt.Size = new Size(110, 29);
            newUserTypeTxt.TabIndex = 6;
            newUserTypeTxt.Text = "Tipo de usuario";
            newUserTypeTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newUserTypeComBox
            // 
            newUserTypeComBox.Anchor = AnchorStyles.None;
            newUserTypeComBox.FormattingEnabled = true;
            newUserTypeComBox.Items.AddRange(new object[] { "0 (admin)", "1 (usuario)" });
            newUserTypeComBox.Location = new Point(3, 32);
            newUserTypeComBox.Name = "newUserTypeComBox";
            newUserTypeComBox.Size = new Size(110, 23);
            newUserTypeComBox.TabIndex = 7;
            // 
            // contUserEmail
            // 
            contUserEmail.ColumnCount = 1;
            contUserEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserEmail.Controls.Add(newUserEmailInp, 0, 1);
            contUserEmail.Controls.Add(newUserEmailTxt, 0, 0);
            contUserEmail.Dock = DockStyle.Fill;
            contUserEmail.Location = new Point(523, 101);
            contUserEmail.Name = "contUserEmail";
            contUserEmail.RowCount = 2;
            contUserEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserEmail.Size = new Size(116, 59);
            contUserEmail.TabIndex = 10;
            // 
            // newUserEmailInp
            // 
            newUserEmailInp.AcceptsTab = true;
            newUserEmailInp.Anchor = AnchorStyles.None;
            newUserEmailInp.BorderStyle = BorderStyle.FixedSingle;
            newUserEmailInp.Location = new Point(3, 32);
            newUserEmailInp.Name = "newUserEmailInp";
            newUserEmailInp.Size = new Size(110, 23);
            newUserEmailInp.TabIndex = 5;
            // 
            // newUserEmailTxt
            // 
            newUserEmailTxt.AutoSize = true;
            newUserEmailTxt.Dock = DockStyle.Fill;
            newUserEmailTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserEmailTxt.Location = new Point(3, 0);
            newUserEmailTxt.Name = "newUserEmailTxt";
            newUserEmailTxt.Size = new Size(110, 29);
            newUserEmailTxt.TabIndex = 5;
            newUserEmailTxt.Text = "Email";
            newUserEmailTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailImg
            // 
            emailImg.Anchor = AnchorStyles.None;
            emailImg.Image = (Image)resources.GetObject("emailImg.Image");
            emailImg.Location = new Point(442, 101);
            emailImg.Name = "emailImg";
            emailImg.Size = new Size(65, 59);
            emailImg.SizeMode = PictureBoxSizeMode.StretchImage;
            emailImg.TabIndex = 3;
            emailImg.TabStop = false;
            // 
            // userRegistrerBtn
            // 
            userRegistrerBtn.Anchor = AnchorStyles.None;
            contAddUser.SetColumnSpan(userRegistrerBtn, 2);
            userRegistrerBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRegistrerBtn.Location = new Point(323, 295);
            userRegistrerBtn.Name = "userRegistrerBtn";
            userRegistrerBtn.Size = new Size(152, 31);
            userRegistrerBtn.TabIndex = 12;
            userRegistrerBtn.Text = "Registrar usuario";
            userRegistrerBtn.UseVisualStyleBackColor = true;
            userRegistrerBtn.Click += userRegistrerBtn_Click;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contAddUser);
            Controls.Add(contStatusStrip);
            Controls.Add(contWinBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar usuario";
            contWinBar.ResumeLayout(false);
            contWinBar.PerformLayout();
            tableContWinBar.ResumeLayout(false);
            tableContWinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).EndInit();
            contStatusStrip.ResumeLayout(false);
            contStatusStrip.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            contAddUser.ResumeLayout(false);
            contUserLastname.ResumeLayout(false);
            contUserLastname.PerformLayout();
            contUserName.ResumeLayout(false);
            contUserName.PerformLayout();
            contUserPasswrd.ResumeLayout(false);
            contUserPasswrd.PerformLayout();
            contNewUser.ResumeLayout(false);
            contNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nameImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeImg).EndInit();
            contUserType.ResumeLayout(false);
            contUserType.PerformLayout();
            contUserEmail.ResumeLayout(false);
            contUserEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel contWinBar;
        private TableLayoutPanel tableContWinBar;
        private PictureBox logoWinBar;
        private Label winBarTxt;
        private PictureBox winBarClseBtn;
        private Panel contStatusStrip;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusTxt;
        private TableLayoutPanel contAddUser;
        private PictureBox userImg;
        private PictureBox passwrdImg;
        private PictureBox nameImg;
        private PictureBox emailImg;
        private PictureBox typeImg;
        private TableLayoutPanel contNewUser;
        private TableLayoutPanel contUserType;
        private TableLayoutPanel contUserEmail;
        private TableLayoutPanel contUserLastname;
        private TableLayoutPanel contUserName;
        private TableLayoutPanel contUserPasswrd;
        private TextBox newUserLastnameInp;
        private TextBox newUserNameInp;
        private TextBox newUserPasswrdInp;
        private TextBox newUserInp;
        private Label newUserNameTxt;
        private Label newUserPasswrdTxt;
        private Label newUserTxt;
        private Label newUserLastnameTxt;
        private Label newUserTypeTxt;
        private Label newUserEmailTxt;
        private ComboBox newUserTypeComBox;
        private TextBox newUserEmailInp;
        private Button userRegistrerBtn;
    }
}