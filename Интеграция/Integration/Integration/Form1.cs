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
using System.Reflection;

namespace Integration
{
    public partial class MainForm : Form
    {
        List<Knapsack.ISolver> algorithms;
        public MainForm()
        {
            InitializeComponent();
            algorithms = new List<Knapsack.ISolver>();
        }

#region Контекстное меню
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmThingInsert = new UpsertThingFrm(UpsertThingFrm.State.Insert);
            if (frmThingInsert.ShowDialog() == DialogResult.OK)
            {
                AddThing(frmThingInsert.Weight, frmThingInsert.Cost);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvThing.SelectedItems.Count == 0) return;
            var frmThingUpdate = new UpsertThingFrm(UpsertThingFrm.State.Update);
            var selectedItem = lvThing.SelectedItems[0];
            frmThingUpdate.Weight = selectedItem.SubItems[1].Text;
            frmThingUpdate.Cost = selectedItem.SubItems[2].Text;
            if (frmThingUpdate.ShowDialog() == DialogResult.OK)
            {
                selectedItem.SubItems[1].Text = frmThingUpdate.Weight;
                selectedItem.SubItems[2].Text = frmThingUpdate.Cost;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvThing.SelectedItems)
                lvThing.Items.Remove(selectedItem);
            ChangeNumber();
            if (lvThing.Items.Count == 0)
            {
                tbMaxMass.Enabled = false;
                tbMaxMass.Text = "";
                btSolve.Enabled = false;
            }
        }

#endregion

#region Главное меню
        private void загрузитьСписокПредметовИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Текстовые файлы|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;

                using (FileStream filrStream = new FileStream(path, FileMode.Open))
                {
                    StreamReader reader = new StreamReader(filrStream);
                    while (!reader.EndOfStream)
                    {
                        var str = reader.ReadLine().Split(' ');
                        AddThing(str[0], str[1]);
                    }
                }
            }
        }

        private void подключитьБиблиотекуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Библиотеки|*.dll";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;
                Assembly myAssembly = null;
                Type mySolve = null;
                try
                {
                    myAssembly = Assembly.LoadFrom(path);
                    mySolve = myAssembly.GetTypes().First();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (mySolve.IsClass && mySolve.GetInterface("ISolver") != null)
                {
                    var myInterfaceSolve = (Knapsack.ISolver)myAssembly.CreateInstance(mySolve.FullName);
                    var nameAlgorithm = myInterfaceSolve.GetName();
                    algorithms.Add(myInterfaceSolve);
                    cbAlgorithm.Items.Add(nameAlgorithm);
                }
                else MessageBox.Show("Подключаемая библиотека не содержит класс, реализующий нужный интерфейс");
            }
        }
#endregion

        private void btSolve_Click(object sender, EventArgs e)
        {
            btResetSolve_Click(sender, e);
            var countElem = lvThing.Items.Count;
            var weiths = new int[countElem];
            var costs = new int[countElem];
            int i = 0;
            foreach (ListViewItem item in lvThing.Items)
            {
                weiths[i] = int.Parse(item.SubItems[1].Text);
                costs[i] = int.Parse(item.SubItems[2].Text);
                i++;
            }

            var W = int.Parse(tbMaxMass.Text);
            var result = algorithms[cbAlgorithm.SelectedIndex].Solve(W, weiths, costs);
            ShowResult(result);
            btResetSolve.Enabled = true;
        }

        private void btResetSolve_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvThing.Items)
                item.ForeColor = Color.Black;
            tbResult.Text = "";
            btResetSolve.Enabled = false; 
        }
        private void BtSolveEnabled(object sender, EventArgs e)
        {
            int res;
            if (cbAlgorithm.SelectedIndex != -1 && tbMaxMass.TextLength != 0 && int.TryParse(tbMaxMass.Text, out res))
                btSolve.Enabled = true;
            else btSolve.Enabled = false;
        }

        private int ChangeNumber()
        {
            int max = 1;
            foreach (ListViewItem item in lvThing.Items)
            {
                item.SubItems[0].Text = max.ToString();
                max++;
            }
            return max;
        }

        private void AddThing(string weith, string cost)
        {
            lvThing.Items.Add(new ListViewItem(new[] { ChangeNumber().ToString(), weith, cost }));
            tbMaxMass.Enabled = true;
        }

        private void ShowResult(bool[] res)
        {
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i])
                {
                    var curElem = (i + 1).ToString();
                    if (tbResult.Text == "")
                        tbResult.Text += "Выбранные предметы: " + curElem;
                    else
                        tbResult.Text += ", " + curElem;
                    lvThing.Items[i].ForeColor = Color.Red;
                }
            }
        }
    }
}
