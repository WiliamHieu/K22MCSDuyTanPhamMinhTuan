#pragma warning disable 1591
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

namespace INVENTORY.Data
{
    /// <summary>
    /// Class representing CustomDmLoaiVatTuGetDropDownResult data.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.CustomDmLoaiVatTuGetDropDownResult.Metadata))]
    public partial class CustomDmLoaiVatTuGetDropDownResult
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="CustomDmLoaiVatTuGetDropDownResult"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static CustomDmLoaiVatTuGetDropDownResult()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDmLoaiVatTuGetDropDownResult"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public CustomDmLoaiVatTuGetDropDownResult()
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
        private Nullable<System.Guid> _id;

        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "uniqueidentifier")]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Nullable<System.Guid> Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    _id = value;
                    OnIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _ten;

        /// <summary>
        /// Gets or sets the Ten column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Ten", Storage = "_ten", DbType = "nvarchar(100)")]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Ten
        {
            get { return _ten; }
            set
            {
                if (_ten != value)
                {
                    OnTenChanging(value);
                    _ten = value;
                    OnTenChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _quyCach;

        /// <summary>
        /// Gets or sets the QuyCach column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "QuyCach", Storage = "_quyCach", DbType = "nvarchar(300)")]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string QuyCach
        {
            get { return _quyCach; }
            set
            {
                if (_quyCach != value)
                {
                    OnQuyCachChanging(value);
                    _quyCach = value;
                    OnQuyCachChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenDonViTinh;

        /// <summary>
        /// Gets or sets the TenDonViTinh column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenDonViTinh", Storage = "_tenDonViTinh", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenDonViTinh
        {
            get { return _tenDonViTinh; }
            set
            {
                if (_tenDonViTinh != value)
                {
                    OnTenDonViTinhChanging(value);
                    _tenDonViTinh = value;
                    OnTenDonViTinhChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private Nullable<int> _soLuong;

        /// <summary>
        /// Gets or sets the SoLuong column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "SoLuong", Storage = "_soLuong", DbType = "int")]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Nullable<int> SoLuong
        {
            get { return _soLuong; }
            set
            {
                if (_soLuong != value)
                {
                    OnSoLuongChanging(value);
                    _soLuong = value;
                    OnSoLuongChanged();
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
        partial void OnIdChanging(Nullable<System.Guid> value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanged();
        /// <summary>Called when <see cref="Ten"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenChanging(string value);
        /// <summary>Called after <see cref="Ten"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenChanged();
        /// <summary>Called when <see cref="QuyCach"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnQuyCachChanging(string value);
        /// <summary>Called after <see cref="QuyCach"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnQuyCachChanged();
        /// <summary>Called when <see cref="TenDonViTinh"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenDonViTinhChanging(string value);
        /// <summary>Called after <see cref="TenDonViTinh"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenDonViTinhChanged();
        /// <summary>Called when <see cref="SoLuong"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoLuongChanging(Nullable<int> value);
        /// <summary>Called after <see cref="SoLuong"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoLuongChanged();

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
        /// Deserializes an instance of <see cref="CustomDmLoaiVatTuGetDropDownResult"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="CustomDmLoaiVatTuGetDropDownResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomDmLoaiVatTuGetDropDownResult"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomDmLoaiVatTuGetDropDownResult FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomDmLoaiVatTuGetDropDownResult));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as CustomDmLoaiVatTuGetDropDownResult;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="CustomDmLoaiVatTuGetDropDownResult"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="CustomDmLoaiVatTuGetDropDownResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomDmLoaiVatTuGetDropDownResult"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomDmLoaiVatTuGetDropDownResult FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomDmLoaiVatTuGetDropDownResult));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as CustomDmLoaiVatTuGetDropDownResult;
            }
        }
        
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
