﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace INVENTORY.Data
{
    /// <summary>
    /// The query extension class for KhNhapXuat.
    /// </summary>
    public static partial class KhNhapXuatExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhNhapXuat GetByKey(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhNhapXuat>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, id);

            return queryable.FirstOrDefault(k => k.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.KhNhapXuat> table, System.Guid id)
        {
            return table.Delete(k => k.Id == id);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhNhapXuat GetByIdKhoHangIdLoaiVatTuThang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int idKhoHang, System.Guid idLoaiVatTu, System.DateTime thang)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhNhapXuat>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByIdKhoHangIdLoaiVatTuThang.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, idKhoHang, idLoaiVatTu, thang);

            return queryable.FirstOrDefault(k => k.IdKhoHang == idKhoHang 
					&& k.IdLoaiVatTu == idLoaiVatTu 
					&& k.Thang == thang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ById(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.Guid id)
        {
            return queryable.Where(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ById(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, System.Guid id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.Id != id);
                default:
                    return queryable.Where(k => k.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ById(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ById(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int idKhoHang)
        {
            return queryable.Where(k => k.IdKhoHang == idKhoHang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, int idKhoHang)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.IdKhoHang > idKhoHang);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.IdKhoHang >= idKhoHang);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.IdKhoHang < idKhoHang);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.IdKhoHang <= idKhoHang);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdKhoHang != idKhoHang);
                default:
                    return queryable.Where(k => k.IdKhoHang == idKhoHang);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int idKhoHang, params int[] additionalValues)
        {
            var idKhoHangList = new List<int> { idKhoHang };

            if (additionalValues != null)
                idKhoHangList.AddRange(additionalValues);

            if (idKhoHangList.Count == 1)
                return queryable.ByIdKhoHang(idKhoHangList[0]);

            return queryable.ByIdKhoHang(idKhoHangList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.IdKhoHang));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.Guid idLoaiVatTu)
        {
            return queryable.Where(k => k.IdLoaiVatTu == idLoaiVatTu);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, System.Guid idLoaiVatTu)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdLoaiVatTu != idLoaiVatTu);
                default:
                    return queryable.Where(k => k.IdLoaiVatTu == idLoaiVatTu);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.Guid idLoaiVatTu, params System.Guid[] additionalValues)
        {
            var idLoaiVatTuList = new List<System.Guid> { idLoaiVatTu };

            if (additionalValues != null)
                idLoaiVatTuList.AddRange(additionalValues);

            if (idLoaiVatTuList.Count == 1)
                return queryable.ByIdLoaiVatTu(idLoaiVatTuList[0]);

            return queryable.ByIdLoaiVatTu(idLoaiVatTuList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdLoaiVatTu));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Thang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thang">Thang to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByThang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.DateTime thang)
        {
            return queryable.Where(k => k.Thang == thang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Thang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thang">Thang to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByThang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, System.DateTime thang)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.Thang > thang);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.Thang >= thang);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.Thang < thang);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.Thang <= thang);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.Thang != thang);
                default:
                    return queryable.Where(k => k.Thang == thang);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Thang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thang">Thang to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByThang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, System.DateTime thang, params System.DateTime[] additionalValues)
        {
            var thangList = new List<System.DateTime> { thang };

            if (additionalValues != null)
                thangList.AddRange(additionalValues);

            if (thangList.Count == 1)
                return queryable.ByThang(thangList[0]);

            return queryable.ByThang(thangList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Thang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByThang(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(k => values.Contains(k.Thang));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Nhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="nhap">Nhap to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByNhap(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int nhap)
        {
            return queryable.Where(k => k.Nhap == nhap);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Nhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="nhap">Nhap to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByNhap(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, int nhap)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.Nhap > nhap);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.Nhap >= nhap);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.Nhap < nhap);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.Nhap <= nhap);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.Nhap != nhap);
                default:
                    return queryable.Where(k => k.Nhap == nhap);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Nhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="nhap">Nhap to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByNhap(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int nhap, params int[] additionalValues)
        {
            var nhapList = new List<int> { nhap };

            if (additionalValues != null)
                nhapList.AddRange(additionalValues);

            if (nhapList.Count == 1)
                return queryable.ByNhap(nhapList[0]);

            return queryable.ByNhap(nhapList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Nhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByNhap(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.Nhap));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Xuat"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="xuat">Xuat to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByXuat(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int xuat)
        {
            return queryable.Where(k => k.Xuat == xuat);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Xuat"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="xuat">Xuat to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByXuat(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, int xuat)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.Xuat > xuat);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.Xuat >= xuat);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.Xuat < xuat);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.Xuat <= xuat);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.Xuat != xuat);
                default:
                    return queryable.Where(k => k.Xuat == xuat);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Xuat"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="xuat">Xuat to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByXuat(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int xuat, params int[] additionalValues)
        {
            var xuatList = new List<int> { xuat };

            if (additionalValues != null)
                xuatList.AddRange(additionalValues);

            if (xuatList.Count == 1)
                return queryable.ByXuat(xuatList[0]);

            return queryable.ByXuat(xuatList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Xuat"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByXuat(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.Xuat));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Chuyen"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuyen">Chuyen to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByChuyen(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int chuyen)
        {
            return queryable.Where(k => k.Chuyen == chuyen);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Chuyen"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuyen">Chuyen to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByChuyen(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, ComparisonOperator comparisonOperator, int chuyen)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.Chuyen > chuyen);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.Chuyen >= chuyen);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.Chuyen < chuyen);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.Chuyen <= chuyen);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.Chuyen != chuyen);
                default:
                    return queryable.Where(k => k.Chuyen == chuyen);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Chuyen"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuyen">Chuyen to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByChuyen(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, int chuyen, params int[] additionalValues)
        {
            var chuyenList = new List<int> { chuyen };

            if (additionalValues != null)
                chuyenList.AddRange(additionalValues);

            if (chuyenList.Count == 1)
                return queryable.ByChuyen(chuyenList[0]);

            return queryable.ByChuyen(chuyenList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhNhapXuat.Chuyen"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhNhapXuat> ByChuyen(this IQueryable<INVENTORY.Data.KhNhapXuat> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.Chuyen));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.KhNhapXuat> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.KhNhapXuat.FirstOrDefault(k => k.Id == id));
            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, int, System.Guid, System.DateTime, INVENTORY.Data.KhNhapXuat> GetByIdKhoHangIdLoaiVatTuThang =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, int idKhoHang, System.Guid idLoaiVatTu, System.DateTime thang) =>
                        db.KhNhapXuat.FirstOrDefault(k => k.IdKhoHang == idKhoHang 
							&& k.IdLoaiVatTu == idLoaiVatTu 
							&& k.Thang == thang));

        }
        #endregion
    }
}
#pragma warning restore 1591
