namespace MineData
{
    partial class EditForm
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
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.comboProp = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.textPropName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textPropValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddProp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(12, 101);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(647, 284);
            this.list.TabIndex = 1;
            this.list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseClick);
            
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 412);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(647, 311);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(377, 412);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(5, 311);
            this.materialDivider2.TabIndex = 5;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(38, 471);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(38, 520);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Date:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(38, 566);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Properties:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(162, 471);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(162, 520);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 24);
            this.lblDate.TabIndex = 10;
            // 
            // comboProp
            // 
            this.comboProp.BackColor = System.Drawing.Color.White;
            this.comboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProp.FormattingEnabled = true;
            this.comboProp.Location = new System.Drawing.Point(166, 565);
            this.comboProp.Name = "comboProp";
            this.comboProp.Size = new System.Drawing.Size(168, 28);
            this.comboProp.TabIndex = 15;
            this.comboProp.SelectedIndexChanged += new System.EventHandler(this.comboProp_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(413, 422);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 24);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "New values";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textName.Depth = 0;
            this.textName.Hint = "";
            this.textName.Location = new System.Drawing.Point(417, 471);
            this.textName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.SelectedText = "";
            this.textName.SelectionLength = 0;
            this.textName.SelectionStart = 0;
            this.textName.Size = new System.Drawing.Size(141, 28);
            this.textName.TabIndex = 37;
            this.textName.UseSystemPasswordChar = false;
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(417, 520);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(222, 27);
            this.dateTime.TabIndex = 36;
            // 
            // textPropName
            // 
            this.textPropName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPropName.Depth = 0;
            this.textPropName.Hint = "";
            this.textPropName.Location = new System.Drawing.Point(498, 567);
            this.textPropName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropName.Name = "textPropName";
            this.textPropName.PasswordChar = '\0';
            this.textPropName.SelectedText = "";
            this.textPropName.SelectionLength = 0;
            this.textPropName.SelectionStart = 0;
            this.textPropName.Size = new System.Drawing.Size(141, 28);
            this.textPropName.TabIndex = 38;
            this.textPropName.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(415, 566);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(66, 24);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Name:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(415, 601);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 24);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = "Value";
            // 
            // textPropValue
            // 
            this.textPropValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPropValue.Depth = 0;
            this.textPropValue.Hint = "";
            this.textPropValue.Location = new System.Drawing.Point(498, 601);
            this.textPropValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPropValue.Name = "textPropValue";
            this.textPropValue.PasswordChar = '\0';
            this.textPropValue.SelectedText = "";
            this.textPropValue.SelectionLength = 0;
            this.textPropValue.SelectionStart = 0;
            this.textPropValue.Size = new System.Drawing.Size(141, 28);
            this.textPropValue.TabIndex = 41;
            this.textPropValue.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(576, 665);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(63, 39);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Depth = 0;
            this.btnAddProp.Location = new System.Drawing.Point(417, 665);
            this.btnAddProp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Primary = true;
            this.btnAddProp.Size = new System.Drawing.Size(141, 39);
            this.btnAddProp.TabIndex = 43;
            this.btnAddProp.Text = "ADD Property";
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(193, 665);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(141, 39);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Detlete item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(672, 736);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPropValue);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.textPropName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.comboProp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.list);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private System.Windows.Forms.ComboBox comboProp;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textName;
        private System.Windows.Forms.DateTimePicker dateTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropName;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textPropValue;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddProp;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
    }
}