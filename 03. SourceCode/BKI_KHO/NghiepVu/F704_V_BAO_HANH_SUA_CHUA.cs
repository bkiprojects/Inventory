﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
using BKI_KHO.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO.NghiepVu
{
    public partial class F704_V_BAO_HANH_SUA_CHUA : Form
    {
        public F704_V_BAO_HANH_SUA_CHUA()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
        private enum e_col_number
        {
            HO_TEN = 1,
            SO_TIEN = 2
        }
        #endregion

        #region Member
        private DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        ITransferDataRow m_obj_trans;
        US_V_BAO_HANH_SUA_CHUA m_us_v_bao_hanh_sua_chua = new US_V_BAO_HANH_SUA_CHUA();
        private string m_str_ma_chung_tu_old = "";
        #endregion

        #region Public method
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Private method
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_cbo_nhan_vien_to_grid();

        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            var v_htb = new Hashtable();
            v_htb.Add(GD_CHUNG_TU_NHAN_VIEN.ID_NHAN_VIEN, e_col_number.HO_TEN);
            v_htb.Add(GD_CHUNG_TU_NHAN_VIEN.SO_TIEN, e_col_number.SO_TIEN);

            DS_GD_CHUNG_TU_NHAN_VIEN v_ds_ct_nhan_vien = new DS_GD_CHUNG_TU_NHAN_VIEN();
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds_ct_nhan_vien.GD_CHUNG_TU_NHAN_VIEN.NewRow());
            return v_obj_trans;
        }

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;

            m_fg.AllowEditing = true;
            this.KeyPreview = true;
            set_define_events();
        }

        private Hashtable get_mapping_col_nhan_vien()
        {
            US_DM_NHAN_VIEN v_us_dm_nhan_vien = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_dm_nhan_vien = new DS_DM_NHAN_VIEN();
            var v_htb = new Hashtable();
            try
            {
                v_us_dm_nhan_vien.BeginTransaction();
                v_us_dm_nhan_vien.FillDataset(v_ds_dm_nhan_vien, "ORDER BY TEN, HO_DEM");
                v_us_dm_nhan_vien.CommitTransaction();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

            foreach (DataRow v_dr in v_ds_dm_nhan_vien.DM_NHAN_VIEN.Rows)
            {
                v_htb.Add(v_dr[DM_NHAN_VIEN.ID], v_dr[DM_NHAN_VIEN.HO_DEM] + " " + v_dr[DM_NHAN_VIEN.TEN]);
            }
            return v_htb;
        }

        private void load_cbo_nhan_vien_to_grid()
        {
            m_fg.Cols[(int)e_col_number.HO_TEN].DataMap = get_mapping_col_nhan_vien();
        }

        private bool check_validate_is_ok()
        {
            if (m_txt_ho_ten_khach_hang.Text.Trim().Length == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập tên khách hàng!");
                return false;
            }
            if (m_txt_dien_thoai_khach_hang.Text.Trim().Length == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập số điện thoại khách hàng!");
                return false;
            }

            if (m_txt_serial.Text.Trim().Length == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập số Serial!");
                return false;
            }

            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_number.HO_TEN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa chọn nhân viên");
                    m_fg.Select(v_i_cur_row, (int)e_col_number.HO_TEN);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_number.SO_TIEN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập số tiền cho nhân viên");
                    m_fg.Select(v_i_cur_row, (int)e_col_number.SO_TIEN);
                    return false;
                }
            }
            return true;
        }

        private bool is_exist_chung_tu(string ip_str_ma_chung_tu)
        {
            US_GD_CHUNG_TU v_us_gd_chung_tu = new US_GD_CHUNG_TU();
            DS_GD_CHUNG_TU v_ds_gd_chung_tu = new DS_GD_CHUNG_TU();
            v_us_gd_chung_tu.FillDatasetByMaChungTu(v_ds_gd_chung_tu, ip_str_ma_chung_tu);
            if (v_ds_gd_chung_tu.GD_CHUNG_TU.Rows.Count > 0)
                return true;
            return false;
        }

        private void form_2_us_v_bao_hanh_sua_chua(
            US_V_BAO_HANH_SUA_CHUA op_us_v_bao_hanh_sua_chua)
        {
            op_us_v_bao_hanh_sua_chua.strGHI_CHU_1 = m_txt_ho_ten_khach_hang.Text;
            op_us_v_bao_hanh_sua_chua.strGHI_CHU_2 = m_txt_dien_thoai_khach_hang.Text;
            op_us_v_bao_hanh_sua_chua.strGHI_CHU_3 = m_txt_dia_chi.Text;
            op_us_v_bao_hanh_sua_chua.strDIEN_GIAI = m_txt_noi_dung.Text;
            op_us_v_bao_hanh_sua_chua.strMA_CT = m_txt_so.Text;
            op_us_v_bao_hanh_sua_chua.datNGAY_CT = m_dat_ngay.Value;
            op_us_v_bao_hanh_sua_chua.dcID_LOAI_CT = 37;
            op_us_v_bao_hanh_sua_chua.dcTONG_TIEN = CIPConvert.ToDecimal(m_lbl_tong_tien.Text);
        }

        private void us_v_bao_hanh_sua_chua_2_form(US_V_BAO_HANH_SUA_CHUA ip_us_v_bao_hanh_sua_chua)
        {
            m_us_v_bao_hanh_sua_chua = ip_us_v_bao_hanh_sua_chua;
            m_str_ma_chung_tu_old = ip_us_v_bao_hanh_sua_chua.strMA_CT;

            m_txt_so.Text = ip_us_v_bao_hanh_sua_chua.strMA_CT;
            m_dat_ngay.Value = ip_us_v_bao_hanh_sua_chua.datNGAY_CT;
            m_txt_ho_ten_khach_hang.Text = ip_us_v_bao_hanh_sua_chua.strGHI_CHU_1;
            m_txt_dien_thoai_khach_hang.Text = ip_us_v_bao_hanh_sua_chua.strGHI_CHU_2;
            m_txt_dia_chi.Text = ip_us_v_bao_hanh_sua_chua.strGHI_CHU_3;
            m_lbl_tong_tien.Text = CIPConvert.ToStr(ip_us_v_bao_hanh_sua_chua.dcTONG_TIEN, "#,##0");
            m_txt_noi_dung.Text = ip_us_v_bao_hanh_sua_chua.strDIEN_GIAI;

            US_GD_CHI_TIET_CHUNG_TU v_us_gd_ct_chung_tu = new US_GD_CHI_TIET_CHUNG_TU();
            DS_GD_CHI_TIET_CHUNG_TU v_ds_gd_ct_chung_tu = new DS_GD_CHI_TIET_CHUNG_TU();
            v_us_gd_ct_chung_tu.FillDatasetByIDChungTu(v_ds_gd_ct_chung_tu, ip_us_v_bao_hanh_sua_chua.dcID);
            m_txt_serial.Text = v_ds_gd_ct_chung_tu.GD_CHI_TIET_CHUNG_TU.Rows[0][GD_CHI_TIET_CHUNG_TU.SO_SERI].ToString();

            US_GD_CHUNG_TU_NHAN_VIEN v_us_ct_nhan_vien = new US_GD_CHUNG_TU_NHAN_VIEN();
            DS_GD_CHUNG_TU_NHAN_VIEN v_ds_ct_nhan_vien = new DS_GD_CHUNG_TU_NHAN_VIEN();
            v_us_ct_nhan_vien.FillDatasetByIDChungTu(
                v_ds_ct_nhan_vien
                , ip_us_v_bao_hanh_sua_chua.dcID);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_ct_nhan_vien, m_fg, get_trans_object(m_fg));
            m_fg.Redraw = true;

            decimal v_dc_total = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_number.SO_TIEN] != null)
                {
                    v_dc_total += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int)e_col_number.SO_TIEN]);
                }
            }
            m_lbl_tong_tien.Text = CIPConvert.ToStr(v_dc_total, "#,##0");
        }

        private void grid_row_2_us_gd_chung_tu_nhan_vien(
        int ip_grid_row
        , US_V_BAO_HANH_SUA_CHUA ip_us_v_bh_sua_chua
        , US_GD_CHUNG_TU_NHAN_VIEN op_us_ct_nhan_vien)
        {
            op_us_ct_nhan_vien.dcSO_TIEN = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_number.SO_TIEN].ToString());
            op_us_ct_nhan_vien.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_number.HO_TEN]);
            op_us_ct_nhan_vien.dcID_CHUNG_TU = ip_us_v_bh_sua_chua.dcID;
        }

        private void form_2_us_gd_chi_tiet_chung_tu(
           US_V_BAO_HANH_SUA_CHUA ip_us_v_bh_sua_chua
           , US_GD_CHI_TIET_CHUNG_TU op_us_gd_ct_chung_tu)
        {
            op_us_gd_ct_chung_tu.dcID_CHUNG_TU = ip_us_v_bh_sua_chua.dcID;
            op_us_gd_ct_chung_tu.strSO_SERI = m_txt_serial.Text;
        }

        private void save_data()
        {
            if (check_validate_is_ok() == false)
                return;

            try
            {
                m_us_v_bao_hanh_sua_chua.BeginTransaction();

                //1. insert gd_chung_tu
                form_2_us_v_bao_hanh_sua_chua(m_us_v_bao_hanh_sua_chua);
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        if (!m_txt_so.Text.Equals(m_str_ma_chung_tu_old))
                        {
                            if (is_exist_chung_tu(m_txt_so.Text))
                            {
                                BaseMessages.MsgBox_Error("Mã số phiếu bảo hành đã tồn tại.");
                                m_txt_so.Focus();
                                return;
                            }
                        }
                        m_us_v_bao_hanh_sua_chua.Update();
                        break;
                    case DataEntryFormMode.InsertDataState:
                        if (is_exist_chung_tu(m_txt_so.Text))
                        {
                            BaseMessages.MsgBox_Error("Mã số phiếu bảo hành đã tồn tại.");
                            m_txt_so.Focus();
                            return;
                        }
                        m_us_v_bao_hanh_sua_chua.Insert();
                        break;
                }

                //2. insert gd chi tiet chung tu
                US_GD_CHI_TIET_CHUNG_TU v_us_gd_ct_chung_tu = new US_GD_CHI_TIET_CHUNG_TU();
                form_2_us_gd_chi_tiet_chung_tu(m_us_v_bao_hanh_sua_chua, v_us_gd_ct_chung_tu);
                v_us_gd_ct_chung_tu.UseTransOfUSObject(m_us_v_bao_hanh_sua_chua);
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.UpdateDataState:
                        v_us_gd_ct_chung_tu.Update();
                        break;
                    case DataEntryFormMode.InsertDataState:
                        v_us_gd_ct_chung_tu.Insert();
                        break;
                }
                //3. insert gd chung tu nhan vien
                US_GD_CHUNG_TU_NHAN_VIEN v_us_gd_ct_nhan_vien = new US_GD_CHUNG_TU_NHAN_VIEN();
                v_us_gd_ct_nhan_vien.UseTransOfUSObject(m_us_v_bao_hanh_sua_chua);
                v_us_gd_ct_nhan_vien.DeleteByIDChungTu(m_us_v_bao_hanh_sua_chua.dcID);
                for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
                {
                    grid_row_2_us_gd_chung_tu_nhan_vien(v_i_cur_row
                        , m_us_v_bao_hanh_sua_chua
                        , v_us_gd_ct_nhan_vien);
                    v_us_gd_ct_nhan_vien.Insert();
                }
                m_us_v_bao_hanh_sua_chua.CommitTransaction();
                MessageBox.Show("Phiếu sửa chữa đã được lưu.");
            }
            catch (Exception v_e)
            {
                if (m_us_v_bao_hanh_sua_chua.is_having_transaction())
                {
                    m_us_v_bao_hanh_sua_chua.Rollback();
                }
                throw v_e;
            }
        }
        #endregion

        #region Event
        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_danh_sach.Click += m_cmd_danh_sach_Click;
            this.Load += F704_V_BAO_HANH_SUA_CHUA_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_fg.LeaveCell += m_fg_LeaveCell;
            m_fg.AfterAddRow += m_fg_AfterAddRow;
            m_cmd_del.Click += m_cmd_del_Click;
        }

        void m_cmd_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_fg.Rows.Count == 3)
                {
                    return;
                }
                m_fg.Rows.Remove(m_fg.Row);
                CGridUtils.MakeSoTT(0, m_fg);
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_AfterAddRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            CGridUtils.MakeSoTT(0, m_fg);
        }

        void m_fg_LeaveCell(object sender, EventArgs e)
        {
            decimal v_dc_total = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {
                if (m_fg.Rows[v_i_cur_row][2] != null)
                    v_dc_total += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int)e_col_number.SO_TIEN]);
            }
            m_lbl_tong_tien.Text = CIPConvert.ToStr(v_dc_total, "#,##0");
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F704_V_BAO_HANH_SUA_CHUA_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_danh_sach_Click(object sender, EventArgs e)
        {
            try
            {

                //1. Chọn phiếu bảo hành
                F706_GD_PHIEU_BAO_HANH frm = new F706_GD_PHIEU_BAO_HANH();
                US_V_BAO_HANH_SUA_CHUA v_us_bao_hanh = new US_V_BAO_HANH_SUA_CHUA();
                if (frm.select_phieu_bao_hanh(v_us_bao_hanh) == DialogResult.OK)
                {
                    //2. đưa thông tin phiếu bảo hành lên trên form
                    us_v_bao_hanh_sua_chua_2_form(v_us_bao_hanh);
                    m_e_form_mode = DataEntryFormMode.UpdateDataState;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
