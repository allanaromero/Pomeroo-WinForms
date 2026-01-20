namespace Pomeroo
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShortRest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLongRest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCycleCount = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note: Enter time in mm:ss (or hh:mm:ss) format.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkTime
            // 
            this.txtWorkTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtWorkTime.Location = new System.Drawing.Point(117, 55);
            this.txtWorkTime.Name = "txtWorkTime";
            this.txtWorkTime.Size = new System.Drawing.Size(153, 22);
            this.txtWorkTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Short Rest";
            // 
            // txtShortRest
            // 
            this.txtShortRest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtShortRest.Location = new System.Drawing.Point(117, 99);
            this.txtShortRest.Name = "txtShortRest";
            this.txtShortRest.Size = new System.Drawing.Size(153, 22);
            this.txtShortRest.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Long Rest";
            // 
            // txtLongRest
            // 
            this.txtLongRest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLongRest.Location = new System.Drawing.Point(117, 137);
            this.txtLongRest.Name = "txtLongRest";
            this.txtLongRest.Size = new System.Drawing.Size(153, 22);
            this.txtLongRest.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cycle Count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCycleCount
            // 
            this.txtCycleCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCycleCount.Location = new System.Drawing.Point(117, 177);
            this.txtCycleCount.Name = "txtCycleCount";
            this.txtCycleCount.Size = new System.Drawing.Size(153, 22);
            this.txtCycleCount.TabIndex = 8;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(195, 218);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtCycleCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLongRest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShortRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWorkTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShortRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLongRest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCycleCount;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}