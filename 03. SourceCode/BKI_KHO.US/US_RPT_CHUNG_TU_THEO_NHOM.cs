///************************************************
/// Generated by: DucVT
/// Date: 27/04/2014 05:55:40
/// Goal: Create User Service Class for RPT_CHUNG_TU_THEO_NHOM
///************************************************
/// <summary>
/// Create User Service Class for RPT_CHUNG_TU_THEO_NHOM
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_RPT_CHUNG_TU_THEO_NHOM : US_Object
    {
        private const string c_TableName = "RPT_CHUNG_TU_THEO_NHOM";

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

        public string strTEN_LOAI_CT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOAI_CT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOAI_CT"] = value;
            }
        }

        public bool IsTEN_LOAI_CTNull()
        {
            return pm_objDR.IsNull("TEN_LOAI_CT");
        }

        public void SetTEN_LOAI_CTNull()
        {
            pm_objDR["TEN_LOAI_CT"] = System.Convert.DBNull;
        }

        public string strMA_CT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_CT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_CT"] = value;
            }
        }

        public bool IsMA_CTNull()
        {
            return pm_objDR.IsNull("MA_CT");
        }

        public void SetMA_CTNull()
        {
            pm_objDR["MA_CT"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CT
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CT", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CT"] = value;
            }
        }

        public bool IsNGAY_CTNull()
        {
            return pm_objDR.IsNull("NGAY_CT");
        }

        public void SetNGAY_CTNull()
        {
            pm_objDR["NGAY_CT"] = System.Convert.DBNull;
        }

        public string strDIEN_GIAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIEN_GIAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIEN_GIAI"] = value;
            }
        }

        public bool IsDIEN_GIAINull()
        {
            return pm_objDR.IsNull("DIEN_GIAI");
        }

        public void SetDIEN_GIAINull()
        {
            pm_objDR["DIEN_GIAI"] = System.Convert.DBNull;
        }

        public decimal dcSO_LUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_LUONG"] = value;
            }
        }

        public bool IsSO_LUONGNull()
        {
            return pm_objDR.IsNull("SO_LUONG");
        }

        public void SetSO_LUONGNull()
        {
            pm_objDR["SO_LUONG"] = System.Convert.DBNull;
        }

        public decimal dcGIA_GIAO_DICH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_GIAO_DICH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_GIAO_DICH"] = value;
            }
        }

        public bool IsGIA_GIAO_DICHNull()
        {
            return pm_objDR.IsNull("GIA_GIAO_DICH");
        }

        public void SetGIA_GIAO_DICHNull()
        {
            pm_objDR["GIA_GIAO_DICH"] = System.Convert.DBNull;
        }

        public decimal dcTONG_TIEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_TIEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_TIEN"] = value;
            }
        }

        public bool IsTONG_TIENNull()
        {
            return pm_objDR.IsNull("TONG_TIEN");
        }

        public void SetTONG_TIENNull()
        {
            pm_objDR["TONG_TIEN"] = System.Convert.DBNull;
        }

        #endregion

        #region "Init Functions"
        public US_RPT_CHUNG_TU_THEO_NHOM()
        {
            pm_objDS = new DS_RPT_CHUNG_TU_THEO_NHOM();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_RPT_CHUNG_TU_THEO_NHOM(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_RPT_CHUNG_TU_THEO_NHOM(decimal i_dbID)
        {
            pm_objDS = new DS_RPT_CHUNG_TU_THEO_NHOM();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDatasetByChungTu(DS_RPT_CHUNG_TU_THEO_NHOM op_ds, decimal ip_id_nhom_hang, string ip_key_word)
        {
            CStoredProc v_sp = new CStoredProc("pr_RPT_CHUNG_TU_THEO_NHOM_SelectAll");
            v_sp.addDecimalInputParam("@ip_id_nhom_hang", ip_id_nhom_hang);
            v_sp.addNVarcharInputParam("@ip_key_word", ip_key_word);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
