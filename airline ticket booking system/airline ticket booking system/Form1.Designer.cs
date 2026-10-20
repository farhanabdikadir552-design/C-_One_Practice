namespace airline_ticket_booking_system
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
            this.grppersonalonfo = new System.Windows.Forms.GroupBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblbaggage = new System.Windows.Forms.Label();
            this.lbltickets = new System.Windows.Forms.Label();
            this.lblpassengerage = new System.Windows.Forms.Label();
            this.lblpassengername = new System.Windows.Forms.Label();
            this.grptravelclass = new System.Windows.Forms.GroupBox();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.grpoptions = new System.Windows.Forms.GroupBox();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.AirlineBookingDetails = new System.Windows.Forms.ListBox();
            this.grppersonalonfo.SuspendLayout();
            this.grptravelclass.SuspendLayout();
            this.grpoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grppersonalonfo
            // 
            this.grppersonalonfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grppersonalonfo.Controls.Add(this.txtbaggage);
            this.grppersonalonfo.Controls.Add(this.txtBaggageWeight);
            this.grppersonalonfo.Controls.Add(this.txtPassengerAge);
            this.grppersonalonfo.Controls.Add(this.txtPassengerName);
            this.grppersonalonfo.Controls.Add(this.lblbaggage);
            this.grppersonalonfo.Controls.Add(this.lbltickets);
            this.grppersonalonfo.Controls.Add(this.lblpassengerage);
            this.grppersonalonfo.Controls.Add(this.lblpassengername);
            this.grppersonalonfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppersonalonfo.Location = new System.Drawing.Point(22, 12);
            this.grppersonalonfo.Name = "grppersonalonfo";
            this.grppersonalonfo.Size = new System.Drawing.Size(487, 257);
            this.grppersonalonfo.TabIndex = 0;
            this.grppersonalonfo.TabStop = false;
            this.grppersonalonfo.Text = "personal information";
            // 
            // txtbaggage
            // 
            this.txtbaggage.Location = new System.Drawing.Point(228, 209);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(239, 30);
            this.txtbaggage.TabIndex = 7;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(228, 159);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(239, 30);
            this.txtBaggageWeight.TabIndex = 6;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(228, 101);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(239, 30);
            this.txtPassengerAge.TabIndex = 5;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(228, 52);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(239, 30);
            this.txtPassengerName.TabIndex = 4;
            // 
            // lblbaggage
            // 
            this.lblbaggage.AutoSize = true;
            this.lblbaggage.Location = new System.Drawing.Point(19, 212);
            this.lblbaggage.Name = "lblbaggage";
            this.lblbaggage.Size = new System.Drawing.Size(203, 25);
            this.lblbaggage.TabIndex = 3;
            this.lblbaggage.Text = "beggage weight(kg)";
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Location = new System.Drawing.Point(19, 159);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(176, 25);
            this.lbltickets.TabIndex = 2;
            this.lbltickets.Text = "number of tickets";
            // 
            // lblpassengerage
            // 
            this.lblpassengerage.AutoSize = true;
            this.lblpassengerage.Location = new System.Drawing.Point(19, 101);
            this.lblpassengerage.Name = "lblpassengerage";
            this.lblpassengerage.Size = new System.Drawing.Size(155, 25);
            this.lblpassengerage.TabIndex = 1;
            this.lblpassengerage.Text = "passenger age";
            // 
            // lblpassengername
            // 
            this.lblpassengername.AutoSize = true;
            this.lblpassengername.Location = new System.Drawing.Point(19, 52);
            this.lblpassengername.Name = "lblpassengername";
            this.lblpassengername.Size = new System.Drawing.Size(172, 25);
            this.lblpassengername.TabIndex = 0;
            this.lblpassengername.Text = "passenger name";
            // 
            // grptravelclass
            // 
            this.grptravelclass.Controls.Add(this.rdoNormalClass);
            this.grptravelclass.Controls.Add(this.rdoBusinessClass);
            this.grptravelclass.Controls.Add(this.rdoFirstClass);
            this.grptravelclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptravelclass.Location = new System.Drawing.Point(12, 287);
            this.grptravelclass.Name = "grptravelclass";
            this.grptravelclass.Size = new System.Drawing.Size(497, 109);
            this.grptravelclass.TabIndex = 1;
            this.grptravelclass.TabStop = false;
            this.grptravelclass.Text = "travel class";
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(154, 43);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(134, 24);
            this.rdoNormalClass.TabIndex = 2;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "normal class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(317, 43);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(151, 24);
            this.rdoBusinessClass.TabIndex = 1;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "business class";
            this.rdoBusinessClass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFirstClass.Location = new System.Drawing.Point(10, 43);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(111, 24);
            this.rdoFirstClass.TabIndex = 0;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "first class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // grpoptions
            // 
            this.grpoptions.Controls.Add(this.chkTravelInsurance);
            this.grpoptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpoptions.Location = new System.Drawing.Point(12, 402);
            this.grpoptions.Name = "grpoptions";
            this.grpoptions.Size = new System.Drawing.Size(497, 98);
            this.grpoptions.TabIndex = 3;
            this.grpoptions.TabStop = false;
            this.grpoptions.Text = "aditional options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(10, 48);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(368, 29);
            this.chkTravelInsurance.TabIndex = 0;
            this.chkTravelInsurance.Text = "add travel insurane($25 per ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(22, 522);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(152, 67);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(196, 522);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(152, 67);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(376, 523);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(152, 67);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // AirlineBookingDetails
            // 
            this.AirlineBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirlineBookingDetails.FormattingEnabled = true;
            this.AirlineBookingDetails.ItemHeight = 25;
            this.AirlineBookingDetails.Location = new System.Drawing.Point(545, 26);
            this.AirlineBookingDetails.Name = "AirlineBookingDetails";
            this.AirlineBookingDetails.Size = new System.Drawing.Size(489, 554);
            this.AirlineBookingDetails.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 601);
            this.Controls.Add(this.AirlineBookingDetails);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.grpoptions);
            this.Controls.Add(this.grptravelclass);
            this.Controls.Add(this.grppersonalonfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grppersonalonfo.ResumeLayout(false);
            this.grppersonalonfo.PerformLayout();
            this.grptravelclass.ResumeLayout(false);
            this.grptravelclass.PerformLayout();
            this.grpoptions.ResumeLayout(false);
            this.grpoptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grppersonalonfo;
        private System.Windows.Forms.Label lblbaggage;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Label lblpassengerage;
        private System.Windows.Forms.Label lblpassengername;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.GroupBox grptravelclass;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.GroupBox grpoptions;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox AirlineBookingDetails;
    }
}

