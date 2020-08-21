using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СSharp_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbViewSet.SelectedItem = "Логический массив";
        }

        int[] arrSet;
        string strSet = "";
        Set set;
        private void openFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Текстовые файлы|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;
                arrSet = new int[File.ReadAllLines(path).Length];
                FileStream fileSet = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(fileSet);

                var i = 0;
                while (!reader.EndOfStream)
                    arrSet[i++] = int.Parse(reader.ReadLine());
                int maxElem = 0;
                foreach (var item in arrSet)
                {
                    if (item > maxElem) maxElem = item;
                }

                CreateSet(maxElem, out set);
                tbSet.Text = set.PrintSet();
            }
        }

        int MaxElem(string strSet)
        {
            var arrSet = strSet.Split(' ').Select(x => int.Parse(x));
            int maxElem = 0;
            foreach (var item in arrSet)
            {
                if (item > maxElem) maxElem = item;
            }
            return maxElem;
        }
        private void btFill_Click(object sender, EventArgs e)
        {
            if (tbInputSet.Text == "")
            {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }
            strSet = tbInputSet.Text;

            var maxElem = MaxElem(strSet);
            CreateSet(maxElem, out set);
            tbSet.Text = set.PrintSet();
        }
        private void CreateSet(int maxElem, out Set newSet)
        {
            if (cbViewSet.SelectedItem.ToString() == "Перечисление элементов")
                newSet = new MultiSet(maxElem);
            else if (cbViewSet.SelectedItem.ToString() == "Логический массив")
                newSet = new SimpleSet(maxElem);
            else newSet = new BitSet(maxElem);

            if (strSet == "")
                newSet.FillSet(arrSet);
            else newSet.FillSet(strSet);
        }

        private void tbInputSet_TextChanged(object sender, EventArgs e)
        {
            if (tbInputSet.Text != "") openFile.Enabled = false;
            else openFile.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbAdd.Text == "")
            {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }
            try
            {
                set.Add(int.Parse(tbAdd.Text));
            }
            catch (OutOfBoundSetException ex)
            {
                MessageBox.Show("Элемент превышает максимальный! \n Пожалуйста, повторите ввод!", "О, нет!");
            }
            tbSet.Text = set.PrintSet();
            tbAdd.Text = "";
        }

        private void btCheckElem_Click(object sender, EventArgs e)
        {
            if (tbCheckElem.Text == "")
            {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }

            string s;
            if (set.InSet(int.Parse(tbCheckElem.Text)))
                s = "Элемент есть в множестве!";
            else s = "Элемента нет :(";
            MessageBox.Show(s);

            tbCheckElem.Text = "";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (tbDel.Text == "")
            {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }
            try
            {
                set.Delete(int.Parse(tbDel.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данного элемента нет в множестве!");
            }
            tbSet.Text = set.PrintSet();
            tbDel.Text = "";
        }

        private void bttestOp_Click(object sender, EventArgs e)
        {
            Set setA, setB, setC, setD;
            if (tbSetA.Text == "" || tbSetB.Text == "")
            {
                MessageBox.Show("Поле ввода пусто!");
                return;
            }

            strSet = tbSetA.Text;
            var maxElem = MaxElem(strSet);
            CreateSet(maxElem, out setA);

            strSet = tbSetB.Text;
            maxElem = MaxElem(strSet);
            CreateSet(maxElem, out setB);

            if (cbViewSet.SelectedItem.ToString() == "Логический массив")
            {
                setC = ((SimpleSet)setA) + ((SimpleSet)setB);
                setD = (SimpleSet)setA * (SimpleSet)setB;
            }
            else
            {
                setC = (BitSet)setA + (BitSet)setB;
                setD = (BitSet)setA * (BitSet)setB;
            }

            tbSet.Text = "C =" + setC.PrintSet() + ",  D = " + setD.PrintSet();
        }
    }
}
