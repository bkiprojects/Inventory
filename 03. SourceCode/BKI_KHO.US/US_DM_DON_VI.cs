///************************************************
/// Generated by: TuyenNT
/// Date: 23/04/2014 08:06:36
/// Goal: Create User Service Class for DM_DON_VI
///************************************************
/// <summary>
/// Create User Service Class for DM_DON_VI
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US
{

    public class US_DM_DON_VI : US_Object
    {
        private const string c_TableName = "DM_DON_VI";
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

        public string strMA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA"] = value;
            }
        }

        public bool IsMANull()
        {
            return pm_objDR.IsNull("MA");
        }

        public void SetMANull()
        {
            pm_objDR["MA"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
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

        #endregion
        #region "Init Functions"
        public US_DM_DON_VI()
        {
            pm_objDS = new DS_DM_DON_VI();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_DON_VI(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_DON_VI(decimal i_dbID)
        {
            pm_objDS = new DS_DM_DON_VI();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }

        public void FillDatasetSearch(DS_DM_DON_VI op_ds, String i_str_search)
        {
            CStoredProc v_sp = new CStoredProc("pr_DM_DON_VI_search");
            v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_search);
            v_sp.fillDataSetByCommand(this, op_ds);
        }

        #endregion
    }
}
