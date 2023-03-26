namespace HomeWork7
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
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UserInfoLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.Location = new System.Drawing.Point(6, 28);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(245, 22);
            this.DatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть вашу дату народження:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(6, 56);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(245, 30);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Розрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CalculateButton_MouseClick);
            // 
            // UserInfoLable
            // 
            this.UserInfoLable.AutoSize = true;
            this.UserInfoLable.Location = new System.Drawing.Point(3, 105);
            this.UserInfoLable.Name = "UserInfoLable";
            this.UserInfoLable.Size = new System.Drawing.Size(0, 16);
            this.UserInfoLable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 233);
            this.Controls.Add(this.UserInfoLable);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label UserInfoLable;
    }
}

