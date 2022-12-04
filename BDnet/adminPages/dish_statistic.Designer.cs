namespace BDnet
{
    partial class dish_statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dish_statistic));
            this.dataSet1 = new BDnet.DataSet1();
            this.statistic_dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistic_dishTableAdapter = new BDnet.DataSet1TableAdapters.statistic_dishTableAdapter();
            this.tableAdapterManager = new BDnet.DataSet1TableAdapters.TableAdapterManager();
            this.statistic_dishBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statistic_dishDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistic_coctailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistic_coctailsTableAdapter = new BDnet.DataSet1TableAdapters.statistic_coctailsTableAdapter();
            this.statistic_coctailsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishBindingNavigator)).BeginInit();
            this.statistic_dishBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_coctailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_coctailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statistic_dishBindingSource
            // 
            this.statistic_dishBindingSource.DataMember = "statistic_dish";
            this.statistic_dishBindingSource.DataSource = this.dataSet1;
            // 
            // statistic_dishTableAdapter
            // 
            this.statistic_dishTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.Order_compositionTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BDnet.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statistic_dishBindingNavigator
            // 
            this.statistic_dishBindingNavigator.AddNewItem = null;
            this.statistic_dishBindingNavigator.BindingSource = this.statistic_dishBindingSource;
            this.statistic_dishBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statistic_dishBindingNavigator.DeleteItem = null;
            this.statistic_dishBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.statistic_dishBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.statistic_dishBindingNavigator.Location = new System.Drawing.Point(9, 50);
            this.statistic_dishBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statistic_dishBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statistic_dishBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statistic_dishBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statistic_dishBindingNavigator.Name = "statistic_dishBindingNavigator";
            this.statistic_dishBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statistic_dishBindingNavigator.Size = new System.Drawing.Size(248, 25);
            this.statistic_dishBindingNavigator.TabIndex = 0;
            this.statistic_dishBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // statistic_dishDataGridView
            // 
            this.statistic_dishDataGridView.AllowUserToAddRows = false;
            this.statistic_dishDataGridView.AllowUserToDeleteRows = false;
            this.statistic_dishDataGridView.AutoGenerateColumns = false;
            this.statistic_dishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statistic_dishDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.statistic_dishDataGridView.DataSource = this.statistic_dishBindingSource;
            this.statistic_dishDataGridView.Location = new System.Drawing.Point(8, 78);
            this.statistic_dishDataGridView.Name = "statistic_dishDataGridView";
            this.statistic_dishDataGridView.ReadOnly = true;
            this.statistic_dishDataGridView.Size = new System.Drawing.Size(440, 485);
            this.statistic_dishDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "popularity";
            this.dataGridViewTextBoxColumn2.HeaderText = "popularity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // statistic_coctailsBindingSource
            // 
            this.statistic_coctailsBindingSource.DataMember = "statistic_coctails";
            this.statistic_coctailsBindingSource.DataSource = this.dataSet1;
            // 
            // statistic_coctailsTableAdapter
            // 
            this.statistic_coctailsTableAdapter.ClearBeforeFill = true;
            // 
            // statistic_coctailsDataGridView
            // 
            this.statistic_coctailsDataGridView.AllowUserToAddRows = false;
            this.statistic_coctailsDataGridView.AllowUserToDeleteRows = false;
            this.statistic_coctailsDataGridView.AutoGenerateColumns = false;
            this.statistic_coctailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statistic_coctailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.popularityDataGridViewTextBoxColumn});
            this.statistic_coctailsDataGridView.DataSource = this.statistic_coctailsBindingSource;
            this.statistic_coctailsDataGridView.Location = new System.Drawing.Point(660, 78);
            this.statistic_coctailsDataGridView.Name = "statistic_coctailsDataGridView";
            this.statistic_coctailsDataGridView.ReadOnly = true;
            this.statistic_coctailsDataGridView.Size = new System.Drawing.Size(459, 485);
            this.statistic_coctailsDataGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // popularityDataGridViewTextBoxColumn
            // 
            this.popularityDataGridViewTextBoxColumn.DataPropertyName = "popularity";
            this.popularityDataGridViewTextBoxColumn.HeaderText = "popularity";
            this.popularityDataGridViewTextBoxColumn.Name = "popularityDataGridViewTextBoxColumn";
            this.popularityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Скрыть окно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.statistic_coctailsBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.bindingNavigator1.Location = new System.Drawing.Point(660, 50);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(217, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // dish_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 565);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statistic_coctailsDataGridView);
            this.Controls.Add(this.statistic_dishDataGridView);
            this.Controls.Add(this.statistic_dishBindingNavigator);
            this.Name = "dish_statistic";
            this.Text = "dish_statistic";
            this.Load += new System.EventHandler(this.dish_statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishBindingNavigator)).EndInit();
            this.statistic_dishBindingNavigator.ResumeLayout(false);
            this.statistic_dishBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_dishDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_coctailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_coctailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource statistic_dishBindingSource;
        private DataSet1TableAdapters.statistic_dishTableAdapter statistic_dishTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statistic_dishBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView statistic_dishDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource statistic_coctailsBindingSource;
        private DataSet1TableAdapters.statistic_coctailsTableAdapter statistic_coctailsTableAdapter;
        private System.Windows.Forms.DataGridView statistic_coctailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popularityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}