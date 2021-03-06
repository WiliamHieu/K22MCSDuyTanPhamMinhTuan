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
    /// Class representing CustomDmLoaiVatTuGetListResult data.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.CustomDmLoaiVatTuGetListResult.Metadata))]
    public partial class CustomDmLoaiVatTuGetListResult
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="CustomDmLoaiVatTuGetListResult"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static CustomDmLoaiVatTuGetListResult()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDmLoaiVatTuGetListResult"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public CustomDmLoaiVatTuGetListResult()
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
        private System.Guid _id;

        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Guid Id
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
        private System.Guid _idNhomVatTu;

        /// <summary>
        /// Gets or sets the IdNhomVatTu column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNhomVatTu", Storage = "_idNhomVatTu", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Guid IdNhomVatTu
        {
            get { return _idNhomVatTu; }
            set
            {
                if (_idNhomVatTu != value)
                {
                    OnIdNhomVatTuChanging(value);
                    _idNhomVatTu = value;
                    OnIdNhomVatTuChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Guid _idDonViTinh;

        /// <summary>
        /// Gets or sets the IdDonViTinh column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdDonViTinh", Storage = "_idDonViTinh", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Guid IdDonViTinh
        {
            get { return _idDonViTinh; }
            set
            {
                if (_idDonViTinh != value)
                {
                    OnIdDonViTinhChanging(value);
                    _idDonViTinh = value;
                    OnIdDonViTinhChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _ten;

        /// <summary>
        /// Gets or sets the Ten column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Ten", Storage = "_ten", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
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
        [System.Runtime.Serialization.DataMember(Order = 5)]
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
        [System.Runtime.Serialization.DataMember(Order = 6)]
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
        private int _trangThai;

        /// <summary>
        /// Gets or sets the TrangThai column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TrangThai", Storage = "_trangThai", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int TrangThai
        {
            get { return _trangThai; }
            set
            {
                if (_trangThai != value)
                {
                    OnTrangThaiChanging(value);
                    _trangThai = value;
                    OnTrangThaiChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _chuThich;

        /// <summary>
        /// Gets or sets the ChuThich column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ChuThich", Storage = "_chuThich", DbType = "nvarchar(300)")]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string ChuThich
        {
            get { return _chuThich; }
            set
            {
                if (_chuThich != value)
                {
                    OnChuThichChanging(value);
                    _chuThich = value;
                    OnChuThichChanged();
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
        partial void OnIdChanging(System.Guid value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanged();
        /// <summary>Called when <see cref="IdNhomVatTu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNhomVatTuChanging(System.Guid value);
        /// <summary>Called after <see cref="IdNhomVatTu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNhomVatTuChanged();
        /// <summary>Called when <see cref="IdDonViTinh"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdDonViTinhChanging(System.Guid value);
        /// <summary>Called after <see cref="IdDonViTinh"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdDonViTinhChanged();
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
        /// <summary>Called when <see cref="TrangThai"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiChanging(int value);
        /// <summary>Called after <see cref="TrangThai"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiChanged();
        /// <summary>Called when <see cref="ChuThich"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanging(string value);
        /// <summary>Called after <see cref="ChuThich"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanged();

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
        /// Deserializes an instance of <see cref="CustomDmLoaiVatTuGetListResult"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="CustomDmLoaiVatTuGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomDmLoaiVatTuGetListResult"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomDmLoaiVatTuGetListResult FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomDmLoaiVatTuGetListResult));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as CustomDmLoaiVatTuGetListResult;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="CustomDmLoaiVatTuGetListResult"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="CustomDmLoaiVatTuGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomDmLoaiVatTuGetListResult"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomDmLoaiVatTuGetListResult FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomDmLoaiVatTuGetListResult));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as CustomDmLoaiVatTuGetListResult;
            }
        }
        
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
