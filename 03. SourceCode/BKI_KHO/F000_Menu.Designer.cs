namespace BKI_KHO {
    partial class F000_Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F000_Menu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_cmd_dm_kho = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_hang_hoa = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nhom_hang = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_don_vi_tinh = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_loai_chung_tu = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nhan_vien = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nhap_kho = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_xuat_kho = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nhap_so_du_dau = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bc_loi_nhuan_gop = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bc_doanh_thu_theo_nv = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_bc_xuat_nhap_ton = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_phan_quyen_cho_nhom = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nguoi_su_dung = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_doi_mat_khau = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_nhom_nsd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationCaption = "Phần mềm quản lý kho hàng";
            this.ribbon.AutoSizeItems = true;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.m_cmd_dm_kho,
            this.m_cmd_hang_hoa,
            this.m_cmd_nhom_hang,
            this.m_cmd_don_vi_tinh,
            this.m_cmd_loai_chung_tu,
            this.m_cmd_nhan_vien,
            this.m_cmd_nhap_kho,
            this.m_cmd_xuat_kho,
            this.m_cmd_nhap_so_du_dau,
            this.m_cmd_bc_loi_nhuan_gop,
            this.m_cmd_bc_doanh_thu_theo_nv,
            this.m_cmd_bc_xuat_nhap_ton,
            this.m_cmd_thoat,
            this.m_cmd_phan_quyen_cho_nhom,
            this.m_cmd_nguoi_su_dung,
            this.m_cmd_doi_mat_khau,
            this.m_cmd_nhom_nsd});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(824, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // m_cmd_dm_kho
            // 
            this.m_cmd_dm_kho.Caption = "Kho";
            this.m_cmd_dm_kho.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_dm_kho.Glyph")));
            this.m_cmd_dm_kho.Id = 1;
            this.m_cmd_dm_kho.LargeGlyph = global::BKI_KHO.Properties.Resources._1431352279_Home;
            this.m_cmd_dm_kho.Name = "m_cmd_dm_kho";
            // 
            // m_cmd_hang_hoa
            // 
            this.m_cmd_hang_hoa.Caption = "Hàng hóa";
            this.m_cmd_hang_hoa.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_hang_hoa.Glyph")));
            this.m_cmd_hang_hoa.Id = 2;
            this.m_cmd_hang_hoa.Name = "m_cmd_hang_hoa";
            this.m_cmd_hang_hoa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // m_cmd_nhom_hang
            // 
            this.m_cmd_nhom_hang.Caption = "Nhóm hàng";
            this.m_cmd_nhom_hang.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhom_hang.Glyph")));
            this.m_cmd_nhom_hang.Id = 3;
            this.m_cmd_nhom_hang.Name = "m_cmd_nhom_hang";
            this.m_cmd_nhom_hang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // m_cmd_don_vi_tinh
            // 
            this.m_cmd_don_vi_tinh.Caption = "Đơn vị tính";
            this.m_cmd_don_vi_tinh.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_don_vi_tinh.Glyph")));
            this.m_cmd_don_vi_tinh.Id = 4;
            this.m_cmd_don_vi_tinh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_don_vi_tinh.LargeGlyph")));
            this.m_cmd_don_vi_tinh.Name = "m_cmd_don_vi_tinh";
            // 
            // m_cmd_loai_chung_tu
            // 
            this.m_cmd_loai_chung_tu.Caption = "Loại chứng từ";
            this.m_cmd_loai_chung_tu.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_loai_chung_tu.Glyph")));
            this.m_cmd_loai_chung_tu.Id = 5;
            this.m_cmd_loai_chung_tu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_loai_chung_tu.LargeGlyph")));
            this.m_cmd_loai_chung_tu.Name = "m_cmd_loai_chung_tu";
            // 
            // m_cmd_nhan_vien
            // 
            this.m_cmd_nhan_vien.Caption = "Nhân viên";
            this.m_cmd_nhan_vien.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhan_vien.Glyph")));
            this.m_cmd_nhan_vien.Id = 6;
            this.m_cmd_nhan_vien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhan_vien.LargeGlyph")));
            this.m_cmd_nhan_vien.Name = "m_cmd_nhan_vien";
            // 
            // m_cmd_nhap_kho
            // 
            this.m_cmd_nhap_kho.Caption = "Nhập kho";
            this.m_cmd_nhap_kho.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhap_kho.Glyph")));
            this.m_cmd_nhap_kho.Id = 7;
            this.m_cmd_nhap_kho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhap_kho.LargeGlyph")));
            this.m_cmd_nhap_kho.Name = "m_cmd_nhap_kho";
            // 
            // m_cmd_xuat_kho
            // 
            this.m_cmd_xuat_kho.Caption = "Xuất kho";
            this.m_cmd_xuat_kho.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_kho.Glyph")));
            this.m_cmd_xuat_kho.Id = 8;
            this.m_cmd_xuat_kho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_kho.LargeGlyph")));
            this.m_cmd_xuat_kho.Name = "m_cmd_xuat_kho";
            // 
            // m_cmd_nhap_so_du_dau
            // 
            this.m_cmd_nhap_so_du_dau.Caption = "Nhập số dư đầu";
            this.m_cmd_nhap_so_du_dau.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhap_so_du_dau.Glyph")));
            this.m_cmd_nhap_so_du_dau.Id = 9;
            this.m_cmd_nhap_so_du_dau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhap_so_du_dau.LargeGlyph")));
            this.m_cmd_nhap_so_du_dau.Name = "m_cmd_nhap_so_du_dau";
            // 
            // m_cmd_bc_loi_nhuan_gop
            // 
            this.m_cmd_bc_loi_nhuan_gop.Caption = "Lợi nhuận gộp";
            this.m_cmd_bc_loi_nhuan_gop.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_loi_nhuan_gop.Glyph")));
            this.m_cmd_bc_loi_nhuan_gop.Id = 11;
            this.m_cmd_bc_loi_nhuan_gop.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_loi_nhuan_gop.LargeGlyph")));
            this.m_cmd_bc_loi_nhuan_gop.Name = "m_cmd_bc_loi_nhuan_gop";
            // 
            // m_cmd_bc_doanh_thu_theo_nv
            // 
            this.m_cmd_bc_doanh_thu_theo_nv.Caption = "Doanh thu theo nhân viên";
            this.m_cmd_bc_doanh_thu_theo_nv.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_doanh_thu_theo_nv.Glyph")));
            this.m_cmd_bc_doanh_thu_theo_nv.Id = 12;
            this.m_cmd_bc_doanh_thu_theo_nv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_doanh_thu_theo_nv.LargeGlyph")));
            this.m_cmd_bc_doanh_thu_theo_nv.Name = "m_cmd_bc_doanh_thu_theo_nv";
            // 
            // m_cmd_bc_xuat_nhap_ton
            // 
            this.m_cmd_bc_xuat_nhap_ton.Caption = "Xuất-Nhập-Tồn";
            this.m_cmd_bc_xuat_nhap_ton.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_xuat_nhap_ton.Glyph")));
            this.m_cmd_bc_xuat_nhap_ton.Id = 13;
            this.m_cmd_bc_xuat_nhap_ton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_bc_xuat_nhap_ton.LargeGlyph")));
            this.m_cmd_bc_xuat_nhap_ton.Name = "m_cmd_bc_xuat_nhap_ton";
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Caption = "Thoát";
            this.m_cmd_thoat.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thoat.Glyph")));
            this.m_cmd_thoat.Id = 15;
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // m_cmd_phan_quyen_cho_nhom
            // 
            this.m_cmd_phan_quyen_cho_nhom.Caption = "Phân quyền cho nhóm";
            this.m_cmd_phan_quyen_cho_nhom.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_phan_quyen_cho_nhom.Glyph")));
            this.m_cmd_phan_quyen_cho_nhom.Id = 16;
            this.m_cmd_phan_quyen_cho_nhom.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_phan_quyen_cho_nhom.LargeGlyph")));
            this.m_cmd_phan_quyen_cho_nhom.Name = "m_cmd_phan_quyen_cho_nhom";
            // 
            // m_cmd_nguoi_su_dung
            // 
            this.m_cmd_nguoi_su_dung.Caption = "Người sử dụng";
            this.m_cmd_nguoi_su_dung.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguoi_su_dung.Glyph")));
            this.m_cmd_nguoi_su_dung.Id = 17;
            this.m_cmd_nguoi_su_dung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nguoi_su_dung.LargeGlyph")));
            this.m_cmd_nguoi_su_dung.Name = "m_cmd_nguoi_su_dung";
            // 
            // m_cmd_doi_mat_khau
            // 
            this.m_cmd_doi_mat_khau.Caption = "Đổi mật khẩu";
            this.m_cmd_doi_mat_khau.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_doi_mat_khau.Glyph")));
            this.m_cmd_doi_mat_khau.Id = 18;
            this.m_cmd_doi_mat_khau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_doi_mat_khau.LargeGlyph")));
            this.m_cmd_doi_mat_khau.Name = "m_cmd_doi_mat_khau";
            // 
            // m_cmd_nhom_nsd
            // 
            this.m_cmd_nhom_nsd.Caption = "Nhóm người sử dụng";
            this.m_cmd_nhom_nsd.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhom_nsd.Glyph")));
            this.m_cmd_nhom_nsd.Id = 19;
            this.m_cmd_nhom_nsd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_nhom_nsd.LargeGlyph")));
            this.m_cmd_nhom_nsd.Name = "m_cmd_nhom_nsd";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_thoat);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_phan_quyen_cho_nhom);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_nguoi_su_dung);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_doi_mat_khau);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_cmd_nhom_nsd);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_dm_kho);
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_hang_hoa);
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_nhom_hang);
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_don_vi_tinh);
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_loai_chung_tu);
            this.ribbonPageGroup2.ItemLinks.Add(this.m_cmd_nhan_vien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.m_cmd_nhap_kho);
            this.ribbonPageGroup3.ItemLinks.Add(this.m_cmd_xuat_kho);
            this.ribbonPageGroup3.ItemLinks.Add(this.m_cmd_nhap_so_du_dau);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.m_cmd_bc_loi_nhuan_gop);
            this.ribbonPageGroup4.ItemLinks.Add(this.m_cmd_bc_doanh_thu_theo_nv);
            this.ribbonPageGroup4.ItemLinks.Add(this.m_cmd_bc_xuat_nhap_ton);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(824, 31);
            // 
            // MdiManager
            // 
            this.MdiManager.MdiParent = this;
            // 
            // F000_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "F000_Menu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý kho hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem m_cmd_dm_kho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem m_cmd_hang_hoa;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nhom_hang;
        private DevExpress.XtraBars.BarButtonItem m_cmd_don_vi_tinh;
        private DevExpress.XtraBars.BarButtonItem m_cmd_loai_chung_tu;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nhan_vien;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nhap_kho;
        private DevExpress.XtraBars.BarButtonItem m_cmd_xuat_kho;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nhap_so_du_dau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bc_loi_nhuan_gop;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bc_doanh_thu_theo_nv;
        private DevExpress.XtraBars.BarButtonItem m_cmd_bc_xuat_nhap_ton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem m_cmd_thoat;
        private DevExpress.XtraBars.BarButtonItem m_cmd_phan_quyen_cho_nhom;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nguoi_su_dung;
        private DevExpress.XtraBars.BarButtonItem m_cmd_doi_mat_khau;
        private DevExpress.XtraBars.BarButtonItem m_cmd_nhom_nsd;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
    }
}