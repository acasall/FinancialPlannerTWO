namespace FinancialPlannerTWO
{
    partial class MainForm
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
            this.lblYearlyInvestment = new System.Windows.Forms.Label();
            this.txtYearlyInvestment = new System.Windows.Forms.TextBox();
            this.lblInvestmentPlan = new System.Windows.Forms.Label();
            this.cmbInvestmentPlan = new System.Windows.Forms.ComboBox();
            this.lblNumYears = new System.Windows.Forms.Label();
            this.txtNumYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstInvestment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblYearlyInvestment
            // 
            this.lblYearlyInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyInvestment.Location = new System.Drawing.Point(115, 49);
            this.lblYearlyInvestment.Name = "lblYearlyInvestment";
            this.lblYearlyInvestment.Size = new System.Drawing.Size(106, 21);
            this.lblYearlyInvestment.TabIndex = 0;
            this.lblYearlyInvestment.Text = "Yearly Investment";
            // 
            // txtYearlyInvestment
            // 
            this.txtYearlyInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlyInvestment.Location = new System.Drawing.Point(264, 49);
            this.txtYearlyInvestment.Multiline = true;
            this.txtYearlyInvestment.Name = "txtYearlyInvestment";
            this.txtYearlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtYearlyInvestment.TabIndex = 1;
            // 
            // lblInvestmentPlan
            // 
            this.lblInvestmentPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestmentPlan.Location = new System.Drawing.Point(115, 96);
            this.lblInvestmentPlan.Name = "lblInvestmentPlan";
            this.lblInvestmentPlan.Size = new System.Drawing.Size(106, 21);
            this.lblInvestmentPlan.TabIndex = 2;
            this.lblInvestmentPlan.Text = "Investment Plan";
            // 
            // cmbInvestmentPlan
            // 
            this.cmbInvestmentPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvestmentPlan.FormattingEnabled = true;
            this.cmbInvestmentPlan.Items.AddRange(new object[] {
            "Retirement 2040",
            "Retirement 2050",
            "Retirement 2055"});
            this.cmbInvestmentPlan.Location = new System.Drawing.Point(264, 96);
            this.cmbInvestmentPlan.Name = "cmbInvestmentPlan";
            this.cmbInvestmentPlan.Size = new System.Drawing.Size(166, 23);
            this.cmbInvestmentPlan.TabIndex = 3;
            // 
            // lblNumYears
            // 
            this.lblNumYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumYears.Location = new System.Drawing.Point(115, 144);
            this.lblNumYears.Name = "lblNumYears";
            this.lblNumYears.Size = new System.Drawing.Size(106, 21);
            this.lblNumYears.TabIndex = 4;
            this.lblNumYears.Text = "Number of Years";
            // 
            // txtNumYears
            // 
            this.txtNumYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumYears.Location = new System.Drawing.Point(264, 145);
            this.txtNumYears.Multiline = true;
            this.txtNumYears.Name = "txtNumYears";
            this.txtNumYears.Size = new System.Drawing.Size(100, 20);
            this.txtNumYears.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(264, 221);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 25);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(195, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(347, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstInvestment
            // 
            this.lstInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvestment.FormattingEnabled = true;
            this.lstInvestment.ItemHeight = 15;
            this.lstInvestment.Location = new System.Drawing.Point(515, 18);
            this.lstInvestment.Name = "lstInvestment";
            this.lstInvestment.Size = new System.Drawing.Size(226, 319);
            this.lstInvestment.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstInvestment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumYears);
            this.Controls.Add(this.lblNumYears);
            this.Controls.Add(this.cmbInvestmentPlan);
            this.Controls.Add(this.lblInvestmentPlan);
            this.Controls.Add(this.txtYearlyInvestment);
            this.Controls.Add(this.lblYearlyInvestment);
            this.Name = "MainForm";
            this.Text = "Financial Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYearlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInvestment;
        private System.Windows.Forms.Label lblInvestmentPlan;
        private System.Windows.Forms.ComboBox cmbInvestmentPlan;
        private System.Windows.Forms.Label lblNumYears;
        private System.Windows.Forms.TextBox txtNumYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstInvestment;
    }
}

