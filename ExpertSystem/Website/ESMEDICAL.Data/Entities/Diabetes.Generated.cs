﻿#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace ESMEDICAL.Data
{
    /// <summary>
    /// The class representing the dbo.Diabetes table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Diabetes")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(ESMEDICAL.Data.Diabetes.Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Diabetes
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Diabetes"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static Diabetes()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Diabetes"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Diabetes()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _id = default(int);

        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private short _age;

        /// <summary>
        /// Gets or sets the Age column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Age", Storage = "_age", DbType = "smallint NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public short Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    OnAgeChanging(value);
                    SendPropertyChanging("Age");
                    _age = value;
                    SendPropertyChanged("Age");
                    OnAgeChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _gender;

        /// <summary>
        /// Gets or sets the Gender column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Gender", Storage = "_gender", DbType = "varchar(6) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (_gender != value)
                {
                    OnGenderChanging(value);
                    SendPropertyChanging("Gender");
                    _gender = value;
                    SendPropertyChanged("Gender");
                    OnGenderChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _polyuria;

        /// <summary>
        /// Gets or sets the Polyuria column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Polyuria", Storage = "_polyuria", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Polyuria
        {
            get { return _polyuria; }
            set
            {
                if (_polyuria != value)
                {
                    OnPolyuriaChanging(value);
                    SendPropertyChanging("Polyuria");
                    _polyuria = value;
                    SendPropertyChanged("Polyuria");
                    OnPolyuriaChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _polydipsia;

        /// <summary>
        /// Gets or sets the Polydipsia column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Polydipsia", Storage = "_polydipsia", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Polydipsia
        {
            get { return _polydipsia; }
            set
            {
                if (_polydipsia != value)
                {
                    OnPolydipsiaChanging(value);
                    SendPropertyChanging("Polydipsia");
                    _polydipsia = value;
                    SendPropertyChanged("Polydipsia");
                    OnPolydipsiaChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _suddenWeightLoss;

        /// <summary>
        /// Gets or sets the SuddenWeightLoss column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "SuddenWeightLoss", Storage = "_suddenWeightLoss", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string SuddenWeightLoss
        {
            get { return _suddenWeightLoss; }
            set
            {
                if (_suddenWeightLoss != value)
                {
                    OnSuddenWeightLossChanging(value);
                    SendPropertyChanging("SuddenWeightLoss");
                    _suddenWeightLoss = value;
                    SendPropertyChanged("SuddenWeightLoss");
                    OnSuddenWeightLossChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _weakness;

        /// <summary>
        /// Gets or sets the Weakness column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Weakness", Storage = "_weakness", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Weakness
        {
            get { return _weakness; }
            set
            {
                if (_weakness != value)
                {
                    OnWeaknessChanging(value);
                    SendPropertyChanging("Weakness");
                    _weakness = value;
                    SendPropertyChanged("Weakness");
                    OnWeaknessChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _polyphagia;

        /// <summary>
        /// Gets or sets the Polyphagia column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Polyphagia", Storage = "_polyphagia", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Polyphagia
        {
            get { return _polyphagia; }
            set
            {
                if (_polyphagia != value)
                {
                    OnPolyphagiaChanging(value);
                    SendPropertyChanging("Polyphagia");
                    _polyphagia = value;
                    SendPropertyChanged("Polyphagia");
                    OnPolyphagiaChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _genitalThrush;

        /// <summary>
        /// Gets or sets the GenitalThrush column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "GenitalThrush", Storage = "_genitalThrush", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string GenitalThrush
        {
            get { return _genitalThrush; }
            set
            {
                if (_genitalThrush != value)
                {
                    OnGenitalThrushChanging(value);
                    SendPropertyChanging("GenitalThrush");
                    _genitalThrush = value;
                    SendPropertyChanged("GenitalThrush");
                    OnGenitalThrushChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _visualBlurring;

        /// <summary>
        /// Gets or sets the VisualBlurring column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "VisualBlurring", Storage = "_visualBlurring", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string VisualBlurring
        {
            get { return _visualBlurring; }
            set
            {
                if (_visualBlurring != value)
                {
                    OnVisualBlurringChanging(value);
                    SendPropertyChanging("VisualBlurring");
                    _visualBlurring = value;
                    SendPropertyChanged("VisualBlurring");
                    OnVisualBlurringChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _itching;

        /// <summary>
        /// Gets or sets the Itching column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Itching", Storage = "_itching", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 11)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Itching
        {
            get { return _itching; }
            set
            {
                if (_itching != value)
                {
                    OnItchingChanging(value);
                    SendPropertyChanging("Itching");
                    _itching = value;
                    SendPropertyChanged("Itching");
                    OnItchingChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _irritability;

        /// <summary>
        /// Gets or sets the Irritability column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Irritability", Storage = "_irritability", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 12)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Irritability
        {
            get { return _irritability; }
            set
            {
                if (_irritability != value)
                {
                    OnIrritabilityChanging(value);
                    SendPropertyChanging("Irritability");
                    _irritability = value;
                    SendPropertyChanged("Irritability");
                    OnIrritabilityChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _delayedHealing;

        /// <summary>
        /// Gets or sets the DelayedHealing column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "DelayedHealing", Storage = "_delayedHealing", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 13)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string DelayedHealing
        {
            get { return _delayedHealing; }
            set
            {
                if (_delayedHealing != value)
                {
                    OnDelayedHealingChanging(value);
                    SendPropertyChanging("DelayedHealing");
                    _delayedHealing = value;
                    SendPropertyChanged("DelayedHealing");
                    OnDelayedHealingChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _partialParesis;

        /// <summary>
        /// Gets or sets the PartialParesis column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "PartialParesis", Storage = "_partialParesis", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 14)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string PartialParesis
        {
            get { return _partialParesis; }
            set
            {
                if (_partialParesis != value)
                {
                    OnPartialParesisChanging(value);
                    SendPropertyChanging("PartialParesis");
                    _partialParesis = value;
                    SendPropertyChanged("PartialParesis");
                    OnPartialParesisChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _muscleStiffness;

        /// <summary>
        /// Gets or sets the MuscleStiffness column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "MuscleStiffness", Storage = "_muscleStiffness", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 15)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string MuscleStiffness
        {
            get { return _muscleStiffness; }
            set
            {
                if (_muscleStiffness != value)
                {
                    OnMuscleStiffnessChanging(value);
                    SendPropertyChanging("MuscleStiffness");
                    _muscleStiffness = value;
                    SendPropertyChanged("MuscleStiffness");
                    OnMuscleStiffnessChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _alopecia;

        /// <summary>
        /// Gets or sets the Alopecia column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Alopecia", Storage = "_alopecia", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 16)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Alopecia
        {
            get { return _alopecia; }
            set
            {
                if (_alopecia != value)
                {
                    OnAlopeciaChanging(value);
                    SendPropertyChanging("Alopecia");
                    _alopecia = value;
                    SendPropertyChanged("Alopecia");
                    OnAlopeciaChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _obesity;

        /// <summary>
        /// Gets or sets the Obesity column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Obesity", Storage = "_obesity", DbType = "varchar(3)")]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.Runtime.Serialization.DataMember(Order = 17)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Obesity
        {
            get { return _obesity; }
            set
            {
                if (_obesity != value)
                {
                    OnObesityChanging(value);
                    SendPropertyChanging("Obesity");
                    _obesity = value;
                    SendPropertyChanged("Obesity");
                    OnObesityChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _class;

        /// <summary>
        /// Gets or sets the Class column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Class", Storage = "_class", DbType = "varchar(8) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        [System.Runtime.Serialization.DataMember(Order = 18)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Class
        {
            get { return _class; }
            set
            {
                if (_class != value)
                {
                    OnClassChanging(value);
                    SendPropertyChanging("Class");
                    _class = value;
                    SendPropertyChanged("Class");
                    OnClassChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 19)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    SendPropertyChanging("CreatedDate");
                    _createdDate = value;
                    SendPropertyChanged("CreatedDate");
                    OnCreatedDateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _createdBy;

        /// <summary>
        /// Gets or sets the CreatedBy column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedBy", Storage = "_createdBy", DbType = "varchar(20) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.Runtime.Serialization.DataMember(Order = 20)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                if (_createdBy != value)
                {
                    OnCreatedByChanging(value);
                    SendPropertyChanging("CreatedBy");
                    _createdBy = value;
                    SendPropertyChanged("CreatedBy");
                    OnCreatedByChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanged();
        /// <summary>Called when <see cref="Age"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAgeChanging(short value);
        /// <summary>Called after <see cref="Age"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAgeChanged();
        /// <summary>Called when <see cref="Gender"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnGenderChanging(string value);
        /// <summary>Called after <see cref="Gender"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnGenderChanged();
        /// <summary>Called when <see cref="Polyuria"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolyuriaChanging(string value);
        /// <summary>Called after <see cref="Polyuria"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolyuriaChanged();
        /// <summary>Called when <see cref="Polydipsia"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolydipsiaChanging(string value);
        /// <summary>Called after <see cref="Polydipsia"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolydipsiaChanged();
        /// <summary>Called when <see cref="SuddenWeightLoss"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSuddenWeightLossChanging(string value);
        /// <summary>Called after <see cref="SuddenWeightLoss"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSuddenWeightLossChanged();
        /// <summary>Called when <see cref="Weakness"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnWeaknessChanging(string value);
        /// <summary>Called after <see cref="Weakness"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnWeaknessChanged();
        /// <summary>Called when <see cref="Polyphagia"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolyphagiaChanging(string value);
        /// <summary>Called after <see cref="Polyphagia"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPolyphagiaChanged();
        /// <summary>Called when <see cref="GenitalThrush"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnGenitalThrushChanging(string value);
        /// <summary>Called after <see cref="GenitalThrush"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnGenitalThrushChanged();
        /// <summary>Called when <see cref="VisualBlurring"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnVisualBlurringChanging(string value);
        /// <summary>Called after <see cref="VisualBlurring"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnVisualBlurringChanged();
        /// <summary>Called when <see cref="Itching"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnItchingChanging(string value);
        /// <summary>Called after <see cref="Itching"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnItchingChanged();
        /// <summary>Called when <see cref="Irritability"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIrritabilityChanging(string value);
        /// <summary>Called after <see cref="Irritability"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIrritabilityChanged();
        /// <summary>Called when <see cref="DelayedHealing"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnDelayedHealingChanging(string value);
        /// <summary>Called after <see cref="DelayedHealing"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnDelayedHealingChanged();
        /// <summary>Called when <see cref="PartialParesis"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPartialParesisChanging(string value);
        /// <summary>Called after <see cref="PartialParesis"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPartialParesisChanged();
        /// <summary>Called when <see cref="MuscleStiffness"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnMuscleStiffnessChanging(string value);
        /// <summary>Called after <see cref="MuscleStiffness"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnMuscleStiffnessChanged();
        /// <summary>Called when <see cref="Alopecia"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAlopeciaChanging(string value);
        /// <summary>Called after <see cref="Alopecia"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnAlopeciaChanged();
        /// <summary>Called when <see cref="Obesity"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnObesityChanging(string value);
        /// <summary>Called after <see cref="Obesity"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnObesityChanged();
        /// <summary>Called when <see cref="Class"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnClassChanging(string value);
        /// <summary>Called after <see cref="Class"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnClassChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="CreatedBy"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedByChanging(string value);
        /// <summary>Called after <see cref="CreatedBy"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedByChanged();

        #endregion

        #region Serialization
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Diabetes"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Diabetes"/> instance.</param>
        /// <returns>An instance of <see cref="Diabetes"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Diabetes FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Diabetes));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Diabetes;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Diabetes"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Diabetes"/> instance.</param>
        /// <returns>An instance of <see cref="Diabetes"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Diabetes FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Diabetes));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Diabetes;
            }
        }
        
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Diabetes Clone()
        {
            return (Diabetes)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
