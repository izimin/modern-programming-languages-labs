using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_task2
{
    public partial class frmStudents : Form
    {
        SerializationStudents listStudents;
        List<Bachelor> oldLst;
        int indexStudent;
        public frmStudents()
        {
            InitializeComponent();
            listStudents = new SerializationStudents();
            indexStudent = 0;
        }

        #region Обработчики кнопок в меню
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnabledAddTb(true);
            VisibleComponents(true);
            listStudents.CreateList();
            создатьToolStripMenuItem.Enabled = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "XML файлы|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;
                listStudents.OpenList(path);
            }
            else return;
            VisibleComponents(true);
            ShowStudent();
            Text = Text.Remove(Text.Length - 1);
            if (listStudents.Students.Count > 1)
                EnabledNextBt(true);
            EnabledAddTb(true);
            EnabledTbMaster(true);
            удалениеToolStripMenuItem.Enabled = true;
            создатьToolStripMenuItem.Enabled = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listStudents.FileName != "")
            {
                listStudents.Save();
                return;
            }
            sfd.Filter = "|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var Name = sfd.FileName;
                listStudents.Save(Name);
            }
            else return;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (сохранитьToolStripMenuItem.Enabled)
            {
                var frmClose = new CloseFrm();
                frmClose.ShowDialog();
                if (frmClose.ansSave == "Yes")
                    сохранитьToolStripMenuItem_Click(sender, e);
            }
            Close();
        }
        private void добавитьСтудентаБакалавраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnabledTbBach(true);
            ChangeList(new Bachelor("", "", ""));
        }

        private void добавитьСтудентаМагистраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleComponentsMaster(true);
            EnabledTbMaster(true);
            ChangeList(new Master("", "", "", 2018, "Стандартный диплом"));
        }

        void ChangeList(Bachelor newStud)
        {
            listStudents.Students.Add(newStud);
            indexStudent = listStudents.Students.Count - 1;
            if (indexStudent > 0) EnabledPrevBt(true);
            ShowStudent();
        }
        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oldLst != null)
            {
                for (int i = 0; i < oldLst.Count; i++)
                {
                    if (oldLst[i] == listStudents.Students[indexStudent])
                        oldLst.RemoveAt(i);
                }
            }
            listStudents.Students.RemoveAt(indexStudent);
            if (listStudents.Students.Count == 0)
            {
                EnabledTbMaster(false);
                MessageBox.Show("Поздравляем! Вы удалили всех студентов :(");
                EnabledSaveBt(false);
                return;
            }
            if (indexStudent > listStudents.Students.Count - 1)
                indexStudent--;
            ShowStudent();
        }
        #endregion

        #region Обработчики полей ввода
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            listStudents.Students[indexStudent].Name = tbName.Text;
            EnabledSaveBt(true);
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            listStudents.Students[indexStudent].Surname = tbSurname.Text;
            EnabledSaveBt(true);
        }

        private void tbFaculty_TextChanged(object sender, EventArgs e)
        {
            listStudents.Students[indexStudent].Faculty = tbFaculty.Text;
            EnabledSaveBt(true);
        }

        private void cbTypeDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Master)listStudents.Students[indexStudent]).TypeDegree = cbTypeDegree.SelectedItem.ToString();
            EnabledSaveBt(true);
        }

        private void cbGraduationYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Master)listStudents.Students[indexStudent]).GraduationYear = int.Parse(cbGraduationYear.SelectedItem.ToString());
            EnabledSaveBt(true);
        }
        private void cbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFind.Enabled = cbFind.SelectedIndex != -1;
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            btFind.Enabled = tbFind.TextLength != 0;
        }
        #endregion 

        #region Обработчики кнопок след./пред./поиск/сброс
        private void btNext_Click(object sender, EventArgs e)
        {
            indexStudent++;
            ShowStudent();
            EnabledPrevBt(true);
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            indexStudent--;
            ShowStudent();
            EnabledNextBt(true);
        }
        private void btClearFind_Click(object sender, EventArgs e)
        {
            EnabledTbMaster(true);
            IsReadOnlyTb(false);
            listStudents.Students = oldLst;
            indexStudent = 0;
            ShowStudent();
            tbFind.Text = "";
            clearFind.Enabled = false;
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            clearFind.Enabled = true;
            var curItem = cbFind.SelectedItem as string;

            var listFind = new List<Bachelor>();
            if (oldLst is null)
                oldLst = listStudents.Students.GetRange(0, listStudents.Students.Count);

            listFind = FindStudents(curItem);

            if (listFind.Count == 0)
            {
                MessageBox.Show("Таких нет!");
                btClearFind_Click(sender, e);
                return;
            }

            listStudents.Students = listFind;
            indexStudent = 0;

            switch (curItem)
            {
                case "Имя": listFind.Sort(delegate (Bachelor b1, Bachelor b2) { return b1.Name.CompareTo(b2.Name); }); break;
                case "Фамилия": listFind.Sort(delegate (Bachelor b1, Bachelor b2) { return b1.Surname.CompareTo(b2.Surname); }); break;
                case "Факультет": listFind.Sort(delegate (Bachelor b1, Bachelor b2) { return b1.Faculty.CompareTo(b2.Faculty); }); break;
            }
            ShowStudent();
        }
        #endregion

        #region Настройка видимости отдельных компанент формы
        private void VisibleComponents(bool flag)
        {
            gbFaculty.Visible = flag;
            gbFindStudent.Visible = flag;
            gbName.Visible = flag;
            gbSurname.Visible = flag;
            btNext.Visible = flag;
            btPrev.Visible = flag;
        }

        private void VisibleComponentsMaster(bool flag)
        {
            gbGraduationYear.Visible = flag;
            gbTypeDegree.Visible = flag;
        }
        private void IsReadOnlyTb(bool v)
        {
            tbName.ReadOnly = v;
            tbSurname.ReadOnly = v;
            tbFaculty.ReadOnly = v;
        }
        #endregion

        #region Настройка активности кнопок
        private void EnabledAddTb(bool flag)
        {
            добавитьСтудентаБакалавраToolStripMenuItem.Enabled = flag;
            добавитьСтудентаМагистраToolStripMenuItem.Enabled = flag;
        }

        private void EnabledTbBach(bool flag)
        {
            tbName.Enabled = flag;
            tbSurname.Enabled = flag;
            tbFaculty.Enabled = flag;
            удалениеToolStripMenuItem.Enabled = true;
        }

        private void EnabledTbMaster(bool flag)
        {
            EnabledTbBach(flag);
            cbGraduationYear.Enabled = flag;
            cbTypeDegree.Enabled = flag;
        }

        private void EnabledNextBt(bool flag)
        {
            btNext.Enabled = flag;
            следующийToolStripMenuItem.Enabled = flag;
        }

        private void EnabledPrevBt(bool flag)
        {
            btPrev.Enabled = flag;
            предыдущийToolStripMenuItem.Enabled = flag;
        }

        private void EnabledSaveBt(bool flag)
        {
            сохранитьToolStripMenuItem.Enabled = flag;
        }
        #endregion

        // Метод отображения информации о студенете 
        private void ShowStudent()
        {
            if (listStudents.Students[indexStudent] is Master)
            {
                VisibleComponentsMaster(true);
                cbGraduationYear.SelectedItem = ((Master)listStudents.Students[indexStudent]).GraduationYear.ToString();
                cbTypeDegree.SelectedItem = ((Master)listStudents.Students[indexStudent]).TypeDegree;
            }
            else VisibleComponentsMaster(false);

            tbName.Text = listStudents.Students[indexStudent].Name;
            tbSurname.Text = listStudents.Students[indexStudent].Surname;
            tbFaculty.Text = listStudents.Students[indexStudent].Faculty;

            EnabledPrevBt(!(indexStudent == 0));
            EnabledNextBt(!(indexStudent == listStudents.Students.Count - 1));
        }

        // Метод поиска студентов
        private List<Bachelor> FindStudents(string curItem)
        {
            var listFind = new List<Bachelor>();
            var findText = tbFind.Text;
            switch (curItem)
            {
                case "Имя":
                    listFind = listStudents.Students.Where(ob => ob.Name == findText).ToList();
                    break;
                case "Фамилия":
                    listFind = listStudents.Students.Where(ob => ob.Surname == findText).ToList();
                    break;
                case "Факультет":
                    listFind = listStudents.Students.Where(ob => ob.Faculty == findText).ToList();
                    break;
            }
            return listFind;
        }
    }
}