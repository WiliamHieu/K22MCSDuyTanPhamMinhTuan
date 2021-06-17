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
    /// Class representing CustomKhPhieuXuatGetListResult data.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.CustomKhPhieuXuatGetListResult.Metadata))]
    public partial class CustomKhPhieuXuatGetListResult
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="CustomKhPhieuXuatGetListResult"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static CustomKhPhieuXuatGetListResult()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomKhPhieuXuatGetListResult"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public CustomKhPhieuXuatGetListResult()
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
        private int _idKhoHang;

        /// <summary>
        /// Gets or sets the IdKhoHang column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdKhoHang", Storage = "_idKhoHang", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int IdKhoHang
        {
            get { return _idKhoHang; }
            set
            {
                if (_idKhoHang != value)
                {
                    OnIdKhoHangChanging(value);
                    _idKhoHang = value;
                    OnIdKhoHangChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Guid _idBoPhan;

        /// <summary>
        /// Gets or sets the IdBoPhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdBoPhan", Storage = "_idBoPhan", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Guid IdBoPhan
        {
            get { return _idBoPhan; }
            set
            {
                if (_idBoPhan != value)
                {
                    OnIdBoPhanChanging(value);
                    _idBoPhan = value;
                    OnIdBoPhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _soPhieu;

        /// <summary>
        /// Gets or sets the SoPhieu column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "SoPhieu", Storage = "_soPhieu", DbType = "nvarchar(20) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string SoPhieu
        {
            get { return _soPhieu; }
            set
            {
                if (_soPhieu != value)
                {
                    OnSoPhieuChanging(value);
                    _soPhieu = value;
                    OnSoPhieuChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenBoPhan;

        /// <summary>
        /// Gets or sets the TenBoPhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenBoPhan", Storage = "_tenBoPhan", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenBoPhan
        {
            get { return _tenBoPhan; }
            set
            {
                if (_tenBoPhan != value)
                {
                    OnTenBoPhanChanging(value);
                    _tenBoPhan = value;
                    OnTenBoPhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenNguoiNhan;

        /// <summary>
        /// Gets or sets the TenNguoiNhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenNguoiNhan", Storage = "_tenNguoiNhan", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenNguoiNhan
        {
            get { return _tenNguoiNhan; }
            set
            {
                if (_tenNguoiNhan != value)
                {
                    OnTenNguoiNhanChanging(value);
                    _tenNguoiNhan = value;
                    OnTenNguoiNhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenNguoiTao;

        /// <summary>
        /// Gets or sets the TenNguoiTao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenNguoiTao", Storage = "_tenNguoiTao", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenNguoiTao
        {
            get { return _tenNguoiTao; }
            set
            {
                if (_tenNguoiTao != value)
                {
                    OnTenNguoiTaoChanging(value);
                    _tenNguoiTao = value;
                    OnTenNguoiTaoChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _ngayTao;

        /// <summary>
        /// Gets or sets the NgayTao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "NgayTao", Storage = "_ngayTao", DbType = "datetime NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime NgayTao
        {
            get { return _ngayTao; }
            set
            {
                if (_ngayTao != value)
                {
                    OnNgayTaoChanging(value);
                    _ngayTao = value;
                    OnNgayTaoChanged();
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
        [System.Runtime.Serialization.DataMember(Order = 9)]
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
        /// <summary>Called when <see cref="IdKhoHang"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdKhoHangChanging(int value);
        /// <summary>Called after <see cref="IdKhoHang"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdKhoHangChanged();
        /// <summary>Called when <see cref="IdBoPhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdBoPhanChanging(System.Guid value);
        /// <summary>Called after <see cref="IdBoPhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdBoPhanChanged();
        /// <summary>Called when <see cref="SoPhieu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanging(string value);
        /// <summary>Called after <see cref="SoPhieu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanged();
        /// <summary>Called when <see cref="TenBoPhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenBoPhanChanging(string value);
        /// <summary>Called after <see cref="TenBoPhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenBoPhanChanged();
        /// <summary>Called when <see cref="TenNguoiNhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguoiNhanChanging(string value);
        /// <summary>Called after <see cref="TenNguoiNhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguoiNhanChanged();
        /// <summary>Called when <see cref="TenNguoiTao"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguoiTaoChanging(string value);
        /// <summary>Called after <see cref="TenNguoiTao"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguoiTaoChanged();
        /// <summary>Called when <see cref="NgayTao"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoChanging(System.DateTime value);
        /// <summary>Called after <see cref="NgayTao"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoChanged();
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
        /// Deserializes an instance of <see cref="CustomKhPhieuXuatGetListResult"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="CustomKhPhieuXuatGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomKhPhieuXuatGetListResult"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomKhPhieuXuatGetListResult FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomKhPhieuXuatGetListResult));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as CustomKhPhieuXuatGetListResult;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="CustomKhPhieuXuatGetListResult"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="CustomKhPhieuXuatGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomKhPhieuXuatGetListResult"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomKhPhieuXuatGetListResult FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomKhPhieuXuatGetListResult));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as CustomKhPhieuXuatGetListResult;
            }
        }
        
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
