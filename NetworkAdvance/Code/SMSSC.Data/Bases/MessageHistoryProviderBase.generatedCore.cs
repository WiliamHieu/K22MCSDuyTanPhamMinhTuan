#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using SMSSC.Entities;
using SMSSC.Data;

#endregion

namespace SMSSC.Data.Bases
{	
	///<summary>This class is the base class for any <see cref="MessageHistoryProviderBase"/> implementation. It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.</summary>
	public abstract partial class MessageHistoryProviderBaseCore : EntityProviderBase<SMSSC.Entities.MessageHistory, SMSSC.Entities.MessageHistoryKey>
	{		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
        
        /// <summary>Gets a row from the DataSource based on its primary key.</summary>
        /// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override SMSSC.Entities.MessageHistory Get(TransactionManager transactionManager, SMSSC.Entities.MessageHistoryKey key)
		{
			return GetById(transactionManager, key.Id);
		}
        
		/// <summary>Gets rows from the datasource based on the PK_MessageHistory_1 index.</summary>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SMSSC.Entities.MessageHistory"/> class.</returns>
		public SMSSC.Entities.MessageHistory GetById(System.Guid _id)
		{
			return GetById(null, _id);
		}
				
		/// <summary>Gets rows from the datasource based on the PK_MessageHistory_1 index.</summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="SMSSC.Entities.MessageHistory"/> class.</returns>
		public abstract SMSSC.Entities.MessageHistory GetById(TransactionManager transactionManager, System.Guid _id);
						
		#endregion "Get By Index Functions"
	
		#region Delete Methods

		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, SMSSC.Entities.MessageHistoryKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Guid _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Guid _id);		
		
		#endregion Delete Methods
		
		#region Custom Methods
		
		#endregion

		#region Helper Functions	
		
		/// <summary>Fill a TList&lt;MessageHistory&gt; From a DataReader.</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MessageHistory&gt;"/></returns>
		public static TList<MessageHistory> Fill(IDataReader reader, TList<MessageHistory> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read()) break; // we are done
					
				string key = null;
				SMSSC.Entities.MessageHistory c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MessageHistory").Append("|").Append((System.Guid)reader[((int)MessageHistoryColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MessageHistory>(key.ToString(), "MessageHistory",entityCreationFactoryType, enableEntityTracking);
				}
				else
				{
					c = new SMSSC.Entities.MessageHistory();
				}
				if (!enableEntityTracking || c.EntityState == EntityState.Added || (enableEntityTracking && ((currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) || (currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged))))
				{
					c.SuppressEntityEvents = true;
					c.Id = (System.Guid)reader[((int)MessageHistoryColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.MessageType = (System.Int32)reader[((int)MessageHistoryColumn.MessageType - 1)];
					c.FromPhoneNumber = (System.String)reader[((int)MessageHistoryColumn.FromPhoneNumber - 1)];
					c.ToPhoneNumber = (System.String)reader[((int)MessageHistoryColumn.ToPhoneNumber - 1)];
					c.ContentText = (System.String)reader[((int)MessageHistoryColumn.ContentText - 1)];
					c.Status = (System.Int32)reader[((int)MessageHistoryColumn.Status - 1)];
					c.CreatedDate = (System.DateTime)reader[((int)MessageHistoryColumn.CreatedDate - 1)];
					c.SentDate = (reader.IsDBNull(((int)MessageHistoryColumn.SentDate - 1)))?null:(System.DateTime?)reader[((int)MessageHistoryColumn.SentDate - 1)];
					c.Note = (reader.IsDBNull(((int)MessageHistoryColumn.Note - 1)))?null:(System.String)reader[((int)MessageHistoryColumn.Note - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		    return rows;
		}		
		
        /// <summary>Refreshes the <see cref="SMSSC.Entities.MessageHistory"/> object from the <see cref="IDataReader"/>.</summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="SMSSC.Entities.MessageHistory"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, SMSSC.Entities.MessageHistory entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Guid)reader[((int)MessageHistoryColumn.Id - 1)];
			entity.OriginalId = (System.Guid)reader["Id"];
			entity.MessageType = (System.Int32)reader[((int)MessageHistoryColumn.MessageType - 1)];
			entity.FromPhoneNumber = (System.String)reader[((int)MessageHistoryColumn.FromPhoneNumber - 1)];
			entity.ToPhoneNumber = (System.String)reader[((int)MessageHistoryColumn.ToPhoneNumber - 1)];
			entity.ContentText = (System.String)reader[((int)MessageHistoryColumn.ContentText - 1)];
			entity.Status = (System.Int32)reader[((int)MessageHistoryColumn.Status - 1)];
			entity.CreatedDate = (System.DateTime)reader[((int)MessageHistoryColumn.CreatedDate - 1)];
			entity.SentDate = (reader.IsDBNull(((int)MessageHistoryColumn.SentDate - 1)))?null:(System.DateTime?)reader[((int)MessageHistoryColumn.SentDate - 1)];
			entity.Note = (reader.IsDBNull(((int)MessageHistoryColumn.Note - 1)))?null:(System.String)reader[((int)MessageHistoryColumn.Note - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>Refreshes the <see cref="SMSSC.Entities.MessageHistory"/> object from the <see cref="DataSet"/>.</summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="SMSSC.Entities.MessageHistory"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, SMSSC.Entities.MessageHistory entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Guid)dataRow["Id"];
			entity.OriginalId = (System.Guid)dataRow["Id"];
			entity.MessageType = (System.Int32)dataRow["MessageType"];
			entity.FromPhoneNumber = (System.String)dataRow["FromPhoneNumber"];
			entity.ToPhoneNumber = (System.String)dataRow["ToPhoneNumber"];
			entity.ContentText = (System.String)dataRow["ContentText"];
			entity.Status = (System.Int32)dataRow["Status"];
			entity.CreatedDate = (System.DateTime)dataRow["CreatedDate"];
			entity.SentDate = Convert.IsDBNull(dataRow["SentDate"]) ? null : (System.DateTime?)dataRow["SentDate"];
			entity.Note = Convert.IsDBNull(dataRow["Note"]) ? null : (System.String)dataRow["Note"];
			entity.AcceptChanges();
		}
		#endregion 
		
	} // end class
	
	#region MessageHistoryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>SMSSC.Entities.MessageHistory</c>
	///</summary>
	public enum MessageHistoryChildEntityTypes
	{
	}
	
	#endregion MessageHistoryChildEntityTypes
	
	#region MessageHistoryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MessageHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageHistory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MessageHistoryFilterBuilder : SqlFilterBuilder<MessageHistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MessageHistoryFilterBuilder class.
		/// </summary>
		public MessageHistoryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MessageHistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MessageHistoryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MessageHistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MessageHistoryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MessageHistoryFilterBuilder
	
	#region MessageHistoryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MessageHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageHistory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MessageHistoryParameterBuilder : ParameterizedSqlFilterBuilder<MessageHistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MessageHistoryParameterBuilder class.
		/// </summary>
		public MessageHistoryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MessageHistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MessageHistoryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MessageHistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MessageHistoryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MessageHistoryParameterBuilder
	
	#region MessageHistorySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MessageHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageHistory"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MessageHistorySortBuilder : SqlSortBuilder<MessageHistoryColumn>
    {
		#region Constructors
		/// <summary>Initializes a new instance of the MessageHistorySqlSortBuilder class.</summary>
		public MessageHistorySortBuilder() : base() { }

		#endregion Constructors
    }    
    #endregion MessageHistorySortBuilder
	
} // end namespace
