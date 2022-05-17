namespace SQLApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.ComboBox();
            this.dtpWorerName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpGoods = new System.Windows.Forms.TextBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWorkerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGoodsNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGoodsName2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnqualifiedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "计件月份：";
            // 
            // dtpMonth
            // 
            this.dtpMonth.Location = new System.Drawing.Point(74, 9);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(105, 21);
            this.dtpMonth.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(252, 9);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(105, 21);
            this.dtpDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "计件日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "部门：";
            // 
            // dtpDepart
            // 
            this.dtpDepart.FormattingEnabled = true;
            this.dtpDepart.Location = new System.Drawing.Point(404, 10);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(97, 20);
            this.dtpDepart.TabIndex = 5;
            this.dtpDepart.SelectedIndexChanged += new System.EventHandler(this.dtpDepart_SelectedIndexChanged);
            // 
            // dtpWorerName
            // 
            this.dtpWorerName.FormattingEnabled = true;
            this.dtpWorerName.Location = new System.Drawing.Point(575, 9);
            this.dtpWorerName.Name = "dtpWorerName";
            this.dtpWorerName.Size = new System.Drawing.Size(97, 20);
            this.dtpWorerName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "员工姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "计件品名：";
            // 
            // dtpGoods
            // 
            this.dtpGoods.Location = new System.Drawing.Point(74, 39);
            this.dtpGoods.Name = "dtpGoods";
            this.dtpGoods.Size = new System.Drawing.Size(598, 21);
            this.dtpGoods.TabIndex = 9;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(678, 8);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(53, 23);
            this.btLoad.TabIndex = 10;
            this.btLoad.Text = "加载";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(730, 8);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(53, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "新增";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(834, 8);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(53, 23);
            this.btDel.TabIndex = 13;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(782, 8);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(53, 23);
            this.btEdit.TabIndex = 12;
            this.btEdit.Text = "修改";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(886, 8);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(53, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CWorkerNo,
            this.CWorkerName,
            this.CGoodsNO,
            this.CGoodsName2,
            this.CSpec,
            this.CCount,
            this.CUnqualifiedCount,
            this.CMonth,
            this.CDay,
            this.CInDB});
            this.dgvList.Location = new System.Drawing.Point(10, 67);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(990, 490);
            this.dgvList.TabIndex = 15;
            this.dgvList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvList_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "工号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "品号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "规格";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "数量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "不合格数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "月份";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // CWorkerNo
            // 
            this.CWorkerNo.HeaderText = "工号";
            this.CWorkerNo.Name = "CWorkerNo";
            this.CWorkerNo.ReadOnly = true;
            // 
            // CWorkerName
            // 
            this.CWorkerName.HeaderText = "姓名";
            this.CWorkerName.Name = "CWorkerName";
            this.CWorkerName.ReadOnly = true;
            // 
            // CGoodsNO
            // 
            this.CGoodsNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CGoodsNO.HeaderText = "品号";
            this.CGoodsNO.Name = "CGoodsNO";
            this.CGoodsNO.ReadOnly = true;
            // 
            // CGoodsName2
            // 
            this.CGoodsName2.FillWeight = 200F;
            this.CGoodsName2.HeaderText = "品名";
            this.CGoodsName2.Name = "CGoodsName2";
            this.CGoodsName2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CGoodsName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CGoodsName2.Visible = false;
            // 
            // CSpec
            // 
            this.CSpec.HeaderText = "规格";
            this.CSpec.Name = "CSpec";
            this.CSpec.ReadOnly = true;
            // 
            // CCount
            // 
            this.CCount.HeaderText = "数量";
            this.CCount.Name = "CCount";
            // 
            // CUnqualifiedCount
            // 
            this.CUnqualifiedCount.HeaderText = "不合格数量";
            this.CUnqualifiedCount.Name = "CUnqualifiedCount";
            // 
            // CMonth
            // 
            this.CMonth.HeaderText = "月份";
            this.CMonth.Name = "CMonth";
            // 
            // CDay
            // 
            this.CDay.HeaderText = "日期";
            this.CDay.Name = "CDay";
            // 
            // CInDB
            // 
            this.CInDB.HeaderText = "CInDB";
            this.CInDB.Name = "CInDB";
            this.CInDB.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.dtpGoods);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpWorerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计件工资录入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dtpDepart;
        private System.Windows.Forms.ComboBox dtpWorerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dtpGoods;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWorkerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGoodsNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn CGoodsName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnqualifiedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInDB;
    }
}

