#region Using directives
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SMSSC.Entities;
#endregion

namespace SMSSC.Data
{
	/// <summary>Defines the common data access methods that can be used by the ProviderDataSource control to interact with the underlying data store.</summary>
	/// <typeparam name="Entity">The class of the business object being accessed.</typeparam>
	/// <typeparam name="EntityKey">The class of the EntityId
	/// property of the specified business object class.</typeparam>
	public interface IEntityProvider<Entity, EntityKey> where Entity : IEntityId<EntityKey>, new() where EntityKey : IEntityKey, new()
	{
		/// <summary>Gets a row from the DataSource based on its primary key.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		Entity Get(TransactionManager mgr, EntityKey key);

		/// <summary>Gets number of rows from the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
        /// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <returns>Returns a number of rows from the DataSource.</returns>
		int GetTotalItems(TransactionManager mgr, string whereClause);

		/// <summary>Gets a page of rows from the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <returns>Returns a TList of Entity objects.</returns>
		TList<Entity> GetPaged(TransactionManager mgr, string whereClause, String orderBy);

		/// <summary>Inserts a row into the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to insert.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		bool Insert(TransactionManager mgr, Entity entity);

		/// <summary>Updates an existing row in the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to update.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		bool Update(TransactionManager mgr, Entity entity);

		/// <summary>Deletes a row from the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to delete.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		bool Delete(TransactionManager mgr, Entity entity);

	}
}
