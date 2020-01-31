namespace MineData
{
    partial class Form3
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
            this.list = new System.Windows.Forms.ListBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textNoPops = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPropName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPropValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(12, 364);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(647, 284);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.list_Format);
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 99);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(647, 245);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Export options";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 160);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Count";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(233, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 48);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Number \r\nof properties\r\n";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(169, 272);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(337, 272);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 24);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Value";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(21, 303);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(124, 24);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "With Property";
            // 
            // textCount
            // 
            this.textCount.BackColor = System.Drawing.Color.White;
            this.textCount.Depth = 0;
            this.textCount.Hint = "";
            this.textCount.Location = new System.Drawing.Point(25, 198);
            this.textCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.textCount.Name = "textCount";
            this.textCount.PasswordChar = '\0';
            this.textCount.SelectedText = "";
            this.textCount.SelectionLength = 0;
            this.textCount.SelectionStart = 0;
            this.textCount.Size = new System.Drawing.Size(157, 28);
            this.textCount.TabIndex = 10;
            this.textCount.UseSystemPasswordChar = false;
            // 
            // textNoPops
            // 
            this.textNoPops.Depth = 0;
            this.textNoPops.Hint = "";
            this.textNoPops.Location = new System.Drawing.Point(237, 198);
            this.textNoPops.MouseState = MaterialSkin.MouseState.HOVER;
            this.textNoPops.Name = "textNoPops";
            this.textNoPops.PasswordChar = '\0';
            this.textNoPops.SelectedText = "";
            this.textNoPops.SelectionLength = 0;
            this.textNoPops.SelectionStart = 0;
            this.textNoPops.Size = new System.Drawing.Size(157, 28);
            this.textNoPops.TabIndex = 11;
            this.textNoPops.UseSystemPasswordChar = false;
            // 
            // textPropName
            // 
            this.textPropName.Depth = 0;
            this.textPropName.Hint = "";
            this.textPropName.Location = new System.Drawing.Point(164, 299);
            this.textPropName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropName.Name = "textPropName";
            this.textPropName.PasswordChar = '\0';
            this.textPropName.SelectedText = "";
            this.textPropName.SelectionLength = 0;
            this.textPropName.SelectionStart = 0;
            this.textPropName.Size = new System.Drawing.Size(134, 28);
            this.textPropName.TabIndex = 12;
            this.textPropName.UseSystemPasswordChar = false;
            // 
            // textPropValue
            // 
            this.textPropValue.Depth = 0;
            this.textPropValue.Hint = "";
            this.textPropValue.Location = new System.Drawing.Point(341, 299);
            this.textPropValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropValue.Name = "textPropValue";
            this.textPropValue.PasswordChar = '\0';
            this.textPropValue.SelectedText = "";
            this.textPropValue.SelectionLength = 0;
            this.textPropValue.SelectionStart = 0;
            this.textPropValue.Size = new System.Drawing.Size(134, 28);
            this.textPropValue.TabIndex = 13;
            this.textPropValue.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(544, 297);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Export";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(672, 662);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textPropValue);
            this.Controls.Add(this.textPropName);
            this.Controls.Add(this.textNoPops);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.list);
            this.MaximumSize = new System.Drawing.Size(672, 662);
            this.MinimumSize = new System.Drawing.Size(672, 662);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCount;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNoPops;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropValue;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}