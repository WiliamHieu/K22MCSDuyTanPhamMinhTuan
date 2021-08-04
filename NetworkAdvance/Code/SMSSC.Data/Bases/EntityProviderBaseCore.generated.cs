#region Using directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Diagnostics;
using System.Text;

using SMSSC.Entities;
#endregion

namespace SMSSC.Data.Bases
{
	/// <summary>
	/// Serves as the base class for objects that provide data access functionality.
	/// Provides a default implementation of the IEntityProvider&lt;Entity, EntityKey&gt; interface.
	/// </summary>
	/// <typeparam name="Entity">The class of the business object being accessed.</typeparam>
	/// <typeparam name="EntityKey">The class of the EntityId
	/// property of the specified business object class.</typeparam>
	[Serializable]
	[CLSCompliant(true)]
	public abstract partial class EntityProviderBaseCore<Entity, EntityKey> : IEntityProvider<Entity, EntityKey> where Entity : IEntityId<EntityKey>, new() where EntityKey : IEntityKey, new()
	{
		#region Get Methods

		/// <summary>Gets a row from the DataSource based on its primary key.</summary>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public virtual Entity Get(EntityKey key)
		{
			return Get(null, key);
		}
			
		/// <summary>Gets a row from the DataSource based on its primary key.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public abstract Entity Get(TransactionManager mgr, EntityKey key);

		#endregion

		#region GetTotalItems Methods
		
        /// <summary>Gets number of rows from the DataSource.</summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <remarks></remarks>
		/// <returns>Returns a number of rows from the DataSource.</returns>
		public virtual int GetTotalItems(string whereClause)
		{
			return GetTotalItems(null, whereClause);
		}

        /// <summary>Gets number of rows from the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <remarks></remarks>
		/// <returns>Returns a number of rows from the DataSource.</returns>
		public abstract int GetTotalItems(TransactionManager mgr, string whereClause);

		#endregion

		#region GetPaged Methods

		/// <summary>Gets a page of rows from the DataSource.</summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <returns>Returns a TList of Entity objects.</returns>
		public virtual TList<Entity> GetPaged(string whereClause, string orderBy)
		{
			return GetPaged(null, whereClause, orderBy);
		}

		/// <summary>Gets a page of rows from the DataSource.</summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <returns>Returns a TList of Entity objects.</returns>
		public abstract TList<Entity> GetPaged(TransactionManager mgr, string whereClause, string orderBy);

		#endregion

		#region Insert Methods

		/// <summary>
		/// Inserts a row into the DataSource.
		/// </summary>
		/// <param name="entity">The Entity object to insert.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public virtual bool Insert(Entity entity)
		{
			return Insert(null, entity);
		}

		/// <summary>
		/// Inserts a row into the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to insert.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public abstract bool Insert(TransactionManager mgr, Entity entity);

		/// <summary>
		/// Inserts rows into the DataSource.
		/// </summary>
		/// <param name="entities">TList of Entity objects to insert.</param>
		/// <returns>Returns the number of rows successfully inserted.</returns>
		public virtual int Insert(TList<Entity> entities)
		{
			return Insert(null, entities);
		}

		/// <summary>
		/// Inserts rows into the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entities">TList of Entity objects to insert.</param>
		/// <returns>Returns the number of rows successfully inserted.</returns>
		public virtual int Insert(TransactionManager mgr, TList<Entity> entities)
		{
			int count = 0;

			foreach ( Entity entity in entities )
			{
				if ( entity.EntityState == EntityState.Added )
				{
					if ( Insert(mgr, entity) )
					{
						count++;
					}
				}
			}

			return count;
		}

		/// <summary>
		/// Efficiently inserts multiple rows into the DataSource.
		/// </summary>
		/// <param name="entities">TList of Entity objects to insert.</param>
		public virtual void BulkInsert(TList<Entity> entities)
		{
			BulkInsert(null, entities);
		}

		/// <summary>
		/// Efficiently inserts multiple rows into the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entities">TList of Entity objects to insert.</param>
		public abstract void BulkInsert(TransactionManager mgr, TList<Entity> entities);

		#endregion
		
		#region Update Methods

		/// <summary>
		/// Updates an existing row in the DataSource.
		/// </summary>
		/// <param name="entity">The Entity object to update.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public virtual bool Update(Entity entity)
		{
			return Update(null, entity);
		}

		/// <summary>
		/// Updates an existing row in the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to update.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public abstract bool Update(TransactionManager mgr, Entity entity);

		/// <summary>
		/// Updates existing rows in the DataSource.
		/// </summary>
		/// <param name="entities">TList of Entity objects to update.</param>
		/// <returns>Returns the number of rows successfully updated.</returns>
		public virtual int Update(TList<Entity> entities)
		{
			return Update(null, entities);
		}

		/// <summary>
		/// Updates existing rows in the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entities">TList of Entity objects to update.</param>
		/// <returns>Returns the number of rows successfully updated.</returns>
		public virtual int Update(TransactionManager mgr, TList<Entity> entities)
		{
			int count = 0;

			foreach ( Entity entity in entities )
			{
				if ( entity.EntityState == EntityState.Changed )
				{
					if ( Update(mgr, entity) )
					{
						count++;
					}
				}
			}

			return count;
		}

		#endregion

		#region Delete Methods

		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="entity">The Entity object to delete.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public virtual bool Delete(Entity entity)
		{
			return Delete(null, entity);
		}

		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entity">The Entity object to delete.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public virtual bool Delete(TransactionManager mgr, Entity entity)
		{
			return Delete(mgr, entity.EntityId);
		}

		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public virtual bool Delete(EntityKey key)
		{
			return Delete(null, key);
		}

		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if the operation is successful.</returns>
		public abstract bool Delete(TransactionManager mgr, EntityKey key);

		/// <summary>
		/// Deletes rows from the DataSource.
		/// </summary>
		/// <param name="entities">TList of Entity objects to delete.</param>
		/// <returns>Returns the number of rows successfully deleted.</returns>
		public virtual int Delete(TList<Entity> entities)
		{
			return Delete(null, entities);
		}

		/// <summary>
		/// Deletes rows from the DataSource.
		/// </summary>
		/// <param name="mgr">A <see cref="TransactionManager"/> object.</param>
		/// <param name="entities">TList of Entity objects to delete.</param>
		/// <returns>Returns the number of rows successfully deleted.</returns>
		public virtual int Delete(TransactionManager mgr, TList<Entity> entities)
		{
			int count = 0;

			foreach ( Entity entity in entities )
			{
				if ( Delete(mgr, entity) )
				{
					count++;
				}
			}

			return count;
		}

		#endregion

		#region Helper Methods
		
		///<summary>
		/// Enforces the rules set in order to load this property for a given type.
		///</summary>
		/// <param name="entity">The entity.</param>
        /// <param name="key">The key.</param>
        /// <param name="deepLoadType">Type of the deep load.</param>
        /// <param name="innerList">The inner list.</param>
		protected bool CanDeepLoad(IEntity entity, String key, DeepLoadType deepLoadType, DeepSession innerList) 
        {
			if ( innerList != null && !innerList.CancelSession)
			{
                if ( deepLoadType == DeepLoadType.ExcludeChildren )
				{
                	if (!innerList.ContainsTypeExcluded(key) && !innerList.HasRun(entity, key))
                    {
                        //add to list prior to firing event
                        innerList.AddRun(entity, key);

                        //call deep loading event
                        DeepSessionEventArgs args = GetDeepSessionArgs(innerList, deepLoadType, entity, key);
                        OnDeepLoading(args);

                        if (args.Skip)
                            return false;

                        if (args.Cancel)
                        {
                            innerList.CancelSession = true;
                            return false;
                        }

                        return true;
                    }
				}
				else if ( deepLoadType == DeepLoadType.IncludeChildren )
				{
                    if (innerList.ContainsType(key) && !innerList.HasRun(entity, key))
                    {
                        //add to list prior to firing event
                        innerList.AddRun(entity, key);

                        //call deep loading event
                        DeepSessionEventArgs args = GetDeepSessionArgs(innerList, deepLoadType, entity, key);
                        OnDeepLoading(args);

                        if (args.Skip)
                            return false;

                        if (args.Cancel)
                        {
                            innerList.CancelSession = true;
                            return false;
                        }

                        return true;
                    }
				}
			}
		
			return false;
        }
		
        /// <summary>
        /// Enforces the rules set in order to save this property for a given type.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="key">The key.</param>
        /// <param name="deepSaveType">Type of the deep save.</param>
        /// <param name="innerList">The inner list.</param>
        /// <returns>
        /// <c>true</c> if this instance [can deep save] the specified entity; otherwise, <c>false</c>.
        /// </returns>
		protected bool CanDeepSave(Object entity, string key, DeepSaveType deepSaveType, DeepSession innerList) 
        {
			if ( innerList != null && !innerList.CancelSession)
			{
				if ( deepSaveType == DeepSaveType.ExcludeChildren )
				{
					if ( !innerList.ContainsType(key) && !innerList.HasRun(entity, key) )
					{
						//Add to list prior to firing
						innerList.AddRun( entity, key);
						
						//call deep saving event
						DeepSessionEventArgs args = GetDeepSessionArgs( innerList, deepSaveType,  entity, key );
						OnDeepSaving( args );
						
						if ( args.Skip )
							return false;
						
						if ( args.Cancel )
						{
							innerList.CancelSession = true;
							return false;
						}
						
						return true;
					}
				}
				else if ( deepSaveType == DeepSaveType.IncludeChildren )
				{
                    if (innerList.ContainsType(key) && !innerList.HasRun(entity, key))
					{
						//Add to list prior to firing
						innerList.AddRun( entity , key);
						
						//call deep saving event
						DeepSessionEventArgs args = GetDeepSessionArgs(innerList, deepSaveType, entity, key);
						OnDeepSaving( args );
						
						if ( args.Skip )
							return false;
						
						if ( args.Cancel )
						{
							innerList.CancelSession = true;
							return false;
						}
						
						return true;
					}
				}
			}

			return false;
        }
		
		/// <summary>
        /// Gets the DeepSession Arguments for an event.
        /// </summary>
        /// <param name="deepSession">the current DeepSession.</param>
		/// <param name="deepTypeValue"> The Deep Type Value</param>
        /// <param name="obj">The current entity or list.</param>
		/// <param name="key">The key.</param>
        /// <returns>
        /// 	<c>DeepSessionEventArgs</c> if the item being run is a valid entity or list.
        /// </returns>
        protected DeepSessionEventArgs GetDeepSessionArgs(DeepSession deepSession, Enum deepTypeValue, object obj, string key)
		{			
			DeepSessionEventArgs args = null;
			
			if (obj is IEntity)
				args = new DeepSessionEventArgs(deepSession, key, deepTypeValue, (IEntity)obj);
			else if (obj is IList)
				args = new DeepSessionEventArgs(deepSession, key, deepTypeValue, (IList)obj);
			else 
				args = new DeepSessionEventArgs();
				
			return args;
		}
		#endregion Helper Methods
		
        #region DataRequesting event definition code
        /// <summary>
        ///     This represents the delegate method prototype that
        ///     event receivers must implement
        /// </summary>
        public delegate void DataRequestingEventHandler(object sender, CommandEventArgs e);

        /// <summary>
        ///     An event which occurs just before a data 
        ///     request is made in the data provider.
        /// </summary>
        public event DataRequestingEventHandler DataRequesting;

        /// <summary>
        ///     This is the method that is responsible for notifying
        ///     receivers that the event occurred just before accessing the 
        ///     data provider.
        /// </summary>
        protected virtual void OnDataRequesting(CommandEventArgs e)
        {
            if (DataRequesting != null)
            {
                DataRequesting(this, e);
            }
        }


        #endregion //('DataRequesting' event definition code)

        #region DataRequested event definition code
        /// <summary>
        ///     This represents the delegate method prototype that
        ///     event receivers must implement 
        /// </summary>
        public delegate void DataRequestedEventHandler(object sender, CommandEventArgs e);
        
        /// <summary>
        ///     An event which occurs just before a data 
        ///     request is made in the data provider.
        /// </summary>
        public event DataRequestedEventHandler DataRequested;

        /// <summary>
        ///     This is the method that is responsible for notifying
        ///     receivers that the event occurred just after accessing the 
        ///     data provider.
        /// </summary>
        protected virtual void OnDataRequested(CommandEventArgs e)
        {
            if (DataRequested != null)
            {
                DataRequested(this, e);
            }
        }
        #endregion //('DataRequested' event definition code)
		
		#region DeepLoading event definition code
        /// <summary>
        ///     This represents the delegate method prototype that
        ///     event receivers must implement 
        /// </summary>
        public delegate void DeepLoadingEventHandler(object sender, DeepSessionEventArgs e);
        
        /// <summary>
        ///     An event which occurs just before a data 
        ///     request is made in the data provider.
        /// </summary>
        public event DeepLoadingEventHandler DeepLoading;

        /// <summary>
        ///     This is the method that is responsible for notifying
        ///     receivers that the event occurred just after accessing the 
        ///     data provider.
        /// </summary>
        protected virtual void OnDeepLoading(DeepSessionEventArgs e)
        {
            if (DeepLoading != null)
            {
                DeepLoading(this, e);
            }
        }
        #endregion //('DeepLoading' event definition code)
		
		#region DeepSaving event definition code
        /// <summary>
        ///     This represents the delegate method prototype that
        ///     event receivers must implement 
        /// </summary>
        public delegate void DeepSavingEventHandler(object sender, DeepSessionEventArgs e);
        
        /// <summary>
        ///     An event which occurs just before a data 
        ///     request is made in the data provider.
        /// </summary>
        public event DeepSavingEventHandler DeepSaving;

        /// <summary>
        ///     This is the method that is responsible for notifying
        ///     receivers that the event occurred just after accessing the 
        ///     data provider.
        /// </summary>
        protected virtual void OnDeepSaving(DeepSessionEventArgs e)
        {
            if (DeepSaving != null)
            {
                DeepSaving(this, e);
            }
        }
        #endregion //('DeepSaving' event definition code)
	}

	#region DeepSessionEventArgs
	/// <summary>
    /// Event Args used to transfer crucial information just before 
    /// and after a command is used in the data provider.
    /// </summary>
    public class DeepSessionEventArgs
    {
        #region Fields
        private IList currentEntityList = null;
        private IEntity currentEntity = null;
        private bool cancel;
		private bool skip;
		private string currentTypePropertyKey = null;
		private DeepSession deepSession = null;
		private Enum deepTypeValue;
        #endregion 

        #region Ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DeepSessionEventArgs"/> class.
        /// </summary>
        public DeepSessionEventArgs() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DeepSessionEventArgs"/> class.
        /// </summary>
        /// <param name="deepSession">The Current Deep Session.</param>
		/// <param name="currentTypePropertyKey">The Current Key"</param>
		/// <param name="deepTypeValue">The current Deep Type Value, DeepSaveType/DeepLoadType </param>
        /// <param name="entity">The entity.</param>
        /// <param name="list">The list.</param>
        public DeepSessionEventArgs(DeepSession deepSession, string currentTypePropertyKey, Enum deepTypeValue, IEntity entity, IList list)
        {
            this.DeepSession = deepSession;
            this.CurrentTypePropertyKey = currentTypePropertyKey;
		    this.CurrentEntity = entity;
            this.CurrentEntityList = list;	
			this.DeepTypeValue = deepTypeValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="deepSession">The deepSession.</param>
		/// <param name="currentTypePropertyKey">The Current Key"</param>
		/// <param name="deepTypeValue">The current Deep Type Value, DeepSaveType/DeepLoadType </param>
		/// <param name="list">The list.</param>
        public DeepSessionEventArgs(DeepSession deepSession, string currentTypePropertyKey, Enum deepTypeValue, IList list) : this(deepSession, currentTypePropertyKey, deepTypeValue, null, list)
        { }
		
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="deepSession">The deepSession.</param>
		/// <param name="currentTypePropertyKey">The Current Key.</param>
		/// <param name="deepTypeValue">The current Deep Type Value, DeepSaveType/DeepLoadType </param>
        /// <param name="entity">The current entity.</param>
        public DeepSessionEventArgs(DeepSession deepSession, string currentTypePropertyKey, Enum deepTypeValue, IEntity entity) : this(deepSession, currentTypePropertyKey, deepTypeValue, entity, null)
        { }
        #endregion 

        #region Properties
        /// <summary>
        /// Gets or sets the current DeepSession.
        /// </summary>
        /// <value>The DeepSession.</value>
        public DeepSession DeepSession
        {
            get { return deepSession; }
            set { deepSession = value; }
        }

        /// <summary>
        /// Gets or sets the current entity which the action is 
        /// being acted on.  If there is no entity, this 
        /// value will be null.
        /// </summary>
        /// <value>The entity.</value>
        public IEntity CurrentEntity
        {
            get { return currentEntity; }
            set { currentEntity = value; }
        }

        /// <summary>
        /// Gets or sets the current .
        /// </summary>
        /// <value>The return value.</value>
        public IList CurrentEntityList
        {
            get {   return currentEntityList; }
            set {   currentEntityList = value; }
        }
		
		/// <summary>
        /// Gets or Sets the name of the current type property key that 
		/// will be used to determine if the property will be run in the deep session.
        /// </summary>
        /// <value>A string value of the type property key.</value>
		public string CurrentTypePropertyKey
		{
			get  {  return 	currentTypePropertyKey;  }
			set  {  currentTypePropertyKey = value;  }
		}
		
		
		///<summary>
		/// The current DeepType Value, Either <c>DeepLoadType</c>, or <c>DeepSaveType</c>.
		///</summary>
		public Enum DeepTypeValue
		{
			get  {  return 	deepTypeValue;  }
			set  {  deepTypeValue = value;  }
		}
		
		/// <summary>
        /// Gets or sets the Cancel property of the event.
        /// </summary>
        /// <value>Current Cancel Value.</value>
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }
		
		/// <summary>
        /// Gets or sets the current Skip value.  
		/// Setting this property will skip the current Deep Property.
        /// </summary>
        /// <value>The name of the method.</value>
        public bool Skip
        {
            get { return skip; }
            set { skip = value; }
        }
        #endregion 
    }
	#endregion 

    #region CommandEventArgs
    /// <summary>
    /// Event Args used to transfer crucial information just before 
    /// and after a command is used in the data provider.
    /// </summary>
    public class CommandEventArgs
    {
        #region Fields
        private IList currentEntityList = null;
        private IEntity currentEntity = null;
        private System.Data.Common.DbCommand command;
        private string methodName = null;
        #endregion 

        #region Ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        public CommandEventArgs() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="list">The list.</param>
        public CommandEventArgs(System.Data.Common.DbCommand command, string methodName, IEntity entity, IList list)
        {
            this.Command = command;
            this.MethodName = methodName;
            this.CurrentEntity = entity;
            this.CurrentEntityList = list;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="list">The list.</param>
        public CommandEventArgs(System.Data.Common.DbCommand command, string methodName, IList list) : this(command, methodName, null, list)
        { }
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="methodName">Name of the method.</param>
        public CommandEventArgs(System.Data.Common.DbCommand command, string methodName) : this(command, methodName, null, null)
        { }
		
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CommandEventArgs"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="entity">The current entity.</param>
        public CommandEventArgs(System.Data.Common.DbCommand command, string methodName, IEntity entity) : this(command, methodName, entity, null)
        { }
        #endregion 

        #region Properties
        /// <summary>
        /// Gets or sets the current command.
        /// </summary>
        /// <value>The command.</value>
        public System.Data.Common.DbCommand Command
        {
            get { return command; }
            set { command = value; }
        }

        /// <summary>
        /// Gets or sets the name of the method.
        /// </summary>
        /// <value>The name of the method.</value>
        public string MethodName
        {
            get { return methodName; }
            set { methodName = value; }
        }

        /// <summary>
        /// Gets or sets the current entity which the action is 
        /// being acted on.  If there is no entity, this 
        /// value will be null.
        /// </summary>
        /// <value>The entity.</value>
        public IEntity CurrentEntity
        {
            get { return currentEntity; }
            set { currentEntity = value; }
        }

        /// <summary>
        /// Gets or sets the current .
        /// </summary>
        /// <value>The return value.</value>
        public IList CurrentEntityList
        {
            get {   return currentEntityList; }
            set {   currentEntityList = value; }
        }
        #endregion 
    }
    #endregion 
		
	#region DeepSession
	
	/// <summary>
	/// Keeps a weak reference of the entire deep transaction for tracking purposes.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class DeepSession : List<String>, IDisposable
    {
        private WeakRefDictionary<string, object> deepSessionInnerList;
		private bool cancelSession;
		private bool skipChildren;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DeepSession"/> class.
        /// </summary>
        public DeepSession()
        { 
        }

        #region Methods
		/// <summary>
		/// Gets the set of current loaded objects.
		/// </summary>
		/// <returns>a list of already run objects</returns>
		public IList<object> GetSessionObjects()
		{
			List<object> list = new List<object>();

            foreach (KeyValuePair<string, object> pair in DeepSessionInnerList)
			{
				if (pair.Value != null)
					list.Add(pair.Value);
			}
			return list;
		}

	    /// <summary>
        /// Adds the specified entity property to the collection of properties.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="key"></param>
        public void AddRun( Object entity, string key )
        {
            if (entity != null && !string.IsNullOrEmpty(key))
            {
                string lkey;
                if (entity is IEntity)
                    lkey = ((IEntity)entity).EntityTrackingKey + key;
                else 
                    lkey = entity.GetHashCode().ToString()+ key;

                DeepSessionInnerList.Add(lkey, entity);
            }
			
			if (DeepSessionInnerList.Count > 300)
				CancelSession = true;
        }

        /// <summary>
        /// Determines whether the specified obj has run for a specified property type.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// 	<c>true</c> if the specified obj has run; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsType(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("key"); 

            string lkey = key.Split('|')[0];
		   if (SkipChildren && lkey.StartsWith("List<"))
				return false;
           
		   return this.Exists(delegate(string s)
           {
                return s.Split('|')[0] == lkey;
           });
        }
	    
		/// <summary>
        /// Determines whether the specified obj has run for a specified property type.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// 	<c>true</c> if the specified obj has run; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsTypeExcluded(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("key"); 

           string lkey = key.Split('|')[0];
		   if (SkipChildren && lkey.StartsWith("List<"))
				return true;
           
           return this.Exists(delegate(string s)
           {
                return s.Split('|')[0] == lkey;
           });
        }
	    
		/// <summary>
		/// Determines whether the specified obj has run.
		/// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="key">The key.</param>
		/// <returns>
		/// 	<c>true</c> if the specified obj has run; otherwise, <c>false</c>.
		/// </returns>
		public bool HasRun( object entity , string key)
		{
			if (entity == null) return false;

            string lkey;
            if (entity is IEntity)
                lkey = ((IEntity)entity).EntityTrackingKey + key;
            else 
                lkey = entity.GetHashCode().ToString()+ key;
				
            if (DeepSessionInnerList.ContainsKey(lkey))
                return true;
			    
			return false;
		}
		
		/// <summary>
        /// Get's the reference of the object that has run
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="key">The key.</param>
        /// <returns>
        /// 	object of the run reference
        /// </returns>
        public object GetReference(object entity, string key)
        {
            if (entity == null) return false;

            string lkey = ((IEntity)entity).EntityTrackingKey + key;
            if (DeepSessionInnerList.ContainsKey(lkey))
            {
                object locateEntity = null;
                if (DeepSessionInnerList.TryGet(lkey, out locateEntity))
                {
                    return locateEntity;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the Deep Session nner list.
        /// </summary>
        /// <value>The inner list.</value>
        public WeakRefDictionary<string, object> DeepSessionInnerList
		{
			get 
			{
				if (deepSessionInnerList == null)
				{
                    deepSessionInnerList = new WeakRefDictionary<string, object>();
				}
                return deepSessionInnerList; 
			}
		}
		
		///<summary>
	    ///If set to true, any further requests for this deep session will be canceled.
	    ///</summary>
		public bool CancelSession
		{
			get{  return cancelSession;	 }
			set{  cancelSession = value; }
		}

	    ///<summary>
        ///If set to true, any further requests for this deep session requesting to Load a child collection will be skipped.
        ///</summary>
        public bool SkipChildren
        {
            get { return skipChildren; }
            set { skipChildren = value; }
        }
		
	    ///<summary>
	    ///Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	    ///</summary>
	    ///<filterpriority>2</filterpriority>
	    public void Dispose()
	    {
            if (deepSessionInnerList != null) 
			{
                //deepSessionInnerList.Clear();
                deepSessionInnerList = null;
			}
	    }
		#endregion Methods
    }
	
	
	#endregion DeepSession
	
	#region Deep Load/Save Handle Delegates
	    /// <summary>
		/// Handler for the deep save
		/// </summary>
		public delegate bool DeepSaveHandle<Entity>(
            TransactionManager transactionManager,  
            TList<Entity> entityList, 
            DeepSaveType saveType, 
            Type[] childTypes, 
            DeepSession list) 
        where Entity : IEntity, new();

		/// <summary>
		/// Handler for the single deep save
		/// </summary>
	    public delegate bool DeepSaveSingleHandle<Entity>(
            TransactionManager transactionManager,  
            Entity entity, 
            DeepSaveType saveType, 
            Type[] childTypes, 
            DeepSession list) 
        where Entity : IEntity, new();
		
		/// <summary>
		/// Handler for the deep load
		/// </summary>
    	public delegate void DeepLoadHandle<Entity>(
			TransactionManager transactionManager,
			TList<Entity> entityList,
			bool goDeep,
			DeepLoadType deepLoadType,
			Type[] childTypes,
			DeepSession list)
		where Entity : IEntity, new();
		
		/// <summary>
		/// Handler for the single deep load
		/// </summary>
		public delegate void DeepLoadSingleHandle<Entity>(
			TransactionManager transactionManager,
			Entity entity,
			bool goDeep,
			DeepLoadType deepLoadType,
			Type[] childTypes,
			DeepSession list)
		where Entity : IEntity, new();
	#endregion 

	#region ChildEntityTypeAttribute
	
	///<summary>
	/// Attribute used to decorate enumerations with underlying system type.
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	public class ChildEntityTypeAttribute : System.Attribute
	{
		///<summary>
		/// Marks the underlying type of a child entity property.
		/// </summary>
		/// <param name="entityType">Type of the property to load.</param>
		public ChildEntityTypeAttribute(Type entityType)
		{
			this.entityType = entityType;
		}
		
		private readonly Type entityType;
		
		/// <summary>
		/// The underlying type for the ChildEntityTypes enumerations.
		/// </summary>
		public Type EntityType
		{
			get	{ return entityType; }
		}

		/// <summary>
		/// Gets the underlying system type for the specified enumeration value.
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public static Type GetType(Enum e)
		{
			ChildEntityTypeAttribute attribute = EntityHelper.GetAttribute<ChildEntityTypeAttribute>(e);
			Type propertyType = null;
			
			if ( attribute != null )
			{
				propertyType = attribute.EntityType;
			}

			return propertyType;
		}
	}
	
	#endregion ChildEntityTypeAttribute

	#region ChildEntityProperty<ChildEntityTypeEnum>

	/// <summary>
	/// Provides a common property used to access the child entity type enumeration value.
	/// </summary>
	public interface IChildEntityProperty
	{
		/// <summary>
		/// Gets the value of the ChildEntityType property.
		/// </summary>
		Enum ChildEntityType { get; }
	}
	
	/// <summary>
	/// A generic wrapper for the generated ChildEntityTypes enumerations.
	/// </summary>
	/// <typeparam name="ChildEntityTypesEnum"></typeparam>
	public class ChildEntityProperty<ChildEntityTypesEnum> : IChildEntityProperty
	{
		/// <summary>
		/// The Name member variable.
		/// </summary>
		private ChildEntityTypesEnum name;

		/// <summary>
		/// Gets or sets the Name property.
		/// </summary>
		public ChildEntityTypesEnum Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets the value of the ChildEntityType property.
		/// </summary>
		public Enum ChildEntityType
		{
			get { return Name as Enum; }
		}
	}

	#endregion ChildEntityProperty<ChildEntityTypeEnum>
}
