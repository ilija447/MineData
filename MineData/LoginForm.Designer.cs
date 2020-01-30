namespace MineData
{
    partial class LoginForm
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
            this.UsernameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.TextUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.logIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Register = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.devTopic = new MaterialSkin.Controls.MaterialDivider();
            this.lblTopic = new MaterialSkin.Controls.MaterialLabel();
            this.comboTopic = new System.Windows.Forms.ComboBox();
            this.btnTopic = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsernameLbl.Depth = 0;
            this.UsernameLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLbl.Location = new System.Drawing.Point(457, 146);
            this.UsernameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(95, 24);
            this.UsernameLbl.TabIndex = 0;
            this.UsernameLbl.Text = "Username";
            this.UsernameLbl.Click += new System.EventHandler(this.Username_Click);
            // 
            // TextUsername
            // 
            this.TextUsername.Depth = 0;
            this.TextUsername.Hint = "";
            this.TextUsername.Location = new System.Drawing.Point(461, 184);
            this.TextUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.PasswordChar = '\0';
            this.TextUsername.SelectedText = "";
            this.TextUsername.SelectionLength = 0;
            this.TextUsername.SelectionStart = 0;
            this.TextUsername.Size = new System.Drawing.Size(254, 28);
            this.TextUsername.TabIndex = 1;
            this.TextUsername.UseSystemPasswordChar = false;
            // 
            // textPassword
            // 
            this.textPassword.Depth = 0;
            this.textPassword.Hint = "";
            this.textPassword.Location = new System.Drawing.Point(461, 261);
            this.textPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.Size = new System.Drawing.Size(254, 28);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(457, 224);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Password";
            // 
            // logIn
            // 
            this.logIn.Depth = 0;
            this.logIn.Location = new System.Drawing.Point(618, 312);
            this.logIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logIn.Name = "logIn";
            this.logIn.Primary = true;
            this.logIn.Size = new System.Drawing.Size(97, 45);
            this.logIn.TabIndex = 4;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Register.Depth = 0;
            this.Register.Location = new System.Drawing.Point(461, 312);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.Register.Name = "Register";
            this.Register.Primary = false;
            this.Register.Size = new System.Drawing.Size(91, 36);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(420, 106);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(332, 278);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(1074, 652);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton2.TabIndex = 8;
            this.materialFlatButton2.Text = "Close";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // devTopic
            // 
            this.devTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.devTopic.Depth = 0;
            this.devTopic.Location = new System.Drawing.Point(420, 426);
            this.devTopic.MouseState = MaterialSkin.MouseState.HOVER;
            this.devTopic.Name = "devTopic";
            this.devTopic.Size = new System.Drawing.Size(332, 126);
            this.devTopic.TabIndex = 9;
            this.devTopic.Text = "materialDivider2";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTopic.Depth = 0;
            this.lblTopic.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTopic.Location = new System.Drawing.Point(457, 442);
            this.lblTopic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(110, 24);
            this.lblTopic.TabIndex = 10;
            this.lblTopic.Text = "Pick a topic";
            this.lblTopic.Visible = false;
            // 
            // comboTopic
            // 
            this.comboTopic.BackColor = System.Drawing.Color.White;
            this.comboTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTopic.FormattingEnabled = true;
            this.comboTopic.Location = new System.Drawing.Point(461, 497);
            this.comboTopic.Name = "comboTopic";
            this.comboTopic.Size = new System.Drawing.Size(174, 28);
            this.comboTopic.TabIndex = 15;
            this.comboTopic.Visible = false;
            this.comboTopic.SelectedIndexChanged += new System.EventHandler(this.comboTopic_SelectedIndexChanged);
            // 
            // btnTopic
            // 
            this.btnTopic.Depth = 0;
            this.btnTopic.Location = new System.Drawing.Point(673, 493);
            this.btnTopic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Primary = true;
            this.btnTopic.Size = new System.Drawing.Size(57, 36);
            this.btnTopic.TabIndex = 16;
            this.btnTopic.Text = "Go";
            this.btnTopic.UseVisualStyleBackColor = true;
            this.btnTopic.Visible = false;
            this.btnTopic.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MineData.Properties.Resources.Home_Final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btnTopic);
            this.Controls.Add(this.comboTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.devTopic);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 750);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel UsernameLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton logIn;
        private MaterialSkin.Controls.MaterialFlatButton Register;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialDivider devTopic;
        private MaterialSkin.Controls.MaterialLabel lblTopic;
        private System.Windows.Forms.ComboBox comboTopic;
        private MaterialSkin.Controls.MaterialRaisedButton btnTopic;
    }
}