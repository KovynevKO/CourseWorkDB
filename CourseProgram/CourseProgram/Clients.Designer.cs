namespace CourseProgram
{
    partial class Clients
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
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cW_KDataSet = new CourseProgram.CW_KDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.cClientTableAdapter = new CourseProgram.CW_KDataSetTableAdapters.cClientTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_KDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cClientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // cClientBindingSource
            // 
            this.cClientBindingSource.DataMember = "cClient";
            this.cClientBindingSource.DataSource = this.cW_KDataSet;
            // 
            // cW_KDataSet
            // 
            this.cW_KDataSet.DataSetName = "CW_KDataSet";
            this.cW_KDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зачинити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cClientTableAdapter
            // 
            this.cClientTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Видалити інформацію";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Зберегти інформацію";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 52);
            this.label1.TabIndex = 77;
            this.label1.Text = "- Додавання відбувається за допомогою таблиці \r\n(редагування порожнього нижнього " +
    "рядка)\r\n- Зміна даних відбувається за допомогою \r\nредагування даних в таблиці\r\n";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(141, 413);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 76;
            this.button8.Text = "Фільтрувати";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 416);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(123, 20);
            this.textBox11.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Фільтрувати за параметром (OrderId=2): ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 73;
            this.button6.Text = "Сортувати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 365);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(123, 20);
            this.textBox10.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Сортувати за параметром (Приклад: OrderId)";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cW_KDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private CW_KDataSet cW_KDataSet;
        private System.Windows.Forms.BindingSource cClientBindingSource;
        private CW_KDataSetTableAdapters.cClientTableAdapter cClientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
    }
}