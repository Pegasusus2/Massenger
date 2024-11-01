namespace Avto_v2
{
    partial class Owners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owners));
            this.panel1 = new System.Windows.Forms.Panel();
            this.владелецDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владелецBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto_v2.Microsoft_Access_База_данныхDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.владелецTableAdapter = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.ВладелецTableAdapter();
            this.tableAdapterManager = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager();
            this.владелецBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.владелецBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.владелецDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingNavigator)).BeginInit();
            this.владелецBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.владелецDataGridView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-20, -101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 652);
            this.panel1.TabIndex = 3;
            // 
            // владелецDataGridView
            // 
            this.владелецDataGridView.AutoGenerateColumns = false;
            this.владелецDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.владелецDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.владелецDataGridView.DataSource = this.владелецBindingSource;
            this.владелецDataGridView.Location = new System.Drawing.Point(143, 129);
            this.владелецDataGridView.Name = "владелецDataGridView";
            this.владелецDataGridView.Size = new System.Drawing.Size(549, 220);
            this.владелецDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_владельца";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_владельца";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_прав";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_прав";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // владелецBindingSource
            // 
            this.владелецBindingSource.DataMember = "Владелец";
            this.владелецBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(317, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // владелецTableAdapter
            // 
            this.владелецTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ВладелецTableAdapter = this.владелецTableAdapter;
            this.tableAdapterManager.МастерскаяTableAdapter = null;
            this.tableAdapterManager.МеханикTableAdapter = null;
            this.tableAdapterManager.РемонтTableAdapter = null;
            // 
            // владелецBindingNavigator
            // 
            this.владелецBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.владелецBindingNavigator.BindingSource = this.владелецBindingSource;
            this.владелецBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.владелецBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.владелецBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.владелецBindingNavigatorSaveItem});
            this.владелецBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.владелецBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.владелецBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.владелецBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.владелецBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.владелецBindingNavigator.Name = "владелецBindingNavigator";
            this.владелецBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.владелецBindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.владелецBindingNavigator.TabIndex = 4;
            this.владелецBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // владелецBindingNavigatorSaveItem
            // 
            this.владелецBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.владелецBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("владелецBindingNavigatorSaveItem.Image")));
            this.владелецBindingNavigatorSaveItem.Name = "владелецBindingNavigatorSaveItem";
            this.владелецBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.владелецBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.владелецBindingNavigatorSaveItem.Click += new System.EventHandler(this.владелецBindingNavigatorSaveItem_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 551);
            this.Controls.Add(this.владелецBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "Owners";
            this.Text = "Владельцы";
            this.Load += new System.EventHandler(this.Owners_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.владелецDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владелецBindingNavigator)).EndInit();
            this.владелецBindingNavigator.ResumeLayout(false);
            this.владелецBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource владелецBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.ВладелецTableAdapter владелецTableAdapter;
        private Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator владелецBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton владелецBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView владелецDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}