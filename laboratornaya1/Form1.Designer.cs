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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.dataGridViewUSERS = new System.Windows.Forms.DataGridView();
            this.ID_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tariff_fkDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeOfUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(26, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1600, 594);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonSort);
            this.tabPage3.Controls.Add(this.comboBoxUserPick);
            this.tabPage3.Controls.Add(this.buttonGetReport1);
            this.tabPage3.Controls.Add(this.dataGridViewUSERS);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1592, 561);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(392, 12);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(144, 52);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Отсортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(17, 25);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(350, 28);
            this.comboBoxUserPick.TabIndex = 4;
            this.comboBoxUserPick.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(17, 477);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(161, 70);
            this.buttonGetReport1.TabIndex = 1;
            this.buttonGetReport1.Text = "Добавить";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // dataGridViewUSERS
            // 
            this.dataGridViewUSERS.AutoGenerateColumns = false;
            this.dataGridViewUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_User,
            this.FIO,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.moneyCountDataGridViewTextBoxColumn,
            this.id_tariff_fkDataGridViewComboBoxColumn,
            this.typeOfUserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.minLeftDataGridViewTextBoxColumn,
            this.gBLeftDataGridViewTextBoxColumn});
            this.dataGridViewUSERS.DataSource = this.bindingSource1;
            this.dataGridViewUSERS.Location = new System.Drawing.Point(17, 82);
            this.dataGridViewUSERS.Name = "dataGridViewUSERS";
            this.dataGridViewUSERS.RowHeadersWidth = 62;
            this.dataGridViewUSERS.RowTemplate.Height = 28;
            this.dataGridViewUSERS.Size = new System.Drawing.Size(1557, 371);
            this.dataGridViewUSERS.TabIndex = 0;
            this.dataGridViewUSERS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUSERS_CellContentClick);
            // 
            // ID_User
            // 
            this.ID_User.DataPropertyName = "ID_User";
            this.ID_User.HeaderText = "ID_User";
            this.ID_User.MinimumWidth = 8;
            this.ID_User.Name = "ID_User";
            this.ID_User.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_User.Width = 150;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "FIO";
            this.FIO.MinimumWidth = 8;
            this.FIO.Name = "FIO";
            this.FIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FIO.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // moneyCountDataGridViewTextBoxColumn
            // 
            this.moneyCountDataGridViewTextBoxColumn.DataPropertyName = "MoneyCount";
            this.moneyCountDataGridViewTextBoxColumn.HeaderText = "MoneyCount";
            this.moneyCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moneyCountDataGridViewTextBoxColumn.Name = "moneyCountDataGridViewTextBoxColumn";
            this.moneyCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // id_tariff_fkDataGridViewComboBoxColumn
            // 
            this.id_tariff_fkDataGridViewComboBoxColumn.DataPropertyName = "ID_Tariff_FK_";
            dataGridViewCellStyle1.NullValue = null;
            this.id_tariff_fkDataGridViewComboBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_tariff_fkDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
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
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // minLeftDataGridViewTextBoxColumn
            // 
            this.minLeftDataGridViewTextBoxColumn.DataPropertyName = "MinLeft";
            this.minLeftDataGridViewTextBoxColumn.HeaderText = "MinLeft";
            this.minLeftDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minLeftDataGridViewTextBoxColumn.Name = "minLeftDataGridViewTextBoxColumn";
            this.minLeftDataGridViewTextBoxColumn.Width = 150;
            // 
            // gBLeftDataGridViewTextBoxColumn
            // 
            this.gBLeftDataGridViewTextBoxColumn.DataPropertyName = "GBLeft";
            this.gBLeftDataGridViewTextBoxColumn.HeaderText = "GBLeft";
            this.gBLeftDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gBLeftDataGridViewTextBoxColumn.Name = "gBLeftDataGridViewTextBoxColumn";
            this.gBLeftDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(laboratornaya1.User);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1592, 561);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Запросы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1256, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 63);
            this.button3.TabIndex = 1;
            this.button3.Text = "Встроенная Процедура";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1256, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Процедура1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1256, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1256, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 26);
            this.dateTimePicker2.TabIndex = 4;
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewUSERS;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_tariff_fkDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gBLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

