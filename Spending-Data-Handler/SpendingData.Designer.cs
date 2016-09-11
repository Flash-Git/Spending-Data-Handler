namespace Spending_Data_Handler
{
    partial class SpendingData
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd_New_Purchase = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(272, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Spending Data";
            // 
            // btnAdd_New_Purchase
            // 
            this.btnAdd_New_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_New_Purchase.Location = new System.Drawing.Point(279, 514);
            this.btnAdd_New_Purchase.Name = "btnAdd_New_Purchase";
            this.btnAdd_New_Purchase.Size = new System.Drawing.Size(237, 59);
            this.btnAdd_New_Purchase.TabIndex = 6;
            this.btnAdd_New_Purchase.Text = "Add New Purchase";
            this.btnAdd_New_Purchase.UseVisualStyleBackColor = true;
            this.btnAdd_New_Purchase.Click += new System.EventHandler(this.btnAdd_New_Purchase_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWeek,
            this.ColumnType,
            this.ColumnTotal,
            this.ColumnName1,
            this.ColumnName2,
            this.ColumnName3,
            this.ColumnName4});
            this.dataGridView.Location = new System.Drawing.Point(12, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(774, 429);
            this.dataGridView.TabIndex = 11;
            // 
            // ColumnWeek
            // 
            this.ColumnWeek.HeaderText = "Date";
            this.ColumnWeek.Name = "ColumnWeek";
            this.ColumnWeek.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // ColumnName1
            // 
            this.ColumnName1.HeaderText = "Name1";
            this.ColumnName1.Name = "ColumnName1";
            this.ColumnName1.ReadOnly = true;
            // 
            // ColumnName2
            // 
            this.ColumnName2.HeaderText = "Name2";
            this.ColumnName2.Name = "ColumnName2";
            this.ColumnName2.ReadOnly = true;
            // 
            // ColumnName3
            // 
            this.ColumnName3.HeaderText = "Name3";
            this.ColumnName3.Name = "ColumnName3";
            this.ColumnName3.ReadOnly = true;
            // 
            // ColumnName4
            // 
            this.ColumnName4.HeaderText = "Name4";
            this.ColumnName4.Name = "ColumnName4";
            this.ColumnName4.ReadOnly = true;
            // 
            // SpendingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 585);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAdd_New_Purchase);
            this.Controls.Add(this.lblTitle);
            this.Name = "SpendingData";
            this.Text = "Spending Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd_New_Purchase;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName4;
    }
}