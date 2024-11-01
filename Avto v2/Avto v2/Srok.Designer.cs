namespace Avto_v2
{
    partial class Srok
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
            this.button1 = new System.Windows.Forms.Button();
            this.авто_ЗапросDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авто_ЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto_v2.Microsoft_Access_База_данныхDataSet();
            this.авто_ЗапросTableAdapter = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.Авто_ЗапросTableAdapter();
            this.tableAdapterManager = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.авто_ЗапросDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авто_ЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.авто_ЗапросDataGridView);
            this.panel1.Location = new System.Drawing.Point(-5, -92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 652);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(323, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // авто_ЗапросDataGridView
            // 
            this.авто_ЗапросDataGridView.AutoGenerateColumns = false;
            this.авто_ЗапросDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.авто_ЗапросDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.авто_ЗапросDataGridView.DataSource = this.авто_ЗапросBindingSource;
            this.авто_ЗапросDataGridView.Location = new System.Drawing.Point(104, 104);
            this.авто_ЗапросDataGridView.Name = "авто_ЗапросDataGridView";
            this.авто_ЗапросDataGridView.Size = new System.Drawing.Size(645, 220);
            this.авто_ЗапросDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn1.HeaderText = "Марка";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата выдочи наряда";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата выдочи наряда";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Планорвая дата оканчания";
            this.dataGridViewTextBoxColumn5.HeaderText = "Планорвая дата оканчания";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Реальная дата окончания";
            this.dataGridViewTextBoxColumn6.HeaderText = "Реальная дата окончания";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // авто_ЗапросBindingSource
            // 
            this.авто_ЗапросBindingSource.DataMember = "Авто Запрос";
            this.авто_ЗапросBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авто_ЗапросTableAdapter
            // 
            this.авто_ЗапросTableAdapter.ClearBeforeFill = true;
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
            // Srok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 512);
            this.Controls.Add(this.panel1);
            this.Name = "Srok";
            this.Text = "Мерседесс - 600";
            this.Load += new System.EventHandler(this.Srok_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.авто_ЗапросDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авто_ЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource авто_ЗапросBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Авто_ЗапросTableAdapter авто_ЗапросTableAdapter;
        private Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView авто_ЗапросDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}