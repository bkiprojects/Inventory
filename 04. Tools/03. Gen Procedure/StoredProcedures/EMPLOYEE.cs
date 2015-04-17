///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'EMPLOYEE'
// Generated by LLBLGen v1.21.2003.712 Final on: 16/03/2008, 11:17:33 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace NhansuLLBL
{
	/// <summary>
	/// Purpose: Data Access class for the table 'EMPLOYEE'.
	/// </summary>
	public class EMPLOYEE : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_bIRTHDAY;
			private SqlDecimal		_iD;
			private SqlString		_pHONE, _qUALIFICATION, _aDDRESS, _eMPLOYEE_CODE, _nAME, _mALE;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EMPLOYEE()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>EMPLOYEE_CODE</LI>
		///		 <LI>NAME. May be SqlString.Null</LI>
		///		 <LI>BIRTHDAY. May be SqlDateTime.Null</LI>
		///		 <LI>MALE. May be SqlString.Null</LI>
		///		 <LI>PHONE. May be SqlString.Null</LI>
		///		 <LI>ADDRESS. May be SqlString.Null</LI>
		///		 <LI>QUALIFICATION. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _eMPLOYEE_CODE));
				cmdToExecute.Parameters.Add(new SqlParameter("@NAME", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nAME));
				cmdToExecute.Parameters.Add(new SqlParameter("@BIRTHDAY", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 23, 3, "", DataRowVersion.Proposed, _bIRTHDAY));
				cmdToExecute.Parameters.Add(new SqlParameter("@MALE", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mALE));
				cmdToExecute.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _pHONE));
				cmdToExecute.Parameters.Add(new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _aDDRESS));
				cmdToExecute.Parameters.Add(new SqlParameter("@QUALIFICATION", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _qUALIFICATION));
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Output, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_iD = (Decimal)cmdToExecute.Parameters["@ID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("EMPLOYEE::Insert::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		///		 <LI>EMPLOYEE_CODE</LI>
		///		 <LI>NAME. May be SqlString.Null</LI>
		///		 <LI>BIRTHDAY. May be SqlDateTime.Null</LI>
		///		 <LI>MALE. May be SqlString.Null</LI>
		///		 <LI>PHONE. May be SqlString.Null</LI>
		///		 <LI>ADDRESS. May be SqlString.Null</LI>
		///		 <LI>QUALIFICATION. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _eMPLOYEE_CODE));
				cmdToExecute.Parameters.Add(new SqlParameter("@NAME", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nAME));
				cmdToExecute.Parameters.Add(new SqlParameter("@BIRTHDAY", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 23, 3, "", DataRowVersion.Proposed, _bIRTHDAY));
				cmdToExecute.Parameters.Add(new SqlParameter("@MALE", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mALE));
				cmdToExecute.Parameters.Add(new SqlParameter("@PHONE", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _pHONE));
				cmdToExecute.Parameters.Add(new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _aDDRESS));
				cmdToExecute.Parameters.Add(new SqlParameter("@QUALIFICATION", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _qUALIFICATION));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("EMPLOYEE::Update::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));

				if(_mainConnectionIsCreatedLocal)
				{
					// Open connection.
					_mainConnection.Open();
				}
				else
				{
					if(_mainConnectionProvider.IsTransactionPending)
					{
						cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("EMPLOYEE::Delete::Error occured.", ex);
			}
			finally
			{
				if(_mainConnectionIsCreatedLocal)
				{
					// Close connection.
					_mainConnection.Close();
				}
				cmdToExecute.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlDecimal ID
		{
			get
			{
				return _iD;
			}
			set
			{
				SqlDecimal iDTmp = (SqlDecimal)value;
				if(iDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID", "ID can't be NULL");
				}
				_iD = value;
			}
		}


		public SqlString EMPLOYEE_CODE
		{
			get
			{
				return _eMPLOYEE_CODE;
			}
			set
			{
				SqlString eMPLOYEE_CODETmp = (SqlString)value;
				if(eMPLOYEE_CODETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("EMPLOYEE_CODE", "EMPLOYEE_CODE can't be NULL");
				}
				_eMPLOYEE_CODE = value;
			}
		}


		public SqlString NAME
		{
			get
			{
				return _nAME;
			}
			set
			{
				SqlString nAMETmp = (SqlString)value;
				if(nAMETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NAME", "NAME can't be NULL");
				}
				_nAME = value;
			}
		}


		public SqlDateTime BIRTHDAY
		{
			get
			{
				return _bIRTHDAY;
			}
			set
			{
				SqlDateTime bIRTHDAYTmp = (SqlDateTime)value;
				if(bIRTHDAYTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("BIRTHDAY", "BIRTHDAY can't be NULL");
				}
				_bIRTHDAY = value;
			}
		}


		public SqlString MALE
		{
			get
			{
				return _mALE;
			}
			set
			{
				SqlString mALETmp = (SqlString)value;
				if(mALETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("MALE", "MALE can't be NULL");
				}
				_mALE = value;
			}
		}


		public SqlString PHONE
		{
			get
			{
				return _pHONE;
			}
			set
			{
				SqlString pHONETmp = (SqlString)value;
				if(pHONETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("PHONE", "PHONE can't be NULL");
				}
				_pHONE = value;
			}
		}


		public SqlString ADDRESS
		{
			get
			{
				return _aDDRESS;
			}
			set
			{
				SqlString aDDRESSTmp = (SqlString)value;
				if(aDDRESSTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ADDRESS", "ADDRESS can't be NULL");
				}
				_aDDRESS = value;
			}
		}


		public SqlString QUALIFICATION
		{
			get
			{
				return _qUALIFICATION;
			}
			set
			{
				SqlString qUALIFICATIONTmp = (SqlString)value;
				if(qUALIFICATIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("QUALIFICATION", "QUALIFICATION can't be NULL");
				}
				_qUALIFICATION = value;
			}
		}
		#endregion
	}
}
