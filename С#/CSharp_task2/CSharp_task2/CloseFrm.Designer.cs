namespace CSharp_task2
{
    partial class CloseFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Возможно есть не сохранённые данные. Сохранить?\r\n";
            // 
            // btYes
            // 
            this.btYes.Location = new System.Drawing.Point(64, 44);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(75, 32);
            this.btYes.TabIndex = 1;
            this.btYes.Text = "Да";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.Location = new System.Drawing.Point(202, 44);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(75, 32);
            this.btNo.TabIndex = 2;
            this.btNo.Text = "Нет";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // CloseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 96);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.label1);
            this.Name = "CloseFrm";
            this.Text = "Выход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
    }
}