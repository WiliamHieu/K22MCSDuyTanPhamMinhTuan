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
    /// The query extension class for KhPhieuChuyenSp.
    /// </summary>
    public static partial class KhPhieuChuyenSpExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhPhieuChuyenSp GetByKey(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhPhieuChuyenSp>;
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
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.KhPhieuChuyenSp> table, System.Guid id)
        {
            return table.Delete(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ById(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid id)
        {
            return queryable.Where(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ById(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, ComparisonOperator comparisonOperator, System.Guid id)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ById(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ById(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdPhieuChuyenCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuChuyenCt">IdPhieuChuyenCt to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdPhieuChuyenCt(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid idPhieuChuyenCt)
        {
            return queryable.Where(k => k.IdPhieuChuyenCt == idPhieuChuyenCt);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdPhieuChuyenCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuChuyenCt">IdPhieuChuyenCt to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdPhieuChuyenCt(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, ComparisonOperator comparisonOperator, System.Guid idPhieuChuyenCt)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdPhieuChuyenCt != idPhieuChuyenCt);
                default:
                    return queryable.Where(k => k.IdPhieuChuyenCt == idPhieuChuyenCt);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdPhieuChuyenCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuChuyenCt">IdPhieuChuyenCt to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdPhieuChuyenCt(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid idPhieuChuyenCt, params System.Guid[] additionalValues)
        {
            var idPhieuChuyenCtList = new List<System.Guid> { idPhieuChuyenCt };

            if (additionalValues != null)
                idPhieuChuyenCtList.AddRange(additionalValues);

            if (idPhieuChuyenCtList.Count == 1)
                return queryable.ByIdPhieuChuyenCt(idPhieuChuyenCtList[0]);

            return queryable.ByIdPhieuChuyenCt(idPhieuChuyenCtList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdPhieuChuyenCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdPhieuChuyenCt(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdPhieuChuyenCt));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid idSanPham)
        {
            return queryable.Where(k => k.IdSanPham == idSanPham);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, ComparisonOperator comparisonOperator, System.Guid idSanPham)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdSanPham != idSanPham);
                default:
                    return queryable.Where(k => k.IdSanPham == idSanPham);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.Guid idSanPham, params System.Guid[] additionalValues)
        {
            var idSanPhamList = new List<System.Guid> { idSanPham };

            if (additionalValues != null)
                idSanPhamList.AddRange(additionalValues);

            if (idSanPhamList.Count == 1)
                return queryable.ByIdSanPham(idSanPhamList[0]);

            return queryable.ByIdSanPham(idSanPhamList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdSanPham));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, int soLuong)
        {
            return queryable.Where(k => k.SoLuong == soLuong);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, ComparisonOperator comparisonOperator, int soLuong)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.SoLuong > soLuong);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.SoLuong >= soLuong);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.SoLuong < soLuong);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.SoLuong <= soLuong);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.SoLuong != soLuong);
                default:
                    return queryable.Where(k => k.SoLuong == soLuong);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, int soLuong, params int[] additionalValues)
        {
            var soLuongList = new List<int> { soLuong };

            if (additionalValues != null)
                soLuongList.AddRange(additionalValues);

            if (soLuongList.Count == 1)
                return queryable.BySoLuong(soLuongList[0]);

            return queryable.BySoLuong(soLuongList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.SoLuong));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.NgayTaoDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTaoDate">NgayTaoDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByNgayTaoDate(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.DateTime ngayTaoDate)
        {
            return queryable.Where(k => k.NgayTaoDate == ngayTaoDate);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.NgayTaoDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTaoDate">NgayTaoDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByNgayTaoDate(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, ComparisonOperator comparisonOperator, System.DateTime ngayTaoDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.NgayTaoDate > ngayTaoDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.NgayTaoDate >= ngayTaoDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.NgayTaoDate < ngayTaoDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.NgayTaoDate <= ngayTaoDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.NgayTaoDate != ngayTaoDate);
                default:
                    return queryable.Where(k => k.NgayTaoDate == ngayTaoDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.NgayTaoDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTaoDate">NgayTaoDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByNgayTaoDate(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, System.DateTime ngayTaoDate, params System.DateTime[] additionalValues)
        {
            var ngayTaoDateList = new List<System.DateTime> { ngayTaoDate };

            if (additionalValues != null)
                ngayTaoDateList.AddRange(additionalValues);

            if (ngayTaoDateList.Count == 1)
                return queryable.ByNgayTaoDate(ngayTaoDateList[0]);

            return queryable.ByNgayTaoDate(ngayTaoDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuChuyenSp.NgayTaoDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuChuyenSp> ByNgayTaoDate(this IQueryable<INVENTORY.Data.KhPhieuChuyenSp> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(k => values.Contains(k.NgayTaoDate));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.KhPhieuChuyenSp> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.KhPhieuChuyenSp.FirstOrDefault(k => k.Id == id));

        }
        #endregion
    }
}
#pragma warning restore 1591
