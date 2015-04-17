﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

namespace BKI_KHO.DanhMuc
{
    public partial class f101_DM_NGUOI_DUNG_DE : Form
    {
        #region public interface
        public f101_DM_NGUOI_DUNG_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US.US_DM_NGUOI_DUNG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_nguoi_dung = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_NGUOI_DUNG m_us_dm_nguoi_dung = new US_DM_NGUOI_DUNG();
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_nguoi_dung.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_nguoi_dung.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void m_cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region private Method

        private void load_data_2_combox()
        {
           // US_DM_NGUOI_DUNG v_us_dm_nguoi_dung = new US_DM_NGUOI_DUNG();
            
           // v_us_dm_nguoi_dung.FillDataset(v_ds_dm_nguoi_dung);
            //
            //m_cbo_ma_to_chuc.DataSource = v_ds_dm_nguoi_dung.Tables[0];
           // m_cbo_ma_to_chuc.DisplayMember = DM_NGUOI_DUNG.ID_TO_CHUC;
           // m_cbo_ma_to_chuc.ValueMember = DM_NGUOI_DUNG.ID_TO_CHUC;
        }
        private void us_obj_2_form()
        {
            m_dat_ngay_sinh.Value = m_us_dm_nguoi_dung.datNGAY_SINH;
            m_txt_email.Text = m_us_dm_nguoi_dung.strEMAIL;
            m_txt_ghi_chu.Text = m_us_dm_nguoi_dung.strGHI_CHU;
            m_txt_ho_nguoi_dung.Text = m_us_dm_nguoi_dung.strHO_NGUOI_DUNG;
            m_txt_ma_nguoi_dung.Text = m_us_dm_nguoi_dung.strMA_NGUOI_DUNG;
            m_cbo_ma_to_chuc.SelectedValue = m_us_dm_nguoi_dung.dcID_TO_CHUC;
            m_txt_mobile.Text = m_us_dm_nguoi_dung.strMOBILE;
            m_txt_ten_dem.Text = m_us_dm_nguoi_dung.strTEN_DEM;
        }
        private void form_2_us_obj()
        {
            m_us_dm_nguoi_dung.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us_dm_nguoi_dung.strEMAIL = m_txt_email.Text;
            m_us_dm_nguoi_dung.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_nguoi_dung.strHO_NGUOI_DUNG = m_txt_ho_nguoi_dung.Text;
            m_us_dm_nguoi_dung.strMA_NGUOI_DUNG = m_txt_ma_nguoi_dung.Text;
            m_us_dm_nguoi_dung.strMOBILE = m_txt_mobile.Text;
            m_us_dm_nguoi_dung.strTEN_DEM = m_txt_ten_dem.Text;
        }
        #endregion

        
    }
}
