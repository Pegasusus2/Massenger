namespace Avto1
{
    partial class War
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.механикЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto1.Microsoft_Access_База_данныхDataSet();
            this.категорияИтогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категория_итогTableAdapter = new Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.Категория_итогTableAdapter();
            this.механик_ЗапросTableAdapter = new Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.Механик_ЗапросTableAdapter();
            this.tableAdapterManager = new Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager();
            this.механик_ЗапросDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.механикЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияИтогBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // механикЗапросBindingSource
            // 
            this.механикЗапросBindingSource.DataMember = "Механик Запрос";
            this.механикЗапросBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорияИтогBindingSource
            // 
            this.категорияИтогBindingSource.DataMember = "Категория итог";
            this.категорияИтогBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // категория_итогTableAdapter
            // 
            this.категория_итогTableAdapter.ClearBeforeFill = true;
            // 
            // механик_ЗапросTableAdapter
            // 
            this.механик_ЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВладелецTableAdapter = null;
            this.tableAdapterManager.МастерскаяTableAdapter = null;
            this.tableAdapterManager.МеханикTableAdapter = null;
            this.tableAdapterManager.РемонтTableAdapter = null;
            // 
            // механик_ЗапросDataGridView
            // 
            this.механик_ЗапросDataGridView.AutoGenerateColumns = false;
            this.механик_ЗапросDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.механик_ЗапросDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.механик_ЗапросDataGridView.DataSource = this.механикЗапросBindingSource;
            this.механик_ЗапросDataGridView.Location = new System.Drawing.Point(12, 12);
            this.механик_ЗапросDataGridView.Name = "механик_ЗапросDataGridView";
            this.механик_ЗапросDataGridView.Size = new System.Drawing.Size(350, 220);
            this.механик_ЗапросDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фио";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фио";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Наряда";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Наряда";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Год выпуска";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год выпуска";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.механик_ЗапросDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "War";
            this.Text = "Довоенные";
            this.Load += new System.EventHandler(this.War_Load);
            ((System.ComponentModel.ISupportInitialize)(this.механикЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияИтогBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource категорияИтогBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Категория_итогTableAdapter категория_итогTableAdapter;
        private System.Windows.Forms.BindingSource механикЗапросBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Механик_ЗапросTableAdapter механик_ЗапросTableAdapter;
        private Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView механик_ЗапросDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}