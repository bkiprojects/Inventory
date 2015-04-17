///************************************************
/// Generated by: QUYETNT
/// Date: 23-04-2014 08:41:04
/// Goal: Create User Service Class for DM_KHACH_HANG
///************************************************
/// <summary>
/// Create User Service Class for DM_KHACH_HANG
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_DM_KHACH_HANG : US_Object
{
	private const string c_TableName = "DM_KHACH_HANG";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strMA_KHACH_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_KHACH_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_KHACH_HANG"] = value;
		}
	}

	public bool IsMA_KHACH_HANGNull() 
	{
		return pm_objDR.IsNull("MA_KHACH_HANG");
	}

	public void SetMA_KHACH_HANGNull() {
		pm_objDR["MA_KHACH_HANG"] = System.Convert.DBNull;
	}

	public string strTEN_KHACH_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_KHACH_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_KHACH_HANG"] = value;
		}
	}

	public bool IsTEN_KHACH_HANGNull() 
	{
		return pm_objDR.IsNull("TEN_KHACH_HANG");
	}

	public void SetTEN_KHACH_HANGNull() {
		pm_objDR["TEN_KHACH_HANG"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SINH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SINH"] = value;
		}
	}

	public bool IsNGAY_SINHNull()
	{
		return pm_objDR.IsNull("NGAY_SINH");
	}

	public void SetNGAY_SINHNull()
	{
		pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
	}

	public string strTEN_CONG_TY 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_CONG_TY", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_CONG_TY"] = value;
		}
	}

	public bool IsTEN_CONG_TYNull() 
	{
		return pm_objDR.IsNull("TEN_CONG_TY");
	}

	public void SetTEN_CONG_TYNull() {
		pm_objDR["TEN_CONG_TY"] = System.Convert.DBNull;
	}

	public string strDIA_CHI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_CHI"] = value;
		}
	}

	public bool IsDIA_CHINull() 
	{
		return pm_objDR.IsNull("DIA_CHI");
	}

	public void SetDIA_CHINull() {
		pm_objDR["DIA_CHI"] = System.Convert.DBNull;
	}

	public string strMA_BUU_DIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_BUU_DIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_BUU_DIEN"] = value;
		}
	}

	public bool IsMA_BUU_DIENNull() 
	{
		return pm_objDR.IsNull("MA_BUU_DIEN");
	}

	public void SetMA_BUU_DIENNull() {
		pm_objDR["MA_BUU_DIEN"] = System.Convert.DBNull;
	}

	public string strTHANH_PHO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "THANH_PHO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["THANH_PHO"] = value;
		}
	}

	public bool IsTHANH_PHONull() 
	{
		return pm_objDR.IsNull("THANH_PHO");
	}

	public void SetTHANH_PHONull() {
		pm_objDR["THANH_PHO"] = System.Convert.DBNull;
	}

	public string strDIEN_THOAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIEN_THOAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIEN_THOAI"] = value;
		}
	}

	public bool IsDIEN_THOAINull() 
	{
		return pm_objDR.IsNull("DIEN_THOAI");
	}

	public void SetDIEN_THOAINull() {
		pm_objDR["DIEN_THOAI"] = System.Convert.DBNull;
	}

	public string strFAX 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "FAX", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["FAX"] = value;
		}
	}

	public bool IsFAXNull() 
	{
		return pm_objDR.IsNull("FAX");
	}

	public void SetFAXNull() {
		pm_objDR["FAX"] = System.Convert.DBNull;
	}

	public string strDIEN_THOAI_1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIEN_THOAI_1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIEN_THOAI_1"] = value;
		}
	}

	public bool IsDIEN_THOAI_1Null() 
	{
		return pm_objDR.IsNull("DIEN_THOAI_1");
	}

	public void SetDIEN_THOAI_1Null() {
		pm_objDR["DIEN_THOAI_1"] = System.Convert.DBNull;
	}

	public string strDIEN_THOAI_2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIEN_THOAI_2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIEN_THOAI_2"] = value;
		}
	}

	public bool IsDIEN_THOAI_2Null() 
	{
		return pm_objDR.IsNull("DIEN_THOAI_2");
	}

	public void SetDIEN_THOAI_2Null() {
		pm_objDR["DIEN_THOAI_2"] = System.Convert.DBNull;
	}

	public string strDI_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DI_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DI_DONG"] = value;
		}
	}

	public bool IsDI_DONGNull() 
	{
		return pm_objDR.IsNull("DI_DONG");
	}

	public void SetDI_DONGNull() {
		pm_objDR["DI_DONG"] = System.Convert.DBNull;
	}

	public string strEMAIL 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["EMAIL"] = value;
		}
	}

	public bool IsEMAILNull() 
	{
		return pm_objDR.IsNull("EMAIL");
	}

	public void SetEMAILNull() {
		pm_objDR["EMAIL"] = System.Convert.DBNull;
	}

	public string strWEBSITE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "WEBSITE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["WEBSITE"] = value;
		}
	}

	public bool IsWEBSITENull() 
	{
		return pm_objDR.IsNull("WEBSITE");
	}

	public void SetWEBSITENull() {
		pm_objDR["WEBSITE"] = System.Convert.DBNull;
	}

	public string strMA_SO_THUE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_SO_THUE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_SO_THUE"] = value;
		}
	}

	public bool IsMA_SO_THUENull() 
	{
		return pm_objDR.IsNull("MA_SO_THUE");
	}

	public void SetMA_SO_THUENull() {
		pm_objDR["MA_SO_THUE"] = System.Convert.DBNull;
	}

	public decimal dcCreditLimit 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "CreditLimit", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["CreditLimit"] = value;
		}
	}

	public bool IsCreditLimitNull()	{
		return pm_objDR.IsNull("CreditLimit");
	}

	public void SetCreditLimitNull() {
		pm_objDR["CreditLimit"] = System.Convert.DBNull;
	}

	public decimal dcID_KIEU_KHACH_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_KIEU_KHACH_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_KIEU_KHACH_HANG"] = value;
		}
	}

	public bool IsID_KIEU_KHACH_HANGNull()	{
		return pm_objDR.IsNull("ID_KIEU_KHACH_HANG");
	}

	public void SetID_KIEU_KHACH_HANGNull() {
		pm_objDR["ID_KIEU_KHACH_HANG"] = System.Convert.DBNull;
	}

	public decimal dcID_KHO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_KHO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_KHO"] = value;
		}
	}

	public bool IsID_KHONull()	{
		return pm_objDR.IsNull("ID_KHO");
	}

	public void SetID_KHONull() {
		pm_objDR["ID_KHO"] = System.Convert.DBNull;
	}

	public decimal dcID_NHAN_VIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_VIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHAN_VIEN"] = value;
		}
	}

	public bool IsID_NHAN_VIENNull()	{
		return pm_objDR.IsNull("ID_NHAN_VIEN");
	}

	public void SetID_NHAN_VIENNull() {
		pm_objDR["ID_NHAN_VIEN"] = System.Convert.DBNull;
	}

	public decimal dcID_SHIP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_SHIP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_SHIP"] = value;
		}
	}

	public bool IsID_SHIPNull()	{
		return pm_objDR.IsNull("ID_SHIP");
	}

	public void SetID_SHIPNull() {
		pm_objDR["ID_SHIP"] = System.Convert.DBNull;
	}

	public decimal dcID_KIEU_MUA_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_KIEU_MUA_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_KIEU_MUA_HANG"] = value;
		}
	}

	public bool IsID_KIEU_MUA_HANGNull()	{
		return pm_objDR.IsNull("ID_KIEU_MUA_HANG");
	}

	public void SetID_KIEU_MUA_HANGNull() {
		pm_objDR["ID_KIEU_MUA_HANG"] = System.Convert.DBNull;
	}

	public decimal dcID_KIEU_THANH_TOAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_KIEU_THANH_TOAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_KIEU_THANH_TOAN"] = value;
		}
	}

	public bool IsID_KIEU_THANH_TOANNull()	{
		return pm_objDR.IsNull("ID_KIEU_THANH_TOAN");
	}

	public void SetID_KIEU_THANH_TOANNull() {
		pm_objDR["ID_KIEU_THANH_TOAN"] = System.Convert.DBNull;
	}

	public decimal dcID_TIEN_TE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TIEN_TE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TIEN_TE"] = value;
		}
	}

	public bool IsID_TIEN_TENull()	{
		return pm_objDR.IsNull("ID_TIEN_TE");
	}

	public void SetID_TIEN_TENull() {
		pm_objDR["ID_TIEN_TE"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_THAM_GIA
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THAM_GIA", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THAM_GIA"] = value;
		}
	}

	public bool IsNGAY_THAM_GIANull()
	{
		return pm_objDR.IsNull("NGAY_THAM_GIA");
	}

	public void SetNGAY_THAM_GIANull()
	{
		pm_objDR["NGAY_THAM_GIA"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_THAM_GIA_GAN_NHAT
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THAM_GIA_GAN_NHAT", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THAM_GIA_GAN_NHAT"] = value;
		}
	}

	public bool IsNGAY_THAM_GIA_GAN_NHATNull()
	{
		return pm_objDR.IsNull("NGAY_THAM_GIA_GAN_NHAT");
	}

	public void SetNGAY_THAM_GIA_GAN_NHATNull()
	{
		pm_objDR["NGAY_THAM_GIA_GAN_NHAT"] = System.Convert.DBNull;
	}

	public string strID_USER 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "ID_USER", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["ID_USER"] = value;
		}
	}

	public bool IsID_USERNull() 
	{
		return pm_objDR.IsNull("ID_USER");
	}

	public void SetID_USERNull() {
		pm_objDR["ID_USER"] = System.Convert.DBNull;
	}

	public DateTime datTIMESTAMP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "TIMESTAMP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["TIMESTAMP"] = value;
		}
	}

	public bool IsTIMESTAMPNull()
	{
		return pm_objDR.IsNull("TIMESTAMP");
	}

	public void SetTIMESTAMPNull()
	{
		pm_objDR["TIMESTAMP"] = System.Convert.DBNull;
	}

	public string strID_NGUOI_DUNG_MOI_NHAT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "ID_NGUOI_DUNG_MOI_NHAT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["ID_NGUOI_DUNG_MOI_NHAT"] = value;
		}
	}

	public bool IsID_NGUOI_DUNG_MOI_NHATNull() 
	{
		return pm_objDR.IsNull("ID_NGUOI_DUNG_MOI_NHAT");
	}

	public void SetID_NGUOI_DUNG_MOI_NHATNull() {
		pm_objDR["ID_NGUOI_DUNG_MOI_NHAT"] = System.Convert.DBNull;
	}

	public DateTime datTHOI_GIAN_GAN_NHAT
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_GAN_NHAT", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["THOI_GIAN_GAN_NHAT"] = value;
		}
	}

	public bool IsTHOI_GIAN_GAN_NHATNull()
	{
		return pm_objDR.IsNull("THOI_GIAN_GAN_NHAT");
	}

	public void SetTHOI_GIAN_GAN_NHATNull()
	{
		pm_objDR["THOI_GIAN_GAN_NHAT"] = System.Convert.DBNull;
	}

	public string strTRANG_THAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
	}

	public string strGHI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU"] = value;
		}
	}

	public bool IsGHI_CHUNull() 
	{
		return pm_objDR.IsNull("GHI_CHU");
	}

	public void SetGHI_CHUNull() {
		pm_objDR["GHI_CHU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_KHACH_HANG() 
	{
		pm_objDS = new DS_DM_KHACH_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_KHACH_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_KHACH_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_KHACH_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_DM_KHACH_HANG m_ds, string i_str_search)
    {
        CStoredProc v_sp = new CStoredProc("pr_DM_KHACH_HANG_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
        v_sp.fillDataSetByCommand(this, m_ds);
    }
}
}
