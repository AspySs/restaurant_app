namespace BDnet
{
    partial class order_compos_ofic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_compos_ofic));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.find_orderComposition_by_idBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BDnet.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find_orderComposition_by_idTableAdapter = new BDnet.DataSet1TableAdapters.find_orderComposition_by_idTableAdapter();
            this.tableAdapterManager = new BDnet.DataSet1TableAdapters.TableAdapterManager();
            this.menuTableAdapter = new BDnet.DataSet1TableAdapters.MenuTableAdapter();
            this.find_orderComposition_by_idBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ord_idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ord_idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.find_orderComposition_by_idDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idBindingNavigator)).BeginInit();
            this.find_orderComposition_by_idBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.find_orderComposition_by_idBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(774, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "name";
            // 
            // find_orderComposition_by_idBindingSource
            // 
            this.find_orderComposition_by_idBindingSource.DataMember = "find_orderComposition_by_id";
            this.find_orderComposition_by_idBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1033, 587);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.menuBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1033, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "name";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dataSet1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1033, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1033, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "блюдо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1033, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "количество:";
            // 
            // find_orderComposition_by_idTableAdapter
            // 
            this.find_orderComposition_by_idTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
            this.tableAdapterManager.Order_compositionTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BDnet.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // find_orderComposition_by_idBindingNavigator
            // 
            this.find_orderComposition_by_idBindingNavigator.AddNewItem = null;
            this.find_orderComposition_by_idBindingNavigator.BindingSource = this.find_orderComposition_by_idBindingSource;
            this.find_orderComposition_by_idBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.find_orderComposition_by_idBindingNavigator.DeleteItem = null;
            this.find_orderComposition_by_idBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.find_orderComposition_by_idBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.find_orderComposition_by_idBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.find_orderComposition_by_idBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.find_orderComposition_by_idBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.find_orderComposition_by_idBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.find_orderComposition_by_idBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.find_orderComposition_by_idBindingNavigator.Name = "find_orderComposition_by_idBindingNavigator";
            this.find_orderComposition_by_idBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.find_orderComposition_by_idBindingNavigator.Size = new System.Drawing.Size(217, 25);
            this.find_orderComposition_by_idBindingNavigator.TabIndex = 13;
            this.find_orderComposition_by_idBindingNavigator.Text = "bindingNavigator1";
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
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ord_idToolStripLabel,
            this.ord_idToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(1033, 536);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(183, 25);
            this.fillToolStrip.TabIndex = 14;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // ord_idToolStripLabel
            // 
            this.ord_idToolStripLabel.Name = "ord_idToolStripLabel";
            this.ord_idToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.ord_idToolStripLabel.Text = "ord_id:";
            // 
            // ord_idToolStripTextBox
            // 
            this.ord_idToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ord_idToolStripTextBox.Name = "ord_idToolStripTextBox";
            this.ord_idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_7);
            // 
            // find_orderComposition_by_idDataGridView
            // 
            this.find_orderComposition_by_idDataGridView.AllowUserToAddRows = false;
            this.find_orderComposition_by_idDataGridView.AllowUserToDeleteRows = false;
            this.find_orderComposition_by_idDataGridView.AutoGenerateColumns = false;
            this.find_orderComposition_by_idDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.find_orderComposition_by_idDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.find_orderComposition_by_idDataGridView.DataSource = this.find_orderComposition_by_idBindingSource;
            this.find_orderComposition_by_idDataGridView.Location = new System.Drawing.Point(0, 28);
            this.find_orderComposition_by_idDataGridView.Name = "find_orderComposition_by_idDataGridView";
            this.find_orderComposition_by_idDataGridView.ReadOnly = true;
            this.find_orderComposition_by_idDataGridView.Size = new System.Drawing.Size(743, 597);
            this.find_orderComposition_by_idDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "position_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "position_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "order_num";
            this.dataGridViewTextBoxColumn2.HeaderText = "order_num";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "officiant";
            this.dataGridViewTextBoxColumn3.HeaderText = "officiant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "table_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "table_number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn6.HeaderText = "count";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn7.HeaderText = "time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            this.menuDataGridView.AllowUserToDeleteRows = false;
            this.menuDataGridView.AutoGenerateColumns = false;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.menuDataGridView.DataSource = this.menuBindingSource;
            this.menuDataGridView.Location = new System.Drawing.Point(749, 205);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.Size = new System.Drawing.Size(245, 420);
            this.menuDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "position_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "position_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn9.HeaderText = "name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "type";
            this.dataGridViewCheckBoxColumn2.HeaderText = "type";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ingredients";
            this.dataGridViewTextBoxColumn10.HeaderText = "ingredients";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn11.HeaderText = "cost";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1033, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 88);
            this.button4.TabIndex = 15;
            this.button4.Text = "Вернуться";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // order_compos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 645);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.find_orderComposition_by_idDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.find_orderComposition_by_idBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "order_compos";
            this.Text = "order_compos";
            this.Load += new System.EventHandler(this.order_compos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idBindingNavigator)).EndInit();
            this.find_orderComposition_by_idBindingNavigator.ResumeLayout(false);
            this.find_orderComposition_by_idBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.find_orderComposition_by_idDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource find_orderComposition_by_idBindingSource;
        public DataSet1TableAdapters.find_orderComposition_by_idTableAdapter find_orderComposition_by_idTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator find_orderComposition_by_idBindingNavigator;
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
        private System.Windows.Forms.ToolStripLabel ord_idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ord_idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DataSet1TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridView find_orderComposition_by_idDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        public System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button4;
    }
}