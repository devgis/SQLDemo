using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLApp.Controls;

namespace SQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //查找部门表
            string sqlDept = "select DEP,NAME from DEPT";
            DataSet ds = SQLHelper.Query(sqlDept);
            if (ds != null && ds.Tables.Count > 0)
            {
                dtpDepart.DisplayMember = "NAME";
                dtpDepart.ValueMember = "DEP";
                dtpDepart.DataSource = ds.Tables[0];
            }
            
            //CGoodsName2

            DataGridViewColumn column = new DataGridViewDataWindowColumn();
            column.HeaderText = "品名";
            column.Name = "CGoodsName";
            (column as DataGridViewDataWindowColumn).SDisplayField = "品号,品名,规格";
            (column as DataGridViewDataWindowColumn).SDisplayMember = "品名";
            (column as DataGridViewDataWindowColumn).SKeyWords = "品号";
            (column as DataGridViewDataWindowColumn).DataSource = createStudentTable();
            dgvList.Columns.Insert(3, column);
            // .Columns.Add(column);

            //LoadData();
        }

        /// <summary>
        /// 生产测试数据
        /// </summary>
        /// <returns></returns>
        private DataTable createStudentTable()
        {
            string sql = "select PRD_NO as 品号,NAME as 品名,SPC as 规格 from PRDT";
            DataSet ds = SQLHelper.Query(sql);
            return ds.Tables[0];
        }

        /// <summary>
        /// 根据条件加载数据 
        /// </summary>
        private void LoadData()
        {
            string sql = "select Y.YG_NO,Y.NAME AS YG_NAME,P.PRD_NO,P.NAME as PRD_NAME,P.SPC as PRD_SPC,QTY,QTY_SH,FJ_DD,FJ_YM from TF_JJFJ J LEFT JOIN PRDT P ON J.PRD_NO=P.PRD_NO LEFT JOIN MF_YG Y ON J.YG_NO=Y.YG_NO";
            sql += " WHERE 1=1";
            dgvList.Rows.Clear();
            DataSet ds = SQLHelper.Query(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                //dgvList.DataSource = ds.Tables[0];
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int RowInde = dgvList.Rows.Add();

                    //Y.YG_NO,Y.NAME AS YG_NAME,P.PRD_NO,P.NAME as PRD_NAME,P.SPC as PRD_SPC,QTY,QTY_SH,FJ_DD,FJ_YM
                    dgvList.Rows[RowInde].Cells["CWorkerNo"].Value = dr["YG_NO"];
                    dgvList.Rows[RowInde].Cells["CWorkerName"].Value = dr["YG_NO"];
                    dgvList.Rows[RowInde].Cells["CGoodsNO"].Value = dr["PRD_NO"];
                    dgvList.Rows[RowInde].Cells["CGoodsName"].Value = dr["PRD_NAME"];
                    dgvList.Rows[RowInde].Cells["CSpec"].Value = dr["PRD_SPC"];
                    dgvList.Rows[RowInde].Cells["CCount"].Value = dr["QTY"];
                    dgvList.Rows[RowInde].Cells["CUnqualifiedCount"].Value = dr["QTY_SH"];
                    dgvList.Rows[RowInde].Cells["CMonth"].Value = Convert.ToDateTime(dr["FJ_YM"]).ToString("yyyy-MM");
                    dgvList.Rows[RowInde].Cells["CDay"].Value = Convert.ToDateTime(dr["FJ_DD"]).ToString("yyyy-MM-dd");
                    dgvList.Rows[RowInde].Cells["CInDB"].Value ="T";
                }
            }
            

            dgvList.ReadOnly = true;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            SetEditAble(false);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //添加行并赋值
            int index=dgvList.Rows.Add();
            if (dtpWorerName.SelectedValue != null)
            {
                dgvList.Rows[index].Cells["CWorkerNo"].Value = dtpWorerName.SelectedValue.ToString();
                dgvList.Rows[index].Cells["CWorkerName"].Value = dtpWorerName.Text;
            }
            //dgvList.Rows[index].Cells["CGoodsNO"].Value = "";
            //dgvList.Rows[index].Cells["CGoodsName"].Value = "";
            //dgvList.Rows[index].Cells["CSpec"].Value = "";
            //dgvList.Rows[index].Cells["CCount"].Value = "";
            //dgvList.Rows[index].Cells["CUnqualifiedCount"].Value = "";
            dgvList.Rows[index].Cells["CMonth"].Value = dtpMonth.Value.ToString("yyyy-MM")+"-01";
            dgvList.Rows[index].Cells["CDay"].Value = dtpMonth.Value.ToString("yyyy-MM-dd");

            SetEditAble(true);

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            dgvList.ReadOnly = false;
        }

        List<DBKey> listKeys = new List<DBKey>();
        private void btDel_Click(object sender, EventArgs e)
        {

            //判断 如果只是在表中 则直接删除 如果已经存入数据库 需要从本地和数据库同时删除
            if (dgvList.SelectedRows==null||dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择行进行删除！");
                return;
            }

            foreach (DataGridViewRow row in dgvList.SelectedRows)
            {
                if (row.Cells["CInDB"].Value != null && row.Cells["CInDB"].Value == "T")
                {
                    DBKey key = new DBKey();
                    listKeys.Add(key);
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    if (Save())
                    {
                        MessageBox.Show("保存成功！");
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("保存中发生错误：" + ex.Message);
                }
            }
            SetEditAble(false);
        }

        private void dtpDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //加载员工表
            if (dtpDepart.SelectedValue != null)
            {
                string deptno = dtpDepart.SelectedValue.ToString();
                string sqlWorker = string.Format("select YG_NO,NAME from MF_YG where DEP='{0}'", deptno);
                DataSet ds = SQLHelper.Query(sqlWorker);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dtpWorerName.DisplayMember = "NAME";
                    dtpWorerName.ValueMember = "YG_NO";
                    dtpWorerName.DataSource = ds.Tables[0];
                }
            }

            
        }

        /// <summary>
        /// 设置表格是否可以编辑
        /// </summary>
        /// <param name="EditAble"></param>
        private void SetEditAble(bool EditAble)
        {
            if(EditAble)
            {
                dgvList.ReadOnly = false;
                dgvList.Columns["CWorkerNo"].ReadOnly = true;
                dgvList.Columns["CWorkerName"].ReadOnly = true;

                dgvList.Columns["CGoodsNO"].ReadOnly = true;
                dgvList.Columns["CGoodsName"].ReadOnly = false;
                dgvList.Columns["CSpec"].ReadOnly = true;
                dgvList.Columns["CCount"].ReadOnly = false;
                dgvList.Columns["CUnqualifiedCount"].ReadOnly = false;
                dgvList.Columns["CMonth"].ReadOnly = false;
                dgvList.Columns["CDay"].ReadOnly = false;
            }
            else
            {
                dgvList.ReadOnly=true;
            }
            
        }

        private void dgvList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataWindow)
            {
                (e.Control as DataWindow).AfterSelector -= new AfterSelectorEventHandler(SalePageAddOrEditForm_AfterSelector);
                (e.Control as DataWindow).AfterSelector += new AfterSelectorEventHandler(SalePageAddOrEditForm_AfterSelector);
            }
        }

        /// <summary>
        /// DataGridView中DataWindow选择后事件处理（获取在下拉框中选择的数据）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SalePageAddOrEditForm_AfterSelector(object sender, AfterSelectorEventArgs e)
        {
            DataGridViewRow row = e.Value as DataGridViewRow;
            DataRowView dataRow = row.DataBoundItem as DataRowView;

            dgvList.Rows[e.RowIndex].Cells["CGoodsNO"].Value = dataRow["品号"].ToString().Trim();
            dgvList.Rows[e.RowIndex].Cells["CSpec"].Value = dataRow["规格"].ToString().Trim();

        }

        private bool Check()
        {
            //逐行测试
            if (dgvList.Rows.Count <= 0)
            {
                MessageBox.Show("没有记录无法保存！");
                return false;
            }
            else
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    //需要检验的字段
                    //dgvList.Rows[RowInde].Cells["CWorkerNo"].Value = dr["YG_NO"];
                    //dgvList.Rows[RowInde].Cells["CWorkerName"].Value = dr["YG_NO"];
                    //dgvList.Rows[RowInde].Cells["CGoodsNO"].Value = dr["PRD_NO"];
                    //dgvList.Rows[RowInde].Cells["CGoodsName"].Value = dr["PRD_NAME"];
                    //dgvList.Rows[RowInde].Cells["CSpec"].Value = dr["PRD_SPC"];
                    //dgvList.Rows[RowInde].Cells["CCount"].Value = dr["QTY"];
                    //dgvList.Rows[RowInde].Cells["CUnqualifiedCount"].Value = dr["QTY_SH"];
                    //dgvList.Rows[RowInde].Cells["CMonth"].Value = Convert.ToDateTime(dr["FJ_YM"]).ToString("yyyy-MM");
                    //dgvList.Rows[RowInde].Cells["CDay"].Value = Convert.ToDateTime(dr["FJ_DD"]).ToString("yyyy-MM-dd");
                }
            }
            return true;
        }

        private bool Save()
        {
            //逐行保存 如果已经保存则执行更新 否则执行插入操作

            //生成事务处理
            //要删除的语句

            //dgvList.Rows[RowInde].Cells["CInDB"].Value = "T"; //T就是在数据库需要UPdate 其他就是在本地需要Insert
            //要Update的语句
            //Insert语句
            //事物提交，修改本地表示 CInDB字段
            //清楚删除主键

            listKeys.Clear();
            return true;
        }
    }
}
