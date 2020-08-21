namespace CSharp_task2
{
    partial class frmStudents
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предыдущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаБакалавраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаМагистраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.gbSurname = new System.Windows.Forms.GroupBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.gbFaculty = new System.Windows.Forms.GroupBox();
            this.tbFaculty = new System.Windows.Forms.TextBox();
            this.gbGraduationYear = new System.Windows.Forms.GroupBox();
            this.cbGraduationYear = new System.Windows.Forms.ComboBox();
            this.gbTypeDegree = new System.Windows.Forms.GroupBox();
            this.cbTypeDegree = new System.Windows.Forms.ComboBox();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.gbFindStudent = new System.Windows.Forms.GroupBox();
            this.clearFind = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbSurname.SuspendLayout();
            this.gbFaculty.SuspendLayout();
            this.gbGraduationYear.SuspendLayout();
            this.gbTypeDegree.SuspendLayout();
            this.gbFindStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(572, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предыдущийToolStripMenuItem,
            this.следующийToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // предыдущийToolStripMenuItem
            // 
            this.предыдущийToolStripMenuItem.Enabled = false;
            this.предыдущийToolStripMenuItem.Name = "предыдущийToolStripMenuItem";
            this.предыдущийToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.предыдущийToolStripMenuItem.Text = "Предыдущий";
            this.предыдущийToolStripMenuItem.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Enabled = false;
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.следующийToolStripMenuItem.Text = "Следующий";
            this.следующийToolStripMenuItem.Click += new System.EventHandler(this.btNext_Click);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаБакалавраToolStripMenuItem,
            this.добавитьСтудентаМагистраToolStripMenuItem,
            this.удалениеToolStripMenuItem});
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.студентToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаБакалавраToolStripMenuItem
            // 
            this.добавитьСтудентаБакалавраToolStripMenuItem.Enabled = false;
            this.добавитьСтудентаБакалавраToolStripMenuItem.Name = "добавитьСтудентаБакалавраToolStripMenuItem";
            this.добавитьСтудентаБакалавраToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.добавитьСтудентаБакалавраToolStripMenuItem.Text = "Добавить студента бакалавра";
            this.добавитьСтудентаБакалавраToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаБакалавраToolStripMenuItem_Click);
            // 
            // добавитьСтудентаМагистраToolStripMenuItem
            // 
            this.добавитьСтудентаМагистраToolStripMenuItem.Enabled = false;
            this.добавитьСтудентаМагистраToolStripMenuItem.Name = "добавитьСтудентаМагистраToolStripMenuItem";
            this.добавитьСтудентаМагистраToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.добавитьСтудентаМагистраToolStripMenuItem.Text = "Добавить студента магистра";
            this.добавитьСтудентаМагистраToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаМагистраToolStripMenuItem_Click);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Enabled = false;
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            this.удалениеToolStripMenuItem.Click += new System.EventHandler(this.удалениеToolStripMenuItem_Click);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(4, 23);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 30);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.tbName);
            this.gbName.Location = new System.Drawing.Point(16, 33);
            this.gbName.Margin = new System.Windows.Forms.Padding(4);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(4);
            this.gbName.Size = new System.Drawing.Size(259, 60);
            this.gbName.TabIndex = 2;
            this.gbName.TabStop = false;
            this.gbName.Text = "Имя";
            this.gbName.Visible = false;
            // 
            // gbSurname
            // 
            this.gbSurname.Controls.Add(this.tbSurname);
            this.gbSurname.Location = new System.Drawing.Point(289, 33);
            this.gbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.gbSurname.Name = "gbSurname";
            this.gbSurname.Padding = new System.Windows.Forms.Padding(4);
            this.gbSurname.Size = new System.Drawing.Size(267, 60);
            this.gbSurname.TabIndex = 3;
            this.gbSurname.TabStop = false;
            this.gbSurname.Text = "Фамилия";
            this.gbSurname.Visible = false;
            // 
            // tbSurname
            // 
            this.tbSurname.Enabled = false;
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(4, 23);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(253, 30);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // gbFaculty
            // 
            this.gbFaculty.Controls.Add(this.tbFaculty);
            this.gbFaculty.Location = new System.Drawing.Point(144, 101);
            this.gbFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Padding = new System.Windows.Forms.Padding(4);
            this.gbFaculty.Size = new System.Drawing.Size(267, 60);
            this.gbFaculty.TabIndex = 4;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Факультет";
            this.gbFaculty.Visible = false;
            // 
            // tbFaculty
            // 
            this.tbFaculty.Enabled = false;
            this.tbFaculty.Location = new System.Drawing.Point(4, 23);
            this.tbFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.Size = new System.Drawing.Size(253, 22);
            this.tbFaculty.TabIndex = 1;
            this.tbFaculty.TextChanged += new System.EventHandler(this.tbFaculty_TextChanged);
            // 
            // gbGraduationYear
            // 
            this.gbGraduationYear.Controls.Add(this.cbGraduationYear);
            this.gbGraduationYear.Location = new System.Drawing.Point(293, 169);
            this.gbGraduationYear.Margin = new System.Windows.Forms.Padding(4);
            this.gbGraduationYear.Name = "gbGraduationYear";
            this.gbGraduationYear.Padding = new System.Windows.Forms.Padding(4);
            this.gbGraduationYear.Size = new System.Drawing.Size(267, 60);
            this.gbGraduationYear.TabIndex = 5;
            this.gbGraduationYear.TabStop = false;
            this.gbGraduationYear.Text = "Годо окончания бакалавриата";
            this.gbGraduationYear.Visible = false;
            // 
            // cbGraduationYear
            // 
            this.cbGraduationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraduationYear.Enabled = false;
            this.cbGraduationYear.FormattingEnabled = true;
            this.cbGraduationYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999"});
            this.cbGraduationYear.Location = new System.Drawing.Point(8, 22);
            this.cbGraduationYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbGraduationYear.Name = "cbGraduationYear";
            this.cbGraduationYear.Size = new System.Drawing.Size(249, 24);
            this.cbGraduationYear.TabIndex = 0;
            this.cbGraduationYear.SelectedIndexChanged += new System.EventHandler(this.cbGraduationYear_SelectedIndexChanged);
            // 
            // gbTypeDegree
            // 
            this.gbTypeDegree.Controls.Add(this.cbTypeDegree);
            this.gbTypeDegree.Location = new System.Drawing.Point(20, 169);
            this.gbTypeDegree.Margin = new System.Windows.Forms.Padding(4);
            this.gbTypeDegree.Name = "gbTypeDegree";
            this.gbTypeDegree.Padding = new System.Windows.Forms.Padding(4);
            this.gbTypeDegree.Size = new System.Drawing.Size(267, 60);
            this.gbTypeDegree.TabIndex = 6;
            this.gbTypeDegree.TabStop = false;
            this.gbTypeDegree.Text = "Тип диплома";
            this.gbTypeDegree.Visible = false;
            // 
            // cbTypeDegree
            // 
            this.cbTypeDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDegree.Enabled = false;
            this.cbTypeDegree.FormattingEnabled = true;
            this.cbTypeDegree.Items.AddRange(new object[] {
            "Стандартный диплом",
            "Диплом с отличием"});
            this.cbTypeDegree.Location = new System.Drawing.Point(4, 20);
            this.cbTypeDegree.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypeDegree.Name = "cbTypeDegree";
            this.cbTypeDegree.Size = new System.Drawing.Size(253, 24);
            this.cbTypeDegree.TabIndex = 0;
            this.cbTypeDegree.SelectedIndexChanged += new System.EventHandler(this.cbTypeDegree_SelectedIndexChanged);
            // 
            // btPrev
            // 
            this.btPrev.Enabled = false;
            this.btPrev.Location = new System.Drawing.Point(17, 101);
            this.btPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(119, 52);
            this.btPrev.TabIndex = 7;
            this.btPrev.Text = "Предыдущий";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Visible = false;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Enabled = false;
            this.btNext.Location = new System.Drawing.Point(429, 101);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(119, 49);
            this.btNext.TabIndex = 8;
            this.btNext.Text = "Следующий";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Visible = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // gbFindStudent
            // 
            this.gbFindStudent.Controls.Add(this.clearFind);
            this.gbFindStudent.Controls.Add(this.btFind);
            this.gbFindStudent.Controls.Add(this.tbFind);
            this.gbFindStudent.Controls.Add(this.label1);
            this.gbFindStudent.Controls.Add(this.cbFind);
            this.gbFindStudent.Location = new System.Drawing.Point(24, 238);
            this.gbFindStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gbFindStudent.Name = "gbFindStudent";
            this.gbFindStudent.Padding = new System.Windows.Forms.Padding(4);
            this.gbFindStudent.Size = new System.Drawing.Size(536, 123);
            this.gbFindStudent.TabIndex = 9;
            this.gbFindStudent.TabStop = false;
            this.gbFindStudent.Text = "Поиск";
            this.gbFindStudent.Visible = false;
            // 
            // clearFind
            // 
            this.clearFind.Location = new System.Drawing.Point(21, 87);
            this.clearFind.Margin = new System.Windows.Forms.Padding(4);
            this.clearFind.Name = "clearFind";
            this.clearFind.Size = new System.Drawing.Size(185, 28);
            this.clearFind.TabIndex = 4;
            this.clearFind.Text = "Сброс";
            this.clearFind.UseVisualStyleBackColor = true;
            this.clearFind.Click += new System.EventHandler(this.btClearFind_Click);
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(432, 53);
            this.btFind.Margin = new System.Windows.Forms.Padding(4);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(92, 28);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Найти";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(236, 53);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(180, 22);
            this.tbFind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // cbFind
            // 
            this.cbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Факультет"});
            this.cbFind.Location = new System.Drawing.Point(21, 52);
            this.cbFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(184, 24);
            this.cbFind.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "students";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 361);
            this.Controls.Add(this.gbFindStudent);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.gbTypeDegree);
            this.Controls.Add(this.gbGraduationYear);
            this.Controls.Add(this.gbFaculty);
            this.Controls.Add(this.gbSurname);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudents";
            this.Text = "Студенты";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbSurname.ResumeLayout(false);
            this.gbSurname.PerformLayout();
            this.gbFaculty.ResumeLayout(false);
            this.gbFaculty.PerformLayout();
            this.gbGraduationYear.ResumeLayout(false);
            this.gbTypeDegree.ResumeLayout(false);
            this.gbFindStudent.ResumeLayout(false);
            this.gbFindStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предыдущийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следующийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаБакалавраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаМагистраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.GroupBox gbSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.GroupBox gbFaculty;
        private System.Windows.Forms.TextBox tbFaculty;
        private System.Windows.Forms.GroupBox gbGraduationYear;
        private System.Windows.Forms.GroupBox gbTypeDegree;
        private System.Windows.Forms.ComboBox cbGraduationYear;
        private System.Windows.Forms.ComboBox cbTypeDegree;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbFindStudent;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Button clearFind;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

