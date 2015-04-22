using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BKI_KHO.HeThong;
using IP.Core.IPCommon;
using BKI_KHO.NghiepVu;
namespace BKI_KHO {
    public partial class F000_Menu : DevExpress.XtraBars.Ribbon.RibbonForm {
        public F000_Menu() {
            InitializeComponent();
            format_control();
            MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage3;
        }
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode) {
            try {
                this.ShowDialog();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #region Private Methods
        private bool IsExistFormName(Form ip_frm) {
            foreach(var child in MdiChildren) {
                if(child.Name == ip_frm.Name) {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private bool IsExistFormText(Form ip_frm) {
            foreach(var child in MdiChildren) {
                if(child.Text == ip_frm.Text) {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void format_control() {
      
            set_define_events();
        }
        #endregion
        ///
        ///Events
        ///
        ///
        private void set_define_events() {
            //Nghiệp vụ
            m_cmd_nhap_kho.ItemClick += m_cmd_nhap_kho_ItemClick;
            m_cmd_xuat_kho.ItemClick += m_cmd_xuat_kho_ItemClick;
            m_cmd_nhap_so_du_dau.ItemClick += m_cmd_nhap_so_du_dau_ItemClick;
            //Hệ thống
            m_cmd_doi_mat_khau.ItemClick += m_cmd_doi_mat_khau_ItemClick;
            m_cmd_phan_quyen_cho_nhom.ItemClick += m_cmd_phan_quyen_cho_nhom_ItemClick;
            m_cmd_thoat.ItemClick += m_cmd_thoat_ItemClick;
            m_cmd_nhom_nsd.ItemClick += m_cmd_nhom_nsd_ItemClick;
            m_cmd_nguoi_su_dung.ItemClick += m_cmd_nguoi_su_dung_ItemClick;
            //Danh muc
            m_cmd_dm_kho.ItemClick += m_cmd_dm_kho_ItemClick;
            m_cmd_don_vi_tinh.ItemClick += m_cmd_don_vi_tinh_ItemClick;
            m_cmd_loai_chung_tu.ItemClick += m_cmd_loai_chung_tu_ItemClick;
            m_cmd_hang_hoa.ItemClick += m_cmd_hang_hoa_ItemClick;
            m_cmd_nhan_vien.ItemClick += m_cmd_nhan_vien_ItemClick;
            m_cmd_nhom_hang.ItemClick += m_cmd_nhom_hang_ItemClick;
            //Bao cao
            m_cmd_bc_xuat_nhap_ton.ItemClick += m_cmd_bc_xuat_nhap_ton_ItemClick;
            m_cmd_bc_loi_nhuan_gop.ItemClick += m_cmd_bc_loi_nhuan_gop_ItemClick;
            m_cmd_bc_doanh_thu_theo_nv.ItemClick += m_cmd_bc_doanh_thu_theo_nv_ItemClick;
        }

        void m_cmd_nhom_hang_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f302_V_DM_NHOM_HANG v_frm = new f302_V_DM_NHOM_HANG();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhan_vien_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f701_DM_NHAN_VIEN v_frm = new f701_DM_NHAN_VIEN();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_doanh_thu_theo_nv_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN v_frm = new f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_loi_nhuan_gop_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f807_RPT_LOI_NHUAN v_frm = new f807_RPT_LOI_NHUAN();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_xuat_nhap_ton_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f806_RPT_XUAT_NHAP_TON v_frm = new f806_RPT_XUAT_NHAP_TON();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hang_hoa_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f305_V_DM_HANG_HOA v_frm = new f305_V_DM_HANG_HOA();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_loai_chung_tu_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f112_DM_LOAI_CHUNG_TU v_frm = new f112_DM_LOAI_CHUNG_TU();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_don_vi_tinh_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f301_DM_DON_VI v_frm = new f301_DM_DON_VI();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dm_kho_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f110_V_DM_KHO v_frm = new f110_V_DM_KHO();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_so_du_dau_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f300_NHAP_SO_DU_DAU v_frm = new f300_NHAP_SO_DU_DAU();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_kho_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f604_phieu_xuat_kho v_frm = new f604_phieu_xuat_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_kho_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f600_phieu_nhap_kho v_frm = new f600_phieu_nhap_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nguoi_su_dung_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhom_nsd_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_cho_nhom_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}