namespace UI.Desktop
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            loginDiv = new TableLayoutPanel();
            passwrdDiv = new TableLayoutPanel();
            PasswrdInpDiv = new GroupBox();
            passwrdInp = new TextBox();
            passwrdImg = new PictureBox();
            inpTxt = new Label();
            wlcTxt = new Label();
            userDiv = new TableLayoutPanel();
            UserInpDiv = new GroupBox();
            userInp = new TextBox();
            userImg = new PictureBox();
            btnSumbit = new Button();
            loginDiv.SuspendLayout();
            passwrdDiv.SuspendLayout();
            PasswrdInpDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).BeginInit();
            userDiv.SuspendLayout();
            UserInpDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
            SuspendLayout();
            // 
            // loginDiv
            // 
            loginDiv.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            loginDiv.ColumnCount = 1;
            loginDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            loginDiv.Controls.Add(passwrdDiv, 0, 3);
            loginDiv.Controls.Add(inpTxt, 0, 1);
            loginDiv.Controls.Add(wlcTxt, 0, 0);
            loginDiv.Controls.Add(userDiv, 0, 2);
            loginDiv.Controls.Add(btnSumbit, 0, 4);
            loginDiv.ForeColor = Color.Black;
            loginDiv.Location = new Point(204, 12);
            loginDiv.Name = "loginDiv";
            loginDiv.RowCount = 5;
            loginDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            loginDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            loginDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5555553F));
            loginDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5555553F));
            loginDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            loginDiv.Size = new Size(347, 426);
            loginDiv.TabIndex = 0;
            // 
            // passwrdDiv
            // 
            passwrdDiv.Anchor = AnchorStyles.None;
            passwrdDiv.ColumnCount = 2;
            passwrdDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            passwrdDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            passwrdDiv.Controls.Add(PasswrdInpDiv, 1, 0);
            passwrdDiv.Controls.Add(passwrdImg, 0, 0);
            passwrdDiv.Location = new Point(5, 251);
            passwrdDiv.Name = "passwrdDiv";
            passwrdDiv.RowCount = 1;
            passwrdDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passwrdDiv.Size = new Size(337, 120);
            passwrdDiv.TabIndex = 3;
            // 
            // PasswrdInpDiv
            // 
            PasswrdInpDiv.Anchor = AnchorStyles.None;
            PasswrdInpDiv.Controls.Add(passwrdInp);
            PasswrdInpDiv.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswrdInpDiv.ForeColor = Color.Black;
            PasswrdInpDiv.Location = new Point(108, 9);
            PasswrdInpDiv.Name = "PasswrdInpDiv";
            PasswrdInpDiv.Size = new Size(222, 101);
            PasswrdInpDiv.TabIndex = 1;
            PasswrdInpDiv.TabStop = false;
            PasswrdInpDiv.Text = "Contraseña";
            // 
            // passwrdInp
            // 
            passwrdInp.AcceptsTab = true;
            passwrdInp.Anchor = AnchorStyles.None;
            passwrdInp.BorderStyle = BorderStyle.FixedSingle;
            passwrdInp.Location = new Point(8, 42);
            passwrdInp.Name = "passwrdInp";
            passwrdInp.PasswordChar = '*';
            passwrdInp.Size = new Size(212, 32);
            passwrdInp.TabIndex = 1;
            // 
            // passwrdImg
            // 
            passwrdImg.Anchor = AnchorStyles.None;
            passwrdImg.Image = Properties.Resources.password;
            passwrdImg.Location = new Point(3, 3);
            passwrdImg.Name = "passwrdImg";
            passwrdImg.Size = new Size(95, 114);
            passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwrdImg.TabIndex = 2;
            passwrdImg.TabStop = false;
            // 
            // inpTxt
            // 
            inpTxt.Anchor = AnchorStyles.None;
            inpTxt.AutoSize = true;
            inpTxt.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inpTxt.ForeColor = Color.Black;
            inpTxt.Location = new Point(79, 83);
            inpTxt.Name = "inpTxt";
            inpTxt.Size = new Size(188, 24);
            inpTxt.TabIndex = 1;
            inpTxt.Text = "Ingrese sus datos";
            inpTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wlcTxt
            // 
            wlcTxt.Anchor = AnchorStyles.None;
            wlcTxt.AutoSize = true;
            wlcTxt.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wlcTxt.ForeColor = Color.Black;
            wlcTxt.Location = new Point(8, 17);
            wlcTxt.Name = "wlcTxt";
            wlcTxt.Size = new Size(331, 37);
            wlcTxt.TabIndex = 0;
            wlcTxt.Text = "Bienvenido devuelta";
            wlcTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userDiv
            // 
            userDiv.Anchor = AnchorStyles.None;
            userDiv.ColumnCount = 2;
            userDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            userDiv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            userDiv.Controls.Add(UserInpDiv, 1, 0);
            userDiv.Controls.Add(userImg, 0, 0);
            userDiv.Location = new Point(5, 123);
            userDiv.Name = "userDiv";
            userDiv.RowCount = 1;
            userDiv.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            userDiv.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            userDiv.Size = new Size(337, 120);
            userDiv.TabIndex = 2;
            // 
            // UserInpDiv
            // 
            UserInpDiv.Anchor = AnchorStyles.None;
            UserInpDiv.Controls.Add(userInp);
            UserInpDiv.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserInpDiv.ForeColor = Color.Black;
            UserInpDiv.Location = new Point(108, 9);
            UserInpDiv.Name = "UserInpDiv";
            UserInpDiv.Size = new Size(222, 101);
            UserInpDiv.TabIndex = 0;
            UserInpDiv.TabStop = false;
            UserInpDiv.Text = "Usuario";
            // 
            // userInp
            // 
            userInp.AcceptsTab = true;
            userInp.Anchor = AnchorStyles.None;
            userInp.BorderStyle = BorderStyle.FixedSingle;
            userInp.Location = new Point(8, 39);
            userInp.Name = "userInp";
            userInp.Size = new Size(212, 32);
            userInp.TabIndex = 0;
            // 
            // userImg
            // 
            userImg.Anchor = AnchorStyles.None;
            userImg.BackgroundImageLayout = ImageLayout.Center;
            userImg.Image = Properties.Resources.user;
            userImg.InitialImage = null;
            userImg.Location = new Point(3, 3);
            userImg.Name = "userImg";
            userImg.Size = new Size(95, 114);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 1;
            userImg.TabStop = false;
            // 
            // btnSumbit
            // 
            btnSumbit.Anchor = AnchorStyles.None;
            btnSumbit.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumbit.ForeColor = Color.Black;
            btnSumbit.Location = new Point(83, 379);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(181, 42);
            btnSumbit.TabIndex = 4;
            btnSumbit.Text = "Ingresar";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginDiv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            loginDiv.ResumeLayout(false);
            loginDiv.PerformLayout();
            passwrdDiv.ResumeLayout(false);
            PasswrdInpDiv.ResumeLayout(false);
            PasswrdInpDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwrdImg).EndInit();
            userDiv.ResumeLayout(false);
            UserInpDiv.ResumeLayout(false);
            UserInpDiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginDiv;
        private Label inpTxt;
        private Label wlcTxt;
        private TableLayoutPanel userDiv;
        private TableLayoutPanel passwrdDiv;
        private Button btnSumbit;
        private GroupBox UserInpDiv;
        private GroupBox PasswrdInpDiv;
        private TextBox userInp;
        private TextBox passwrdInp;
        private PictureBox userImg;
        private PictureBox passwrdImg;
    }
}
