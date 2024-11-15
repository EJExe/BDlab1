namespace laboratornaya1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewReps = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DELETEBUTTON = new System.Windows.Forms.Button();
            this.UPDATEBUTTON = new System.Windows.Forms.Button();
            this.ADDBUTTON = new System.Windows.Forms.Button();
            this.SaveUs = new System.Windows.Forms.Button();
            this.dataGridViewUs = new System.Windows.Forms.DataGridView();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Ordersdatagrid = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SaveTarButton = new System.Windows.Forms.Button();
            this.AddTarButton = new System.Windows.Forms.Button();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tariff_fkDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeOfUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReps)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ordersdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1600, 594);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridViewReps);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1592, 561);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Процедуры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReps
            // 
            this.dataGridViewReps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReps.Location = new System.Drawing.Point(40, 33);
            this.dataGridViewReps.Name = "dataGridViewReps";
            this.dataGridViewReps.RowHeadersWidth = 62;
            this.dataGridViewReps.RowTemplate.Height = 28;
            this.dataGridViewReps.Size = new System.Drawing.Size(802, 377);
            this.dataGridViewReps.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DELETEBUTTON);
            this.tabPage1.Controls.Add(this.UPDATEBUTTON);
            this.tabPage1.Controls.Add(this.ADDBUTTON);
            this.tabPage1.Controls.Add(this.SaveUs);
            this.tabPage1.Controls.Add(this.dataGridViewUs);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1592, 561);
            this.tabPage1.TabIndex = 9;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DELETEBUTTON
            // 
            this.DELETEBUTTON.Location = new System.Drawing.Point(1173, 298);
            this.DELETEBUTTON.Name = "DELETEBUTTON";
            this.DELETEBUTTON.Size = new System.Drawing.Size(113, 66);
            this.DELETEBUTTON.TabIndex = 4;
            this.DELETEBUTTON.Text = "DELETE";
            this.DELETEBUTTON.UseVisualStyleBackColor = true;
            this.DELETEBUTTON.Click += new System.EventHandler(this.DELETEBUTTON_Click);
            // 
            // UPDATEBUTTON
            // 
            this.UPDATEBUTTON.Location = new System.Drawing.Point(1171, 223);
            this.UPDATEBUTTON.Name = "UPDATEBUTTON";
            this.UPDATEBUTTON.Size = new System.Drawing.Size(115, 69);
            this.UPDATEBUTTON.TabIndex = 3;
            this.UPDATEBUTTON.Text = "UPDATE";
            this.UPDATEBUTTON.UseVisualStyleBackColor = true;
            this.UPDATEBUTTON.Click += new System.EventHandler(this.UPDATEBUTTON_Click);
            // 
            // ADDBUTTON
            // 
            this.ADDBUTTON.Location = new System.Drawing.Point(1171, 148);
            this.ADDBUTTON.Name = "ADDBUTTON";
            this.ADDBUTTON.Size = new System.Drawing.Size(115, 69);
            this.ADDBUTTON.TabIndex = 2;
            this.ADDBUTTON.Text = "ADD";
            this.ADDBUTTON.UseVisualStyleBackColor = true;
            this.ADDBUTTON.Click += new System.EventHandler(this.ADDBUTTON_Click);
            // 
            // SaveUs
            // 
            this.SaveUs.Location = new System.Drawing.Point(1173, 59);
            this.SaveUs.Name = "SaveUs";
            this.SaveUs.Size = new System.Drawing.Size(115, 69);
            this.SaveUs.TabIndex = 1;
            this.SaveUs.Text = "Сохранить";
            this.SaveUs.UseVisualStyleBackColor = true;
            this.SaveUs.Click += new System.EventHandler(this.SaveUs_Click);
            // 
            // dataGridViewUs
            // 
            this.dataGridViewUs.AutoGenerateColumns = false;
            this.dataGridViewUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUserDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.id_tariff_fkDataGridViewComboBoxColumn,
            this.typeOfUserDataGridViewTextBoxColumn});
            this.dataGridViewUs.DataSource = this.bindingSource1;
            this.dataGridViewUs.Location = new System.Drawing.Point(64, 43);
            this.dataGridViewUs.Name = "dataGridViewUs";
            this.dataGridViewUs.RowHeadersWidth = 62;
            this.dataGridViewUs.RowTemplate.Height = 28;
            this.dataGridViewUs.Size = new System.Drawing.Size(1054, 445);
            this.dataGridViewUs.TabIndex = 0;
            this.dataGridViewUs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUs_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отчет1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(898, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 95);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отчет2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(898, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(898, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AddTarButton);
            this.tabPage3.Controls.Add(this.SaveTarButton);
            this.tabPage3.Controls.Add(this.Ordersdatagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1592, 561);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Тарифы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Ordersdatagrid
            // 
            this.Ordersdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordersdatagrid.Location = new System.Drawing.Point(46, 32);
            this.Ordersdatagrid.Name = "Ordersdatagrid";
            this.Ordersdatagrid.RowHeadersWidth = 62;
            this.Ordersdatagrid.RowTemplate.Height = 28;
            this.Ordersdatagrid.Size = new System.Drawing.Size(941, 442);
            this.Ordersdatagrid.TabIndex = 0;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Services.UsersService);
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // SaveTarButton
            // 
            this.SaveTarButton.Location = new System.Drawing.Point(1051, 40);
            this.SaveTarButton.Name = "SaveTarButton";
            this.SaveTarButton.Size = new System.Drawing.Size(142, 70);
            this.SaveTarButton.TabIndex = 1;
            this.SaveTarButton.Text = "Сохранить";
            this.SaveTarButton.UseVisualStyleBackColor = true;
            // 
            // AddTarButton
            // 
            this.AddTarButton.Location = new System.Drawing.Point(1051, 132);
            this.AddTarButton.Name = "AddTarButton";
            this.AddTarButton.Size = new System.Drawing.Size(142, 69);
            this.AddTarButton.TabIndex = 2;
            this.AddTarButton.Text = "Добавить";
            this.AddTarButton.UseVisualStyleBackColor = true;
            this.AddTarButton.Click += new System.EventHandler(this.AddTarButton_Click);
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // id_tariff_fkDataGridViewComboBoxColumn
            // 
            this.id_tariff_fkDataGridViewComboBoxColumn.DataPropertyName = "ID_Tariff_FK_";
            this.id_tariff_fkDataGridViewComboBoxColumn.HeaderText = "ID_Tariff_FK_";
            this.id_tariff_fkDataGridViewComboBoxColumn.MinimumWidth = 8;
            this.id_tariff_fkDataGridViewComboBoxColumn.Name = "id_tariff_fkDataGridViewComboBoxColumn";
            this.id_tariff_fkDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_tariff_fkDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_tariff_fkDataGridViewComboBoxColumn.Width = 150;
            // 
            // typeOfUserDataGridViewTextBoxColumn
            // 
            this.typeOfUserDataGridViewTextBoxColumn.DataPropertyName = "TypeOfUser";
            this.typeOfUserDataGridViewTextBoxColumn.HeaderText = "TypeOfUser";
            this.typeOfUserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfUserDataGridViewTextBoxColumn.Name = "typeOfUserDataGridViewTextBoxColumn";
            this.typeOfUserDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(laboratornaya1.User);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReps)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ordersdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewReps;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewUs;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_tariff_fkDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ADDBUTTON;
        private System.Windows.Forms.Button SaveUs;
        private System.Windows.Forms.Button UPDATEBUTTON;
        private System.Windows.Forms.Button DELETEBUTTON;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView Ordersdatagrid;
        private System.Windows.Forms.Button AddTarButton;
        private System.Windows.Forms.Button SaveTarButton;
    }
}

