namespace hotel_room_booking_system
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
            this.lblinformation = new System.Windows.Forms.Label();
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblguest = new System.Windows.Forms.Label();
            this.lblnights = new System.Windows.Forms.Label();
            this.lblguestage = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.grproomtype = new System.Windows.Forms.GroupBox();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.grpoptions = new System.Windows.Forms.GroupBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.grproomtype.SuspendLayout();
            this.grpoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinformation
            // 
            this.lblinformation.AutoSize = true;
            this.lblinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformation.Location = new System.Drawing.Point(12, 9);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(207, 25);
            this.lblinformation.TabIndex = 0;
            this.lblinformation.Text = "personal information";
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestname.Location = new System.Drawing.Point(12, 72);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(124, 25);
            this.lblguestname.TabIndex = 1;
            this.lblguestname.Text = "guest name";
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguest.Location = new System.Drawing.Point(12, 231);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(167, 25);
            this.lblguest.TabIndex = 2;
            this.lblguest.Text = "number of guest";
            // 
            // lblnights
            // 
            this.lblnights.AutoSize = true;
            this.lblnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnights.Location = new System.Drawing.Point(12, 181);
            this.lblnights.Name = "lblnights";
            this.lblnights.Size = new System.Drawing.Size(172, 25);
            this.lblnights.TabIndex = 3;
            this.lblnights.Text = "number of nights";
            // 
            // lblguestage
            // 
            this.lblguestage.AutoSize = true;
            this.lblguestage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestage.Location = new System.Drawing.Point(17, 123);
            this.lblguestage.Name = "lblguestage";
            this.lblguestage.Size = new System.Drawing.Size(107, 25);
            this.lblguestage.TabIndex = 4;
            this.lblguestage.Text = "guest age";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(216, 61);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(267, 36);
            this.txtGuestName.TabIndex = 5;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(216, 224);
            this.txtGuests.Multiline = true;
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(267, 32);
            this.txtGuests.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(216, 172);
            this.txtNights.Multiline = true;
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(267, 34);
            this.txtNights.TabIndex = 8;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(216, 116);
            this.txtGuestAge.Multiline = true;
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(267, 32);
            this.txtGuestAge.TabIndex = 9;
            // 
            // grproomtype
            // 
            this.grproomtype.Controls.Add(this.rdoHight);
            this.grproomtype.Controls.Add(this.rdoNormal);
            this.grproomtype.Controls.Add(this.rdoStandard);
            this.grproomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grproomtype.Location = new System.Drawing.Point(22, 278);
            this.grproomtype.Name = "grproomtype";
            this.grproomtype.Size = new System.Drawing.Size(461, 124);
            this.grproomtype.TabIndex = 10;
            this.grproomtype.TabStop = false;
            this.grproomtype.Text = "room type";
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Location = new System.Drawing.Point(328, 55);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(78, 29);
            this.rdoHight.TabIndex = 2;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "high";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(174, 55);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(102, 29);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(15, 55);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(121, 29);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(25, 49);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(370, 29);
            this.chkBreakfast.TabIndex = 11;
            this.chkBreakfast.Text = "break fast(10 per guest per nights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // grpoptions
            // 
            this.grpoptions.Controls.Add(this.chkBreakfast);
            this.grpoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpoptions.Location = new System.Drawing.Point(22, 418);
            this.grpoptions.Name = "grpoptions";
            this.grpoptions.Size = new System.Drawing.Size(471, 100);
            this.grpoptions.TabIndex = 12;
            this.grpoptions.TabStop = false;
            this.grpoptions.Text = "additional options";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(22, 550);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(162, 65);
            this.btncalculate.TabIndex = 13;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(420, 550);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(162, 65);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(216, 550);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 65);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(588, 16);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(517, 604);
            this.lstBookingDetails.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 627);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.grpoptions);
            this.Controls.Add(this.grproomtype);
            this.Controls.Add(this.txtGuestAge);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblguestage);
            this.Controls.Add(this.lblnights);
            this.Controls.Add(this.lblguest);
            this.Controls.Add(this.lblguestname);
            this.Controls.Add(this.lblinformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grproomtype.ResumeLayout(false);
            this.grproomtype.PerformLayout();
            this.grpoptions.ResumeLayout(false);
            this.grpoptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinformation;
        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblguest;
        private System.Windows.Forms.Label lblnights;
        private System.Windows.Forms.Label lblguestage;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.GroupBox grproomtype;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.GroupBox grpoptions;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

