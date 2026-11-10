namespace Lab1_ManagementSystem
{
    partial class MushroomForm
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
            this.lblForest = new System.Windows.Forms.Label();
            this.lblConvex = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.lblGills = new System.Windows.Forms.Label();
            this.cmbForest = new System.Windows.Forms.ComboBox();
            this.cmbConvex = new System.Windows.Forms.ComboBox();
            this.cmbRing = new System.Windows.Forms.ComboBox();
            this.cmbGills = new System.Windows.Forms.ComboBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(304, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MUSHROOM IDENTIFICATION";
            // 
            // lblForest
            // 
            this.lblForest.AutoSize = true;
            this.lblForest.Location = new System.Drawing.Point(174, 67);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(274, 20);
            this.lblForest.TabIndex = 1;
            this.lblForest.Text = "Does the mushroom grow in a forest?";
            // 
            // lblConvex
            // 
            this.lblConvex.AutoSize = true;
            this.lblConvex.Location = new System.Drawing.Point(174, 121);
            this.lblConvex.Name = "lblConvex";
            this.lblConvex.Size = new System.Drawing.Size(296, 20);
            this.lblConvex.TabIndex = 2;
            this.lblConvex.Text = "Does the mushroom have a convex cup?";
            // 
            // lblRing
            // 
            this.lblRing.AutoSize = true;
            this.lblRing.Location = new System.Drawing.Point(174, 182);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(243, 20);
            this.lblRing.TabIndex = 3;
            this.lblRing.Text = "Does the mushroom have a ring?";
            this.lblRing.Visible = false;
            // 
            // lblGills
            // 
            this.lblGills.AutoSize = true;
            this.lblGills.Location = new System.Drawing.Point(174, 239);
            this.lblGills.Name = "lblGills";
            this.lblGills.Size = new System.Drawing.Size(230, 20);
            this.lblGills.TabIndex = 4;
            this.lblGills.Text = "Does the mushroom have gills?";
            this.lblGills.Visible = false;
            // 
            // cmbForest
            // 
            this.cmbForest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForest.FormattingEnabled = true;
            this.cmbForest.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbForest.Location = new System.Drawing.Point(476, 64);
            this.cmbForest.Name = "cmbForest";
            this.cmbForest.Size = new System.Drawing.Size(121, 28);
            this.cmbForest.TabIndex = 5;
            // 
            // cmbConvex
            // 
            this.cmbConvex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvex.FormattingEnabled = true;
            this.cmbConvex.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbConvex.Location = new System.Drawing.Point(476, 113);
            this.cmbConvex.Name = "cmbConvex";
            this.cmbConvex.Size = new System.Drawing.Size(121, 28);
            this.cmbConvex.TabIndex = 6;
            // 
            // cmbRing
            // 
            this.cmbRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRing.FormattingEnabled = true;
            this.cmbRing.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbRing.Location = new System.Drawing.Point(476, 174);
            this.cmbRing.Name = "cmbRing";
            this.cmbRing.Size = new System.Drawing.Size(121, 28);
            this.cmbRing.TabIndex = 7;
            this.cmbRing.Visible = false;
            // 
            // cmbGills
            // 
            this.cmbGills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGills.FormattingEnabled = true;
            this.cmbGills.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbGills.Location = new System.Drawing.Point(476, 236);
            this.cmbGills.Name = "cmbGills";
            this.cmbGills.Size = new System.Drawing.Size(121, 28);
            this.cmbGills.TabIndex = 8;
            this.cmbGills.Visible = false;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(308, 300);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(154, 33);
            this.btnIdentify.TabIndex = 9;
            this.btnIdentify.Text = "Identify Mushroom";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(491, 346);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 36);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MushroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.cmbGills);
            this.Controls.Add(this.cmbRing);
            this.Controls.Add(this.cmbConvex);
            this.Controls.Add(this.cmbForest);
            this.Controls.Add(this.lblGills);
            this.Controls.Add(this.lblRing);
            this.Controls.Add(this.lblConvex);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.lblTitle);
            this.Name = "MushroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mushroom Identification Service";
            this.Click += new System.EventHandler(this.MushroomForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.Label lblConvex;
        private System.Windows.Forms.Label lblRing;
        private System.Windows.Forms.Label lblGills;
        private System.Windows.Forms.ComboBox cmbForest;
        private System.Windows.Forms.ComboBox cmbConvex;
        private System.Windows.Forms.ComboBox cmbRing;
        private System.Windows.Forms.ComboBox cmbGills;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogout;
    }
}