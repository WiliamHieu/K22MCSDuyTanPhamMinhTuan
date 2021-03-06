#pragma warning disable 1591
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;

namespace ESMEDICAL.Data
{
    /// <summary>
    /// The <see cref="System.Data.Linq.DataContext"/> class for the ESMEDICAL database.
    /// </summary>
    public partial class EsMedicalDbContext
        : CodeSmith.Data.Linq.DataContextBase, System.Data.Services.IUpdatable
    {
        public static readonly System.Data.Linq.Mapping.MappingSource MappingCache = new System.Data.Linq.Mapping.AttributeMappingSource();

        #region ConnectionString
        
        private const string CONNECTION_NAME = "EsmedicalConnectionString";
        
        private static volatile string _connectionString;
        
        private static object _connectionLock = new Object();

        /// <summary>The application connection string read from web.config or app.config</summary>
        /// <example>
        /// Add the following key to the "connectionStrings" section of your config:
        /// <code><![CDATA[
        /// <configuration>
        ///     <connectionStrings>
        ///         <add name="EsmedicalConnectionString"
        ///             connectionString="Data Source=(local);Initial Catalog=DATABASE;Integrated Security=True"
        ///             providerName="System.Data.SqlClient" />
        ///     </connectionStrings>
        /// </configuration>
        /// ]]></code>
        /// </example>
        
        public static string ConnectionString
        {
            get
            {
                if (_connectionString == null)
                {
                    lock (_connectionLock)
                    {
                        if (_connectionString == null)
                            _connectionString = GetDefaultConnectionString();
                    }
                }
                return _connectionString;
            }
        }

        private static string GetDefaultConnectionString()
        {
            var settings = System.Configuration.ConfigurationManager.ConnectionStrings[CONNECTION_NAME];
            if (settings == null)
            {
                string message = string.Format("Could not find the connection string '{0}' in the configuration file.  " +
                       "Please add an entry to connectionStrings section named '{0}'.", CONNECTION_NAME);
                throw new System.Configuration.ConfigurationErrorsException(message);
            }
            return settings.ConnectionString;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="EsMedicalDbContext"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public EsMedicalDbContext()
            : base(ConnectionString, MappingCache)
        {
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsMedicalDbContext"/> class.
        /// </summary>
        /// <param name="connection">The connection string.</param>
        [System.Diagnostics.DebuggerNonUserCode]
        public EsMedicalDbContext(string connection)
            : base(connection, MappingCache)
        {
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsMedicalDbContext"/> class.
        /// </summary>
        /// <param name="connection">The database connection.</param>
        [System.Diagnostics.DebuggerNonUserCode]
        public EsMedicalDbContext(System.Data.IDbConnection connection)
            : base(connection, MappingCache)
        {
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsMedicalDbContext"/> class.
        /// </summary>
        /// <param name="connection">The connection string.</param>
        /// <param name="mappingSource">The mapping source.</param>
        [System.Diagnostics.DebuggerNonUserCode]
        public EsMedicalDbContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EsMedicalDbContext"/> class.
        /// </summary>
        /// <param name="connection">The database connection.</param>
        /// <param name="mappingSource">The mapping source.</param>
        [System.Diagnostics.DebuggerNonUserCode]
        public EsMedicalDbContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }
        #endregion

        #region Tables
        /// <summary>Represents the dbo.Diabetes table in the underlying database.</summary>
        public System.Data.Linq.Table<ESMEDICAL.Data.Diabetes> Diabetes
        {
            get { return GetTable<ESMEDICAL.Data.Diabetes>(); }
        }

        /// <summary>Represents the dbo.DiabetesRules table in the underlying database.</summary>
        public System.Data.Linq.Table<ESMEDICAL.Data.DiabetesRules> DiabetesRules
        {
            get { return GetTable<ESMEDICAL.Data.DiabetesRules>(); }
        }

        /// <summary>Represents the dbo.Users table in the underlying database.</summary>
        public System.Data.Linq.Table<ESMEDICAL.Data.Users> Users
        {
            get { return GetTable<ESMEDICAL.Data.Users>(); }
        }

        #endregion

        #region Functions
        /// <summary>Method that is mapped to the dbo.Custom_Diabetes_Get_List database procedure.</summary>
        /// <returns></returns>
        [System.Data.Linq.Mapping.Function(Name = "dbo.Custom_Diabetes_Get_List")]
        public System.Data.Linq.ISingleResult<ESMEDICAL.Data.CustomDiabetesGetListResult> CustomDiabetesGetList(
            [System.Data.Linq.Mapping.Parameter(Name = "@FromDate", DbType = "datetime")] System.DateTime? fromDate,
            [System.Data.Linq.Mapping.Parameter(Name = "@ToDate", DbType = "datetime")] System.DateTime? toDate,
            [System.Data.Linq.Mapping.Parameter(Name = "@Gender", DbType = "varchar(6)")] string gender,
            [System.Data.Linq.Mapping.Parameter(Name = "@PageIndex", DbType = "int")] int? pageIndex,
            [System.Data.Linq.Mapping.Parameter(Name = "@PageSize", DbType = "int")] int? pageSize)
        {
            var methodInfo = (System.Reflection.MethodInfo)System.Reflection.MethodInfo.GetCurrentMethod();
            var result = this.ExecuteMethodCall(this, methodInfo, fromDate, toDate, gender, pageIndex, pageSize);

            return ((System.Data.Linq.ISingleResult<ESMEDICAL.Data.CustomDiabetesGetListResult>)(result.ReturnValue));
        }

        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called after this instance is created.</summary>
        partial void OnCreated();

        /// <summary>Called before a <see cref="Diabetes"/> is inserted.</summary>
        /// <param name="instance">The instance.</param>
        partial void InsertDiabetes(ESMEDICAL.Data.Diabetes instance);

        /// <summary>Called before a <see cref="Diabetes"/> is updated.</summary>
        /// <param name="instance">The instance.</param>
        partial void UpdateDiabetes(ESMEDICAL.Data.Diabetes instance);

        /// <summary>Called before a <see cref="Diabetes"/> is deleted.</summary>
        /// <param name="instance">The instance.</param>
        partial void DeleteDiabetes(ESMEDICAL.Data.Diabetes instance);

        /// <summary>Called before a <see cref="DiabetesRules"/> is inserted.</summary>
        /// <param name="instance">The instance.</param>
        partial void InsertDiabetesRules(ESMEDICAL.Data.DiabetesRules instance);

        /// <summary>Called before a <see cref="DiabetesRules"/> is updated.</summary>
        /// <param name="instance">The instance.</param>
        partial void UpdateDiabetesRules(ESMEDICAL.Data.DiabetesRules instance);

        /// <summary>Called before a <see cref="DiabetesRules"/> is deleted.</summary>
        /// <param name="instance">The instance.</param>
        partial void DeleteDiabetesRules(ESMEDICAL.Data.DiabetesRules instance);

        /// <summary>Called before a <see cref="Users"/> is inserted.</summary>
        /// <param name="instance">The instance.</param>
        partial void InsertUsers(ESMEDICAL.Data.Users instance);

        /// <summary>Called before a <see cref="Users"/> is updated.</summary>
        /// <param name="instance">The instance.</param>
        partial void UpdateUsers(ESMEDICAL.Data.Users instance);

        /// <summary>Called before a <see cref="Users"/> is deleted.</summary>
        /// <param name="instance">The instance.</param>
        partial void DeleteUsers(ESMEDICAL.Data.Users instance);
        #endregion

        #region IUpdatable Members
        /// <summary>
        /// Adds the specified value to the collection.
        /// </summary>
        /// <param name="targetResource">Target object that defines the property.</param>
        /// <param name="propertyName">The name of the collection property to which the resource should be added..</param>
        /// <param name="resourceToBeAdded">The opaque object representing the resource to be added.</param>
        void System.Data.Services.IUpdatable.AddReferenceToCollection(object targetResource, string propertyName, object resourceToBeAdded)
        {
            var t = targetResource.GetType();

            var collectionProperty = GetPropertyInfoForType(t, propertyName, false);
            var collection = collectionProperty.GetValue(targetResource, null) as System.Collections.IList;
            if (collection == null)
                return; // throw error

            collection.Add(resourceToBeAdded);
        }

        /// <summary>
        /// Cancels a change to the data.
        /// </summary>
        void System.Data.Services.IUpdatable.ClearChanges()
        {
            var mi = GetType().GetMethod("ClearCache",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.InvokeMethod);

            if (mi != null)
                mi.Invoke(this, null);
        }

        /// <summary>
        /// Creates the resource of the specified type and that belongs to the specified container.
        /// </summary>
        /// <param name="containerName">The name of the entity set to which the resource belongs.</param>
        /// <param name="fullTypeName">The full namespace-qualified type name of the resource.</param>
        /// <returns>
        /// The object representing a resource of specified type and belonging to the specified container.
        /// </returns>
        object System.Data.Services.IUpdatable.CreateResource(string containerName, string fullTypeName)
        {
            var t = Type.GetType(fullTypeName);
            var table = GetTableForType(t);

            object value = Construct(t);
            table.InsertOnSubmit(value);

            return (value);
        }

        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="targetResource">The resource to be deleted.</param>
        void System.Data.Services.IUpdatable.DeleteResource(object targetResource)
        {
            var t = targetResource.GetType();
            var table = GetTableForType(t);
            table.DeleteOnSubmit(targetResource);
        }

        /// <summary>
        /// Gets the resource of the specified type identified by a query and type name.
        /// </summary>
        /// <param name="query">Language integratee query(LINQ) pointing to a particular resource.</param>
        /// <param name="fullTypeName">The fully qualified type name of resource.</param>
        /// <returns>
        /// An opaque object representing a resource of the specified type, referenced by the specified query.
        /// </returns>
        object System.Data.Services.IUpdatable.GetResource(System.Linq.IQueryable query, string fullTypeName)
        {
            object result = null;

            foreach (object item in query)
            {
                if (result != null)
                    throw new System.Data.Services.DataServiceException("A single resource is expected");
                result = item;
            }

            if (result == null)
                throw new System.Data.Services.DataServiceException(404, "Resource not found");

            if (fullTypeName != null && result.GetType().FullName != fullTypeName)
                throw new System.Data.Services.DataServiceException("Resource type mismatch");

            return result;
        }

        /// <summary>
        /// Gets the value of the specified property on the target object.
        /// </summary>
        /// <param name="targetResource">An opaque object that represents a resource.</param>
        /// <param name="propertyName">The name of the property whose value needs to be retrieved.</param>
        /// <returns></returns>
        object System.Data.Services.IUpdatable.GetValue(object targetResource, string propertyName)
        {
            var t = targetResource.GetType();
            var pi = GetPropertyInfoForType(t, propertyName, false);

            object value;

            try
            {
                value = pi.GetValue(targetResource, null);
            }
            catch (Exception ex)
            {
                throw new System.Data.Services.DataServiceException(
                    string.Format("Failed getting property {0} value", propertyName), ex);
            }
            return value;
        }

        /// <summary>
        /// Removes the specified value from the collection.
        /// </summary>
        /// <param name="targetResource">The target object that defines the property.</param>
        /// <param name="propertyName">The name of the property whose value needs to be updated.</param>
        /// <param name="resourceToBeRemoved">The property value that needs to be removed.</param>
        void System.Data.Services.IUpdatable.RemoveReferenceFromCollection(object targetResource, string propertyName, object resourceToBeRemoved)
        {
            var t = targetResource.GetType();

            var collectionProperty = GetPropertyInfoForType(t, propertyName, false);
            var collection = collectionProperty.GetValue(targetResource, null) as System.Collections.IList;
            if (collection == null)
                return; // throw error

            collection.Remove(resourceToBeRemoved);
        }

        /// <summary>
        /// Returns the instance of the resource represented by the specified resource object.
        /// </summary>
        /// <param name="resource">The object representing the resource whose instance needs to be retrieved.</param>
        /// <returns>
        /// Returns the instance of the resource represented by the specified resource object.
        /// </returns>
        object System.Data.Services.IUpdatable.ResolveResource(object resource)
        {
            return resource;
        }

        /// <summary>
        /// Saves all the changes that have been made by using the <see cref="T:System.Data.Services.IUpdatable"/> APIs.
        /// </summary>
        void System.Data.Services.IUpdatable.SaveChanges()
        {
            try
            {
                SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new System.Data.Services.DataServiceException("Error Saving Context. " + ex.GetBaseException().Message, ex);
            }
        }

        /// <summary>
        /// Sets the value of the specified reference property on the target object.
        /// </summary>
        /// <param name="targetResource">The target object that defines the property.</param>
        /// <param name="propertyName">The name of the property whose value needs to be updated.</param>
        /// <param name="propertyValue">The property value to be updated.</param>
        void System.Data.Services.IUpdatable.SetReference(object targetResource, string propertyName, object propertyValue)
        {
            ((System.Data.Services.IUpdatable)this).SetValue(targetResource, propertyName, propertyValue);
        }

        /// <summary>
        /// Sets the value of the property with the specified name on the target resource to the specified property value.
        /// </summary>
        /// <param name="targetResource">The target object that defines the property.</param>
        /// <param name="propertyName">The name of the property whose value needs to be updated.</param>
        /// <param name="propertyValue">The property value for update.</param>
        void System.Data.Services.IUpdatable.SetValue(object targetResource, string propertyName, object propertyValue)
        {
            var t = targetResource.GetType();
            var pi = GetPropertyInfoForType(t, propertyName, true);

            try
            {
                pi.SetValue(targetResource, propertyValue, null);
            }
            catch (Exception ex)
            {
                throw new System.Data.Services.DataServiceException(
                  string.Format("Error setting property {0} to {1}", propertyName, propertyValue), ex);
            }
        }

        /// <summary>
        /// Updates the resource identified by the parameter <paramref name="resource"/>.
        /// </summary>
        /// <param name="resource">The resource to be updated.</param>
        /// <returns></returns>
        object System.Data.Services.IUpdatable.ResetResource(object resource)
        {
            var t = resource.GetType();
            var table = GetTableForType(t);
            return table.GetOriginalEntityState(resource);
        }

        private System.Reflection.PropertyInfo GetPropertyInfoForType(Type t, string propertyName, bool setter)
        {
            System.Reflection.PropertyInfo pi;

            try
            {
                System.Reflection.BindingFlags flags = System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance;
                flags |= setter ? System.Reflection.BindingFlags.SetProperty : System.Reflection.BindingFlags.GetProperty;

                pi = t.GetProperty(propertyName, flags);

                if (pi == null)
                    throw new System.Data.Services.DataServiceException(
                        string.Format("Failed to find property {0} on type {1}", propertyName, t.Name));
            }
            catch (Exception exception)
            {
                throw new System.Data.Services.DataServiceException(
                    string.Format("Error finding property {0}", propertyName), exception);
            }

            return (pi);
        }

        private System.Data.Linq.ITable GetTableForType(Type t)
        {
            var table = GetTable(t);
            if (table == null)
                throw new System.Data.Services.DataServiceException(string.Format("No table found for type {0}", t.Name));

            return (table);
        }

        private static object Construct(Type t)
        {
            var ci = t.GetConstructor(Type.EmptyTypes);

            if (ci == null)
                throw new System.Data.Services.DataServiceException(
                    string.Format("No default ctor found for type {0}", t.Name));

            return (ci.Invoke(null));
        }
        #endregion

        #region RuleManager
        private readonly CodeSmith.Data.Rules.RuleManager _ruleManager = new CodeSmith.Data.Rules.RuleManager();

        /// <summary>
        /// Gets the current <see cref="CodeSmith.Data.Rules.RuleManager"/> for the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        public CodeSmith.Data.Rules.RuleManager RuleManager
        {
            get { return _ruleManager; }
        }

        /// <summary>
        /// Sends changes made to retrieved objects to the underlying database.
        /// </summary>
        /// <param name="failureMode">How concurrency conflicts should be reported.</param>
        public override void SubmitChanges(System.Data.Linq.ConflictMode failureMode)
        {
            bool isValid = RuleManager.Run(this);

            if (!isValid)
                throw new CodeSmith.Data.Rules.BrokenRuleException(RuleManager.BrokenRules);

            PopulateLastAudit();
            BeforeSubmitChanges();
            base.SubmitChanges(failureMode);
            RefreshLastAudit();
            AfterSubmitChanges();
        }
        #endregion

        #region Auditing
        /// <summary>Called before the underlying DataContext.SubmitChanges is called.</summary>
        partial void BeforeSubmitChanges();

        /// <summary>Called after the underlying DataContext.SubmitChanges is called.</summary>
        partial void AfterSubmitChanges();

        private bool _auditingEnabled = true;

        /// <summary>
        /// Gets or sets a value indicating whether auditing is enabled.
        /// </summary>
        /// <value><c>true</c> if auditing is enabled; otherwise, <c>false</c>.</value>
        public bool AuditingEnabled
        {
            get { return _auditingEnabled; }
            set { _auditingEnabled = value; }
        }

        private CodeSmith.Data.Audit.AuditLog _lastAudit;

        /// <summary>
        /// Gets the last <see cref="CodeSmith.Data.Audit.AuditLog"/>.
        /// </summary>
        /// <value>The last <see cref="CodeSmith.Data.Audit.AuditLog"/>.</value>
        /// <remarks>
        /// <see cref="AuditingEnabled"/> must be <c>true</c> for <see cref="LastAudit"/> to be populated.
        /// </remarks>
        public CodeSmith.Data.Audit.AuditLog LastAudit
        {
            get { return _lastAudit; }
        }

        /// <summary>
        /// Populates the <see cref="LastAudit"/> property with the <see cref="CodeSmith.Data.Audit.AuditLog"/>
        /// of changes in this <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// <see cref="AuditingEnabled"/> must be <c>true</c> for <see cref="LastAudit"/> to be populated.
        /// </remarks>
        protected virtual void PopulateLastAudit()
        {
            if (!AuditingEnabled)
                return;

            _lastAudit = CodeSmith.Data.Audit.AuditManager.CreateAuditLog(this);
        }

        /// <summary>
        /// Refresh the <see cref="AuditLog"/> values stored in the <see cref="LastAudit"/> after SubmitChanges call.
        /// </summary>
        protected virtual void RefreshLastAudit()
        {
            if (_lastAudit != null) 
                CodeSmith.Data.Audit.AuditManager.Refresh(_lastAudit);
        }
        #endregion

        /// <summary>
        /// Sends changes made to retrieved objects to the underlying database.
        /// </summary>
        /// <param name="refreshMode">Defines how to handle optimistic concurrency conflicts.</param>
        public void SubmitChanges(System.Data.Linq.RefreshMode refreshMode)
        {
            try
            {
                SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
            }
            catch (System.Data.Linq.ChangeConflictException)
            {
                foreach (var occ in ChangeConflicts)
                    occ.Resolve(refreshMode);

                SubmitChanges();
            }
        }
    }
}
#pragma warning restore 1591
