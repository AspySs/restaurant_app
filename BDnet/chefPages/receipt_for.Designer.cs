namespace BDnet
{
    partial class receipt_for
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receipt_for));
            this.dataSet1 = new BDnet.DataSet1();
            this.receipt_for_dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receipt_for_dishTableAdapter = new BDnet.DataSet1TableAdapters.receipt_for_dishTableAdapter();
            this.tableAdapterManager = new BDnet.DataSet1TableAdapters.TableAdapterManager();
            this.receipt_for_dishBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.pos_idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pos_idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.receipt_for_dishDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishBindingNavigator)).BeginInit();
            this.receipt_for_dishBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receipt_for_dishBindingSource
            // 
            this.receipt_for_dishBindingSource.DataMember = "receipt_for_dish";
            this.receipt_for_dishBindingSource.DataSource = this.dataSet1;
            // 
            // receipt_for_dishTableAdapter
            // 
            this.receipt_for_dishTableAdapter.ClearBeforeFill = true;
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
            // receipt_for_dishBindingNavigator
            // 
            this.receipt_for_dishBindingNavigator.AddNewItem = null;
            this.receipt_for_dishBindingNavigator.BindingSource = this.receipt_for_dishBindingSource;
            this.receipt_for_dishBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receipt_for_dishBindingNavigator.DeleteItem = null;
            this.receipt_for_dishBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.receipt_for_dishBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.receipt_for_dishBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receipt_for_dishBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receipt_for_dishBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receipt_for_dishBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receipt_for_dishBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receipt_for_dishBindingNavigator.Name = "receipt_for_dishBindingNavigator";
            this.receipt_for_dishBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receipt_for_dishBindingNavigator.Size = new System.Drawing.Size(217, 25);
            this.receipt_for_dishBindingNavigator.TabIndex = 0;
            this.receipt_for_dishBindingNavigator.Text = "bindingNavigator1";
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pos_idToolStripLabel,
            this.pos_idToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(923, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // pos_idToolStripLabel
            // 
            this.pos_idToolStripLabel.Name = "pos_idToolStripLabel";
            this.pos_idToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.pos_idToolStripLabel.Text = "pos_id:";
            // 
            // pos_idToolStripTextBox
            // 
            this.pos_idToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pos_idToolStripTextBox.Name = "pos_idToolStripTextBox";
            this.pos_idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // receipt_for_dishDataGridView
            // 
            this.receipt_for_dishDataGridView.AllowUserToAddRows = false;
            this.receipt_for_dishDataGridView.AllowUserToDeleteRows = false;
            this.receipt_for_dishDataGridView.AutoGenerateColumns = false;
            this.receipt_for_dishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipt_for_dishDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.receipt_for_dishDataGridView.DataSource = this.receipt_for_dishBindingSource;
            this.receipt_for_dishDataGridView.Location = new System.Drawing.Point(0, 28);
            this.receipt_for_dishDataGridView.Name = "receipt_for_dishDataGridView";
            this.receipt_for_dishDataGridView.ReadOnly = true;
            this.receipt_for_dishDataGridView.Size = new System.Drawing.Size(756, 419);
            this.receipt_for_dishDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ingredients";
            this.dataGridViewTextBoxColumn2.HeaderText = "ingredients";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 269);
            this.button1.TabIndex = 3;
            this.button1.Text = "вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receipt_for
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receipt_for_dishDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.receipt_for_dishBindingNavigator);
            this.Name = "receipt_for";
            this.Text = "receipt_for";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishBindingNavigator)).EndInit();
            this.receipt_for_dishBindingNavigator.ResumeLayout(false);
            this.receipt_for_dishBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_for_dishDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource receipt_for_dishBindingSource;
        public DataSet1TableAdapters.receipt_for_dishTableAdapter receipt_for_dishTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receipt_for_dishBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel pos_idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pos_idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView receipt_for_dishDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}