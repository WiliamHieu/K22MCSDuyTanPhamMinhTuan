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
	///<summary>This class is the base class for any <see cref="MessageTemplateProviderBase"/> implementation. It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.</summary>
	public abstract partial class MessageTemplateProviderBaseCore : EntityProviderBase<SMSSC.Entities.MessageTemplate, SMSSC.Entities.MessageTemplateKey>
	{		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
        
        /// <summary>Gets a row from the DataSource based on its primary key.</summary>
        /// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override SMSSC.Entities.MessageTemplate Get(TransactionManager transactionManager, SMSSC.Entities.MessageTemplateKey key)
		{
			return GetById(transactionManager, key.Id);
		}
        
		/// <summary>Gets rows from the datasource based on the PK_MessageTemplate index.</summary>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SMSSC.Entities.MessageTemplate"/> class.</returns>
		public SMSSC.Entities.MessageTemplate GetById(System.Int32 _id)
		{
			return GetById(null, _id);
		}
				
		/// <summary>Gets rows from the datasource based on the PK_MessageTemplate index.</summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="SMSSC.Entities.MessageTemplate"/> class.</returns>
		public abstract SMSSC.Entities.MessageTemplate GetById(TransactionManager transactionManager, System.Int32 _id);
						
		#endregion "Get By Index Functions"
	
		#region Delete Methods

		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, SMSSC.Entities.MessageTemplateKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
		#endregion Delete Methods
		
		#region Custom Methods
		
		#endregion

		#region Helper Functions	
		
		/// <summary>Fill a TList&lt;MessageTemplate&gt; From a DataReader.</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MessageTemplate&gt;"/></returns>
		public static TList<MessageTemplate> Fill(IDataReader reader, TList<MessageTemplate> rows, int start, int pageLength)
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
				SMSSC.Entities.MessageTemplate c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MessageTemplate").Append("|").Append((System.Int32)reader[((int)MessageTemplateColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MessageTemplate>(key.ToString(), "MessageTemplate",entityCreationFactoryType, enableEntityTracking);
				}
				else
				{
					c = new SMSSC.Entities.MessageTemplate();
				}
				if (!enableEntityTracking || c.EntityState == EntityState.Added || (enableEntityTracking && ((currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) || (currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged))))
				{
					c.SuppressEntityEvents = true;
					c.Id = (System.Int32)reader[((int)MessageTemplateColumn.Id - 1)];
					c.Title = (System.String)reader[((int)MessageTemplateColumn.Title - 1)];
					c.ContentText = (System.String)reader[((int)MessageTemplateColumn.ContentText - 1)];
					c.Status = (System.Int32)reader[((int)MessageTemplateColumn.Status - 1)];
					c.CreatedDate = (System.DateTime)reader[((int)MessageTemplateColumn.CreatedDate - 1)];
					c.Note = (reader.IsDBNull(((int)MessageTemplateColumn.Note - 1)))?null:(System.String)reader[((int)MessageTemplateColumn.Note - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		    return rows;
		}		
		
        /// <summary>Refreshes the <see cref="SMSSC.Entities.MessageTemplate"/> object from the <see cref="IDataReader"/>.</summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="SMSSC.Entities.MessageTemplate"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, SMSSC.Entities.MessageTemplate entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[((int)MessageTemplateColumn.Id - 1)];
			entity.Title = (System.String)reader[((int)MessageTemplateColumn.Title - 1)];
			entity.ContentText = (System.String)reader[((int)MessageTemplateColumn.ContentText - 1)];
			entity.Status = (System.Int32)reader[((int)MessageTemplateColumn.Status - 1)];
			entity.CreatedDate = (System.DateTime)reader[((int)MessageTemplateColumn.CreatedDate - 1)];
			entity.Note = (reader.IsDBNull(((int)MessageTemplateColumn.Note - 1)))?null:(System.String)reader[((int)MessageTemplateColumn.Note - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>Refreshes the <see cref="SMSSC.Entities.MessageTemplate"/> object from the <see cref="DataSet"/>.</summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="SMSSC.Entities.MessageTemplate"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, SMSSC.Entities.MessageTemplate entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["Id"];
			entity.Title = (System.String)dataRow["Title"];
			entity.ContentText = (System.String)dataRow["ContentText"];
			entity.Status = (System.Int32)dataRow["Status"];
			entity.CreatedDate = (System.DateTime)dataRow["CreatedDate"];
			entity.Note = Convert.IsDBNull(dataRow["Note"]) ? null : (System.String)dataRow["Note"];
			entity.AcceptChanges();
		}
		#endregion 
		
	} // end class
	
	#region MessageTemplateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>SMSSC.Entities.MessageTemplate</c>
	///</summary>
	public enum MessageTemplateChildEntityTypes
	{
	}
	
	#endregion MessageTemplateChildEntityTypes
	
	#region MessageTemplateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MessageTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MessageTemplateFilterBuilder : SqlFilterBuilder<MessageTemplateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MessageTemplateFilterBuilder class.
		/// </summary>
		public MessageTemplateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MessageTemplateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MessageTemplateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MessageTemplateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MessageTemplateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MessageTemplateFilterBuilder
	
	#region MessageTemplateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MessageTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MessageTemplateParameterBuilder : ParameterizedSqlFilterBuilder<MessageTemplateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MessageTemplateParameterBuilder class.
		/// </summary>
		public MessageTemplateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MessageTemplateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MessageTemplateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MessageTemplateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MessageTemplateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MessageTemplateParameterBuilder
	
	#region MessageTemplateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MessageTemplateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MessageTemplate"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MessageTemplateSortBuilder : SqlSortBuilder<MessageTemplateColumn>
    {
		#region Constructors
		/// <summary>Initializes a new instance of the MessageTemplateSqlSortBuilder class.</summary>
		public MessageTemplateSortBuilder() : base() { }

		#endregion Constructors
    }    
    #endregion MessageTemplateSortBuilder
	
} // end namespace
