using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Integration
{
    public partial class UpsertThingFrm : Form
    {
        public enum State
        {
            Insert,
            Update
        }

        public string Weight
        {
            get { return tbWeight.Text; }
            set { tbWeight.Text = value; }
        }
        public string Cost
        {
            get { return tbCost.Text; }
            set { tbCost.Text = value; }
        }

        public bool BtOk
        {
            get { return btOK.Enabled; }
            set { btOK.Enabled = value; }
        }

        public UpsertThingFrm(State frmState)
        {
            InitializeComponent();
            switch (frmState)
            {
                case State.Insert:
                    btOK.Text = @"Добавить";
                    btOK.Enabled = false;
                    break;

                case State.Update:
                    Text = "Изменение данных";
                    btOK.Text = @"Изменть";
                    break;     
            }
        }

        private void CheckTb(object sender, EventArgs e)
        {
            int res, res1;
            if (tbCost.TextLength != 0 && tbWeight.TextLength != 0
                && int.TryParse(tbWeight.Text, out res) && int.TryParse(tbCost.Text, out res1))
                btOK.Enabled = true;
            else
                btOK.Enabled = false;
        }
    }
}
