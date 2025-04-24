namespace UI.Desktop.Sections.Main.Admin.DeleteUser
{
    partial class deleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteUser));
            contStatusStrip = new Panel();
            statusBar = new StatusStrip();
            statusTxt = new ToolStripStatusLabel();
            contWinBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            contMenuStrip = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchTxt = new Label();
            searchByID = new TextBox();
            SearchImg = new PictureBox();
            contDeleteUser = new TableLayoutPanel();
            contTypeDelete = new TableLayoutPanel();
            newUserTypeTxt = new Label();
            typeDeleteData = new ComboBox();
            contEmailDelete = new TableLayoutPanel();
            newUserEmailTxt = new Label();
            emailDeleteData = new TextBox();
            contLastnameDelete = new TableLayoutPanel();
            newUserLastnameTxt = new Label();
            lastnameDeleteData = new TextBox();
            contNameDelete = new TableLayoutPanel();
            newUserNameTxt = new Label();
            nameDeleteData = new TextBox();
            contPasswrdDelete = new TableLayoutPanel();
            newUserPasswrdTxt = new Label();
            passwrdDeleteData = new TextBox();
            userDeleteBtn = new Button();
            nameImg = new PictureBox();
            passwrdImg = new PictureBox();
            emailImg = new PictureBox();
            typeImg = new PictureBox();
            contUsernameDelete = new TableLayoutPanel();
            newUserTxt = new Label();
            userDeleteData = new TextBox();
            userImg = new PictureBox();
            contStatusStrip.SuspendLayout();
            statusBar.SuspendLayout();
            contWinBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contMenuStrip.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchImg).BeginInit();
            contDeleteUser.SuspendLayout();
            contTypeDelete.SuspendLayout();
            contEmailDelete.SuspendLayout();
            contLastnameDelete.SuspendLayout();
            contNameDelete.SuspendLayout();
            contPasswrdDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nameImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeImg).BeginInit();
            contUsernameDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
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
            // contWinBar
            // 
            contWinBar.AutoSize = true;
            contWinBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contWinBar.BorderStyle = BorderStyle.FixedSingle;
            contWinBar.Controls.Add(tableLayoutPanel1);
            contWinBar.Dock = DockStyle.Top;
            contWinBar.Location = new Point(0, 0);
            contWinBar.Name = "contWinBar";
            contWinBar.Size = new Size(800, 57);
            contWinBar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.91913652F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8965683F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.8365059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.782596F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(798, 55);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.MouseDown += tableContWinBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 55);
            label1.TabIndex = 1;
            label1.Text = "Eliminar usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(746, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += winBarClseBtn_Click;
            // 
            // contMenuStrip
            // 
            contMenuStrip.BorderStyle = BorderStyle.FixedSingle;
            contMenuStrip.Controls.Add(tableLayoutPanel2);
            contMenuStrip.Dock = DockStyle.Top;
            contMenuStrip.Location = new Point(0, 57);
            contMenuStrip.Name = "contMenuStrip";
            contMenuStrip.Size = new Size(800, 44);
            contMenuStrip.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.98548F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.98549F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.985487F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.06064F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9829F));
            tableLayoutPanel2.Controls.Add(searchTxt, 1, 0);
            tableLayoutPanel2.Controls.Add(searchByID, 2, 0);
            tableLayoutPanel2.Controls.Add(SearchImg, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(798, 42);
            tableLayoutPanel2.TabIndex = 0;
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
            // contDeleteUser
            // 
            contDeleteUser.ColumnCount = 4;
            contDeleteUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contDeleteUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            contDeleteUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            contDeleteUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contDeleteUser.Controls.Add(contTypeDelete, 2, 5);
            contDeleteUser.Controls.Add(contEmailDelete, 2, 4);
            contDeleteUser.Controls.Add(contLastnameDelete, 2, 3);
            contDeleteUser.Controls.Add(contNameDelete, 2, 2);
            contDeleteUser.Controls.Add(contPasswrdDelete, 2, 1);
            contDeleteUser.Controls.Add(userDeleteBtn, 2, 6);
            contDeleteUser.Controls.Add(nameImg, 1, 2);
            contDeleteUser.Controls.Add(passwrdImg, 1, 1);
            contDeleteUser.Controls.Add(emailImg, 1, 4);
            contDeleteUser.Controls.Add(typeImg, 1, 5);
            contDeleteUser.Controls.Add(contUsernameDelete, 2, 0);
            contDeleteUser.Controls.Add(userImg, 1, 0);
            contDeleteUser.Dock = DockStyle.Fill;
            contDeleteUser.Location = new Point(0, 101);
            contDeleteUser.Name = "contDeleteUser";
            contDeleteUser.RowCount = 7;
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4927521F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.492754F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.492754F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.492754F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.492754F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4927568F));
            contDeleteUser.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043479F));
            contDeleteUser.Size = new Size(800, 287);
            contDeleteUser.TabIndex = 6;
            // 
            // contTypeDelete
            // 
            contTypeDelete.ColumnCount = 2;
            contTypeDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contTypeDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contTypeDelete.Controls.Add(newUserTypeTxt, 0, 0);
            contTypeDelete.Controls.Add(typeDeleteData, 1, 0);
            contTypeDelete.Dock = DockStyle.Fill;
            contTypeDelete.Location = new Point(283, 208);
            contTypeDelete.Name = "contTypeDelete";
            contTypeDelete.RowCount = 1;
            contTypeDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contTypeDelete.Size = new Size(314, 35);
            contTypeDelete.TabIndex = 19;
            // 
            // newUserTypeTxt
            // 
            newUserTypeTxt.AutoSize = true;
            newUserTypeTxt.Dock = DockStyle.Fill;
            newUserTypeTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTypeTxt.Location = new Point(3, 0);
            newUserTypeTxt.Name = "newUserTypeTxt";
            newUserTypeTxt.Size = new Size(151, 35);
            newUserTypeTxt.TabIndex = 7;
            newUserTypeTxt.Text = "Tipo de usuario";
            newUserTypeTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // typeDeleteData
            // 
            typeDeleteData.Anchor = AnchorStyles.None;
            typeDeleteData.FlatStyle = FlatStyle.System;
            typeDeleteData.FormattingEnabled = true;
            typeDeleteData.Items.AddRange(new object[] { "0 (admin)", "1 (usuario)" });
            typeDeleteData.Location = new Point(173, 6);
            typeDeleteData.Name = "typeDeleteData";
            typeDeleteData.Size = new Size(125, 23);
            typeDeleteData.TabIndex = 8;
            // 
            // contEmailDelete
            // 
            contEmailDelete.ColumnCount = 2;
            contEmailDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contEmailDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contEmailDelete.Controls.Add(newUserEmailTxt, 0, 0);
            contEmailDelete.Controls.Add(emailDeleteData, 1, 0);
            contEmailDelete.Dock = DockStyle.Fill;
            contEmailDelete.Location = new Point(283, 167);
            contEmailDelete.Name = "contEmailDelete";
            contEmailDelete.RowCount = 1;
            contEmailDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contEmailDelete.Size = new Size(314, 35);
            contEmailDelete.TabIndex = 18;
            // 
            // newUserEmailTxt
            // 
            newUserEmailTxt.AutoSize = true;
            newUserEmailTxt.Dock = DockStyle.Fill;
            newUserEmailTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserEmailTxt.Location = new Point(3, 0);
            newUserEmailTxt.Name = "newUserEmailTxt";
            newUserEmailTxt.Size = new Size(151, 35);
            newUserEmailTxt.TabIndex = 6;
            newUserEmailTxt.Text = "Email";
            newUserEmailTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailDeleteData
            // 
            emailDeleteData.AcceptsTab = true;
            emailDeleteData.Anchor = AnchorStyles.None;
            emailDeleteData.BorderStyle = BorderStyle.FixedSingle;
            emailDeleteData.Location = new Point(171, 6);
            emailDeleteData.Name = "emailDeleteData";
            emailDeleteData.ReadOnly = true;
            emailDeleteData.Size = new Size(129, 23);
            emailDeleteData.TabIndex = 7;
            // 
            // contLastnameDelete
            // 
            contLastnameDelete.ColumnCount = 2;
            contLastnameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contLastnameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contLastnameDelete.Controls.Add(newUserLastnameTxt, 0, 0);
            contLastnameDelete.Controls.Add(lastnameDeleteData, 1, 0);
            contLastnameDelete.Dock = DockStyle.Fill;
            contLastnameDelete.Location = new Point(283, 126);
            contLastnameDelete.Name = "contLastnameDelete";
            contLastnameDelete.RowCount = 1;
            contLastnameDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contLastnameDelete.Size = new Size(314, 35);
            contLastnameDelete.TabIndex = 17;
            // 
            // newUserLastnameTxt
            // 
            newUserLastnameTxt.AutoSize = true;
            newUserLastnameTxt.Dock = DockStyle.Fill;
            newUserLastnameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserLastnameTxt.Location = new Point(3, 0);
            newUserLastnameTxt.Name = "newUserLastnameTxt";
            newUserLastnameTxt.Size = new Size(151, 35);
            newUserLastnameTxt.TabIndex = 5;
            newUserLastnameTxt.Text = "Apellido";
            newUserLastnameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastnameDeleteData
            // 
            lastnameDeleteData.AcceptsTab = true;
            lastnameDeleteData.Anchor = AnchorStyles.None;
            lastnameDeleteData.BorderStyle = BorderStyle.FixedSingle;
            lastnameDeleteData.Location = new Point(171, 6);
            lastnameDeleteData.Name = "lastnameDeleteData";
            lastnameDeleteData.ReadOnly = true;
            lastnameDeleteData.Size = new Size(129, 23);
            lastnameDeleteData.TabIndex = 6;
            // 
            // contNameDelete
            // 
            contNameDelete.ColumnCount = 2;
            contNameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contNameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contNameDelete.Controls.Add(newUserNameTxt, 0, 0);
            contNameDelete.Controls.Add(nameDeleteData, 1, 0);
            contNameDelete.Dock = DockStyle.Fill;
            contNameDelete.Location = new Point(283, 85);
            contNameDelete.Name = "contNameDelete";
            contNameDelete.RowCount = 1;
            contNameDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contNameDelete.Size = new Size(314, 35);
            contNameDelete.TabIndex = 16;
            // 
            // newUserNameTxt
            // 
            newUserNameTxt.AutoSize = true;
            newUserNameTxt.Dock = DockStyle.Fill;
            newUserNameTxt.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserNameTxt.Location = new Point(3, 0);
            newUserNameTxt.Name = "newUserNameTxt";
            newUserNameTxt.Size = new Size(151, 35);
            newUserNameTxt.TabIndex = 4;
            newUserNameTxt.Text = "Nombre";
            newUserNameTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameDeleteData
            // 
            nameDeleteData.AcceptsTab = true;
            nameDeleteData.Anchor = AnchorStyles.None;
            nameDeleteData.BorderStyle = BorderStyle.FixedSingle;
            nameDeleteData.Location = new Point(171, 6);
            nameDeleteData.Name = "nameDeleteData";
            nameDeleteData.ReadOnly = true;
            nameDeleteData.Size = new Size(129, 23);
            nameDeleteData.TabIndex = 5;
            // 
            // contPasswrdDelete
            // 
            contPasswrdDelete.ColumnCount = 2;
            contPasswrdDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contPasswrdDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contPasswrdDelete.Controls.Add(newUserPasswrdTxt, 0, 0);
            contPasswrdDelete.Controls.Add(passwrdDeleteData, 1, 0);
            contPasswrdDelete.Dock = DockStyle.Fill;
            contPasswrdDelete.Location = new Point(283, 44);
            contPasswrdDelete.Name = "contPasswrdDelete";
            contPasswrdDelete.RowCount = 1;
            contPasswrdDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contPasswrdDelete.Size = new Size(314, 35);
            contPasswrdDelete.TabIndex = 15;
            // 
            // newUserPasswrdTxt
            // 
            newUserPasswrdTxt.AutoSize = true;
            newUserPasswrdTxt.Dock = DockStyle.Fill;
            newUserPasswrdTxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserPasswrdTxt.Location = new Point(3, 0);
            newUserPasswrdTxt.Name = "newUserPasswrdTxt";
            newUserPasswrdTxt.Size = new Size(151, 35);
            newUserPasswrdTxt.TabIndex = 3;
            newUserPasswrdTxt.Text = "Contraseña";
            newUserPasswrdTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwrdDeleteData
            // 
            passwrdDeleteData.AcceptsTab = true;
            passwrdDeleteData.Anchor = AnchorStyles.None;
            passwrdDeleteData.BorderStyle = BorderStyle.FixedSingle;
            passwrdDeleteData.Location = new Point(171, 6);
            passwrdDeleteData.Name = "passwrdDeleteData";
            passwrdDeleteData.ReadOnly = true;
            passwrdDeleteData.Size = new Size(129, 23);
            passwrdDeleteData.TabIndex = 4;
            // 
            // userDeleteBtn
            // 
            userDeleteBtn.Anchor = AnchorStyles.None;
            userDeleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDeleteBtn.Location = new Point(364, 251);
            userDeleteBtn.Name = "userDeleteBtn";
            userDeleteBtn.Size = new Size(152, 31);
            userDeleteBtn.TabIndex = 13;
            userDeleteBtn.Text = "Eliminar usuario";
            userDeleteBtn.UseVisualStyleBackColor = true;
            userDeleteBtn.Click += userDeleteBtn_Click;
            // 
            // nameImg
            // 
            nameImg.Anchor = AnchorStyles.None;
            nameImg.Image = (Image)resources.GetObject("nameImg.Image");
            nameImg.Location = new Point(218, 103);
            nameImg.Name = "nameImg";
            contDeleteUser.SetRowSpan(nameImg, 2);
            nameImg.Size = new Size(44, 40);
            nameImg.SizeMode = PictureBoxSizeMode.StretchImage;
            nameImg.TabIndex = 7;
            nameImg.TabStop = false;
            // 
            // passwrdImg
            // 
            passwrdImg.Anchor = AnchorStyles.None;
            passwrdImg.Image = (Image)resources.GetObject("passwrdImg.Image");
            passwrdImg.Location = new Point(218, 44);
            passwrdImg.Name = "passwrdImg";
            passwrdImg.Size = new Size(43, 35);
            passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwrdImg.TabIndex = 6;
            passwrdImg.TabStop = false;
            // 
            // emailImg
            // 
            emailImg.Anchor = AnchorStyles.None;
            emailImg.Image = (Image)resources.GetObject("emailImg.Image");
            emailImg.Location = new Point(218, 167);
            emailImg.Name = "emailImg";
            emailImg.Size = new Size(44, 35);
            emailImg.SizeMode = PictureBoxSizeMode.StretchImage;
            emailImg.TabIndex = 8;
            emailImg.TabStop = false;
            // 
            // typeImg
            // 
            typeImg.Anchor = AnchorStyles.None;
            typeImg.Image = (Image)resources.GetObject("typeImg.Image");
            typeImg.Location = new Point(216, 208);
            typeImg.Name = "typeImg";
            typeImg.Size = new Size(47, 35);
            typeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            typeImg.TabIndex = 9;
            typeImg.TabStop = false;
            // 
            // contUsernameDelete
            // 
            contUsernameDelete.ColumnCount = 2;
            contUsernameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUsernameDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contUsernameDelete.Controls.Add(newUserTxt, 0, 0);
            contUsernameDelete.Controls.Add(userDeleteData, 1, 0);
            contUsernameDelete.Dock = DockStyle.Fill;
            contUsernameDelete.Location = new Point(283, 3);
            contUsernameDelete.Name = "contUsernameDelete";
            contUsernameDelete.RowCount = 1;
            contUsernameDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contUsernameDelete.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contUsernameDelete.Size = new Size(314, 35);
            contUsernameDelete.TabIndex = 14;
            // 
            // newUserTxt
            // 
            newUserTxt.AutoSize = true;
            newUserTxt.Dock = DockStyle.Fill;
            newUserTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserTxt.Location = new Point(3, 0);
            newUserTxt.Name = "newUserTxt";
            newUserTxt.Size = new Size(151, 35);
            newUserTxt.TabIndex = 2;
            newUserTxt.Text = "Nombre de usuario";
            newUserTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userDeleteData
            // 
            userDeleteData.AcceptsTab = true;
            userDeleteData.Anchor = AnchorStyles.None;
            userDeleteData.BorderStyle = BorderStyle.FixedSingle;
            userDeleteData.Location = new Point(171, 6);
            userDeleteData.Name = "userDeleteData";
            userDeleteData.ReadOnly = true;
            userDeleteData.Size = new Size(129, 23);
            userDeleteData.TabIndex = 3;
            // 
            // userImg
            // 
            userImg.Anchor = AnchorStyles.None;
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(221, 3);
            userImg.Name = "userImg";
            userImg.Size = new Size(38, 35);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 5;
            userImg.TabStop = false;
            // 
            // deleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contDeleteUser);
            Controls.Add(contMenuStrip);
            Controls.Add(contWinBar);
            Controls.Add(contStatusStrip);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "deleteUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrar usuario";
            contStatusStrip.ResumeLayout(false);
            contStatusStrip.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            contWinBar.ResumeLayout(false);
            contWinBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contMenuStrip.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchImg).EndInit();
            contDeleteUser.ResumeLayout(false);
            contTypeDelete.ResumeLayout(false);
            contTypeDelete.PerformLayout();
            contEmailDelete.ResumeLayout(false);
            contEmailDelete.PerformLayout();
            contLastnameDelete.ResumeLayout(false);
            contLastnameDelete.PerformLayout();
            contNameDelete.ResumeLayout(false);
            contNameDelete.PerformLayout();
            contPasswrdDelete.ResumeLayout(false);
            contPasswrdDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nameImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeImg).EndInit();
            contUsernameDelete.ResumeLayout(false);
            contUsernameDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel contStatusStrip;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusTxt;
        private Panel contWinBar;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel contMenuStrip;
        private TableLayoutPanel tableLayoutPanel2;
        private Label searchTxt;
        private TextBox searchByID;
        private PictureBox SearchImg;
        private TableLayoutPanel contDeleteUser;
        private PictureBox nameImg;
        private PictureBox userImg;
        private PictureBox passwrdImg;
        private PictureBox emailImg;
        private PictureBox typeImg;
        private Button userDeleteBtn;
        private TableLayoutPanel contUsernameDelete;
        private TableLayoutPanel contTypeDelete;
        private TableLayoutPanel contEmailDelete;
        private TableLayoutPanel contLastnameDelete;
        private TableLayoutPanel contNameDelete;
        private TableLayoutPanel contPasswrdDelete;
        private Label newUserTxt;
        private Label newUserPasswrdTxt;
        private Label newUserNameTxt;
        private Label newUserLastnameTxt;
        private Label newUserTypeTxt;
        private Label newUserEmailTxt;
        private ComboBox typeDeleteData;
        private TextBox emailDeleteData;
        private TextBox lastnameDeleteData;
        private TextBox nameDeleteData;
        private TextBox passwrdDeleteData;
        private TextBox userDeleteData;
    }
}