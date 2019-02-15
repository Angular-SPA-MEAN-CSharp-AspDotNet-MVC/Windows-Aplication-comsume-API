namespace WindowsFormsCrudApi
{
    partial class Form2
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
            this.closeModalBtn = new System.Windows.Forms.Button();
            this.modalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeModalBtn
            // 
            this.closeModalBtn.Location = new System.Drawing.Point(223, 221);
            this.closeModalBtn.Name = "closeModalBtn";
            this.closeModalBtn.Size = new System.Drawing.Size(75, 23);
            this.closeModalBtn.TabIndex = 0;
            this.closeModalBtn.Text = "Close";
            this.closeModalBtn.UseVisualStyleBackColor = true;
            this.closeModalBtn.Click += new System.EventHandler(this.CloseModalBtn_Click);
            // 
            // modalLbl
            // 
            this.modalLbl.AutoSize = true;
            this.modalLbl.Location = new System.Drawing.Point(136, 105);
            this.modalLbl.Name = "modalLbl";
            this.modalLbl.Size = new System.Drawing.Size(35, 13);
            this.modalLbl.TabIndex = 1;
            this.modalLbl.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 286);
            this.Controls.Add(this.modalLbl);
            this.Controls.Add(this.closeModalBtn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeModalBtn;
        private System.Windows.Forms.Label modalLbl;
    }
}