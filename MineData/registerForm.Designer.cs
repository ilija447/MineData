namespace MineData
{
    partial class registerForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPass1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textPass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbUser = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbScietist = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textUsername.Depth = 0;
            this.textUsername.Hint = "";
            this.textUsername.Location = new System.Drawing.Point(27, 48);
            this.textUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.Size = new System.Drawing.Size(317, 28);
            this.textUsername.TabIndex = 1;
            this.textUsername.UseSystemPasswordChar = false;
            // 
            // textPass1
            // 
            this.textPass1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPass1.Depth = 0;
            this.textPass1.Hint = "";
            this.textPass1.Location = new System.Drawing.Point(27, 138);
            this.textPass1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPass1.Name = "textPass1";
            this.textPass1.PasswordChar = '*';
            this.textPass1.SelectedText = "";
            this.textPass1.SelectionLength = 0;
            this.textPass1.SelectionStart = 0;
            this.textPass1.Size = new System.Drawing.Size(317, 28);
            this.textPass1.TabIndex = 3;
            this.textPass1.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 111);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password";
            // 
            // textPass2
            // 
            this.textPass2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPass2.Depth = 0;
            this.textPass2.Hint = "";
            this.textPass2.Location = new System.Drawing.Point(27, 196);
            this.textPass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPass2.Name = "textPass2";
            this.textPass2.PasswordChar = '*';
            this.textPass2.SelectedText = "";
            this.textPass2.SelectionLength = 0;
            this.textPass2.SelectionStart = 0;
            this.textPass2.Size = new System.Drawing.Size(317, 28);
            this.textPass2.TabIndex = 5;
            this.textPass2.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(158, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Repeat Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(226, 330);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(118, 46);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Depth = 0;
            this.cbUser.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbUser.Location = new System.Drawing.Point(27, 248);
            this.cbUser.Margin = new System.Windows.Forms.Padding(0);
            this.cbUser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbUser.Name = "cbUser";
            this.cbUser.Ripple = true;
            this.cbUser.Size = new System.Drawing.Size(66, 30);
            this.cbUser.TabIndex = 7;
            this.cbUser.Text = "User";
            this.cbUser.UseVisualStyleBackColor = true;
            this.cbUser.CheckedChanged += new System.EventHandler(this.cbUser_CheckedChanged);
            // 
            // cbScietist
            // 
            this.cbScietist.AutoSize = true;
            this.cbScietist.Depth = 0;
            this.cbScietist.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbScietist.Location = new System.Drawing.Point(141, 248);
            this.cbScietist.Margin = new System.Windows.Forms.Padding(0);
            this.cbScietist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbScietist.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbScietist.Name = "cbScietist";
            this.cbScietist.Ripple = true;
            this.cbScietist.Size = new System.Drawing.Size(98, 30);
            this.cbScietist.TabIndex = 8;
            this.cbScietist.Text = "Scientist";
            this.cbScietist.UseVisualStyleBackColor = true;
            this.cbScietist.CheckedChanged += new System.EventHandler(this.cbScietist_CheckedChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(27, 335);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(78, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "Cancel";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(370, 400);
            this.ControlBox = false;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cbScietist);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textPass2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textPass1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.materialLabel1);
            this.MaximumSize = new System.Drawing.Size(388, 447);
            this.MinimumSize = new System.Drawing.Size(388, 447);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPass1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPass2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private MaterialSkin.Controls.MaterialCheckBox cbUser;
        private MaterialSkin.Controls.MaterialCheckBox cbScietist;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}