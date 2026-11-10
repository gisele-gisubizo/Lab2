namespace Lab1_ManagementSystem
{
    partial class BicycleForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudStartHour = new System.Windows.Forms.NumericUpDown();
            this.nudEndHour = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(240, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BICYCLE RENTAL SERVICE";
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Location = new System.Drawing.Point(214, 81);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(105, 20);
            this.lblStartHour.TabIndex = 1;
            this.lblStartHour.Text = "Starting hour:";
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Location = new System.Drawing.Point(214, 141);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(102, 20);
            this.lblEndHour.TabIndex = 2;
            this.lblEndHour.Text = "Ending Hour:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(214, 259);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Cost:";
            // 
            // nudStartHour
            // 
            this.nudStartHour.Location = new System.Drawing.Point(352, 81);
            this.nudStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudStartHour.Name = "nudStartHour";
            this.nudStartHour.Size = new System.Drawing.Size(120, 26);
            this.nudStartHour.TabIndex = 4;
            // 
            // nudEndHour
            // 
            this.nudEndHour.Location = new System.Drawing.Point(352, 141);
            this.nudEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudEndHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndHour.Name = "nudEndHour";
            this.nudEndHour.Size = new System.Drawing.Size(120, 26);
            this.nudEndHour.TabIndex = 5;
            this.nudEndHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(263, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(380, 336);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 35);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(336, 252);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(136, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // BicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudEndHour);
            this.Controls.Add(this.nudStartHour);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEndHour);
            this.Controls.Add(this.lblStartHour);
            this.Controls.Add(this.lblTitle);
            this.Name = "BicycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicycle Rental Services";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudStartHour;
        private System.Windows.Forms.NumericUpDown nudEndHour;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtTotal;
    }
}