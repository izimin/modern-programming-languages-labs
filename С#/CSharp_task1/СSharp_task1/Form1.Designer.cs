namespace СSharp_task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbViewSet = new System.Windows.Forms.ComboBox();
            this.gbViewSet = new System.Windows.Forms.GroupBox();
            this.tbInputSet = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lbGoFile = new System.Windows.Forms.Label();
            this.btFill = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCheckElem = new System.Windows.Forms.Button();
            this.tbCheckElem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btDel = new System.Windows.Forms.Button();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bttestOp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSetB = new System.Windows.Forms.TextBox();
            this.tbSetA = new System.Windows.Forms.TextBox();
            this.gbViewSet.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbViewSet
            // 
            this.cbViewSet.FormattingEnabled = true;
            this.cbViewSet.Items.AddRange(new object[] {
            "Перечисление элементов",
            "Логический массив",
            "Битовый массив"});
            this.cbViewSet.Location = new System.Drawing.Point(6, 19);
            this.cbViewSet.Name = "cbViewSet";
            this.cbViewSet.Size = new System.Drawing.Size(208, 21);
            this.cbViewSet.TabIndex = 0;
            // 
            // gbViewSet
            // 
            this.gbViewSet.Controls.Add(this.cbViewSet);
            this.gbViewSet.Location = new System.Drawing.Point(12, 12);
            this.gbViewSet.Name = "gbViewSet";
            this.gbViewSet.Size = new System.Drawing.Size(224, 47);
            this.gbViewSet.TabIndex = 1;
            this.gbViewSet.TabStop = false;
            this.gbViewSet.Text = "Вариант представлеиня";
            // 
            // tbInputSet
            // 
            this.tbInputSet.Location = new System.Drawing.Point(6, 19);
            this.tbInputSet.Name = "tbInputSet";
            this.tbInputSet.Size = new System.Drawing.Size(208, 20);
            this.tbInputSet.TabIndex = 2;
            this.tbInputSet.TextChanged += new System.EventHandler(this.tbInputSet_TextChanged);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lbGoFile);
            this.gbInput.Controls.Add(this.btFill);
            this.gbInput.Controls.Add(this.openFile);
            this.gbInput.Controls.Add(this.tbInputSet);
            this.gbInput.Location = new System.Drawing.Point(12, 65);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(224, 127);
            this.gbInput.TabIndex = 3;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Ввод данных";
            // 
            // lbGoFile
            // 
            this.lbGoFile.AutoSize = true;
            this.lbGoFile.Location = new System.Drawing.Point(93, 78);
            this.lbGoFile.Name = "lbGoFile";
            this.lbGoFile.Size = new System.Drawing.Size(31, 13);
            this.lbGoFile.TabIndex = 5;
            this.lbGoFile.Text = "ИЛИ";
            // 
            // btFill
            // 
            this.btFill.Location = new System.Drawing.Point(7, 46);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(207, 23);
            this.btFill.TabIndex = 4;
            this.btFill.Text = "Заполнить из введенной строки";
            this.btFill.UseVisualStyleBackColor = true;
            this.btFill.Click += new System.EventHandler(this.btFill_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(7, 98);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(207, 23);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Заполнить из файла";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSet);
            this.groupBox1.Location = new System.Drawing.Point(264, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее состояние множества";
            // 
            // tbSet
            // 
            this.tbSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSet.Location = new System.Drawing.Point(19, 20);
            this.tbSet.Name = "tbSet";
            this.tbSet.Size = new System.Drawing.Size(568, 29);
            this.tbSet.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.tbAdd);
            this.groupBox2.Location = new System.Drawing.Point(264, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить элемент в множество";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(7, 42);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(7, 20);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(173, 20);
            this.tbAdd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btCheckElem);
            this.groupBox3.Controls.Add(this.tbCheckElem);
            this.groupBox3.Location = new System.Drawing.Point(461, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверить наличие элемента";
            // 
            // btCheckElem
            // 
            this.btCheckElem.Location = new System.Drawing.Point(7, 42);
            this.btCheckElem.Name = "btCheckElem";
            this.btCheckElem.Size = new System.Drawing.Size(75, 23);
            this.btCheckElem.TabIndex = 6;
            this.btCheckElem.Text = "Проверить";
            this.btCheckElem.UseVisualStyleBackColor = true;
            this.btCheckElem.Click += new System.EventHandler(this.btCheckElem_Click);
            // 
            // tbCheckElem
            // 
            this.tbCheckElem.Location = new System.Drawing.Point(7, 20);
            this.tbCheckElem.Name = "tbCheckElem";
            this.tbCheckElem.Size = new System.Drawing.Size(173, 20);
            this.tbCheckElem.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btDel);
            this.groupBox4.Controls.Add(this.tbDel);
            this.groupBox4.Location = new System.Drawing.Point(658, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 77);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удалить элемент из множества";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(7, 42);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(7, 20);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(173, 20);
            this.tbDel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bttestOp);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbSetB);
            this.groupBox5.Controls.Add(this.tbSetA);
            this.groupBox5.Location = new System.Drawing.Point(264, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(587, 39);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тестирование операторных методов";
            // 
            // bttestOp
            // 
            this.bttestOp.Location = new System.Drawing.Point(477, 11);
            this.bttestOp.Name = "bttestOp";
            this.bttestOp.Size = new System.Drawing.Size(75, 23);
            this.bttestOp.TabIndex = 5;
            this.bttestOp.Text = "GO!";
            this.bttestOp.UseVisualStyleBackColor = true;
            this.bttestOp.Click += new System.EventHandler(this.bttestOp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "В = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "А = ";
            // 
            // tbSetB
            // 
            this.tbSetB.Location = new System.Drawing.Point(288, 14);
            this.tbSetB.Name = "tbSetB";
            this.tbSetB.Size = new System.Drawing.Size(173, 20);
            this.tbSetB.TabIndex = 2;
            // 
            // tbSetA
            // 
            this.tbSetA.Location = new System.Drawing.Point(48, 14);
            this.tbSetA.Name = "tbSetA";
            this.tbSetA.Size = new System.Drawing.Size(173, 20);
            this.tbSetA.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 203);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbViewSet);
            this.Name = "Form1";
            this.Text = "Sets";
            this.gbViewSet.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbViewSet;
        private System.Windows.Forms.GroupBox gbViewSet;
        private System.Windows.Forms.TextBox tbInputSet;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lbGoFile;
        private System.Windows.Forms.Button btFill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCheckElem;
        private System.Windows.Forms.TextBox tbCheckElem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bttestOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSetB;
        private System.Windows.Forms.TextBox tbSetA;
    }
}

