namespace Savings_Calculator
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
			this.btnCalculate = new System.Windows.Forms.Button();
			this.cboTerms = new System.Windows.Forms.ComboBox();
			this.InitialLbl = new System.Windows.Forms.Label();
			this.interestLbl = new System.Windows.Forms.Label();
			this.yearsLbl = new System.Windows.Forms.Label();
			this.calculatedLbl = new System.Windows.Forms.Label();
			this.monthlyLbl = new System.Windows.Forms.Label();
			this.totalLbl = new System.Windows.Forms.Label();
			this.nudInitial = new System.Windows.Forms.NumericUpDown();
			this.nudInterest = new System.Windows.Forms.NumericUpDown();
			this.nudYears = new System.Windows.Forms.NumericUpDown();
			this.nudMonthly = new System.Windows.Forms.NumericUpDown();
			this.nudTotal = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudInitial)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInterest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMonthly)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(9, 233);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// cboTerms
			// 
			this.cboTerms.FormattingEnabled = true;
			this.cboTerms.Location = new System.Drawing.Point(123, 120);
			this.cboTerms.Name = "cboTerms";
			this.cboTerms.Size = new System.Drawing.Size(121, 21);
			this.cboTerms.TabIndex = 1;
			// 
			// InitialLbl
			// 
			this.InitialLbl.AutoSize = true;
			this.InitialLbl.Location = new System.Drawing.Point(12, 30);
			this.InitialLbl.Name = "InitialLbl";
			this.InitialLbl.Size = new System.Drawing.Size(76, 13);
			this.InitialLbl.TabIndex = 2;
			this.InitialLbl.Text = "Initial Amount: ";
			// 
			// interestLbl
			// 
			this.interestLbl.AutoSize = true;
			this.interestLbl.Location = new System.Drawing.Point(12, 60);
			this.interestLbl.Name = "interestLbl";
			this.interestLbl.Size = new System.Drawing.Size(82, 13);
			this.interestLbl.TabIndex = 3;
			this.interestLbl.Text = "Interest Rate %:";
			// 
			// yearsLbl
			// 
			this.yearsLbl.AutoSize = true;
			this.yearsLbl.Location = new System.Drawing.Point(12, 91);
			this.yearsLbl.Name = "yearsLbl";
			this.yearsLbl.Size = new System.Drawing.Size(37, 13);
			this.yearsLbl.TabIndex = 4;
			this.yearsLbl.Text = "Years:";
			// 
			// calculatedLbl
			// 
			this.calculatedLbl.AutoSize = true;
			this.calculatedLbl.Location = new System.Drawing.Point(12, 120);
			this.calculatedLbl.Name = "calculatedLbl";
			this.calculatedLbl.Size = new System.Drawing.Size(63, 13);
			this.calculatedLbl.TabIndex = 5;
			this.calculatedLbl.Text = "Calculated: ";
			// 
			// monthlyLbl
			// 
			this.monthlyLbl.AutoSize = true;
			this.monthlyLbl.Location = new System.Drawing.Point(12, 147);
			this.monthlyLbl.Name = "monthlyLbl";
			this.monthlyLbl.Size = new System.Drawing.Size(94, 13);
			this.monthlyLbl.TabIndex = 6;
			this.monthlyLbl.Text = "Monthly Payment: ";
			// 
			// totalLbl
			// 
			this.totalLbl.AutoSize = true;
			this.totalLbl.Location = new System.Drawing.Point(9, 192);
			this.totalLbl.Name = "totalLbl";
			this.totalLbl.Size = new System.Drawing.Size(75, 13);
			this.totalLbl.TabIndex = 7;
			this.totalLbl.Text = "Total Savings:";
			// 
			// nudInitial
			// 
			this.nudInitial.DecimalPlaces = 2;
			this.nudInitial.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudInitial.Location = new System.Drawing.Point(124, 30);
			this.nudInitial.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudInitial.Name = "nudInitial";
			this.nudInitial.Size = new System.Drawing.Size(120, 20);
			this.nudInitial.TabIndex = 8;
			// 
			// nudInterest
			// 
			this.nudInterest.DecimalPlaces = 2;
			this.nudInterest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudInterest.Location = new System.Drawing.Point(124, 56);
			this.nudInterest.Name = "nudInterest";
			this.nudInterest.Size = new System.Drawing.Size(60, 20);
			this.nudInterest.TabIndex = 9;
			// 
			// nudYears
			// 
			this.nudYears.Location = new System.Drawing.Point(124, 89);
			this.nudYears.Name = "nudYears";
			this.nudYears.Size = new System.Drawing.Size(40, 20);
			this.nudYears.TabIndex = 10;
			// 
			// nudMonthly
			// 
			this.nudMonthly.DecimalPlaces = 2;
			this.nudMonthly.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudMonthly.Location = new System.Drawing.Point(124, 147);
			this.nudMonthly.Name = "nudMonthly";
			this.nudMonthly.Size = new System.Drawing.Size(120, 20);
			this.nudMonthly.TabIndex = 11;
			// 
			// nudTotal
			// 
			this.nudTotal.DecimalPlaces = 2;
			this.nudTotal.Enabled = false;
			this.nudTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.nudTotal.Location = new System.Drawing.Point(123, 185);
			this.nudTotal.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudTotal.Name = "nudTotal";
			this.nudTotal.ReadOnly = true;
			this.nudTotal.Size = new System.Drawing.Size(120, 20);
			this.nudTotal.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 267);
			this.Controls.Add(this.nudTotal);
			this.Controls.Add(this.nudMonthly);
			this.Controls.Add(this.nudYears);
			this.Controls.Add(this.nudInterest);
			this.Controls.Add(this.nudInitial);
			this.Controls.Add(this.totalLbl);
			this.Controls.Add(this.monthlyLbl);
			this.Controls.Add(this.calculatedLbl);
			this.Controls.Add(this.yearsLbl);
			this.Controls.Add(this.interestLbl);
			this.Controls.Add(this.InitialLbl);
			this.Controls.Add(this.cboTerms);
			this.Controls.Add(this.btnCalculate);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudInitial)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInterest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMonthly)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.ComboBox cboTerms;
		private System.Windows.Forms.Label InitialLbl;
		private System.Windows.Forms.Label interestLbl;
		private System.Windows.Forms.Label yearsLbl;
		private System.Windows.Forms.Label calculatedLbl;
		private System.Windows.Forms.Label monthlyLbl;
		private System.Windows.Forms.Label totalLbl;
		private System.Windows.Forms.NumericUpDown nudInitial;
		private System.Windows.Forms.NumericUpDown nudInterest;
		private System.Windows.Forms.NumericUpDown nudYears;
		private System.Windows.Forms.NumericUpDown nudMonthly;
		private System.Windows.Forms.NumericUpDown nudTotal;
	}
}

