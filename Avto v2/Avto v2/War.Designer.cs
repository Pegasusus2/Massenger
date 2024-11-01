namespace Avto_v2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.microsoft_Access_База_данныхDataSet = new Avto_v2.Microsoft_Access_База_данныхDataSet();
            this.механик_ЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.механик_ЗапросTableAdapter = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.Механик_ЗапросTableAdapter();
            this.tableAdapterManager = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager();
            this.механик_ЗапросDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.механик_ЗапросDataGridView);
            this.panel1.Location = new System.Drawing.Point(-50, -48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 554);
            this.panel1.TabIndex = 0;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // механик_ЗапросBindingSource
            // 
            this.механик_ЗапросBindingSource.DataMember = "Механик Запрос";
            this.механик_ЗапросBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // механик_ЗапросTableAdapter
            // 
            this.механик_ЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.механик_ЗапросDataGridView.DataSource = this.механик_ЗапросBindingSource;
            this.механик_ЗапросDataGridView.Location = new System.Drawing.Point(335, 60);
            this.механик_ЗапросDataGridView.Name = "механик_ЗапросDataGridView";
            this.механик_ЗапросDataGridView.Size = new System.Drawing.Size(347, 220);
            this.механик_ЗапросDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(398, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 506);
            this.Controls.Add(this.panel1);
            this.Name = "War";
            this.Text = "War";
            this.Load += new System.EventHandler(this.War_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.механик_ЗапросDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource механик_ЗапросBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Механик_ЗапросTableAdapter механик_ЗапросTableAdapter;
        private Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView механик_ЗапросDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}