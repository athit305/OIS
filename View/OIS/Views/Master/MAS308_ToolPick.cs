﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.MAS.DTO;
using OIS.MAS.DTO.Criteria;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS308_ToolPick : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
            SEQ,
            CRT_NAME,
            CRT_DATE,
            CRT_MACHINE,
            UPD_NAME,
            UPD_DATE,
            UPD_MACHINE,
            DEL_NAME,
            DEL_DATE,
            DEL_MACHINE,
            ID,
            CRT_ID,
            UPD_ID,
            DEL_ID,
        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();

        SortableBindingList<sp_MAS308_GetToolPick_Result> dataList = new SortableBindingList<sp_MAS308_GetToolPick_Result>();
        private MAS308_ToolPick_Criteria Criteria = new MAS308_ToolPick_Criteria();
        #endregion

        #region "Constructor"
        public MAS308_ToolPick()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            gvResult.SetOISStyle();
            gvResult.MappingEnum(typeof(eCol));

            gvResult.SetColumnNumeric((int)eCol.SEQ, 0);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
            {
                gvResult.Columns[i].Visible = false;
            }

            bdSource.DataSource = Criteria;
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bdSource.EndEdit();
                dataList = vmMas.GetToolPick(Criteria);
                gvResult.DataSource = dataList;

                gvResult.SetRowDeletedStyle((int)eCol.DEL_ID);
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void AddNew()
        {
            try
            {
                using (MAS308_ToolPickEntry dlg = new MAS308_ToolPickEntry())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void EditData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sp_MAS308_GetToolPick_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS308_GetToolPick_Result;
                using (MAS308_ToolPickEntry dlg = new MAS308_ToolPickEntry(row))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }
        private void ClearScreen()
        {
            Criteria = new MAS308_ToolPick_Criteria();
            bdSource.DataSource = Criteria;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS308_ToolPick_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS308_ToolPick_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }
        private void MAS308_ToolPick_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }
        private void MAS308_ToolPick_OnClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void gvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData(e);
        }
        #endregion
    }
}
