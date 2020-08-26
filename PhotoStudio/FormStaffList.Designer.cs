namespace PhotoStudio
{
    partial class FormStaffList
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
            this.photoStudioDataSet = new PhotoStudio.PhotoStudioDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCheckFIO = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.staffTableAdapter = new PhotoStudio.PhotoStudioDataSetTableAdapters.StaffTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoStudioDataSet
            // 
            this.photoStudioDataSet.DataSetName = "PhotoStudioDataSet";
            this.photoStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 140;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn1.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.photoStudioDataSet;
            // 
            // comboBoxCheckFIO
            // 
            this.comboBoxCheckFIO.DataSource = this.staffBindingSource;
            this.comboBoxCheckFIO.DisplayMember = "FIO";
            this.comboBoxCheckFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCheckFIO.FormattingEnabled = true;
            this.comboBoxCheckFIO.Location = new System.Drawing.Point(78, 42);
            this.comboBoxCheckFIO.Name = "comboBoxCheckFIO";
            this.comboBoxCheckFIO.Size = new System.Drawing.Size(253, 33);
            this.comboBoxCheckFIO.TabIndex = 8;
            this.comboBoxCheckFIO.ValueMember = "FIO";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(107, 81);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 38);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPosition);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonRegistration);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.textBoxPatronymic);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Location = new System.Drawing.Point(684, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 349);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление сотрудника";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Администратор",
            "Фотограф"});
            this.comboBoxPosition.Location = new System.Drawing.Point(162, 187);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(169, 33);
            this.comboBoxPosition.TabIndex = 44;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSalary.Location = new System.Drawing.Point(162, 228);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(169, 30);
            this.textBoxSalary.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Зарплата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Должность:";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(107, 304);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(144, 36);
            this.buttonRegistration.TabIndex = 52;
            this.buttonRegistration.Text = "Добавить";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Имя:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(162, 268);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(169, 30);
            this.textBoxPassword.TabIndex = 48;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(162, 147);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(169, 30);
            this.textBoxPhone.TabIndex = 43;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(162, 107);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(169, 30);
            this.textBoxPatronymic.TabIndex = 42;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(162, 28);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(169, 30);
            this.textBoxSurname.TabIndex = 40;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(162, 67);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(169, 30);
            this.textBoxFirstName.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.comboBoxCheckFIO);
            this.groupBox2.Location = new System.Drawing.Point(684, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 125);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление сотрудника";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "ФИО:";
            // 
            // FormStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormStaffList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormStaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoStudioDataSet photoStudioDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private PhotoStudioDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBoxCheckFIO;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}