namespace MineData
{
    partial class Form1
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
            this.textPropName = new System.Windows.Forms.TextBox();
            this.textPropValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listProp = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTopic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewTopic = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPropName
            // 
            this.textPropName.Location = new System.Drawing.Point(6, 56);
            this.textPropName.Name = "textPropName";
            this.textPropName.Size = new System.Drawing.Size(171, 22);
            this.textPropName.TabIndex = 1;
            // 
            // textPropValue
            // 
            this.textPropValue.Location = new System.Drawing.Point(207, 56);
            this.textPropValue.Name = "textPropValue";
            this.textPropValue.Size = new System.Drawing.Size(171, 22);
            this.textPropValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textPropName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPropValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(26, 150);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(171, 22);
            this.textName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(227, 150);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(171, 22);
            this.dateTime.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Property";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listProp
            // 
            this.listProp.FormattingEnabled = true;
            this.listProp.ItemHeight = 16;
            this.listProp.Location = new System.Drawing.Point(26, 339);
            this.listProp.Name = "listProp";
            this.listProp.Size = new System.Drawing.Size(529, 84);
            this.listProp.TabIndex = 12;
            this.listProp.SelectedIndexChanged += new System.EventHandler(this.listProp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Properties";
            // 
            // comboTopic
            // 
            this.comboTopic.FormattingEnabled = true;
            this.comboTopic.Location = new System.Drawing.Point(113, 17);
            this.comboTopic.Name = "comboTopic";
            this.comboTopic.Size = new System.Drawing.Size(121, 24);
            this.comboTopic.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pick a topic:";
            // 
            // btnNewTopic
            // 
            this.btnNewTopic.Location = new System.Drawing.Point(293, 14);
            this.btnNewTopic.Name = "btnNewTopic";
            this.btnNewTopic.Size = new System.Drawing.Size(105, 29);
            this.btnNewTopic.TabIndex = 16;
            this.btnNewTopic.Text = "Add Topic";
            this.btnNewTopic.UseVisualStyleBackColor = true;
            this.btnNewTopic.Click += new System.EventHandler(this.btnNewTopic_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(677, 12);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(111, 29);
            this.btnViewAll.TabIndex = 17;
            this.btnViewAll.Text = "View Data";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::MineData.Properties.Resources.check;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(711, 361);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.Location = new System.Drawing.Point(404, 14);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(105, 29);
            this.btnDeleteTopic.TabIndex = 18;
            this.btnDeleteTopic.Text = "Delete Topic";
            this.btnDeleteTopic.UseVisualStyleBackColor = true;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnNewTopic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTopic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listProp);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textPropName;
        private System.Windows.Forms.TextBox textPropValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listProp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewTopic;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnDeleteTopic;
    }
}

