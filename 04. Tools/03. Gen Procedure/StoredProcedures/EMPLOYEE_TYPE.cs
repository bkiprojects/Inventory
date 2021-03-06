///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'EMPLOYEE_TYPE'
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
	/// Purpose: Data Access class for the table 'EMPLOYEE_TYPE'.
	/// </summary>
	public class EMPLOYEE_TYPE : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDecimal		_iD;
			private SqlString		_nAME, _eMPLOYEE_TYPE_CODE;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EMPLOYEE_TYPE()
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
		///		 <LI>EMPLOYEE_TYPE_CODE. May be SqlString.Null</LI>
		///		 <LI>NAME. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_TYPE_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@EMPLOYEE_TYPE_CODE", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _eMPLOYEE_TYPE_CODE));
				cmdToExecute.Parameters.Add(new SqlParameter("@NAME", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nAME));
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
				throw new Exception("EMPLOYEE_TYPE::Insert::Error occured.", ex);
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
		///		 <LI>EMPLOYEE_TYPE_CODE. May be SqlString.Null</LI>
		///		 <LI>NAME. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_TYPE_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, _iD));
				cmdToExecute.Parameters.Add(new SqlParameter("@EMPLOYEE_TYPE_CODE", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _eMPLOYEE_TYPE_CODE));
				cmdToExecute.Parameters.Add(new SqlParameter("@NAME", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nAME));

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
				throw new Exception("EMPLOYEE_TYPE::Update::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[pr_EMPLOYEE_TYPE_Delete]";
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
				throw new Exception("EMPLOYEE_TYPE::Delete::Error occured.", ex);
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


		public SqlString EMPLOYEE_TYPE_CODE
		{
			get
			{
				return _eMPLOYEE_TYPE_CODE;
			}
			set
			{
				SqlString eMPLOYEE_TYPE_CODETmp = (SqlString)value;
				if(eMPLOYEE_TYPE_CODETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("EMPLOYEE_TYPE_CODE", "EMPLOYEE_TYPE_CODE can't be NULL");
				}
				_eMPLOYEE_TYPE_CODE = value;
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
		#endregion
	}
}
