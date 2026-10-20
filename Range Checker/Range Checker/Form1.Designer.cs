namespace Range_Checker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrangedecision = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.Controls.Add(this.lblrangedecision);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtrange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "range checker application";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter an integer in the range of 1 throught 10";
            // 
            // txtrange
            // 
            this.txtrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrange.Location = new System.Drawing.Point(169, 117);
            this.txtrange.Name = "txtrange";
            this.txtrange.Size = new System.Drawing.Size(278, 39);
            this.txtrange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "range decision";
            // 
            // lblrangedecision
            // 
            this.lblrangedecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangedecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrangedecision.Location = new System.Drawing.Point(50, 243);
            this.lblrangedecision.Name = "lblrangedecision";
            this.lblrangedecision.Size = new System.Drawing.Size(568, 60);
            this.lblrangedecision.TabIndex = 3;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(273, 331);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 81);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(483, 331);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 81);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(49, 331);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(162, 81);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "check qualfication";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblrangedecision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrange;
    }
}

