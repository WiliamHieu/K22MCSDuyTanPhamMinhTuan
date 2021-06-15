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

namespace INVENTORY.Data
{
    /// <summary>
    /// Class representing CustomRpHangNhapResult1 data.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.CustomRpHangNhapResult1.Metadata))]
    public partial class CustomRpHangNhapResult1
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="CustomRpHangNhapResult1"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static CustomRpHangNhapResult1()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRpHangNhapResult1"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public CustomRpHangNhapResult1()
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
        private System.Guid _idNhomVatTu;

        /// <summary>
        /// Gets or sets the IdNhomVatTu column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNhomVatTu", Storage = "_idNhomVatTu", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
        private string _tenNhomVatTu;

        /// <summary>
        /// Gets or sets the TenNhomVatTu column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenNhomVatTu", Storage = "_tenNhomVatTu", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenNhomVatTu
        {
            get { return _tenNhomVatTu; }
            set
            {
                if (_tenNhomVatTu != value)
                {
                    OnTenNhomVatTuChanging(value);
                    _tenNhomVatTu = value;
                    OnTenNhomVatTuChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenLoaiVatTu;

        /// <summary>
        /// Gets or sets the TenLoaiVatTu column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenLoaiVatTu", Storage = "_tenLoaiVatTu", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenLoaiVatTu
        {
            get { return _tenLoaiVatTu; }
            set
            {
                if (_tenLoaiVatTu != value)
                {
                    OnTenLoaiVatTuChanging(value);
                    _tenLoaiVatTu = value;
                    OnTenLoaiVatTuChanged();
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
        [System.Runtime.Serialization.DataMember(Order = 4)]
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
        [System.Runtime.Serialization.DataMember(Order = 5)]
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
        [System.Runtime.Serialization.DataMember(Order = 6)]
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
        /// <summary>Called when <see cref="IdNhomVatTu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNhomVatTuChanging(System.Guid value);
        /// <summary>Called after <see cref="IdNhomVatTu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNhomVatTuChanged();
        /// <summary>Called when <see cref="TenNhomVatTu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNhomVatTuChanging(string value);
        /// <summary>Called after <see cref="TenNhomVatTu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNhomVatTuChanged();
        /// <summary>Called when <see cref="TenLoaiVatTu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenLoaiVatTuChanging(string value);
        /// <summary>Called after <see cref="TenLoaiVatTu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenLoaiVatTuChanged();
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
        /// Deserializes an instance of <see cref="CustomRpHangNhapResult1"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="CustomRpHangNhapResult1"/> instance.</param>
        /// <returns>An instance of <see cref="CustomRpHangNhapResult1"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomRpHangNhapResult1 FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomRpHangNhapResult1));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as CustomRpHangNhapResult1;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="CustomRpHangNhapResult1"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="CustomRpHangNhapResult1"/> instance.</param>
        /// <returns>An instance of <see cref="CustomRpHangNhapResult1"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomRpHangNhapResult1 FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomRpHangNhapResult1));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as CustomRpHangNhapResult1;
            }
        }
        
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
