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
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS104_PositionEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();

        private sp_MAS104_GetPosition_Result posResult;
        #endregion

        #region "Constructor"
        public MAS104_PositionEntry()
        {
            InitializeComponent();
        }
        public MAS104_PositionEntry(sp_MAS104_GetPosition_Result data)
        {
            InitializeComponent();
            posResult = data;
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                SetControlToValidate(txtNameTh, txtNameEn, txtSeq);

                RetriveData();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void RetriveData()
        {
            try
            {
                if (posResult == null)
                {
                    posResult = new sp_MAS104_GetPosition_Result();
                    posResult.CRT_DATE = DateTime.Now;
                    this.ToolBarSwitch = "2122222222";
                }
                else if (posResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                }

                CtrlUtil.EnableControls(posResult.DEL_ID.IsNull(), txtNameTh, txtNameEn, txtSeq);

                bs.DataSource = posResult;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateBeforeSave()
        {

            try
            {
                gbMain.Focus();
                bs.EndEdit();

                if (!ValidateControl())
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return false;
            }
        }
        private void SaveData()
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID =vmMas.SavePosition(posResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        posResult = vmMas.GetPosition(ID);
                        RetriveData();
                    }
                }
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
        private void CancelData(bool isCancel)
        {

            try
            {
                string msg;
                if (isCancel)
                {
                    msg = MessageCode.CFM0003;
                }
                else
                {
                    msg = MessageCode.CFM0004;
                }
                if (rMessageBox.ShowConfirmation(this, msg) == DialogResult.Yes)
                {
                    vmMas.CancelPosition(posResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    posResult = vmMas.GetPosition(posResult.ID);
                    RetriveData();
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void MAS104_PositionEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS104_PositionEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS104_PositionEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS104_PositionEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }
        #endregion
    }
}
