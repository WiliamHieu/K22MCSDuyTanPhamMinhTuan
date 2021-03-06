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
    /// Class representing CustomKhPhieuNhapGetListResult data.
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.CustomKhPhieuNhapGetListResult.Metadata))]
    public partial class CustomKhPhieuNhapGetListResult
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="CustomKhPhieuNhapGetListResult"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static CustomKhPhieuNhapGetListResult()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomKhPhieuNhapGetListResult"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public CustomKhPhieuNhapGetListResult()
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
        private int _loaiNhap;

        /// <summary>
        /// Gets or sets the LoaiNhap column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LoaiNhap", Storage = "_loaiNhap", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int LoaiNhap
        {
            get { return _loaiNhap; }
            set
            {
                if (_loaiNhap != value)
                {
                    OnLoaiNhapChanging(value);
                    _loaiNhap = value;
                    OnLoaiNhapChanged();
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
        private string _tenNguonNhap;

        /// <summary>
        /// Gets or sets the TenNguonNhap column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenNguonNhap", Storage = "_tenNguonNhap", DbType = "nvarchar(100) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenNguonNhap
        {
            get { return _tenNguonNhap; }
            set
            {
                if (_tenNguonNhap != value)
                {
                    OnTenNguonNhapChanging(value);
                    _tenNguonNhap = value;
                    OnTenNguonNhapChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _tenLoaiNhap;

        /// <summary>
        /// Gets or sets the TenLoaiNhap column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TenLoaiNhap", Storage = "_tenLoaiNhap", DbType = "nvarchar(11)")]
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string TenLoaiNhap
        {
            get { return _tenLoaiNhap; }
            set
            {
                if (_tenLoaiNhap != value)
                {
                    OnTenLoaiNhapChanging(value);
                    _tenLoaiNhap = value;
                    OnTenLoaiNhapChanged();
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
        /// <summary>Called when <see cref="LoaiNhap"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaiNhapChanging(int value);
        /// <summary>Called after <see cref="LoaiNhap"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaiNhapChanged();
        /// <summary>Called when <see cref="SoPhieu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanging(string value);
        /// <summary>Called after <see cref="SoPhieu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanged();
        /// <summary>Called when <see cref="TenNguonNhap"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguonNhapChanging(string value);
        /// <summary>Called after <see cref="TenNguonNhap"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenNguonNhapChanged();
        /// <summary>Called when <see cref="TenLoaiNhap"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenLoaiNhapChanging(string value);
        /// <summary>Called after <see cref="TenLoaiNhap"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTenLoaiNhapChanged();
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
        /// Deserializes an instance of <see cref="CustomKhPhieuNhapGetListResult"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="CustomKhPhieuNhapGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomKhPhieuNhapGetListResult"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomKhPhieuNhapGetListResult FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomKhPhieuNhapGetListResult));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as CustomKhPhieuNhapGetListResult;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="CustomKhPhieuNhapGetListResult"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="CustomKhPhieuNhapGetListResult"/> instance.</param>
        /// <returns>An instance of <see cref="CustomKhPhieuNhapGetListResult"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static CustomKhPhieuNhapGetListResult FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(CustomKhPhieuNhapGetListResult));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as CustomKhPhieuNhapGetListResult;
            }
        }
        
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
