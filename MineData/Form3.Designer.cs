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
            this.lblCount = new MaterialSkin.Controls.MaterialLabel();
            this.lblNoOfProps = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPropValue = new MaterialSkin.Controls.MaterialLabel();
            this.textCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textNoPops = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPropName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPropValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbProp = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbValue = new MaterialSkin.Controls.MaterialRadioButton();
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPropName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(12, 366);
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
            this.materialDivider1.Location = new System.Drawing.Point(12, 130);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(647, 154);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "FIlter by:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblCount.Depth = 0;
            this.lblCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(21, 165);
            this.lblCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 24);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Data count";
            // 
            // lblNoOfProps
            // 
            this.lblNoOfProps.AutoSize = true;
            this.lblNoOfProps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblNoOfProps.Depth = 0;
            this.lblNoOfProps.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoOfProps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoOfProps.Location = new System.Drawing.Point(233, 141);
            this.lblNoOfProps.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoOfProps.Name = "lblNoOfProps";
            this.lblNoOfProps.Size = new System.Drawing.Size(119, 48);
            this.lblNoOfProps.TabIndex = 6;
            this.lblNoOfProps.Text = "Number \r\nof properties\r\n";
            this.lblNoOfProps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(453, 165);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblPropValue
            // 
            this.lblPropValue.AutoSize = true;
            this.lblPropValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblPropValue.Depth = 0;
            this.lblPropValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPropValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropValue.Location = new System.Drawing.Point(233, 165);
            this.lblPropValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropValue.Name = "lblPropValue";
            this.lblPropValue.Size = new System.Drawing.Size(57, 24);
            this.lblPropValue.TabIndex = 8;
            this.lblPropValue.Text = "Value";
            this.lblPropValue.Visible = false;
            // 
            // textCount
            // 
            this.textCount.BackColor = System.Drawing.Color.White;
            this.textCount.Depth = 0;
            this.textCount.Hint = "";
            this.textCount.Location = new System.Drawing.Point(25, 199);
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
            this.textNoPops.Location = new System.Drawing.Point(237, 199);
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
            this.textPropName.Location = new System.Drawing.Point(25, 199);
            this.textPropName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropName.Name = "textPropName";
            this.textPropName.PasswordChar = '\0';
            this.textPropName.SelectedText = "";
            this.textPropName.SelectionLength = 0;
            this.textPropName.SelectionStart = 0;
            this.textPropName.Size = new System.Drawing.Size(157, 28);
            this.textPropName.TabIndex = 12;
            this.textPropName.UseSystemPasswordChar = false;
            this.textPropName.Visible = false;
            // 
            // textPropValue
            // 
            this.textPropValue.Depth = 0;
            this.textPropValue.Hint = "";
            this.textPropValue.Location = new System.Drawing.Point(237, 199);
            this.textPropValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropValue.Name = "textPropValue";
            this.textPropValue.PasswordChar = '\0';
            this.textPropValue.SelectedText = "";
            this.textPropValue.SelectionLength = 0;
            this.textPropValue.SelectionStart = 0;
            this.textPropValue.Size = new System.Drawing.Size(157, 28);
            this.textPropValue.TabIndex = 13;
            this.textPropValue.UseSystemPasswordChar = false;
            this.textPropValue.Visible = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(554, 290);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Export";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rbProp
            // 
            this.rbProp.AutoSize = true;
            this.rbProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.rbProp.Depth = 0;
            this.rbProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbProp.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbProp.Location = new System.Drawing.Point(256, 94);
            this.rbProp.Margin = new System.Windows.Forms.Padding(0);
            this.rbProp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbProp.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbProp.Name = "rbProp";
            this.rbProp.Ripple = true;
            this.rbProp.Size = new System.Drawing.Size(96, 30);
            this.rbProp.TabIndex = 15;
            this.rbProp.Text = "Property";
            this.rbProp.UseVisualStyleBackColor = false;
            this.rbProp.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbValue
            // 
            this.rbValue.AutoSize = true;
            this.rbValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.rbValue.Checked = true;
            this.rbValue.Depth = 0;
            this.rbValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbValue.Location = new System.Drawing.Point(135, 94);
            this.rbValue.Margin = new System.Windows.Forms.Padding(0);
            this.rbValue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbValue.Name = "rbValue";
            this.rbValue.Ripple = true;
            this.rbValue.Size = new System.Drawing.Size(74, 30);
            this.rbValue.TabIndex = 16;
            this.rbValue.TabStop = true;
            this.rbValue.Text = "Value";
            this.rbValue.UseVisualStyleBackColor = false;
            this.rbValue.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // textName
            // 
            this.textName.Depth = 0;
            this.textName.Hint = "";
            this.textName.Location = new System.Drawing.Point(457, 199);
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(157, 28);
            this.textName.TabIndex = 17;
            this.textName.UseSystemPasswordChar = false;
            // 
            // lblPropName
            // 
            this.lblPropName.AutoSize = true;
            this.lblPropName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblPropName.Depth = 0;
            this.lblPropName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPropName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropName.Location = new System.Drawing.Point(21, 165);
            this.lblPropName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropName.Name = "lblPropName";
            this.lblPropName.Size = new System.Drawing.Size(61, 24);
            this.lblPropName.TabIndex = 18;
            this.lblPropName.Text = "Name";
            this.lblPropName.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(672, 662);
            this.Controls.Add(this.lblPropName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.rbValue);
            this.Controls.Add(this.rbProp);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textPropValue);
            this.Controls.Add(this.textPropName);
            this.Controls.Add(this.textNoPops);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.lblPropValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNoOfProps);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.list);
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
        private MaterialSkin.Controls.MaterialLabel lblCount;
        private MaterialSkin.Controls.MaterialLabel lblNoOfProps;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblPropValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textCount;
        private MaterialSkin.Controls.MaterialSingleLineTextField textNoPops;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropValue;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRadioButton rbProp;
        private MaterialSkin.Controls.MaterialRadioButton rbValue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private MaterialSkin.Controls.MaterialLabel lblPropName;
    }
}