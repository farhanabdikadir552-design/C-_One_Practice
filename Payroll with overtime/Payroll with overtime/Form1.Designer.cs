namespace Payroll_with_overtime
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
            this.txthourswork = new System.Windows.Forms.TextBox();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txthourlypayrate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txthourswork
            // 
            this.txthourswork.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourswork.Location = new System.Drawing.Point(305, 68);
            this.txthourswork.Multiline = true;
            this.txthourswork.Name = "txthourswork";
            this.txthourswork.Size = new System.Drawing.Size(209, 48);
            this.txthourswork.TabIndex = 10;
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore2.Location = new System.Drawing.Point(69, 152);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(228, 37);
            this.lblscore2.TabIndex = 9;
            this.lblscore2.Text = "hourly pay rate";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(69, 71);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(210, 37);
            this.lblscore1.TabIndex = 8;
            this.lblscore1.Text = "hours worked";
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspay.Location = new System.Drawing.Point(305, 268);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(278, 76);
            this.lblgrosspay.TabIndex = 13;
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.Location = new System.Drawing.Point(123, 268);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(156, 37);
            this.lblaverage.TabIndex = 12;
            this.lblaverage.Text = "gross pay";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(352, 387);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 81);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(562, 387);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 81);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(128, 387);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(120, 81);
            this.btncalculate.TabIndex = 14;
            this.btncalculate.Text = "calculate gross pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txthourlypayrate
            // 
            this.txthourlypayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourlypayrate.Location = new System.Drawing.Point(305, 152);
            this.txthourlypayrate.Multiline = true;
            this.txthourlypayrate.Name = "txthourlypayrate";
            this.txthourlypayrate.Size = new System.Drawing.Size(209, 48);
            this.txthourlypayrate.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 528);
            this.Controls.Add(this.txthourlypayrate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.txthourswork);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txthourswork;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txthourlypayrate;
    }
}

