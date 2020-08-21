namespace Integration
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gbListThing = new System.Windows.Forms.GroupBox();
            this.lvThing = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSolve = new System.Windows.Forms.GroupBox();
            this.btResetSolve = new System.Windows.Forms.Button();
            this.btSolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxMass = new System.Windows.Forms.TextBox();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.msFrm = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьБиблиотекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gbListThing.SuspendLayout();
            this.cmsList.SuspendLayout();
            this.gbSolve.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.msFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListThing
            // 
            this.gbListThing.Controls.Add(this.lvThing);
            this.gbListThing.Location = new System.Drawing.Point(12, 33);
            this.gbListThing.Name = "gbListThing";
            this.gbListThing.Size = new System.Drawing.Size(383, 308);
            this.gbListThing.TabIndex = 0;
            this.gbListThing.TabStop = false;
            this.gbListThing.Text = "Список предметов";
            // 
            // lvThing
            // 
            this.lvThing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvThing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3});
            this.lvThing.ContextMenuStrip = this.cmsList;
            this.lvThing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThing.FullRowSelect = true;
            this.lvThing.Location = new System.Drawing.Point(3, 18);
            this.lvThing.Name = "lvThing";
            this.lvThing.Size = new System.Drawing.Size(377, 287);
            this.lvThing.TabIndex = 0;
            this.lvThing.UseCompatibleStateImageBehavior = false;
            this.lvThing.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "№ предмета";
            this.ch1.Width = 100;
            // 
            // ch2
            // 
            this.ch2.Text = "Вес";
            this.ch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch2.Width = 82;
            // 
            // ch3
            // 
            this.ch3.Text = "Стоимость";
            this.ch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch3.Width = 100;
            // 
            // cmsList
            // 
            this.cmsList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(198, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // gbSolve
            // 
            this.gbSolve.Controls.Add(this.btResetSolve);
            this.gbSolve.Controls.Add(this.btSolve);
            this.gbSolve.Controls.Add(this.label2);
            this.gbSolve.Controls.Add(this.label1);
            this.gbSolve.Controls.Add(this.tbMaxMass);
            this.gbSolve.Controls.Add(this.cbAlgorithm);
            this.gbSolve.Location = new System.Drawing.Point(417, 33);
            this.gbSolve.Name = "gbSolve";
            this.gbSolve.Size = new System.Drawing.Size(254, 308);
            this.gbSolve.TabIndex = 0;
            this.gbSolve.TabStop = false;
            this.gbSolve.Text = "Данные для решения";
            // 
            // btResetSolve
            // 
            this.btResetSolve.Enabled = false;
            this.btResetSolve.Location = new System.Drawing.Point(10, 258);
            this.btResetSolve.Name = "btResetSolve";
            this.btResetSolve.Size = new System.Drawing.Size(238, 47);
            this.btResetSolve.TabIndex = 4;
            this.btResetSolve.Text = "Сбросить";
            this.btResetSolve.UseVisualStyleBackColor = true;
            this.btResetSolve.Click += new System.EventHandler(this.btResetSolve_Click);
            // 
            // btSolve
            // 
            this.btSolve.Enabled = false;
            this.btSolve.Location = new System.Drawing.Point(9, 195);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(238, 50);
            this.btSolve.TabIndex = 4;
            this.btSolve.Text = "Решить";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вместимость рюкзака";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Алгоритм решения";
            // 
            // tbMaxMass
            // 
            this.tbMaxMass.Enabled = false;
            this.tbMaxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxMass.Location = new System.Drawing.Point(7, 144);
            this.tbMaxMass.Name = "tbMaxMass";
            this.tbMaxMass.Size = new System.Drawing.Size(241, 34);
            this.tbMaxMass.TabIndex = 1;
            this.tbMaxMass.TextChanged += new System.EventHandler(this.BtSolveEnabled);
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Location = new System.Drawing.Point(7, 61);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(241, 37);
            this.cbAlgorithm.TabIndex = 0;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.BtSolveEnabled);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbResult);
            this.gbResult.Location = new System.Drawing.Point(12, 347);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(659, 91);
            this.gbResult.TabIndex = 0;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(13, 32);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(635, 34);
            this.tbResult.TabIndex = 0;
            // 
            // msFrm
            // 
            this.msFrm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.msFrm.Location = new System.Drawing.Point(0, 0);
            this.msFrm.Name = "msFrm";
            this.msFrm.Size = new System.Drawing.Size(689, 28);
            this.msFrm.TabIndex = 2;
            this.msFrm.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem,
            this.подключитьБиблиотекуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьСписокПредметовИзФайлаToolStripMenuItem
            // 
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem.Name = "загрузитьСписокПредметовИзФайлаToolStripMenuItem";
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem.Text = "Загрузить список предметов из файла";
            this.загрузитьСписокПредметовИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСписокПредметовИзФайлаToolStripMenuItem_Click);
            // 
            // подключитьБиблиотекуToolStripMenuItem
            // 
            this.подключитьБиблиотекуToolStripMenuItem.Name = "подключитьБиблиотекуToolStripMenuItem";
            this.подключитьБиблиотекуToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.подключитьБиблиотекуToolStripMenuItem.Text = "Подключить библиотеку";
            this.подключитьБиблиотекуToolStripMenuItem.Click += new System.EventHandler(this.подключитьБиблиотекуToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.msFrm);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSolve);
            this.Controls.Add(this.gbListThing);
            this.MainMenuStrip = this.msFrm;
            this.Name = "MainForm";
            this.Text = "Задача о рюкзаке";
            this.gbListThing.ResumeLayout(false);
            this.cmsList.ResumeLayout(false);
            this.gbSolve.ResumeLayout(false);
            this.gbSolve.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.msFrm.ResumeLayout(false);
            this.msFrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListThing;
        private System.Windows.Forms.GroupBox gbSolve;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ContextMenuStrip cmsList;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ListView lvThing;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxMass;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.MenuStrip msFrm;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСписокПредметовИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьБиблиотекуToolStripMenuItem;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btResetSolve;
    }
}

