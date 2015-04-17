///************************************************
/// Generated by: NinhVH
/// Date: 26/11/2012 03:27:22
/// Goal: Create User Service Class for HT_NHOM_NGUOI_SU_DUNG
///************************************************
/// <summary>
/// Create User Service Class for HT_NHOM_NGUOI_SU_DUNG
/// </summary>


using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BKI_KHO.US
{
    public class US_HT_NHOM_NGUOI_SU_DUNG : US_Object
    {
        private const string c_TableName = "HT_NHOM_NGUOI_SU_DUNG";
        #region Public Properties
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

        public string strMA_NHOM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_NHOM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_NHOM"] = value;
            }
        }

        public bool IsMA_NHOMNull()
        {
            return pm_objDR.IsNull("MA_NHOM");
        }

        public void SetMA_NHOMNull()
        {
            pm_objDR["MA_NHOM"] = System.Convert.DBNull;
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

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_NHOM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_NHOM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_NHOM"] = value;
            }
        }

        public bool IsTRANG_THAI_NHOMNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_NHOM");
        }

        public void SetTRANG_THAI_NHOMNull()
        {
            pm_objDR["TRANG_THAI_NHOM"] = System.Convert.DBNull;
        }

        public decimal dcID_INPUTED_BY
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_INPUTED_BY", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_INPUTED_BY"] = value;
            }
        }

        public bool IsID_INPUTED_BYNull()
        {
            return pm_objDR.IsNull("ID_INPUTED_BY");
        }

        public void SetID_INPUTED_BYNull()
        {
            pm_objDR["ID_INPUTED_BY"] = System.Convert.DBNull;
        }

        public DateTime datINPUTED_DATE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "INPUTED_DATE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["INPUTED_DATE"] = value;
            }
        }

        public bool IsINPUTED_DATENull()
        {
            return pm_objDR.IsNull("INPUTED_DATE");
        }

        public void SetINPUTED_DATENull()
        {
            pm_objDR["INPUTED_DATE"] = System.Convert.DBNull;
        }

        public decimal dcID_LAST_UPDATED_BY
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LAST_UPDATED_BY", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LAST_UPDATED_BY"] = value;
            }
        }

        public bool IsID_LAST_UPDATED_BYNull()
        {
            return pm_objDR.IsNull("ID_LAST_UPDATED_BY");
        }

        public void SetID_LAST_UPDATED_BYNull()
        {
            pm_objDR["ID_LAST_UPDATED_BY"] = System.Convert.DBNull;
        }

        public DateTime datLAS_UPDATED_DATE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "LAS_UPDATED_DATE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["LAS_UPDATED_DATE"] = value;
            }
        }

        public bool IsLAS_UPDATED_DATENull()
        {
            return pm_objDR.IsNull("LAS_UPDATED_DATE");
        }

        public void SetLAS_UPDATED_DATENull()
        {
            pm_objDR["LAS_UPDATED_DATE"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_HT_NHOM_NGUOI_SU_DUNG()
        {
            pm_objDS = new DS_HT_NHOM_NGUOI_SU_DUNG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_NHOM_NGUOI_SU_DUNG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_NHOM_NGUOI_SU_DUNG(decimal i_dbID)
        {
            pm_objDS = new DS_HT_NHOM_NGUOI_SU_DUNG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
    }

}
