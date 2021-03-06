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
    /// The class representing the dbo.KhPhieuChuyen table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.KhPhieuChuyen")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(INVENTORY.Data.KhPhieuChuyen.Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class KhPhieuChuyen
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="KhPhieuChuyen"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static KhPhieuChuyen()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="KhPhieuChuyen"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public KhPhieuChuyen()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _khoHangDmKhoHang = default(System.Data.Linq.EntityRef<DmKhoHang>);
            _khoNhanDmKhoHang = default(System.Data.Linq.EntityRef<DmKhoHang>);
            _phieuChuyenKhPhieuChuyenCtList = new System.Data.Linq.EntitySet<KhPhieuChuyenCt>(OnPhieuChuyenKhPhieuChuyenCtListAdd, OnPhieuChuyenKhPhieuChuyenCtListRemove);
            _phieuChuyenKhPhieuNhapList = new System.Data.Linq.EntitySet<KhPhieuNhap>(OnPhieuChuyenKhPhieuNhapListAdd, OnPhieuChuyenKhPhieuNhapListRemove);
            _phieuChuyenKhPhieuNhapNbList = new System.Data.Linq.EntitySet<KhPhieuNhapNb>(OnPhieuChuyenKhPhieuNhapNbListAdd, OnPhieuChuyenKhPhieuNhapNbListRemove);
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
        private int _idKhoNhan;

        /// <summary>
        /// Gets or sets the IdKhoNhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdKhoNhan", Storage = "_idKhoNhan", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int IdKhoNhan
        {
            get { return _idKhoNhan; }
            set
            {
                if (_idKhoNhan != value)
                {
                    if (_khoNhanDmKhoHang.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnIdKhoNhanChanging(value);
                    SendPropertyChanging("IdKhoNhan");
                    _idKhoNhan = value;
                    SendPropertyChanged("IdKhoNhan");
                    OnIdKhoNhanChanged();
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
                    SendPropertyChanging("SoPhieu");
                    _soPhieu = value;
                    SendPropertyChanged("SoPhieu");
                    OnSoPhieuChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _idNguoiGiao;

        /// <summary>
        /// Gets or sets the IdNguoiGiao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNguoiGiao", Storage = "_idNguoiGiao", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int IdNguoiGiao
        {
            get { return _idNguoiGiao; }
            set
            {
                if (_idNguoiGiao != value)
                {
                    OnIdNguoiGiaoChanging(value);
                    SendPropertyChanging("IdNguoiGiao");
                    _idNguoiGiao = value;
                    SendPropertyChanged("IdNguoiGiao");
                    OnIdNguoiGiaoChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _trangThai;

        /// <summary>
        /// Gets or sets the TrangThai column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TrangThai", Storage = "_trangThai", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int TrangThai
        {
            get { return _trangThai; }
            set
            {
                if (_trangThai != value)
                {
                    OnTrangThaiChanging(value);
                    SendPropertyChanging("TrangThai");
                    _trangThai = value;
                    SendPropertyChanged("TrangThai");
                    OnTrangThaiChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _trangThaiNhan;

        /// <summary>
        /// Gets or sets the TrangThaiNhan column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TrangThaiNhan", Storage = "_trangThaiNhan", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int TrangThaiNhan
        {
            get { return _trangThaiNhan; }
            set
            {
                if (_trangThaiNhan != value)
                {
                    OnTrangThaiNhanChanging(value);
                    SendPropertyChanging("TrangThaiNhan");
                    _trangThaiNhan = value;
                    SendPropertyChanged("TrangThaiNhan");
                    OnTrangThaiNhanChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _idNguoiTao;

        /// <summary>
        /// Gets or sets the IdNguoiTao column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IdNguoiTao", Storage = "_idNguoiTao", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
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
        [System.Runtime.Serialization.DataMember(Order = 9)]
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
        [System.Runtime.Serialization.DataMember(Order = 10)]
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
        private string _chuThich;

        /// <summary>
        /// Gets or sets the ChuThich column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ChuThich", Storage = "_chuThich", DbType = "nvarchar(300)")]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        [System.Runtime.Serialization.DataMember(Order = 11)]
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
        private System.Data.Linq.EntityRef<DmKhoHang> _khoHangDmKhoHang;

        /// <summary>
        /// Gets or sets the <see cref="DmKhoHang"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "DmKhoHang_KhPhieuChuyen", Storage = "_khoHangDmKhoHang", ThisKey = "IdKhoHang", OtherKey = "Id", IsForeignKey = true)]
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
                        previousValue.KhoHangKhPhieuChuyenList.Remove(this);
                    }
                    _khoHangDmKhoHang.Entity = value;
                    if (value != null)
                    {
                        value.KhoHangKhPhieuChuyenList.Add(this);
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
        private System.Data.Linq.EntityRef<DmKhoHang> _khoNhanDmKhoHang;

        /// <summary>
        /// Gets or sets the <see cref="DmKhoHang"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "DmKhoHang_KhPhieuChuyen1", Storage = "_khoNhanDmKhoHang", ThisKey = "IdKhoNhan", OtherKey = "Id", IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 13, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public DmKhoHang KhoNhanDmKhoHang
        {
            get { return (serializing && !_khoNhanDmKhoHang.HasLoadedOrAssignedValue) ? null : _khoNhanDmKhoHang.Entity; }
            set
            {
                DmKhoHang previousValue = _khoNhanDmKhoHang.Entity;
                if (previousValue != value || _khoNhanDmKhoHang.HasLoadedOrAssignedValue == false)
                {
                    OnKhoNhanDmKhoHangChanging(value);
                    SendPropertyChanging("KhoNhanDmKhoHang");
                    if (previousValue != null)
                    {
                        _khoNhanDmKhoHang.Entity = null;
                        previousValue.KhoNhanKhPhieuChuyenList.Remove(this);
                    }
                    _khoNhanDmKhoHang.Entity = value;
                    if (value != null)
                    {
                        value.KhoNhanKhPhieuChuyenList.Add(this);
                        _idKhoNhan = value.Id;
                    }
                    else
                    {
                        _idKhoNhan = default(int);
                    }
                    SendPropertyChanged("KhoNhanDmKhoHang");
                    OnKhoNhanDmKhoHangChanged();
                }
            }
        }
        
        
        

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<KhPhieuChuyenCt> _phieuChuyenKhPhieuChuyenCtList;

        /// <summary>
        /// Gets or sets the <see cref="KhPhieuChuyenCt"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "KhPhieuChuyen_KhPhieuChuyenCt", Storage = "_phieuChuyenKhPhieuChuyenCtList", ThisKey = "Id", OtherKey = "IdPhieuChuyen")]
        [System.Runtime.Serialization.DataMember(Order=14, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<KhPhieuChuyenCt> PhieuChuyenKhPhieuChuyenCtList
        {
            get { return (serializing && !_phieuChuyenKhPhieuChuyenCtList.HasLoadedOrAssignedValues) ? null : _phieuChuyenKhPhieuChuyenCtList; }
            set { _phieuChuyenKhPhieuChuyenCtList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuChuyenCtListAdd(KhPhieuChuyenCt entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuChuyenCtListRemove(KhPhieuChuyenCt entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = null;
            SendPropertyChanged(null);
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<KhPhieuNhap> _phieuChuyenKhPhieuNhapList;

        /// <summary>
        /// Gets or sets the <see cref="KhPhieuNhap"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "KhPhieuChuyen_KhPhieuNhap", Storage = "_phieuChuyenKhPhieuNhapList", ThisKey = "Id", OtherKey = "IdPhieuChuyen")]
        [System.Runtime.Serialization.DataMember(Order=15, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<KhPhieuNhap> PhieuChuyenKhPhieuNhapList
        {
            get { return (serializing && !_phieuChuyenKhPhieuNhapList.HasLoadedOrAssignedValues) ? null : _phieuChuyenKhPhieuNhapList; }
            set { _phieuChuyenKhPhieuNhapList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuNhapListAdd(KhPhieuNhap entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuNhapListRemove(KhPhieuNhap entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = null;
            SendPropertyChanged(null);
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<KhPhieuNhapNb> _phieuChuyenKhPhieuNhapNbList;

        /// <summary>
        /// Gets or sets the <see cref="KhPhieuNhapNb"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "KhPhieuChuyen_KhPhieuNhapNb", Storage = "_phieuChuyenKhPhieuNhapNbList", ThisKey = "Id", OtherKey = "IdPhieuChuyen")]
        [System.Runtime.Serialization.DataMember(Order=16, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<KhPhieuNhapNb> PhieuChuyenKhPhieuNhapNbList
        {
            get { return (serializing && !_phieuChuyenKhPhieuNhapNbList.HasLoadedOrAssignedValues) ? null : _phieuChuyenKhPhieuNhapNbList; }
            set { _phieuChuyenKhPhieuNhapNbList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuNhapNbListAdd(KhPhieuNhapNb entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnPhieuChuyenKhPhieuNhapNbListRemove(KhPhieuNhapNb entity)
        {
            SendPropertyChanging(null);
            entity.PhieuChuyenKhPhieuChuyen = null;
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
        /// <summary>Called when <see cref="IdKhoNhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdKhoNhanChanging(int value);
        /// <summary>Called after <see cref="IdKhoNhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdKhoNhanChanged();
        /// <summary>Called when <see cref="SoPhieu"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanging(string value);
        /// <summary>Called after <see cref="SoPhieu"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnSoPhieuChanged();
        /// <summary>Called when <see cref="IdNguoiGiao"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiGiaoChanging(int value);
        /// <summary>Called after <see cref="IdNguoiGiao"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdNguoiGiaoChanged();
        /// <summary>Called when <see cref="TrangThai"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiChanging(int value);
        /// <summary>Called after <see cref="TrangThai"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiChanged();
        /// <summary>Called when <see cref="TrangThaiNhan"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiNhanChanging(int value);
        /// <summary>Called after <see cref="TrangThaiNhan"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTrangThaiNhanChanged();
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
        /// <summary>Called when <see cref="ChuThich"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanging(string value);
        /// <summary>Called after <see cref="ChuThich"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnChuThichChanged();
        /// <summary>Called when <see cref="KhoHangDmKhoHang"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoHangDmKhoHangChanging(DmKhoHang value);
        /// <summary>Called after <see cref="KhoHangDmKhoHang"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoHangDmKhoHangChanged();
        /// <summary>Called when <see cref="KhoNhanDmKhoHang"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoNhanDmKhoHangChanging(DmKhoHang value);
        /// <summary>Called after <see cref="KhoNhanDmKhoHang"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnKhoNhanDmKhoHangChanged();

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
        /// Deserializes an instance of <see cref="KhPhieuChuyen"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="KhPhieuChuyen"/> instance.</param>
        /// <returns>An instance of <see cref="KhPhieuChuyen"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static KhPhieuChuyen FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(KhPhieuChuyen));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as KhPhieuChuyen;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="KhPhieuChuyen"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="KhPhieuChuyen"/> instance.</param>
        /// <returns>An instance of <see cref="KhPhieuChuyen"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static KhPhieuChuyen FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(KhPhieuChuyen));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as KhPhieuChuyen;
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
        public KhPhieuChuyen Clone()
        {
            return (KhPhieuChuyen)((ICloneable)this).Clone();
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
            _khoHangDmKhoHang = Detach(_khoHangDmKhoHang);
            _khoNhanDmKhoHang = Detach(_khoNhanDmKhoHang);
            _phieuChuyenKhPhieuChuyenCtList = Detach(_phieuChuyenKhPhieuChuyenCtList, OnPhieuChuyenKhPhieuChuyenCtListAdd, OnPhieuChuyenKhPhieuChuyenCtListRemove);
            _phieuChuyenKhPhieuNhapList = Detach(_phieuChuyenKhPhieuNhapList, OnPhieuChuyenKhPhieuNhapListAdd, OnPhieuChuyenKhPhieuNhapListRemove);
            _phieuChuyenKhPhieuNhapNbList = Detach(_phieuChuyenKhPhieuNhapNbList, OnPhieuChuyenKhPhieuNhapNbListAdd, OnPhieuChuyenKhPhieuNhapNbListRemove);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414
