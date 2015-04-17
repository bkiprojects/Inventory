///************************************************
/// Generated by: DucVT
/// Date: 13/05/2014 09:44:23
/// Goal: Create User Service Class for RPT_HANG_HOA_XUAT_NHAP
///************************************************
/// <summary>
/// Create User Service Class for RPT_HANG_HOA_XUAT_NHAP
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_RPT_HANG_HOA_XUAT_NHAP : US_Object
    {
        private const string c_TableName = "RPT_HANG_HOA_XUAT_NHAP";
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

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_HANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_HANG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_HANG"] = value;
            }
        }

        public bool IsMA_HANGNull()
        {
            return pm_objDR.IsNull("MA_HANG");
        }

        public void SetMA_HANGNull()
        {
            pm_objDR["MA_HANG"] = System.Convert.DBNull;
        }

        public string strTEN_HANG_VN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_HANG_VN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_HANG_VN"] = value;
            }
        }

        public bool IsTEN_HANG_VNNull()
        {
            return pm_objDR.IsNull("TEN_HANG_VN");
        }

        public void SetTEN_HANG_VNNull()
        {
            pm_objDR["TEN_HANG_VN"] = System.Convert.DBNull;
        }

        public string strTEN_HANG_EN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_HANG_EN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_HANG_EN"] = value;
            }
        }

        public bool IsTEN_HANG_ENNull()
        {
            return pm_objDR.IsNull("TEN_HANG_EN");
        }

        public void SetTEN_HANG_ENNull()
        {
            pm_objDR["TEN_HANG_EN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_NHAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_NHAP"] = value;
            }
        }

        public bool IsNGAY_NHAPNull()
        {
            return pm_objDR.IsNull("NGAY_NHAP");
        }

        public void SetNGAY_NHAPNull()
        {
            pm_objDR["NGAY_NHAP"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_XUAT
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_XUAT", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_XUAT"] = value;
            }
        }

        public bool IsNGAY_XUATNull()
        {
            return pm_objDR.IsNull("NGAY_XUAT");
        }

        public void SetNGAY_XUATNull()
        {
            pm_objDR["NGAY_XUAT"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_RPT_HANG_HOA_XUAT_NHAP()
        {
            pm_objDS = new DS_RPT_HANG_HOA_XUAT_NHAP();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_RPT_HANG_HOA_XUAT_NHAP(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_RPT_HANG_HOA_XUAT_NHAP(decimal i_dbID)
        {
            pm_objDS = new DS_RPT_HANG_HOA_XUAT_NHAP();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDataset_By_ID_ThoiGian(DS_RPT_HANG_HOA_XUAT_NHAP op_ds, decimal ip_id_nhom_hang, DateTime ip_tu_ngay, DateTime ip_den_ngay)
        {
            CStoredProc v_sp = new CStoredProc("pr_RPT_HANG_HOA_XUAT_NHAP_SelectAll");
            v_sp.addDatetimeInputParam("@ip_from_date", ip_tu_ngay);
            v_sp.addDatetimeInputParam("@ip_to_date", ip_den_ngay);
            v_sp.addNVarcharInputParam("@ip_id_nhom_hang", ip_id_nhom_hang);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
