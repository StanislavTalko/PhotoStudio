namespace PhotoStudio
{
    partial class FormClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.groupBoxNewOrder = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoStudioDataSet = new PhotoStudio.PhotoStudioDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDay = new System.Windows.Forms.DateTimePicker();
            this.labelService = new System.Windows.Forms.Label();
            this.serviceTableAdapter = new PhotoStudio.PhotoStudioDataSetTableAdapters.ServiceTableAdapter();
            this.dataGridViewMyOrders = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkBoxActual = new System.Windows.Forms.CheckBox();
            this.buttonOpenSelectedOrder = new System.Windows.Forms.Button();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter = new PhotoStudio.PhotoStudioDataSetTableAdapters.LogTableAdapter();
            this.groupBoxNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли как:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Location = new System.Drawing.Point(129, 242);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentUser.TabIndex = 1;
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Location = new System.Drawing.Point(23, 262);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(192, 29);
            this.buttonChangeUser.TabIndex = 2;
            this.buttonChangeUser.Text = "Сменить пользователя";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // groupBoxNewOrder
            // 
            this.groupBoxNewOrder.Controls.Add(this.button1);
            this.groupBoxNewOrder.Controls.Add(this.labelPrice);
            this.groupBoxNewOrder.Controls.Add(this.label4);
            this.groupBoxNewOrder.Controls.Add(this.label3);
            this.groupBoxNewOrder.Controls.Add(this.comboBoxTime);
            this.groupBoxNewOrder.Controls.Add(this.comboBoxService);
            this.groupBoxNewOrder.Controls.Add(this.label2);
            this.groupBoxNewOrder.Controls.Add(this.dateTimePickerOrderDay);
            this.groupBoxNewOrder.Controls.Add(this.labelService);
            this.groupBoxNewOrder.Location = new System.Drawing.Point(12, 9);
            this.groupBoxNewOrder.Name = "groupBoxNewOrder";
            this.groupBoxNewOrder.Size = new System.Drawing.Size(430, 230);
            this.groupBoxNewOrder.TabIndex = 3;
            this.groupBoxNewOrder.TabStop = false;
            this.groupBoxNewOrder.Text = "Оформление заказа";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(248, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Записаться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(158, 181);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 29);
            this.labelPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.comboBoxTime.Location = new System.Drawing.Point(163, 135);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(253, 37);
            this.comboBoxTime.TabIndex = 4;
            // 
            // comboBoxService
            // 
            this.comboBoxService.DataSource = this.serviceBindingSource;
            this.comboBoxService.DisplayMember = "Service_Name";
            this.comboBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(163, 52);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(253, 37);
            this.comboBoxService.TabIndex = 3;
            this.comboBoxService.ValueMember = "Service_Name";
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.photoStudioDataSet;
            // 
            // photoStudioDataSet
            // 
            this.photoStudioDataSet.DataSetName = "PhotoStudioDataSet";
            this.photoStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            // 
            // dateTimePickerOrderDay
            // 
            this.dateTimePickerOrderDay.CustomFormat = "\"ddd, MMM, yyyy\"";
            this.dateTimePickerOrderDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOrderDay.Location = new System.Drawing.Point(163, 95);
            this.dateTimePickerOrderDay.MinDate = new System.DateTime(2020, 6, 27, 0, 0, 0, 0);
            this.dateTimePickerOrderDay.Name = "dateTimePickerOrderDay";
            this.dateTimePickerOrderDay.Size = new System.Drawing.Size(253, 34);
            this.dateTimePickerOrderDay.TabIndex = 1;
            this.dateTimePickerOrderDay.Value = new System.DateTime(2020, 6, 27, 0, 0, 0, 0);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(6, 55);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(92, 29);
            this.labelService.TabIndex = 0;
            this.labelService.Text = "Услуга";
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewMyOrders
            // 
            this.dataGridViewMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyOrders.Location = new System.Drawing.Point(448, 9);
            this.dataGridViewMyOrders.Name = "dataGridViewMyOrders";
            this.dataGridViewMyOrders.RowTemplate.Height = 24;
            this.dataGridViewMyOrders.Size = new System.Drawing.Size(364, 293);
            this.dataGridViewMyOrders.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(287, 245);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(141, 39);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxActual
            // 
            this.checkBoxActual.AutoSize = true;
            this.checkBoxActual.Location = new System.Drawing.Point(448, 308);
            this.checkBoxActual.Name = "checkBoxActual";
            this.checkBoxActual.Size = new System.Drawing.Size(209, 21);
            this.checkBoxActual.TabIndex = 6;
            this.checkBoxActual.Text = "Только актуальные записи";
            this.checkBoxActual.UseVisualStyleBackColor = true;
            // 
            // buttonOpenSelectedOrder
            // 
            this.buttonOpenSelectedOrder.Location = new System.Drawing.Point(287, 290);
            this.buttonOpenSelectedOrder.Name = "buttonOpenSelectedOrder";
            this.buttonOpenSelectedOrder.Size = new System.Drawing.Size(141, 43);
            this.buttonOpenSelectedOrder.TabIndex = 7;
            this.buttonOpenSelectedOrder.Text = "Открыть выбранный заказ";
            this.buttonOpenSelectedOrder.UseVisualStyleBackColor = true;
            this.buttonOpenSelectedOrder.Click += new System.EventHandler(this.buttonOpenSelectedOrder_Click);
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            this.logBindingSource.DataSource = this.photoStudioDataSet;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 498);
            this.Controls.Add(this.buttonOpenSelectedOrder);
            this.Controls.Add(this.checkBoxActual);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewMyOrders);
            this.Controls.Add(this.groupBoxNewOrder);
            this.Controls.Add(this.buttonChangeUser);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фотостудия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBoxNewOrder.ResumeLayout(false);
            this.groupBoxNewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.GroupBox groupBoxNewOrder;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDay;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private PhotoStudioDataSet photoStudioDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private PhotoStudioDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMyOrders;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxActual;
        private System.Windows.Forms.Button buttonOpenSelectedOrder;
        private System.Windows.Forms.BindingSource logBindingSource;
        private PhotoStudioDataSetTableAdapters.LogTableAdapter logTableAdapter;
    }
}