using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spending_Data_Handler
{
    public partial class spendingForm : Form
    {
        public spendingForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Spending_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is CheckedListBox)
                {
                    CheckedListBox checkedListBox = (CheckedListBox)control;
                    foreach(int i in checkedListBox.CheckedIndices)
                    {
                        checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }
    }
}
