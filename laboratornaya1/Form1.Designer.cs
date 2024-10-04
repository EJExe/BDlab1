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
            this.comboBoxUserReport = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonUserSave = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.tabPageTariff = new System.Windows.Forms.TabPage();
            this.buttonTariffsave = new System.Windows.Forms.Button();
            this.dataGridViewTariff = new System.Windows.Forms.DataGridView();
            this.tabPageCall = new System.Windows.Forms.TabPage();
            this.buttonRemoveCall = new System.Windows.Forms.Button();
            this.buttonADDcall = new System.Windows.Forms.Button();
            this.SaveCALL = new System.Windows.Forms.Button();
            this.dataGridViewCall = new System.Windows.Forms.DataGridView();
            this.tabPageTypeOfCall = new System.Windows.Forms.TabPage();
            this.dataGridViewTypeOfCall = new System.Windows.Forms.DataGridView();
            this.tabPageSpravochnikTariff = new System.Windows.Forms.TabPage();
            this.dataGridViewSpravochnikTariff = new System.Windows.Forms.DataGridView();
            this.tabPageTypeUser = new System.Windows.Forms.TabPage();
            this.dataGridViewTypeUser = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewVlojProc = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageTariff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTariff)).BeginInit();
            this.tabPageCall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCall)).BeginInit();
            this.tabPageTypeOfCall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeOfCall)).BeginInit();
            this.tabPageSpravochnikTariff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravochnikTariff)).BeginInit();
            this.tabPageTypeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeUser)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVlojProc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserReport
            // 
            this.comboBoxUserReport.FormattingEnabled = true;
            this.comboBoxUserReport.Location = new System.Drawing.Point(26, 545);
            this.comboBoxUserReport.Name = "comboBoxUserReport";
            this.comboBoxUserReport.Size = new System.Drawing.Size(389, 28);
            this.comboBoxUserReport.TabIndex = 1;
            this.comboBoxUserReport.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserReport_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageTariff);
            this.tabControl1.Controls.Add(this.tabPageCall);
            this.tabControl1.Controls.Add(this.tabPageTypeOfCall);
            this.tabControl1.Controls.Add(this.tabPageSpravochnikTariff);
            this.tabControl1.Controls.Add(this.tabPageTypeUser);
            this.tabControl1.Location = new System.Drawing.Point(26, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.buttonRemoveUser);
            this.tabPageUser.Controls.Add(this.buttonADD);
            this.tabPageUser.Controls.Add(this.buttonUserSave);
            this.tabPageUser.Controls.Add(this.dataGridViewUser);
            this.tabPageUser.Location = new System.Drawing.Point(4, 29);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(844, 462);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "Пользователь";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Location = new System.Drawing.Point(308, 366);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(120, 46);
            this.buttonRemoveUser.TabIndex = 3;
            this.buttonRemoveUser.Text = "Удалить";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(308, 314);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(120, 46);
            this.buttonADD.TabIndex = 2;
            this.buttonADD.Text = "Добавить ";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonUserSave
            // 
            this.buttonUserSave.Location = new System.Drawing.Point(26, 309);
            this.buttonUserSave.Name = "buttonUserSave";
            this.buttonUserSave.Size = new System.Drawing.Size(261, 137);
            this.buttonUserSave.TabIndex = 1;
            this.buttonUserSave.Text = "Сохранить ";
            this.buttonUserSave.UseVisualStyleBackColor = true;
            this.buttonUserSave.Click += new System.EventHandler(this.buttonUserSave_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(832, 279);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // tabPageTariff
            // 
            this.tabPageTariff.Controls.Add(this.buttonTariffsave);
            this.tabPageTariff.Controls.Add(this.dataGridViewTariff);
            this.tabPageTariff.Location = new System.Drawing.Point(4, 29);
            this.tabPageTariff.Name = "tabPageTariff";
            this.tabPageTariff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTariff.Size = new System.Drawing.Size(844, 462);
            this.tabPageTariff.TabIndex = 1;
            this.tabPageTariff.Text = "Тариф";
            this.tabPageTariff.UseVisualStyleBackColor = true;
            // 
            // buttonTariffsave
            // 
            this.buttonTariffsave.Location = new System.Drawing.Point(19, 310);
            this.buttonTariffsave.Name = "buttonTariffsave";
            this.buttonTariffsave.Size = new System.Drawing.Size(222, 136);
            this.buttonTariffsave.TabIndex = 1;
            this.buttonTariffsave.Text = "Сохранить ";
            this.buttonTariffsave.UseVisualStyleBackColor = true;
            this.buttonTariffsave.Click += new System.EventHandler(this.buttonTariffsave_Click);
            // 
            // dataGridViewTariff
            // 
            this.dataGridViewTariff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTariff.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTariff.Name = "dataGridViewTariff";
            this.dataGridViewTariff.RowHeadersWidth = 62;
            this.dataGridViewTariff.RowTemplate.Height = 28;
            this.dataGridViewTariff.Size = new System.Drawing.Size(843, 290);
            this.dataGridViewTariff.TabIndex = 0;
            // 
            // tabPageCall
            // 
            this.tabPageCall.Controls.Add(this.buttonRemoveCall);
            this.tabPageCall.Controls.Add(this.buttonADDcall);
            this.tabPageCall.Controls.Add(this.SaveCALL);
            this.tabPageCall.Controls.Add(this.dataGridViewCall);
            this.tabPageCall.Location = new System.Drawing.Point(4, 29);
            this.tabPageCall.Name = "tabPageCall";
            this.tabPageCall.Size = new System.Drawing.Size(844, 462);
            this.tabPageCall.TabIndex = 2;
            this.tabPageCall.Text = "Звонок";
            this.tabPageCall.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCall
            // 
            this.buttonRemoveCall.Location = new System.Drawing.Point(257, 359);
            this.buttonRemoveCall.Name = "buttonRemoveCall";
            this.buttonRemoveCall.Size = new System.Drawing.Size(137, 44);
            this.buttonRemoveCall.TabIndex = 3;
            this.buttonRemoveCall.Text = "Удалить";
            this.buttonRemoveCall.UseVisualStyleBackColor = true;
            this.buttonRemoveCall.Click += new System.EventHandler(this.buttonRemoveCall_Click);
            // 
            // buttonADDcall
            // 
            this.buttonADDcall.Location = new System.Drawing.Point(257, 309);
            this.buttonADDcall.Name = "buttonADDcall";
            this.buttonADDcall.Size = new System.Drawing.Size(137, 44);
            this.buttonADDcall.TabIndex = 2;
            this.buttonADDcall.Text = "Добавить ";
            this.buttonADDcall.UseVisualStyleBackColor = true;
            this.buttonADDcall.Click += new System.EventHandler(this.buttonADDcall_Click);
            // 
            // SaveCALL
            // 
            this.SaveCALL.Location = new System.Drawing.Point(15, 303);
            this.SaveCALL.Name = "SaveCALL";
            this.SaveCALL.Size = new System.Drawing.Size(226, 146);
            this.SaveCALL.TabIndex = 1;
            this.SaveCALL.Text = "Сохранить ";
            this.SaveCALL.UseVisualStyleBackColor = true;
            this.SaveCALL.Click += new System.EventHandler(this.SaveCALL_Click);
            // 
            // dataGridViewCall
            // 
            this.dataGridViewCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCall.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewCall.Name = "dataGridViewCall";
            this.dataGridViewCall.RowHeadersWidth = 62;
            this.dataGridViewCall.RowTemplate.Height = 28;
            this.dataGridViewCall.Size = new System.Drawing.Size(841, 285);
            this.dataGridViewCall.TabIndex = 0;
            // 
            // tabPageTypeOfCall
            // 
            this.tabPageTypeOfCall.Controls.Add(this.dataGridViewTypeOfCall);
            this.tabPageTypeOfCall.Location = new System.Drawing.Point(4, 29);
            this.tabPageTypeOfCall.Name = "tabPageTypeOfCall";
            this.tabPageTypeOfCall.Size = new System.Drawing.Size(844, 462);
            this.tabPageTypeOfCall.TabIndex = 3;
            this.tabPageTypeOfCall.Text = "Тип Звонка";
            this.tabPageTypeOfCall.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTypeOfCall
            // 
            this.dataGridViewTypeOfCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeOfCall.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewTypeOfCall.Name = "dataGridViewTypeOfCall";
            this.dataGridViewTypeOfCall.RowHeadersWidth = 62;
            this.dataGridViewTypeOfCall.RowTemplate.Height = 28;
            this.dataGridViewTypeOfCall.Size = new System.Drawing.Size(844, 288);
            this.dataGridViewTypeOfCall.TabIndex = 0;
            // 
            // tabPageSpravochnikTariff
            // 
            this.tabPageSpravochnikTariff.Controls.Add(this.dataGridViewSpravochnikTariff);
            this.tabPageSpravochnikTariff.Location = new System.Drawing.Point(4, 29);
            this.tabPageSpravochnikTariff.Name = "tabPageSpravochnikTariff";
            this.tabPageSpravochnikTariff.Size = new System.Drawing.Size(844, 462);
            this.tabPageSpravochnikTariff.TabIndex = 4;
            this.tabPageSpravochnikTariff.Text = "Справочник Тарифов";
            this.tabPageSpravochnikTariff.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSpravochnikTariff
            // 
            this.dataGridViewSpravochnikTariff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpravochnikTariff.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewSpravochnikTariff.Name = "dataGridViewSpravochnikTariff";
            this.dataGridViewSpravochnikTariff.RowHeadersWidth = 62;
            this.dataGridViewSpravochnikTariff.RowTemplate.Height = 28;
            this.dataGridViewSpravochnikTariff.Size = new System.Drawing.Size(848, 291);
            this.dataGridViewSpravochnikTariff.TabIndex = 0;
            // 
            // tabPageTypeUser
            // 
            this.tabPageTypeUser.Controls.Add(this.dataGridViewTypeUser);
            this.tabPageTypeUser.Location = new System.Drawing.Point(4, 29);
            this.tabPageTypeUser.Name = "tabPageTypeUser";
            this.tabPageTypeUser.Size = new System.Drawing.Size(844, 462);
            this.tabPageTypeUser.TabIndex = 5;
            this.tabPageTypeUser.Text = "Типы Пользователей";
            this.tabPageTypeUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTypeUser
            // 
            this.dataGridViewTypeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeUser.Location = new System.Drawing.Point(3, 4);
            this.dataGridViewTypeUser.Name = "dataGridViewTypeUser";
            this.dataGridViewTypeUser.RowHeadersWidth = 62;
            this.dataGridViewTypeUser.RowTemplate.Height = 28;
            this.dataGridViewTypeUser.Size = new System.Drawing.Size(844, 291);
            this.dataGridViewTypeUser.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(925, 21);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(675, 638);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильтр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(571, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewVlojProc);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Процедуры ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVlojProc
            // 
            this.dataGridViewVlojProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVlojProc.Location = new System.Drawing.Point(27, 179);
            this.dataGridViewVlojProc.Name = "dataGridViewVlojProc";
            this.dataGridViewVlojProc.RowHeadersWidth = 62;
            this.dataGridViewVlojProc.RowTemplate.Height = 28;
            this.dataGridViewVlojProc.Size = new System.Drawing.Size(605, 383);
            this.dataGridViewVlojProc.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(298, 132);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Хранимая Процедура";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 754);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBoxUserReport);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageTariff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTariff)).EndInit();
            this.tabPageCall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCall)).EndInit();
            this.tabPageTypeOfCall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeOfCall)).EndInit();
            this.tabPageSpravochnikTariff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpravochnikTariff)).EndInit();
            this.tabPageTypeUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeUser)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVlojProc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTariff;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridView dataGridViewTariff;
        private System.Windows.Forms.TabPage tabPageCall;
        private System.Windows.Forms.DataGridView dataGridViewCall;
        private System.Windows.Forms.TabPage tabPageTypeOfCall;
        private System.Windows.Forms.DataGridView dataGridViewTypeOfCall;
        private System.Windows.Forms.TabPage tabPageSpravochnikTariff;
        private System.Windows.Forms.DataGridView dataGridViewSpravochnikTariff;
        private System.Windows.Forms.TabPage tabPageTypeUser;
        private System.Windows.Forms.DataGridView dataGridViewTypeUser;
        private System.Windows.Forms.Button SaveCALL;
        private System.Windows.Forms.Button buttonUserSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonTariffsave;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewVlojProc;
        private System.Windows.Forms.Button buttonADDcall;
        private System.Windows.Forms.Button buttonRemoveCall;
        private System.Windows.Forms.Button buttonRemoveUser;
    }
}

