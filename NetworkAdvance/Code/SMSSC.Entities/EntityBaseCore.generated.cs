﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file EntityBase.cs instead.
*/

#region Using Directives

using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
#endregion

namespace SMSSC.Entities
{
	/// <summary>The base object for each database table entity.</summary>
	[Serializable]
	public abstract partial class EntityBaseCore : IEntity, INotifyPropertyChanged, IDataErrorInfo, IDeserializationCallback, INotifyPropertyChanging
	{
		#region Constructors
		
		/// <summary>Initializes a new instance of the <see cref="T:EntityBaseCore"/> class.</summary>
		protected EntityBaseCore()
		{
		}
		
      	#endregion
		
	    /// <summary>Determines whether the entity is being tracked by the Locator.</summary>
		[NonSerialized]
		[Display(AutoGenerateField = false)]
		private bool isEntityTracked = false;

		/// <summary>Suppresses Entity Events from Firing, useful when loading the entities from the database.</summary>
	    [NonSerialized] 
		[Display(AutoGenerateField = false)]
		private bool suppressEntityEvents = false;
		
		/// <summary>Used by in place editing of databinding features for new inserted row. Indicates that we are in the middle of an IBinding insert transaction.</summary>
		[NonSerialized]
		[Display(AutoGenerateField = false)]
		protected bool bindingIsNew = true;
	
		///<summary>The actual hashcode of the entity.</summary>
		private string entityHashCode;
		
		/// <summary>The name of the underlying database table.</summary>
		[Display(AutoGenerateField = false)]
		public abstract string TableName { get;}
		
		/// <summary>The name of the underlying database table's columns.</summary>
		/// <value>A string array that holds the columns names.</value>
		[Display(AutoGenerateField = false)]
		public abstract string[] TableColumns {get;}

		/// <summary>True if object has been <see cref="MarkToDelete"/>. ReadOnly.</summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public virtual bool IsDeleted
		{
			get { return this.EntityState == EntityState.Deleted; }
		}		
	
		/// <summary>Indicates if the object has been modified from its original state.</summary>
		/// <remarks>True if object has been modified from its original state; otherwise False;</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public virtual bool IsDirty
		{
			get { return this.EntityState != EntityState.Unchanged; }
		}
		
		/// <summary>Indicates if the object is new.</summary>
		/// <remarks>True if objectis new; otherwise False;</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public virtual bool IsNew
		{
			get { return this.EntityState == EntityState.Added; }
			set { this.EntityState = EntityState.Added; }
		}
		
		/// <summary>Indicates state of object</summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public abstract EntityState EntityState { get; set; }
		
		/// <summary>Accepts the changes made to this object.</summary>
		/// <remarks> After calling this method <see cref="IsDirty"/> and <see cref="IsNew"/> are false. <see cref="IsDeleted"/> flag remain unchanged as it is handled by the parent List.</remarks>
		public virtual void AcceptChanges()
		{			
			this.bindingIsNew = false;
			EntityState = EntityState.Unchanged;
			OnPropertyChanged(string.Empty);
		}
		
		///<summary>Revert all changes and restore original values.  To be implemented in concrete class.</summary>
		public abstract void CancelChanges();
		
		///<summary>Marks entity to be deleted.</summary>
		public virtual void MarkToDelete()
		{
			
			if (this.EntityState != EntityState.Added)
				this.EntityState = EntityState.Deleted ;
		}
		
		///<summary>Remove the "isDeleted" mark from the entity.</summary>
		public virtual void RemoveDeleteMark()
		{
			if (this.EntityState != EntityState.Added) 
			{				
				this.EntityState = EntityState.Changed ;
			}
		}
				 
		/// <summary>Gets or sets the parent collection.</summary>
        /// <value>The parent collection.</value>
		[XmlIgnore]
		public abstract object ParentCollection{get;set;}
		
		#region Common Columns
		/// <summary>
		/// 
		/// </summary>
		
		[Required(ErrorMessage =  "ContentText is Required")]
		public abstract System.String ContentText {get;set;}
		/// <summary>
		/// 
		/// </summary>
		
		[Required(ErrorMessage =  "Status is Required")]
		public abstract System.Int32 Status {get;set;}
		/// <summary>
		/// 
		/// </summary>
		
		[Required(ErrorMessage =  "CreatedDate is Required")]
		public abstract System.DateTime CreatedDate {get;set;}
		/// <summary>
		/// 
		/// </summary>
		
		[Required(ErrorMessage =  "Note is Required")]
		public abstract System.String Note {get;set;}
		#endregion		
				
		/// <summary>Determines whether the property value has changed from the original data.</summary>
		/// <param name="columnName">The column name.</param>
		/// <returns><c>true</c> if the property value has changed; otherwise, <c>false</c>.</returns>
		public abstract bool IsPropertyChanged(string columnName);
		
		/// <summary>Object that contains data to associate with this object</summary>
		[NonSerialized]
		private object tag;	
		
		/// <summary>Gets or sets the object that contains supplemental data about this object.</summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				if (this.tag == value)
					return;
				this.tag = value;
			}
		}
		
		/// <summary>Determines whether this entity is being tracked.</summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public bool IsEntityTracked 
		{	
			get
			{
				return isEntityTracked;
			}
			set
			{
				isEntityTracked = value;
			}	
		}
		
				
		/// <summary>Determines whether this entity is to suppress events while set to true.</summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}
		
		///<summary>Provides the tracking key for the <see cref="EntityLocator"/></summary>
		[XmlIgnoreAttribute(), BrowsableAttribute(false)]
		[Display(AutoGenerateField = false)]
		public abstract string EntityTrackingKey {	get; set; }
		
		///<summary>Provides a unique HashCode throughout the lifetime of the entity.</summary>
		public override int GetHashCode()
		{
			if (entityHashCode == null) entityHashCode = Guid.NewGuid().ToString();
			return entityHashCode.GetHashCode(); 
		}

        #region INotifyPropertyChanging Members

        /// <summary>
        /// Event to indicate that a property is changing.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Called when a property is changing
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing.</param>
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if (!suppressEntityEvents)
            {
                OnPropertyChanging(new PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Called when a property is changing
        /// </summary>
        /// <param name="e">PropertyChangingEventArgs</param>
        protected virtual void OnPropertyChanging(PropertyChangingEventArgs e)
        {
            if (!suppressEntityEvents)
            {
                // Check field level security instead of ValidationRules.ValidateRules(e.PropertyName);

                if (null != PropertyChanging)
                {
                    PropertyChanging(this, e);
                }
            }
        }

        #endregion        
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
		/// Event to indicate that a property has changed.
		/// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;
		
		/// <summary>
		/// Called when a property is changed
		/// </summary>
		/// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			if (!suppressEntityEvents)
			{
				OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Called when a property is changed
		/// </summary>
		/// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!suppressEntityEvents)
			{
				//Validate the property
         		ValidationRules.ValidateRules(e.PropertyName);

				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
		
		#region IDataErrorInfo Members

		/// <summary>
		/// Gets an error message indicating what is wrong with this object.
		/// </summary>
		/// <value></value>
		/// <returns>An error message indicating what is wrong with this object. The default is an empty string ("").</returns>      
		[Display(AutoGenerateField = false)]
		public string Error
		{
			get 
			{
				string errorDescription = string.Empty;
				if (!IsValid)
				{
					errorDescription = ValidationRules.GetBrokenRules().ToString();
				}				
				return errorDescription;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:String"/> with the specified column name.
		/// </summary>
		/// <value></value>
		public string this[string columnName]
		{
			get
			{
				string errorDescription = string.Empty;
				if (!IsValid)
				{
				 	errorDescription = ValidationRules.GetBrokenRules().GetPropertyErrorDescriptions(columnName);
				}
				return errorDescription;
			}
		}
		
      	#endregion

      	#region Validation
		
		[NonSerialized]
     	private Validation.ValidationRules _validationRules;
		
		/// <summary>
		/// Returns the list of <see cref="Validation.ValidationRules"/> associated with this object.
		/// </summary>
		[XmlIgnoreAttribute()]
		protected Validation.ValidationRules ValidationRules
		{
			get
			{
				if (_validationRules == null)
				{
					_validationRules = new Validation.ValidationRules(this);
					
					//lazy init the rules as well.
					AddValidationRules();
				}
	
				return _validationRules;
			}
		}
		
		/// <summary>
		/// Assigns validation rules to this object.
		/// </summary>
		/// <remarks>
		/// This method can be overridden in a derived class to add custom validation rules. 
		///</remarks>
		protected virtual void AddValidationRules()
		{
			
		}

		/// <summary>
		/// Returns a list of all the validation rules that failed.
		/// </summary>
		/// <returns><see cref="Validation.BrokenRulesList" /></returns>
		[XmlIgnoreAttribute()]
		[Display(AutoGenerateField = false)]
		public virtual Validation.BrokenRulesList BrokenRulesList
		{
			get
			{
				return ValidationRules.GetBrokenRules();
			}
		}
		
		/// <summary>
		/// Adds a rule to the list of validated rules.
		/// </summary>
		/// <param name="handler">The method that implements the rule.</param>
		/// <param name="propertyName">
		/// The name of the property on the target object where the rule implementation can retrieve
		/// the value to be validated.
		/// </param>
		public void AddValidationRuleHandler(Validation.ValidationRuleHandler handler, String propertyName)
		{
		   ValidationRules.AddRule(handler, propertyName);
		}

		/// <summary>
		/// Adds a rule to the list of validated rules.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="handler">The method that implements the rule.</param>
		/// <param name="args">
		/// A <see cref="Validation.ValidationRuleArgs"/> object specifying the property name and other arguments
		/// passed to the rule method
		/// </param>
		public void AddValidationRuleHandler(Validation.ValidationRuleHandler handler, Validation.ValidationRuleArgs args)
		{
		    ValidationRules.AddRule(handler, args);
		}
	
		/// <summary>
		/// Returns <see langword="true" /> if the object is valid, 
		/// <see langword="false" /> if the object validation rules that have indicated failure. 
		/// </summary>
		[Browsable(false)]
		[Display(AutoGenerateField = false)]
		public virtual bool IsValid
		{
			get
			{
				Validate();
				return ValidationRules.IsValid;
			}
		}

		/// <summary>
		/// Force this object to validate itself using the assigned business rules.
		/// </summary>
		/// <remarks>Validates all properties.</remarks>
		public void Validate()
		{
			ValidationRules.ValidateRules();
		}
	
		/// <summary>
		/// Force the object to validate itself using the assigned business rules.
		/// </summary>
		/// <param name="propertyName">Name of the property to validate.</param>
		public void Validate(string propertyName)
		{
			ValidationRules.ValidateRules(propertyName);
		}
		
		/// <summary>
		/// Force the object to validate itself using the assigned business rules.
		/// </summary>
		/// <param name="column">Column enumeration representing the column to validate.</param>
		public void Validate(System.Enum column)
		{
			Validate(column.ToString());
		}
      	#endregion

		#region IDeserializationCallback Members
	
			/// <summary>
			/// Runs when the entire object graph has been deserialized.
			/// </summary>
			/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
			public void OnDeserialization(object sender)
			{
				if(!suppressEntityEvents)
				{
					ValidationRules.Target = this;
					AddValidationRules();
				}
			}
	
		#endregion
		
	}
}
