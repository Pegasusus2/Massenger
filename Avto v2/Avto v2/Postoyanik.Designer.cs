namespace Avto_v2
{
    partial class Postoyanik
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
            this.постоянный_ИтогDataGridView = new System.Windows.Forms.DataGridView();
            this.постоянный_ИтогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new Avto_v2.Microsoft_Access_База_данныхDataSet();
            this.постоянный_ИтогTableAdapter = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.Постоянный_ИтогTableAdapter();
            this.tableAdapterManager = new Avto_v2.Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постоянный_ИтогDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянный_ИтогBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.постоянный_ИтогDataGridView);
            this.panel1.Location = new System.Drawing.Point(-20, -101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 652);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(322, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // постоянный_ИтогDataGridView
            // 
            this.постоянный_ИтогDataGridView.AutoGenerateColumns = false;
            this.постоянный_ИтогDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постоянный_ИтогDataGridView.DataSource = this.постоянный_ИтогBindingSource;
            this.постоянный_ИтогDataGridView.Location = new System.Drawing.Point(263, 113);
            this.постоянный_ИтогDataGridView.Name = "постоянный_ИтогDataGridView";
            this.постоянный_ИтогDataGridView.Size = new System.Drawing.Size(300, 220);
            this.постоянный_ИтогDataGridView.TabIndex = 0;
            // 
            // постоянный_ИтогBindingSource
            // 
            this.постоянный_ИтогBindingSource.DataMember = "Постоянный Итог";
            this.постоянный_ИтогBindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // постоянный_ИтогTableAdapter
            // 
            this.постоянный_ИтогTableAdapter.ClearBeforeFill = true;
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
            // Postoyanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 551);
            this.Controls.Add(this.panel1);
            this.Name = "Postoyanik";
            this.Text = "Постоянный механик";
            this.Load += new System.EventHandler(this.Postoyanik_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.постоянный_ИтогDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянный_ИтогBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource постоянный_ИтогBindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Постоянный_ИтогTableAdapter постоянный_ИтогTableAdapter;
        private Microsoft_Access_База_данныхDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView постоянный_ИтогDataGridView;
        private System.Windows.Forms.Button button1;
    }
}