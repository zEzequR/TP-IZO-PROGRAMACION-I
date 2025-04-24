namespace UI.Desktop.Sections.Main.Admin.ModUser
{
    partial class modifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyUser));
            contWinBar = new Panel();
            tableContWinBar = new TableLayoutPanel();
            logoWinBar = new PictureBox();
            winBarTxt = new Label();
            winBarClseBtn = new PictureBox();
            contStatusStrip = new Panel();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contMenuStrip = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            searchTxt = new Label();
            searchByID = new TextBox();
            SearchImg = new PictureBox();
            contModUser = new TableLayoutPanel();
            contUserLastname = new TableLayoutPanel();
            newUserLastnameTxt = new Label();
            modUserLastnameInp = new TextBox();
            contUserName = new TableLayoutPanel();
            newUserNameTxt = new Label();
            modUserNameInp = new TextBox();
            contUserPasswrd = new TableLayoutPanel();
            newUserPasswrdTxt = new Label();
            modUserPasswrdInp = new TextBox();
            contNewUser = new TableLayoutPanel();
            modUserInp = new TextBox();
            newUserTxt = new Label();
            userImg = new PictureBox();
            nameImg = new PictureBox();
            passwrdImg = new PictureBox();
            typeImg = new PictureBox();
            contUserType = new TableLayoutPanel();
            newUserEmailTxt = new Label();
            modUserEmailInp = new TextBox();
            contUserEmail = new TableLayoutPanel();
            newUserTypeComBox = new ComboBox();
            newUserTypeTxt = new Label();
            emailImg = new PictureBox();
            userRegistrerBtn = new Button();
            contWinBar.SuspendLayout();
            tableContWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWinBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBarClseBtn).BeginInit();
            contStatusStrip.SuspendLayout();
            statusBar.SuspendLayout();
            contMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchImg).BeginInit();
            contModUser.SuspendLayout();
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
            contWinBar.TabIndex = 2;
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
            winBarTxt.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winBarTxt.Location = new Point(66, 0);
            winBarTxt.Name = "winBarTxt";
            winBarTxt.Size = new Size(136, 55);
            winBarTxt.TabIndex = 1;
            winBarTxt.Text = "Modificar usuario";
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
            contStatusStrip.TabIndex = 3;
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
            // contMenuStrip
            // 
            contMenuStrip.BorderStyle = BorderStyle.FixedSingle;
            contMenuStrip.Controls.Add(tableLayoutPanel1);
            contMenuStrip.Dock = DockStyle.Top;
            contMenuStrip.Location = new Point(0, 57);
            contMenuStrip.Name = "contMenuStrip";
            contMenuStrip.Size = new Size(800, 44);
            contMenuStrip.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.98548F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.98549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.985487F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.06064F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9829F));
            tableLayoutPanel1.Controls.Add(searchTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(searchByID, 2, 0);
            tableLayoutPanel1.Controls.Add(SearchImg, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(798, 42);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // searchTxt
            // 
            searchTxt.AutoSize = true;
            searchTxt.Dock = DockStyle.Fill;
            searchTxt.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.Location = new Point(186, 0);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(177, 42);
            searchTxt.TabIndex = 1;
            searchTxt.Text = "Buscar";
            searchTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchByID
            // 
            searchByID.AcceptsTab = true;
            searchByID.Anchor = AnchorStyles.None;
            searchByID.BorderStyle = BorderStyle.FixedSingle;
            searchByID.Location = new Point(389, 9);
            searchByID.Name = "searchByID";
            searchByID.Size = new Size(137, 23);
            searchByID.TabIndex = 2;
            // 
            // SearchImg
            // 
            SearchImg.Anchor = AnchorStyles.None;
            SearchImg.Cursor = Cursors.Hand;
            SearchImg.Image = (Image)resources.GetObject("SearchImg.Image");
            SearchImg.Location = new Point(560, 3);
            SearchImg.Name = "SearchImg";
            SearchImg.Size = new Size(42, 36);
            SearchImg.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchImg.TabIndex = 0;
            SearchImg.TabStop = false;
            SearchImg.Click += SearchImg_Click;
            // 
            // contModUser
            // 
            contModUser.AutoSize = true;
            contModUser.ColumnCount = 6;
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53063F));
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2921734F));
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0864716F));
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.2679167F));
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2921734F));
            contModUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.53063F));
            contModUser.Controls.Add(contUserLastname, 2, 3);
            contModUser.Controls.Add(contUserName, 2, 2);
            contModUser.Controls.Add(contUserPasswrd, 2, 1);
            contModUser.Controls.Add(contNewUser, 2, 0);
            contModUser.Controls.Add(userImg, 1, 0);
            contModUser.Controls.Add(nameImg, 1, 2);
            contModUser.Controls.Add(passwrdImg, 1, 1);
            contModUser.Controls.Add(typeImg, 3, 2);
            contModUser.Controls.Add(contUserType, 4, 1);
            contModUser.Controls.Add(contUserEmail, 4, 2);
            contModUser.Controls.Add(emailImg, 3, 1);
            contModUser.Controls.Add(userRegistrerBtn, 2, 4);
            contModUser.Dock = DockStyle.Fill;
            contModUser.Location = new Point(0, 101);
            contModUser.Name = "contModUser";
            contModUser.RowCount = 5;
            contModUser.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1854286F));
            contModUser.RowStyles.Add(new RowStyle(SizeType.Percent, 21.8543053F));
            contModUser.RowStyles.Add(new RowStyle(SizeType.Percent, 21.8543053F));
            contModUser.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1920528F));
            contModUser.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9139071F));
            contModUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contModUser.Size = new Size(800, 287);
            contModUser.TabIndex = 5;
            // 
            // contUserLastname
            // 
            contUserLastname.ColumnCount = 1;
            contUserLastname.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserLastname.Controls.Add(newUserLastnameTxt, 0, 0);
            contUserLastname.Controls.Add(modUserLastnameInp, 0, 1);
            contUserLastname.Dock = DockStyle.Fill;
            contUserLastname.Location = new Point(281, 190);
            contUserLastname.Name = "contUserLastname";
            contUserLastname.RowCount = 2;
            contUserLastname.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserLastname.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserLastname.Size = new Size(146, 54);
            contUserLastname.TabIndex = 9;
            // 
            // newUserLastnameTxt
            // 
            newUserLastnameTxt.AutoSize = true;
            newUserLastnameTxt.Dock = DockStyle.Fill;
            newUserLastnameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserLastnameTxt.Location = new Point(3, 0);
            newUserLastnameTxt.Name = "newUserLastnameTxt";
            newUserLastnameTxt.Size = new Size(140, 27);
            newUserLastnameTxt.TabIndex = 4;
            newUserLastnameTxt.Text = "Apellido";
            newUserLastnameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modUserLastnameInp
            // 
            modUserLastnameInp.AcceptsTab = true;
            modUserLastnameInp.Anchor = AnchorStyles.None;
            modUserLastnameInp.BorderStyle = BorderStyle.FixedSingle;
            modUserLastnameInp.Location = new Point(13, 30);
            modUserLastnameInp.Name = "modUserLastnameInp";
            modUserLastnameInp.Size = new Size(120, 23);
            modUserLastnameInp.TabIndex = 3;
            // 
            // contUserName
            // 
            contUserName.ColumnCount = 1;
            contUserName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserName.Controls.Add(newUserNameTxt, 0, 0);
            contUserName.Controls.Add(modUserNameInp, 0, 1);
            contUserName.Dock = DockStyle.Fill;
            contUserName.Location = new Point(281, 128);
            contUserName.Name = "contUserName";
            contUserName.RowCount = 2;
            contUserName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserName.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserName.Size = new Size(146, 56);
            contUserName.TabIndex = 8;
            // 
            // newUserNameTxt
            // 
            newUserNameTxt.AutoSize = true;
            newUserNameTxt.Dock = DockStyle.Fill;
            newUserNameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserNameTxt.Location = new Point(3, 0);
            newUserNameTxt.Name = "newUserNameTxt";
            newUserNameTxt.Size = new Size(140, 28);
            newUserNameTxt.TabIndex = 3;
            newUserNameTxt.Text = "Nombre";
            newUserNameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modUserNameInp
            // 
            modUserNameInp.AcceptsTab = true;
            modUserNameInp.Anchor = AnchorStyles.None;
            modUserNameInp.BorderStyle = BorderStyle.FixedSingle;
            modUserNameInp.Location = new Point(13, 31);
            modUserNameInp.Name = "modUserNameInp";
            modUserNameInp.Size = new Size(120, 23);
            modUserNameInp.TabIndex = 2;
            // 
            // contUserPasswrd
            // 
            contUserPasswrd.ColumnCount = 1;
            contUserPasswrd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserPasswrd.Controls.Add(newUserPasswrdTxt, 0, 0);
            contUserPasswrd.Controls.Add(modUserPasswrdInp, 0, 1);
            contUserPasswrd.Dock = DockStyle.Fill;
            contUserPasswrd.Location = new Point(281, 66);
            contUserPasswrd.Name = "contUserPasswrd";
            contUserPasswrd.RowCount = 2;
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserPasswrd.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contUserPasswrd.Size = new Size(146, 56);
            contUserPasswrd.TabIndex = 7;
            // 
            // newUserPasswrdTxt
            // 
            newUserPasswrdTxt.AutoSize = true;
            newUserPasswrdTxt.Dock = DockStyle.Fill;
            newUserPasswrdTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserPasswrdTxt.Location = new Point(3, 0);
            newUserPasswrdTxt.Name = "newUserPasswrdTxt";
            newUserPasswrdTxt.Size = new Size(140, 28);
            newUserPasswrdTxt.TabIndex = 2;
            newUserPasswrdTxt.Text = "Contraseña";
            newUserPasswrdTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modUserPasswrdInp
            // 
            modUserPasswrdInp.AcceptsTab = true;
            modUserPasswrdInp.Anchor = AnchorStyles.None;
            modUserPasswrdInp.BorderStyle = BorderStyle.FixedSingle;
            modUserPasswrdInp.Location = new Point(13, 31);
            modUserPasswrdInp.Name = "modUserPasswrdInp";
            modUserPasswrdInp.PasswordChar = '*';
            modUserPasswrdInp.Size = new Size(120, 23);
            modUserPasswrdInp.TabIndex = 1;
            // 
            // contNewUser
            // 
            contNewUser.ColumnCount = 1;
            contNewUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contNewUser.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            contNewUser.Controls.Add(modUserInp, 0, 1);
            contNewUser.Controls.Add(newUserTxt, 0, 0);
            contNewUser.Dock = DockStyle.Fill;
            contNewUser.Location = new Point(281, 3);
            contNewUser.Name = "contNewUser";
            contNewUser.RowCount = 2;
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contNewUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contNewUser.Size = new Size(146, 57);
            contNewUser.TabIndex = 6;
            // 
            // modUserInp
            // 
            modUserInp.AcceptsTab = true;
            modUserInp.Anchor = AnchorStyles.None;
            modUserInp.BorderStyle = BorderStyle.FixedSingle;
            modUserInp.Location = new Point(13, 31);
            modUserInp.Name = "modUserInp";
            modUserInp.Size = new Size(120, 23);
            modUserInp.TabIndex = 0;
            // 
            // newUserTxt
            // 
            newUserTxt.AutoSize = true;
            newUserTxt.Dock = DockStyle.Fill;
            newUserTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTxt.Location = new Point(3, 0);
            newUserTxt.Name = "newUserTxt";
            newUserTxt.Size = new Size(140, 28);
            newUserTxt.TabIndex = 1;
            newUserTxt.Text = "Nombre de usuario";
            newUserTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userImg
            // 
            userImg.Anchor = AnchorStyles.None;
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(183, 3);
            userImg.Name = "userImg";
            userImg.Size = new Size(68, 57);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 0;
            userImg.TabStop = false;
            // 
            // nameImg
            // 
            nameImg.Anchor = AnchorStyles.None;
            nameImg.Image = (Image)resources.GetObject("nameImg.Image");
            nameImg.Location = new Point(182, 157);
            nameImg.Name = "nameImg";
            contModUser.SetRowSpan(nameImg, 2);
            nameImg.Size = new Size(70, 58);
            nameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            nameImg.TabIndex = 2;
            nameImg.TabStop = false;
            // 
            // passwrdImg
            // 
            passwrdImg.Anchor = AnchorStyles.None;
            passwrdImg.Image = (Image)resources.GetObject("passwrdImg.Image");
            passwrdImg.Location = new Point(183, 66);
            passwrdImg.Name = "passwrdImg";
            passwrdImg.Size = new Size(68, 56);
            passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwrdImg.TabIndex = 1;
            passwrdImg.TabStop = false;
            // 
            // typeImg
            // 
            typeImg.Anchor = AnchorStyles.None;
            typeImg.Image = (Image)resources.GetObject("typeImg.Image");
            typeImg.Location = new Point(440, 128);
            typeImg.Name = "typeImg";
            typeImg.Size = new Size(69, 56);
            typeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            typeImg.TabIndex = 4;
            typeImg.TabStop = false;
            // 
            // contUserType
            // 
            contUserType.ColumnCount = 1;
            contUserType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserType.Controls.Add(newUserEmailTxt, 0, 0);
            contUserType.Controls.Add(modUserEmailInp, 0, 1);
            contUserType.Dock = DockStyle.Fill;
            contUserType.Location = new Point(523, 66);
            contUserType.Name = "contUserType";
            contUserType.RowCount = 2;
            contUserType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserType.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserType.Size = new Size(116, 56);
            contUserType.TabIndex = 11;
            // 
            // newUserEmailTxt
            // 
            newUserEmailTxt.AutoSize = true;
            newUserEmailTxt.Dock = DockStyle.Fill;
            newUserEmailTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserEmailTxt.Location = new Point(3, 0);
            newUserEmailTxt.Name = "newUserEmailTxt";
            newUserEmailTxt.Size = new Size(110, 28);
            newUserEmailTxt.TabIndex = 5;
            newUserEmailTxt.Text = "Email";
            newUserEmailTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modUserEmailInp
            // 
            modUserEmailInp.AcceptsTab = true;
            modUserEmailInp.Anchor = AnchorStyles.None;
            modUserEmailInp.BorderStyle = BorderStyle.FixedSingle;
            modUserEmailInp.Location = new Point(3, 31);
            modUserEmailInp.Name = "modUserEmailInp";
            modUserEmailInp.Size = new Size(110, 23);
            modUserEmailInp.TabIndex = 5;
            // 
            // contUserEmail
            // 
            contUserEmail.ColumnCount = 1;
            contUserEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUserEmail.Controls.Add(newUserTypeComBox, 0, 1);
            contUserEmail.Controls.Add(newUserTypeTxt, 0, 0);
            contUserEmail.Dock = DockStyle.Fill;
            contUserEmail.Location = new Point(523, 128);
            contUserEmail.Name = "contUserEmail";
            contUserEmail.RowCount = 2;
            contUserEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUserEmail.Size = new Size(116, 56);
            contUserEmail.TabIndex = 10;
            // 
            // newUserTypeComBox
            // 
            newUserTypeComBox.Anchor = AnchorStyles.None;
            newUserTypeComBox.FormattingEnabled = true;
            newUserTypeComBox.Items.AddRange(new object[] { "0 (admin)", "1 (usuario)" });
            newUserTypeComBox.Location = new Point(3, 31);
            newUserTypeComBox.Name = "newUserTypeComBox";
            newUserTypeComBox.Size = new Size(110, 23);
            newUserTypeComBox.TabIndex = 7;
            // 
            // newUserTypeTxt
            // 
            newUserTypeTxt.AutoSize = true;
            newUserTypeTxt.Dock = DockStyle.Fill;
            newUserTypeTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTypeTxt.Location = new Point(3, 0);
            newUserTypeTxt.Name = "newUserTypeTxt";
            newUserTypeTxt.Size = new Size(110, 28);
            newUserTypeTxt.TabIndex = 6;
            newUserTypeTxt.Text = "Tipo de usuario";
            newUserTypeTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailImg
            // 
            emailImg.Anchor = AnchorStyles.None;
            emailImg.Image = (Image)resources.GetObject("emailImg.Image");
            emailImg.Location = new Point(441, 66);
            emailImg.Name = "emailImg";
            emailImg.Size = new Size(68, 56);
            emailImg.SizeMode = PictureBoxSizeMode.StretchImage;
            emailImg.TabIndex = 3;
            emailImg.TabStop = false;
            // 
            // userRegistrerBtn
            // 
            userRegistrerBtn.Anchor = AnchorStyles.None;
            contModUser.SetColumnSpan(userRegistrerBtn, 2);
            userRegistrerBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRegistrerBtn.Location = new Point(323, 251);
            userRegistrerBtn.Name = "userRegistrerBtn";
            userRegistrerBtn.Size = new Size(152, 31);
            userRegistrerBtn.TabIndex = 12;
            userRegistrerBtn.Text = "Actualizar usuario";
            userRegistrerBtn.UseVisualStyleBackColor = true;
            userRegistrerBtn.Click += userRegistrerBtn_Click;
            // 
            // modifyUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contModUser);
            Controls.Add(contMenuStrip);
            Controls.Add(contStatusStrip);
            Controls.Add(contWinBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "modifyUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar usuario";
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
            contMenuStrip.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchImg).EndInit();
            contModUser.ResumeLayout(false);
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
        private Panel contMenuStrip;
        private Label searchTxt;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox searchByID;
        private TableLayoutPanel contModUser;
        private TableLayoutPanel contUserLastname;
        private Label newUserLastnameTxt;
        private TextBox modUserLastnameInp;
        private TableLayoutPanel contUserName;
        private Label newUserNameTxt;
        private TextBox modUserNameInp;
        private TableLayoutPanel contUserPasswrd;
        private Label newUserPasswrdTxt;
        private TextBox modUserPasswrdInp;
        private TableLayoutPanel contNewUser;
        private TextBox modUserInp;
        private Label newUserTxt;
        private PictureBox userImg;
        private PictureBox nameImg;
        private PictureBox passwrdImg;
        private PictureBox typeImg;
        private TableLayoutPanel contUserType;
        private Label newUserTypeTxt;
        private ComboBox newUserTypeComBox;
        private TableLayoutPanel contUserEmail;
        private TextBox modUserEmailInp;
        private Label newUserEmailTxt;
        private PictureBox emailImg;
        private Button userRegistrerBtn;
        private PictureBox SearchImg;
    }
}