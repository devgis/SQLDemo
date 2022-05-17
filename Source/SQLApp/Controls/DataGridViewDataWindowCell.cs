using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;

namespace SQLApp.Controls
{
    public class DataGridViewDataWindowCell:DataGridViewTextBoxCell
    {
        public override void InitializeEditingControl(int rowIndex, object
              initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            DataGridViewDataWindowEditingControl dataWindowControl =
                DataGridView.EditingControl as DataGridViewDataWindowEditingControl;
            dataWindowControl.PopupGridAutoSize = false;
            DataGridViewDataWindowColumn dataWindowColumn=
                (DataGridViewDataWindowColumn)OwningColumn;

            dataWindowControl.sDisplayMember = dataWindowColumn.SDisplayMember;//����3��������datasource����ǰ��
            dataWindowControl.sDisplayField = dataWindowColumn.SDisplayField;
            dataWindowControl.sKeyWords = dataWindowColumn.SKeyWords;

            dataWindowControl.DataSource = dataWindowColumn.DataSource;

            dataWindowControl.Text = (string)this.Value;
            dataWindowControl.RowFilterVisible = true;  //�˾�������datasource���ú���

            
        }



        [Browsable(false)]
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewDataWindowEditingControl);
            }
        }
       
        public override Type ValueType
        {
            get
            {
                return typeof(string);
            }
        }
        private DataGridViewDataWindowEditingControl EditingDataWindow
        {
            get
            {
                DataGridViewDataWindowEditingControl dataWindowControl =
                    DataGridView.EditingControl as DataGridViewDataWindowEditingControl;

                return dataWindowControl;
            }
        }

       
    }

    
}
