#pragma warning disable 1591
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
    /// The query extension class for KhPhieuNhapNbCt.
    /// </summary>
    public static partial class KhPhieuNhapNbCtExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhPhieuNhapNbCt GetByKey(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhPhieuNhapNbCt>;
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
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.KhPhieuNhapNbCt> table, System.Guid id)
        {
            return table.Delete(k => k.Id == id);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhPhieuNhapNbCt GetByIdPhieuNhapNbIdLoaiVatTuIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idPhieuNhapNb, System.Guid idLoaiVatTu, System.Guid idSanPham)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhPhieuNhapNbCt>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByIdPhieuNhapNbIdLoaiVatTuIdSanPham.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, idPhieuNhapNb, idLoaiVatTu, idSanPham);

            return queryable.FirstOrDefault(k => k.IdPhieuNhapNb == idPhieuNhapNb 
					&& k.IdLoaiVatTu == idLoaiVatTu 
					&& k.IdSanPham == idSanPham);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ById(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid id)
        {
            return queryable.Where(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ById(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, System.Guid id)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ById(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ById(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdPhieuNhapNb"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuNhapNb">IdPhieuNhapNb to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdPhieuNhapNb(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idPhieuNhapNb)
        {
            return queryable.Where(k => k.IdPhieuNhapNb == idPhieuNhapNb);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdPhieuNhapNb"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuNhapNb">IdPhieuNhapNb to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdPhieuNhapNb(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, System.Guid idPhieuNhapNb)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdPhieuNhapNb != idPhieuNhapNb);
                default:
                    return queryable.Where(k => k.IdPhieuNhapNb == idPhieuNhapNb);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdPhieuNhapNb"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuNhapNb">IdPhieuNhapNb to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdPhieuNhapNb(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idPhieuNhapNb, params System.Guid[] additionalValues)
        {
            var idPhieuNhapNbList = new List<System.Guid> { idPhieuNhapNb };

            if (additionalValues != null)
                idPhieuNhapNbList.AddRange(additionalValues);

            if (idPhieuNhapNbList.Count == 1)
                return queryable.ByIdPhieuNhapNb(idPhieuNhapNbList[0]);

            return queryable.ByIdPhieuNhapNb(idPhieuNhapNbList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdPhieuNhapNb"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdPhieuNhapNb(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdPhieuNhapNb));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idLoaiVatTu)
        {
            return queryable.Where(k => k.IdLoaiVatTu == idLoaiVatTu);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, System.Guid idLoaiVatTu)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idLoaiVatTu, params System.Guid[] additionalValues)
        {
            var idLoaiVatTuList = new List<System.Guid> { idLoaiVatTu };

            if (additionalValues != null)
                idLoaiVatTuList.AddRange(additionalValues);

            if (idLoaiVatTuList.Count == 1)
                return queryable.ByIdLoaiVatTu(idLoaiVatTuList[0]);

            return queryable.ByIdLoaiVatTu(idLoaiVatTuList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdLoaiVatTu));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idSanPham)
        {
            return queryable.Where(k => k.IdSanPham == idSanPham);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, System.Guid idSanPham)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, System.Guid idSanPham, params System.Guid[] additionalValues)
        {
            var idSanPhamList = new List<System.Guid> { idSanPham };

            if (additionalValues != null)
                idSanPhamList.AddRange(additionalValues);

            if (idSanPhamList.Count == 1)
                return queryable.ByIdSanPham(idSanPhamList[0]);

            return queryable.ByIdSanPham(idSanPhamList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdSanPham));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, int soLuong)
        {
            return queryable.Where(k => k.SoLuong == soLuong);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, int soLuong)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, int soLuong, params int[] additionalValues)
        {
            var soLuongList = new List<int> { soLuong };

            if (additionalValues != null)
                soLuongList.AddRange(additionalValues);

            if (soLuongList.Count == 1)
                return queryable.BySoLuong(soLuongList[0]);

            return queryable.BySoLuong(soLuongList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.SoLuong));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByTrangThai(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, int trangThai)
        {
            return queryable.Where(k => k.TrangThai == trangThai);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByTrangThai(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ComparisonOperator comparisonOperator, int trangThai)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.TrangThai > trangThai);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.TrangThai >= trangThai);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.TrangThai < trangThai);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.TrangThai <= trangThai);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.TrangThai != trangThai);
                default:
                    return queryable.Where(k => k.TrangThai == trangThai);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByTrangThai(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, int trangThai, params int[] additionalValues)
        {
            var trangThaiList = new List<int> { trangThai };

            if (additionalValues != null)
                trangThaiList.AddRange(additionalValues);

            if (trangThaiList.Count == 1)
                return queryable.ByTrangThai(trangThaiList[0]);

            return queryable.ByTrangThai(trangThaiList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByTrangThai(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.TrangThai));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByChuThich(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, string chuThich)
        {
            // support nulls
            return chuThich == null 
                ? queryable.Where(k => k.ChuThich == null) 
                : queryable.Where(k => k.ChuThich == chuThich);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByChuThich(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, ContainmentOperator containmentOperator, string chuThich)
        {
            if (chuThich == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("chuThich", "Parameter 'chuThich' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(k => k.ChuThich.Contains(chuThich));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(k => k.ChuThich.StartsWith(chuThich));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(k => k.ChuThich.EndsWith(chuThich));
                case ContainmentOperator.NotContains:
                    return queryable.Where(k => k.ChuThich.Contains(chuThich) == false);
                case ContainmentOperator.NotEquals:
                    return chuThich == null 
                        ? queryable.Where(k => k.ChuThich != null) 
                        : queryable.Where(k => k.ChuThich != chuThich);
                default:
                    return chuThich == null 
                        ? queryable.Where(k => k.ChuThich == null) 
                        : queryable.Where(k => k.ChuThich == chuThich);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByChuThich(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, string chuThich, params string[] additionalValues)
        {
            var chuThichList = new List<string> { chuThich };

            if (additionalValues != null)
                chuThichList.AddRange(additionalValues);
            else
                chuThichList.Add(null);

            if (chuThichList.Count == 1)
                return queryable.ByChuThich(chuThichList[0]);

            return queryable.ByChuThich(chuThichList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuNhapNbCt.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> ByChuThich(this IQueryable<INVENTORY.Data.KhPhieuNhapNbCt> queryable, IEnumerable<string> values)
        {
            // creating dynamic expression to support nulls
            var expression = DynamicExpression.BuildExpression<INVENTORY.Data.KhPhieuNhapNbCt, bool>("ChuThich", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.KhPhieuNhapNbCt> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.KhPhieuNhapNbCt.FirstOrDefault(k => k.Id == id));
            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, System.Guid, System.Guid, INVENTORY.Data.KhPhieuNhapNbCt> GetByIdPhieuNhapNbIdLoaiVatTuIdSanPham =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid idPhieuNhapNb, System.Guid idLoaiVatTu, System.Guid idSanPham) =>
                        db.KhPhieuNhapNbCt.FirstOrDefault(k => k.IdPhieuNhapNb == idPhieuNhapNb 
							&& k.IdLoaiVatTu == idLoaiVatTu 
							&& k.IdSanPham == idSanPham));

        }
        #endregion
    }
}
#pragma warning restore 1591
