namespace PhotoStudio
{
    partial class FormStaff
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
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStaffList = new System.Windows.Forms.Button();
            this.photoStudioDataSet = new PhotoStudio.PhotoStudioDataSet();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewAllOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDoneOrders = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddToMyOrders = new System.Windows.Forms.Button();
            this.buttonAddToDoneOrders = new System.Windows.Forms.Button();
            this.buttonDeleteFromMyOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoneOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeUser.Location = new System.Drawing.Point(170, 25);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(188, 48);
            this.buttonChangeUser.TabIndex = 5;
            this.buttonChangeUser.Text = "Сменить пользователя";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentUser.Location = new System.Drawing.Point(569, 13);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы вошли как:";
            // 
            // buttonStaffList
            // 
            this.buttonStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStaffList.Location = new System.Drawing.Point(170, 79);
            this.buttonStaffList.Name = "buttonStaffList";
            this.buttonStaffList.Size = new System.Drawing.Size(188, 47);
            this.buttonStaffList.TabIndex = 7;
            this.buttonStaffList.Text = "Список сотрудников";
            this.buttonStaffList.UseVisualStyleBackColor = true;
            this.buttonStaffList.Click += new System.EventHandler(this.buttonStaffList_Click);
            // 
            // photoStudioDataSet
            // 
            this.photoStudioDataSet.DataSetName = "PhotoStudioDataSet";
            this.photoStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.RowTemplate.Height = 24;
            this.dataGridViewRes.Size = new System.Drawing.Size(457, 231);
            this.dataGridViewRes.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(6, 186);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(158, 40);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewAllOrders
            // 
            this.dataGridViewAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllOrders.Location = new System.Drawing.Point(0, 299);
            this.dataGridViewAllOrders.Name = "dataGridViewAllOrders";
            this.dataGridViewAllOrders.RowTemplate.Height = 24;
            this.dataGridViewAllOrders.Size = new System.Drawing.Size(462, 256);
            this.dataGridViewAllOrders.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Мои заказы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(110, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Возможные заказы:";
            // 
            // dataGridViewDoneOrders
            // 
            this.dataGridViewDoneOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoneOrders.Location = new System.Drawing.Point(468, 299);
            this.dataGridViewDoneOrders.Name = "dataGridViewDoneOrders";
            this.dataGridViewDoneOrders.RowTemplate.Height = 24;
            this.dataGridViewDoneOrders.Size = new System.Drawing.Size(457, 256);
            this.dataGridViewDoneOrders.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(583, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выполненные заказы:";
            // 
            // buttonAddToMyOrders
            // 
            this.buttonAddToMyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToMyOrders.Location = new System.Drawing.Point(6, 132);
            this.buttonAddToMyOrders.Name = "buttonAddToMyOrders";
            this.buttonAddToMyOrders.Size = new System.Drawing.Size(158, 48);
            this.buttonAddToMyOrders.TabIndex = 15;
            this.buttonAddToMyOrders.Text = "Добавить в мои заказы";
            this.buttonAddToMyOrders.UseVisualStyleBackColor = true;
            this.buttonAddToMyOrders.Click += new System.EventHandler(this.buttonAddToMyOrders_Click);
            // 
            // buttonAddToDoneOrders
            // 
            this.buttonAddToDoneOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToDoneOrders.Location = new System.Drawing.Point(6, 79);
            this.buttonAddToDoneOrders.Name = "buttonAddToDoneOrders";
            this.buttonAddToDoneOrders.Size = new System.Drawing.Size(158, 47);
            this.buttonAddToDoneOrders.TabIndex = 16;
            this.buttonAddToDoneOrders.Text = "Добавить в выполненные заказы";
            this.buttonAddToDoneOrders.UseVisualStyleBackColor = true;
            this.buttonAddToDoneOrders.Click += new System.EventHandler(this.buttonAddToDoneOrders_Click);
            // 
            // buttonDeleteFromMyOrders
            // 
            this.buttonDeleteFromMyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFromMyOrders.Location = new System.Drawing.Point(6, 25);
            this.buttonDeleteFromMyOrders.Name = "buttonDeleteFromMyOrders";
            this.buttonDeleteFromMyOrders.Size = new System.Drawing.Size(158, 48);
            this.buttonDeleteFromMyOrders.TabIndex = 17;
            this.buttonDeleteFromMyOrders.Text = "Удалить из моих заказов";
            this.buttonDeleteFromMyOrders.UseVisualStyleBackColor = true;
            this.buttonDeleteFromMyOrders.Click += new System.EventHandler(this.buttonDeleteFromMyOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddToDoneOrders);
            this.groupBox1.Controls.Add(this.buttonAddToMyOrders);
            this.groupBox1.Controls.Add(this.buttonDeleteFromMyOrders);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonStaffList);
            this.groupBox1.Controls.Add(this.buttonChangeUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(464, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 231);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель действий";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDoneOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAllOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.dataGridViewRes);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фотостудия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStaff_FormClosed);
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoneOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label label1;
        private PhotoStudioDataSet photoStudioDataSet;
        private System.Windows.Forms.Button buttonStaffList;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewAllOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDoneOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddToMyOrders;
        private System.Windows.Forms.Button buttonAddToDoneOrders;
        private System.Windows.Forms.Button buttonDeleteFromMyOrders;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}