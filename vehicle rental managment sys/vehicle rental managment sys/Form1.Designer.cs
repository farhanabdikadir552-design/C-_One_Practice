namespace vehicle_rental_managment_sys
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
            this.grpcustomer = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblexperience = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.grpvehicle = new System.Windows.Forms.GroupBox();
            this.rdEconomy = new System.Windows.Forms.RadioButton();
            this.rdluxury = new System.Windows.Forms.RadioButton();
            this.rdsuv = new System.Windows.Forms.RadioButton();
            this.grpinsurance = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.piceconomy = new System.Windows.Forms.PictureBox();
            this.picsuv = new System.Windows.Forms.PictureBox();
            this.picluxury = new System.Windows.Forms.PictureBox();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.grpcustomer.SuspendLayout();
            this.grpvehicle.SuspendLayout();
            this.grpinsurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piceconomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsuv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picluxury)).BeginInit();
            this.SuspendLayout();
            // 
            // grpcustomer
            // 
            this.grpcustomer.Controls.Add(this.txtexperience);
            this.grpcustomer.Controls.Add(this.txtdays);
            this.grpcustomer.Controls.Add(this.txtage);
            this.grpcustomer.Controls.Add(this.txtname);
            this.grpcustomer.Controls.Add(this.lbldays);
            this.grpcustomer.Controls.Add(this.lblexperience);
            this.grpcustomer.Controls.Add(this.lblage);
            this.grpcustomer.Controls.Add(this.lblname);
            this.grpcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpcustomer.Location = new System.Drawing.Point(5, 10);
            this.grpcustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpcustomer.Name = "grpcustomer";
            this.grpcustomer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpcustomer.Size = new System.Drawing.Size(387, 199);
            this.grpcustomer.TabIndex = 0;
            this.grpcustomer.TabStop = false;
            this.grpcustomer.Text = "customer information";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(5, 46);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(132, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "customer name";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(5, 89);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(118, 20);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "customer age";
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperience.Location = new System.Drawing.Point(5, 170);
            this.lblexperience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(212, 20);
            this.lblexperience.TabIndex = 2;
            this.lblexperience.Text = "years of driving exprience";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(5, 133);
            this.lbldays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(183, 20);
            this.lbldays.TabIndex = 3;
            this.lbldays.Text = "number of rental days";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(180, 38);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 30);
            this.txtname.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(180, 83);
            this.txtage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(192, 30);
            this.txtage.TabIndex = 5;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(180, 125);
            this.txtdays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(192, 30);
            this.txtdays.TabIndex = 6;
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(180, 162);
            this.txtexperience.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(192, 30);
            this.txtexperience.TabIndex = 7;
            // 
            // grpvehicle
            // 
            this.grpvehicle.Controls.Add(this.picluxury);
            this.grpvehicle.Controls.Add(this.picsuv);
            this.grpvehicle.Controls.Add(this.piceconomy);
            this.grpvehicle.Controls.Add(this.rdsuv);
            this.grpvehicle.Controls.Add(this.rdluxury);
            this.grpvehicle.Controls.Add(this.rdEconomy);
            this.grpvehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpvehicle.Location = new System.Drawing.Point(12, 222);
            this.grpvehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpvehicle.Name = "grpvehicle";
            this.grpvehicle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpvehicle.Size = new System.Drawing.Size(548, 210);
            this.grpvehicle.TabIndex = 8;
            this.grpvehicle.TabStop = false;
            this.grpvehicle.Text = "vehicle type";
            // 
            // rdEconomy
            // 
            this.rdEconomy.AutoSize = true;
            this.rdEconomy.Location = new System.Drawing.Point(5, 35);
            this.rdEconomy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdEconomy.Name = "rdEconomy";
            this.rdEconomy.Size = new System.Drawing.Size(124, 29);
            this.rdEconomy.TabIndex = 0;
            this.rdEconomy.TabStop = true;
            this.rdEconomy.Text = "economy";
            this.rdEconomy.UseVisualStyleBackColor = true;
            // 
            // rdluxury
            // 
            this.rdluxury.AutoSize = true;
            this.rdluxury.Location = new System.Drawing.Point(402, 35);
            this.rdluxury.Margin = new System.Windows.Forms.Padding(2);
            this.rdluxury.Name = "rdluxury";
            this.rdluxury.Size = new System.Drawing.Size(95, 29);
            this.rdluxury.TabIndex = 1;
            this.rdluxury.TabStop = true;
            this.rdluxury.Text = "luxury";
            this.rdluxury.UseVisualStyleBackColor = true;
            // 
            // rdsuv
            // 
            this.rdsuv.AutoSize = true;
            this.rdsuv.Location = new System.Drawing.Point(222, 35);
            this.rdsuv.Margin = new System.Windows.Forms.Padding(2);
            this.rdsuv.Name = "rdsuv";
            this.rdsuv.Size = new System.Drawing.Size(71, 29);
            this.rdsuv.TabIndex = 2;
            this.rdsuv.TabStop = true;
            this.rdsuv.Text = "suv";
            this.rdsuv.UseVisualStyleBackColor = true;
            // 
            // grpinsurance
            // 
            this.grpinsurance.Controls.Add(this.chkinsurance);
            this.grpinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpinsurance.Location = new System.Drawing.Point(14, 436);
            this.grpinsurance.Margin = new System.Windows.Forms.Padding(2);
            this.grpinsurance.Name = "grpinsurance";
            this.grpinsurance.Padding = new System.Windows.Forms.Padding(2);
            this.grpinsurance.Size = new System.Drawing.Size(546, 106);
            this.grpinsurance.TabIndex = 9;
            this.grpinsurance.TabStop = false;
            this.grpinsurance.Text = "insurance option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinsurance.Location = new System.Drawing.Point(30, 42);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(357, 33);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "add insurance($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(12, 547);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(160, 69);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(205, 547);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 69);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(400, 547);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 69);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // piceconomy
            // 
            this.piceconomy.Image = ((System.Drawing.Image)(resources.GetObject("piceconomy.Image")));
            this.piceconomy.Location = new System.Drawing.Point(15, 84);
            this.piceconomy.Name = "piceconomy";
            this.piceconomy.Size = new System.Drawing.Size(132, 105);
            this.piceconomy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piceconomy.TabIndex = 3;
            this.piceconomy.TabStop = false;
            // 
            // picsuv
            // 
            this.picsuv.Image = ((System.Drawing.Image)(resources.GetObject("picsuv.Image")));
            this.picsuv.Location = new System.Drawing.Point(203, 84);
            this.picsuv.Name = "picsuv";
            this.picsuv.Size = new System.Drawing.Size(132, 105);
            this.picsuv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsuv.TabIndex = 4;
            this.picsuv.TabStop = false;
            // 
            // picluxury
            // 
            this.picluxury.Image = ((System.Drawing.Image)(resources.GetObject("picluxury.Image")));
            this.picluxury.Location = new System.Drawing.Point(388, 84);
            this.picluxury.Name = "picluxury";
            this.picluxury.Size = new System.Drawing.Size(132, 105);
            this.picluxury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picluxury.TabIndex = 5;
            this.picluxury.TabStop = false;
            // 
            // lstresult
            // 
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 20;
            this.lstresult.Location = new System.Drawing.Point(591, 36);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(520, 604);
            this.lstresult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 661);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.grpinsurance);
            this.Controls.Add(this.grpvehicle);
            this.Controls.Add(this.grpcustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "vehicle rental managment system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpcustomer.ResumeLayout(false);
            this.grpcustomer.PerformLayout();
            this.grpvehicle.ResumeLayout(false);
            this.grpvehicle.PerformLayout();
            this.grpinsurance.ResumeLayout(false);
            this.grpinsurance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piceconomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsuv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picluxury)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpcustomer;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox grpvehicle;
        private System.Windows.Forms.RadioButton rdsuv;
        private System.Windows.Forms.RadioButton rdluxury;
        private System.Windows.Forms.RadioButton rdEconomy;
        private System.Windows.Forms.GroupBox grpinsurance;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox piceconomy;
        private System.Windows.Forms.PictureBox picluxury;
        private System.Windows.Forms.PictureBox picsuv;
        private System.Windows.Forms.ListBox lstresult;
    }
}

