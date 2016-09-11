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
    public partial class SpendingData : Form
    {
        public SpendingData()
        {
            InitializeComponent();
        }

        private void btnAdd_New_Purchase_Click(object sender, EventArgs e)
        {
            spendingForm frm = new spendingForm();
            frm.Show();
        }
    }
}
