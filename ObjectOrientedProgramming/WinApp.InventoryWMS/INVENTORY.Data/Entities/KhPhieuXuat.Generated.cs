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
    /// The class representing the dbo.KhPhieuXuat table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.KhPhieuXuat")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.KhPhieuXuat.Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class KhPhieuXuat
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="KhPhieuXuat"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static KhPhieuXuat()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="KhPhieuXuat"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public KhPhieuXuat()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _boPhanDmBoPhan = default(System.Data.Linq.EntityRef<DmBoPhan>);
            _khoHangDmKhoHang = default(System.Data.Linq.EntityRef<DmKhoHang>);
            _phieuXuatKhPhieuXuatCtList = new System.Data.Linq.EntitySet<KhPhieuXuatCt>(OnPhieuXuatKhPhieuXuatCtListAdd, OnPhieuXuatKhPhieuXuatCtListRemove);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Guid _id;

        /// <summary>
        /// Gets or sets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "uniqueidentifier NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
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
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
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
                    if (_khoHangDmKhoHang.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnIdKhoHangChanging(value);
                    SendPropertyChanging("IdKhoHang");
                    _idKhoHang = value;
                    SendPropertyChanged("IdKhoHang");
                    OnIdKhoHangChanged();
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string SoPhieu
        {
            get { return _soPhieu; }
            set
            {
                if (_soPhieu != value)
                {
                    OnSoPhieuChanging(value);
                    SendPropertyChanging("SoPhieu");
                    _soPhieu = value;
                    SendPropertyChanged("SoPhieu");
                    OnSoPhieuChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Guid _idBoPhan;

        /// <summary>
        /// Gets or sets the IdBoPhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdBoPhan", Storage = "_idBoPhan", DbType = "uniqueidentifier NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Guid IdBoPhan
        {
            get { return _idBoPhan; }
            set
            {
                if (_idBoPhan != value)
                {
                    if (_boPhanDmBoPhan.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnIdBoPhanChanging(value);
                    SendPropertyChanging("IdBoPhan");
                    _idBoPhan = value;
                    SendPropertyChanged("IdBoPhan");
                    OnIdBoPhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _idNguoiNhan;

        /// <summary>
        /// Gets or sets the IdNguoiNhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNguoiNhan", Storage = "_idNguoiNhan", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int IdNguoiNhan
        {
            get { return _idNguoiNhan; }
            set
            {
                if (_idNguoiNhan != value)
                {
                    OnIdNguoiNhanChanging(value);
                    SendPropertyChanging("IdNguoiNhan");
                    _idNguoiNhan = value;
                    SendPropertyChanged("IdNguoiNhan");
                    OnIdNguoiNhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _idNguoiTao;

        /// <summary>
        /// Gets or sets the IdNguoiTao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNguoiTao", Storage = "_idNguoiTao", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int IdNguoiTao
        {
            get { return _idNguoiTao; }
            set
            {
                if (_idNguoiTao != value)
                {
                    OnIdNguoiTaoChanging(value);
                    SendPropertyChanging("IdNguoiTao");
                    _idNguoiTao = value;
                    SendPropertyChanged("IdNguoiTao");
                    OnIdNguoiTaoChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _ngayTao;

        /// <summary>
        /// Gets or sets the NgayTao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "NgayTao", Storage = "_ngayTao", DbType = "datetime NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime NgayTao
        {
            get { return _ngayTao; }
            set
            {
                if (_ngayTao != value)
                {
                    OnNgayTaoChanging(value);
                    SendPropertyChanging("NgayTao");
                    _ngayTao = value;
                    SendPropertyChanged("NgayTao");
                    OnNgayTaoChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _ngayTaoDate;

        /// <summary>
        /// Gets or sets the NgayTaoDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "NgayTaoDate", Storage = "_ngayTaoDate", DbType = "date NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime NgayTaoDate
        {
            get { return _ngayTaoDate; }
            set
            {
                if (_ngayTaoDate != value)
                {
                    OnNgayTaoDateChanging(value);
                    SendPropertyChanging("NgayTaoDate");
                    _ngayTaoDate = value;
                    SendPropertyChanged("NgayTaoDate");
                    OnNgayTaoDateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool _updateTon;

        /// <summary>
        /// Gets or sets the UpdateTon column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UpdateTon", Storage = "_updateTon", DbType = "bit NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public bool UpdateTon
        {
            get { return _updateTon; }
            set
            {
                if (_updateTon != value)
                {
                    OnUpdateTonChanging(value);
                    SendPropertyChanging("UpdateTon");
                    _updateTon = value;
                    SendPropertyChanged("UpdateTon");
                    OnUpdateTonChanged();
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
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string ChuThich
        {
            get { return _chuThich; }
            set
            {
                if (_chuThich != value)
                {
                    OnChuThichChanging(value);
                    SendPropertyChanging("ChuThich");
                    _chuThich = value;
                    SendPropertyChanged("ChuThich");
                    OnChuThichChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntityRef<DmBoPhan> _boPhanDmBoPhan;

        /// <summary>
        /// Gets or sets the <see cref="DmBoPhan"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "DmBoPhan_KhPhieuXuat", Storage = "_boPhanDmBoPhan", ThisKey = "IdBoPhan", OtherKey = "Id", IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 11, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public DmBoPhan BoPhanDmBoPhan
        {
            get { return (serializing && !_boPhanDmBoPhan.HasLoadedOrAssignedValue) ? null : _boPhanDmBoPhan.Entity; }
            set
            {
                DmBoPhan previousValue = _boPhanDmBoPhan.Entity;
                if (previousValue != value || _boPhanDmBoPhan.HasLoadedOrAssignedValue == false)
                {
                    OnBoPhanDmBoPhanChanging(value);
                    SendPropertyChanging("BoPhanDmBoPhan");
                    if (previousValue != null)
                    {
                        _boPhanDmBoPhan.Entity = null;
                        previousValue.BoPhanKhPhieuXuatList.Remove(this);
                    }
                    _boPhanDmBoPhan.Entity = value;
                    if (value != null)
                    {
                        value.BoPhanKhPhieuXuatList.Add(this);
                        _idBoPhan = value.Id;
                    }
                    else
                    {
                        _idBoPhan = default(System.Guid);
                    }
                    SendPropertyChanged("BoPhanDmBoPhan");
                    OnBoPhanDmBoPhanChanged();
                }
            }
        }
        
        
        

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntityRef<DmKhoHang> _khoHangDmKhoHang;

        /// <summary>
        /// Gets or sets the <see cref="DmKhoHang"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "DmKhoHang_KhPhieuXuat", Storage = "_khoHangDmKhoHang", ThisKey = "IdKhoHang", OtherKey = "Id", IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 12, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public DmKhoHang KhoHangDmKhoHang
        {
            get { return (serializing && !_khoHangDmKhoHang.HasLoadedOrAssignedValue) ? null : _khoHangDmKhoHang.Entity; }
            set
            {
                DmKhoHang previousValue = _khoHangDmKhoHang.Entity;
                if (previousValue != value || _khoHangDmKhoHang.HasLoadedOrAssignedValue == false)
                {
                    OnKhoHangDmKhoHangChanging(value);
                    SendPropertyChanging("KhoHangDmKhoHang");
                    if (previousValue != null)
                    {
                        _khoHangDmKhoHang.Entity = null;
                        previousValue.KhoHangKhPhieuXuatList.Remove(this);
                    }
                    _khoHangDmKhoHang.Entity = value;
                    if (value != null)
                    {
                        value.KhoHangKhPhieuXuatList.Add(this);
                        _idKhoHang = value.Id;
                    }
                    else
                    {
                        _idKhoHang = default(int);
                    }
                    SendPropertyChanged("KhoHangDmKhoHang");
                    OnKhoHangDmKhoHangChanged();
                }
            }
        }
        
        
        

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<KhPhieuXuatCt> _phieuXuatKhPhieuXuatCtList;

        /// <summary>
        /// Gets or sets the <see cref="KhPhieuXuatCt"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "KhPhieuXuat_KhPhieuXuatCt", Storage = "_phieuXuatKhPhieuXuatCtList", ThisKey = "Id", OtherKey = "IdPhieuXuat")]
        [System.Runtime.Serialization.DataMember(Order=13, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<KhPhieuXuatCt> PhieuXuatKhPhieuXuatCtList
        {
            get { return (serializing && !_phieuXuatKhPhieuXuatCtList.HasLoadedOrAssignedValues) ? null : _phieuXuatKhPhieuXuatCtList; }
            set { _phieuXuatKhPhieuXuatCtList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuXuatKhPhieuXuatCtListAdd(KhPhieuXuatCt entity)
        {
            SendPropertyChanging(null);
            entity.PhieuXuatKhPhieuXuat = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuXuatKhPhieuXuatCtListRemove(KhPhieuXuatCt entity)
        {
            SendPropertyChanging(null);
            entity.PhieuXuatKhPhieuXuat = null;
            SendPropertyChanged(null);
        }
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
        /// <summary>Called when <see cref="SoPhieu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanging(string value);
        /// <summary>Called after <see cref="SoPhieu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanged();
        /// <summary>Called when <see cref="IdBoPhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdBoPhanChanging(System.Guid value);
        /// <summary>Called after <see cref="IdBoPhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdBoPhanChanged();
        /// <summary>Called when <see cref="IdNguoiNhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiNhanChanging(int value);
        /// <summary>Called after <see cref="IdNguoiNhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiNhanChanged();
        /// <summary>Called when <see cref="IdNguoiTao"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiTaoChanging(int value);
        /// <summary>Called after <see cref="IdNguoiTao"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiTaoChanged();
        /// <summary>Called when <see cref="NgayTao"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoChanging(System.DateTime value);
        /// <summary>Called after <see cref="NgayTao"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoChanged();
        /// <summary>Called when <see cref="NgayTaoDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="NgayTaoDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNgayTaoDateChanged();
        /// <summary>Called when <see cref="UpdateTon"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUpdateTonChanging(bool value);
        /// <summary>Called after <see cref="UpdateTon"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUpdateTonChanged();
        /// <summary>Called when <see cref="ChuThich"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanging(string value);
        /// <summary>Called after <see cref="ChuThich"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanged();
        /// <summary>Called when <see cref="BoPhanDmBoPhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnBoPhanDmBoPhanChanging(DmBoPhan value);
        /// <summary>Called after <see cref="BoPhanDmBoPhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnBoPhanDmBoPhanChanged();
        /// <summary>Called when <see cref="KhoHangDmKhoHang"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoHangDmKhoHangChanging(DmKhoHang value);
        /// <summary>Called after <see cref="KhoHangDmKhoHang"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoHangDmKhoHangChanged();

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
        /// Deserializes an instance of <see cref="KhPhieuXuat"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="KhPhieuXuat"/> instance.</param>
        /// <returns>An instance of <see cref="KhPhieuXuat"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static KhPhieuXuat FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(KhPhieuXuat));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as KhPhieuXuat;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="KhPhieuXuat"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="KhPhieuXuat"/> instance.</param>
        /// <returns>An instance of <see cref="KhPhieuXuat"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static KhPhieuXuat FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(KhPhieuXuat));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as KhPhieuXuat;
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
        public KhPhieuXuat Clone()
        {
            return (KhPhieuXuat)((ICloneable)this).Clone();
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
            _boPhanDmBoPhan = Detach(_boPhanDmBoPhan);
            _khoHangDmKhoHang = Detach(_khoHangDmKhoHang);
            _phieuXuatKhPhieuXuatCtList = Detach(_phieuXuatKhPhieuXuatCtList, OnPhieuXuatKhPhieuXuatCtListAdd, OnPhieuXuatKhPhieuXuatCtListRemove);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
