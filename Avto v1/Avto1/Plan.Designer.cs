namespace Avto1
{
    partial class Plan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idНарядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдочиНарядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановыйСрокзадержкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto1.Microsoft_Access_База_данныхDataSet();
            this.плановый_срок_задержка_TableAdapter = new Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.Плановый_срок_задержка_TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.плановыйСрокзадержкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.маркаDataGridViewTextBoxColumn,
            this.idНарядаDataGridViewTextBoxColumn,
            this.датаВыдочиНарядаDataGridViewTextBoxColumn,
            this.фиоDataGridViewTextBoxColumn,
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn,
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.плановыйСрокзадержкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            // 
            // idНарядаDataGridViewTextBoxColumn
            // 
            this.idНарядаDataGridViewTextBoxColumn.DataPropertyName = "Id_Наряда";
            this.idНарядаDataGridViewTextBoxColumn.HeaderText = "Id_Наряда";
            this.idНарядаDataGridViewTextBoxColumn.Name = "idНарядаDataGridViewTextBoxColumn";
            // 
            // датаВыдочиНарядаDataGridViewTextBoxColumn
            // 
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.DataPropertyName = "Дата выдочи наряда";
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.HeaderText = "Дата выдочи наряда";
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.Name = "датаВыдочиНарядаDataGridViewTextBoxColumn";
            // 
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "Фио";
            this.фиоDataGridViewTextBoxColumn.HeaderText = "Фио";
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            // 
            // планорваяДатаОканчанияDataGridViewTextBoxColumn
            // 
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn.DataPropertyName = "Планорвая дата оканчания";
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn.HeaderText = "Планорвая дата оканчания";
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn.Name = "планорваяДатаОканчанияDataGridViewTextBoxColumn";
            // 
            // реальнаяДатаОкончанияDataGridViewTextBoxColumn
            // 
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Реальная дата окончания";
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn.HeaderText = "Реальная дата окончания";
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn.Name = "реальнаяДатаОкончанияDataGridViewTextBoxColumn";
            // 
            // плановыйСрокзадержкаBindingSource
            // 
            this.плановыйСрокзадержкаBindingSource.DataMember = "Плановый срок(задержка)";
            this.плановыйСрокзадержкаBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // плановый_срок_задержка_TableAdapter
            // 
            this.плановый_срок_задержка_TableAdapter.ClearBeforeFill = true;
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
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Plan";
            this.Text = "Мерседес-600";
            this.Load += new System.EventHandler(this.Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.плановыйСрокзадержкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource плановыйСрокзадержкаBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Плановый_срок_задержка_TableAdapter плановый_срок_задержка_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idНарядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдочиНарядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn планорваяДатаОканчанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn реальнаяДатаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}