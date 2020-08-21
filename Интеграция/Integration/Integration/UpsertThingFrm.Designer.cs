namespace Integration
{
    partial class UpsertThingFrm
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
            this.gbWeight = new System.Windows.Forms.GroupBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.gbCost = new System.Windows.Forms.GroupBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.gbWeight.SuspendLayout();
            this.gbCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWeight
            // 
            this.gbWeight.Controls.Add(this.tbWeight);
            this.gbWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbWeight.Location = new System.Drawing.Point(0, 0);
            this.gbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.gbWeight.Name = "gbWeight";
            this.gbWeight.Padding = new System.Windows.Forms.Padding(4);
            this.gbWeight.Size = new System.Drawing.Size(180, 54);
            this.gbWeight.TabIndex = 0;
            this.gbWeight.TabStop = false;
            this.gbWeight.Text = "Вес";
            // 
            // tbWeight
            // 
            this.tbWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWeight.Location = new System.Drawing.Point(4, 22);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(176, 22);
            this.tbWeight.TabIndex = 0;
            this.tbWeight.TextChanged += new System.EventHandler(this.CheckTb);
            // 
            // gbCost
            // 
            this.gbCost.Controls.Add(this.tbCost);
            this.gbCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCost.Location = new System.Drawing.Point(0, 54);
            this.gbCost.Margin = new System.Windows.Forms.Padding(4);
            this.gbCost.Name = "gbCost";
            this.gbCost.Padding = new System.Windows.Forms.Padding(4);
            this.gbCost.Size = new System.Drawing.Size(180, 54);
            this.gbCost.TabIndex = 1;
            this.gbCost.TabStop = false;
            this.gbCost.Text = "Стоимость";
            // 
            // tbCost
            // 
            this.tbCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCost.Location = new System.Drawing.Point(4, 19);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(172, 22);
            this.tbCost.TabIndex = 0;
            this.tbCost.TextChanged += new System.EventHandler(this.CheckTb);
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOK.Location = new System.Drawing.Point(0, 108);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(180, 53);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "btOK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // UpsertThingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 161);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbCost);
            this.Controls.Add(this.gbWeight);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpsertThingFrm";
            this.RightToLeftLayout = true;
            this.Text = "Предмет";
            this.gbWeight.ResumeLayout(false);
            this.gbWeight.PerformLayout();
            this.gbCost.ResumeLayout(false);
            this.gbCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWeight;
        private System.Windows.Forms.GroupBox gbCost;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Button btOK;
    }
}