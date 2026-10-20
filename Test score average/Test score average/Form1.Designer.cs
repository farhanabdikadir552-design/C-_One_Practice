namespace Test_score_average
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
            this.entergroupBox = new System.Windows.Forms.GroupBox();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblaverageresulte = new System.Windows.Forms.Label();
            this.entergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // entergroupBox
            // 
            this.entergroupBox.Controls.Add(this.lblaverageresulte);
            this.entergroupBox.Controls.Add(this.txtscore2);
            this.entergroupBox.Controls.Add(this.txtscore3);
            this.entergroupBox.Controls.Add(this.txtscore1);
            this.entergroupBox.Controls.Add(this.lblaverage);
            this.entergroupBox.Controls.Add(this.lblscore2);
            this.entergroupBox.Controls.Add(this.lblscore3);
            this.entergroupBox.Controls.Add(this.lblscore1);
            this.entergroupBox.Location = new System.Drawing.Point(32, 40);
            this.entergroupBox.Name = "entergroupBox";
            this.entergroupBox.Size = new System.Drawing.Size(731, 349);
            this.entergroupBox.TabIndex = 0;
            this.entergroupBox.TabStop = false;
            this.entergroupBox.Text = "enter three test scores";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore1.Location = new System.Drawing.Point(77, 67);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(180, 37);
            this.lblscore1.TabIndex = 0;
            this.lblscore1.Text = "test score 1";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore3.Location = new System.Drawing.Point(77, 179);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(182, 37);
            this.lblscore3.TabIndex = 1;
            this.lblscore3.Text = "test score 3";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore2.Location = new System.Drawing.Point(77, 122);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(182, 37);
            this.lblscore2.TabIndex = 2;
            this.lblscore2.Text = "test score 2";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.Location = new System.Drawing.Point(210, 238);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(131, 37);
            this.lblaverage.TabIndex = 3;
            this.lblaverage.Text = "average";
            // 
            // txtscore1
            // 
            this.txtscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore1.Location = new System.Drawing.Point(292, 78);
            this.txtscore1.Multiline = true;
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(166, 26);
            this.txtscore1.TabIndex = 5;
            // 
            // txtscore3
            // 
            this.txtscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore3.Location = new System.Drawing.Point(292, 190);
            this.txtscore3.Multiline = true;
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(166, 26);
            this.txtscore3.TabIndex = 6;
            // 
            // txtscore2
            // 
            this.txtscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore2.Location = new System.Drawing.Point(292, 133);
            this.txtscore2.Multiline = true;
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(166, 26);
            this.txtscore2.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(146, 420);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(120, 81);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "calculate average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(580, 420);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 81);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(370, 420);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 81);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblaverageresulte
            // 
            this.lblaverageresulte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverageresulte.Location = new System.Drawing.Point(347, 238);
            this.lblaverageresulte.Name = "lblaverageresulte";
            this.lblaverageresulte.Size = new System.Drawing.Size(156, 37);
            this.lblaverageresulte.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.entergroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.entergroupBox.ResumeLayout(false);
            this.entergroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox entergroupBox;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblaverageresulte;
    }
}

