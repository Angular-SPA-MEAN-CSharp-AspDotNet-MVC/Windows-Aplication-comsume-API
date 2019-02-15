namespace WindowsFormsCrudApi
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
            this.label1 = new System.Windows.Forms.Label();
            this.ApiTextBox = new System.Windows.Forms.TextBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.comboBoxDDL = new System.Windows.Forms.ComboBox();
            this.postBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plese input the API URI, or use the default value:";
            // 
            // ApiTextBox
            // 
            this.ApiTextBox.Location = new System.Drawing.Point(102, 86);
            this.ApiTextBox.Name = "ApiTextBox";
            this.ApiTextBox.Size = new System.Drawing.Size(236, 20);
            this.ApiTextBox.TabIndex = 1;
            this.ApiTextBox.Text = "http://localhost:21884/api/Emerson";
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(365, 86);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(75, 23);
            this.getBtn.TabIndex = 2;
            this.getBtn.Text = "GET";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.GetBtn_Click);
            // 
            // comboBoxDDL
            // 
            this.comboBoxDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDDL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDDL.FormattingEnabled = true;
            this.comboBoxDDL.Location = new System.Drawing.Point(102, 136);
            this.comboBoxDDL.Name = "comboBoxDDL";
            this.comboBoxDDL.Size = new System.Drawing.Size(236, 21);
            this.comboBoxDDL.TabIndex = 3;
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(365, 133);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(75, 23);
            this.postBtn.TabIndex = 4;
            this.postBtn.Text = "POST";
            this.postBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.comboBoxDDL);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.ApiTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApiTextBox;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.ComboBox comboBoxDDL;
        private System.Windows.Forms.Button postBtn;
    }
}

