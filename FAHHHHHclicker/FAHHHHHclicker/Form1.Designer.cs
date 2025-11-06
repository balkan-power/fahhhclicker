namespace FAHHHHHclicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClickyButton = new System.Windows.Forms.Button();
            this.putsAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickyButton
            // 
            this.ClickyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClickyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClickyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickyButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClickyButton.Location = new System.Drawing.Point(12, 178);
            this.ClickyButton.Name = "ClickyButton";
            this.ClickyButton.Size = new System.Drawing.Size(776, 260);
            this.ClickyButton.TabIndex = 0;
            this.ClickyButton.Text = "CLICK!!!";
            this.ClickyButton.UseVisualStyleBackColor = false;
            this.ClickyButton.Click += new System.EventHandler(this.ClickyButton_Click);
            // 
            // putsAmount
            // 
            this.putsAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.putsAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.putsAmount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putsAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.putsAmount.Location = new System.Drawing.Point(12, 150);
            this.putsAmount.Name = "putsAmount";
            this.putsAmount.Size = new System.Drawing.Size(776, 25);
            this.putsAmount.TabIndex = 1;
            this.putsAmount.Text = "0";
            this.putsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount of people who got FAHHH\'d:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.putsAmount);
            this.Controls.Add(this.ClickyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FAHHHHHHHHHHHHHHHHHHHH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickyButton;
        private System.Windows.Forms.Label putsAmount;
        private System.Windows.Forms.Label label1;
    }
}

