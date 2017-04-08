namespace PresentationLayerWinform
{
    partial class EmployeeList
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
            this.practico1DataSet1 = new Shared.Practico1DataSet();
            this.employee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.practico1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.SuspendLayout();
            // 
            // practico1DataSet1
            // 
            this.practico1DataSet1.DataSetName = "Practico1DataSet";
            this.practico1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee
            // 
            this.employee.AllowUserToAddRows = false;
            this.employee.AllowUserToDeleteRows = false;
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.Location = new System.Drawing.Point(32, 43);
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.Size = new System.Drawing.Size(702, 609);
            this.employee.TabIndex = 0;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 697);
            this.Controls.Add(this.employee);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.practico1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.Practico1DataSet practico1DataSet1;
        private System.Windows.Forms.DataGridView employee;
    }
}

