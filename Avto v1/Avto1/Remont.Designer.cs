namespace Avto1
{
    partial class Remont
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idНарядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idВладельцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.механикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idМастерскойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьНарядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдочиНарядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto1.Microsoft_Access_База_данныхDataSet();
            this.ремонтTableAdapter = new Avto1.Microsoft_Access_База_данныхDataSetTableAdapters.РемонтTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idНарядаDataGridViewTextBoxColumn,
            this.idАвтоDataGridViewTextBoxColumn,
            this.idВладельцаDataGridViewTextBoxColumn,
            this.механикDataGridViewTextBoxColumn,
            this.idМастерскойDataGridViewTextBoxColumn,
            this.стоимостьНарядаDataGridViewTextBoxColumn,
            this.датаВыдочиНарядаDataGridViewTextBoxColumn,
            this.категорияРаботDataGridViewTextBoxColumn,
            this.планорваяДатаОканчанияDataGridViewTextBoxColumn,
            this.реальнаяДатаОкончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ремонтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1054, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // idНарядаDataGridViewTextBoxColumn
            // 
            this.idНарядаDataGridViewTextBoxColumn.DataPropertyName = "Id_Наряда";
            this.idНарядаDataGridViewTextBoxColumn.HeaderText = "Id_Наряда";
            this.idНарядаDataGridViewTextBoxColumn.Name = "idНарядаDataGridViewTextBoxColumn";
            // 
            // idАвтоDataGridViewTextBoxColumn
            // 
            this.idАвтоDataGridViewTextBoxColumn.DataPropertyName = "Id_Авто";
            this.idАвтоDataGridViewTextBoxColumn.HeaderText = "Id_Авто";
            this.idАвтоDataGridViewTextBoxColumn.Name = "idАвтоDataGridViewTextBoxColumn";
            // 
            // idВладельцаDataGridViewTextBoxColumn
            // 
            this.idВладельцаDataGridViewTextBoxColumn.DataPropertyName = "Id_Владельца";
            this.idВладельцаDataGridViewTextBoxColumn.HeaderText = "Id_Владельца";
            this.idВладельцаDataGridViewTextBoxColumn.Name = "idВладельцаDataGridViewTextBoxColumn";
            // 
            // механикDataGridViewTextBoxColumn
            // 
            this.механикDataGridViewTextBoxColumn.DataPropertyName = "Механик";
            this.механикDataGridViewTextBoxColumn.HeaderText = "Механик";
            this.механикDataGridViewTextBoxColumn.Name = "механикDataGridViewTextBoxColumn";
            // 
            // idМастерскойDataGridViewTextBoxColumn
            // 
            this.idМастерскойDataGridViewTextBoxColumn.DataPropertyName = "Id_Мастерской";
            this.idМастерскойDataGridViewTextBoxColumn.HeaderText = "Id_Мастерской";
            this.idМастерскойDataGridViewTextBoxColumn.Name = "idМастерскойDataGridViewTextBoxColumn";
            // 
            // стоимостьНарядаDataGridViewTextBoxColumn
            // 
            this.стоимостьНарядаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость наряда";
            this.стоимостьНарядаDataGridViewTextBoxColumn.HeaderText = "Стоимость наряда";
            this.стоимостьНарядаDataGridViewTextBoxColumn.Name = "стоимостьНарядаDataGridViewTextBoxColumn";
            // 
            // датаВыдочиНарядаDataGridViewTextBoxColumn
            // 
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.DataPropertyName = "Дата выдочи наряда";
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.HeaderText = "Дата выдочи наряда";
            this.датаВыдочиНарядаDataGridViewTextBoxColumn.Name = "датаВыдочиНарядаDataGridViewTextBoxColumn";
            // 
            // категорияРаботDataGridViewTextBoxColumn
            // 
            this.категорияРаботDataGridViewTextBoxColumn.DataPropertyName = "Категория работ";
            this.категорияРаботDataGridViewTextBoxColumn.HeaderText = "Категория работ";
            this.категорияРаботDataGridViewTextBoxColumn.Name = "категорияРаботDataGridViewTextBoxColumn";
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
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // Remont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Remont";
            this.Text = "Наряды";
            this.Load += new System.EventHandler(this.Remont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idНарядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idВладельцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn механикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМастерскойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьНарядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдочиНарядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn планорваяДатаОканчанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn реальнаяДатаОкончанияDataGridViewTextBoxColumn;
    }
}