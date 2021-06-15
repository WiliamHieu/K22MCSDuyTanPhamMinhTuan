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
    /// The query extension class for KhSanPham.
    /// </summary>
    public static partial class KhSanPhamExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhSanPham GetByKey(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhSanPham>;
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
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.KhSanPham> table, System.Guid id)
        {
            return table.Delete(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ById(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid id)
        {
            return queryable.Where(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ById(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, System.Guid id)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ById(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ById(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdSanPham(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idSanPham)
        {
            return queryable.Where(k => k.IdSanPham == idSanPham);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdSanPham(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, System.Guid idSanPham)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdSanPham(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idSanPham, params System.Guid[] additionalValues)
        {
            var idSanPhamList = new List<System.Guid> { idSanPham };

            if (additionalValues != null)
                idSanPhamList.AddRange(additionalValues);

            if (idSanPhamList.Count == 1)
                return queryable.ByIdSanPham(idSanPhamList[0]);

            return queryable.ByIdSanPham(idSanPhamList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdSanPham(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdSanPham));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int idKhoHang)
        {
            return queryable.Where(k => k.IdKhoHang == idKhoHang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, int idKhoHang)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int idKhoHang, params int[] additionalValues)
        {
            var idKhoHangList = new List<int> { idKhoHang };

            if (additionalValues != null)
                idKhoHangList.AddRange(additionalValues);

            if (idKhoHangList.Count == 1)
                return queryable.ByIdKhoHang(idKhoHangList[0]);

            return queryable.ByIdKhoHang(idKhoHangList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdKhoHang(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.IdKhoHang));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdNguonNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguonNhap">IdNguonNhap to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdNguonNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idNguonNhap)
        {
            return queryable.Where(k => k.IdNguonNhap == idNguonNhap);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdNguonNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguonNhap">IdNguonNhap to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdNguonNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, System.Guid idNguonNhap)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdNguonNhap != idNguonNhap);
                default:
                    return queryable.Where(k => k.IdNguonNhap == idNguonNhap);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdNguonNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguonNhap">IdNguonNhap to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdNguonNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idNguonNhap, params System.Guid[] additionalValues)
        {
            var idNguonNhapList = new List<System.Guid> { idNguonNhap };

            if (additionalValues != null)
                idNguonNhapList.AddRange(additionalValues);

            if (idNguonNhapList.Count == 1)
                return queryable.ByIdNguonNhap(idNguonNhapList[0]);

            return queryable.ByIdNguonNhap(idNguonNhapList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdNguonNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdNguonNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdNguonNhap));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idLoaiVatTu)
        {
            return queryable.Where(k => k.IdLoaiVatTu == idLoaiVatTu);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, System.Guid idLoaiVatTu)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idLoaiVatTu">IdLoaiVatTu to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.Guid idLoaiVatTu, params System.Guid[] additionalValues)
        {
            var idLoaiVatTuList = new List<System.Guid> { idLoaiVatTu };

            if (additionalValues != null)
                idLoaiVatTuList.AddRange(additionalValues);

            if (idLoaiVatTuList.Count == 1)
                return queryable.ByIdLoaiVatTu(idLoaiVatTuList[0]);

            return queryable.ByIdLoaiVatTu(idLoaiVatTuList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.IdLoaiVatTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByIdLoaiVatTu(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdLoaiVatTu));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongNhap">SoLuongNhap to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int soLuongNhap)
        {
            return queryable.Where(k => k.SoLuongNhap == soLuongNhap);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongNhap">SoLuongNhap to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, int soLuongNhap)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.SoLuongNhap > soLuongNhap);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.SoLuongNhap >= soLuongNhap);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.SoLuongNhap < soLuongNhap);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.SoLuongNhap <= soLuongNhap);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.SoLuongNhap != soLuongNhap);
                default:
                    return queryable.Where(k => k.SoLuongNhap == soLuongNhap);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongNhap">SoLuongNhap to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int soLuongNhap, params int[] additionalValues)
        {
            var soLuongNhapList = new List<int> { soLuongNhap };

            if (additionalValues != null)
                soLuongNhapList.AddRange(additionalValues);

            if (soLuongNhapList.Count == 1)
                return queryable.BySoLuongNhap(soLuongNhapList[0]);

            return queryable.BySoLuongNhap(soLuongNhapList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongNhap"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongNhap(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.SoLuongNhap));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongTon"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongTon">SoLuongTon to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongTon(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int soLuongTon)
        {
            return queryable.Where(k => k.SoLuongTon == soLuongTon);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongTon"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongTon">SoLuongTon to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongTon(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, int soLuongTon)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.SoLuongTon > soLuongTon);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.SoLuongTon >= soLuongTon);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.SoLuongTon < soLuongTon);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.SoLuongTon <= soLuongTon);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.SoLuongTon != soLuongTon);
                default:
                    return queryable.Where(k => k.SoLuongTon == soLuongTon);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongTon"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuongTon">SoLuongTon to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongTon(this IQueryable<INVENTORY.Data.KhSanPham> queryable, int soLuongTon, params int[] additionalValues)
        {
            var soLuongTonList = new List<int> { soLuongTon };

            if (additionalValues != null)
                soLuongTonList.AddRange(additionalValues);

            if (soLuongTonList.Count == 1)
                return queryable.BySoLuongTon(soLuongTonList[0]);

            return queryable.BySoLuongTon(soLuongTonList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.SoLuongTon"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> BySoLuongTon(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.SoLuongTon));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.NgayTao"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTao">NgayTao to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByNgayTao(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.DateTime ngayTao)
        {
            return queryable.Where(k => k.NgayTao == ngayTao);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.NgayTao"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTao">NgayTao to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByNgayTao(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ComparisonOperator comparisonOperator, System.DateTime ngayTao)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(k => k.NgayTao > ngayTao);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(k => k.NgayTao >= ngayTao);
                case ComparisonOperator.LessThan:
                    return queryable.Where(k => k.NgayTao < ngayTao);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(k => k.NgayTao <= ngayTao);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.NgayTao != ngayTao);
                default:
                    return queryable.Where(k => k.NgayTao == ngayTao);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.NgayTao"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ngayTao">NgayTao to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByNgayTao(this IQueryable<INVENTORY.Data.KhSanPham> queryable, System.DateTime ngayTao, params System.DateTime[] additionalValues)
        {
            var ngayTaoList = new List<System.DateTime> { ngayTao };

            if (additionalValues != null)
                ngayTaoList.AddRange(additionalValues);

            if (ngayTaoList.Count == 1)
                return queryable.ByNgayTao(ngayTaoList[0]);

            return queryable.ByNgayTao(ngayTaoList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.NgayTao"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByNgayTao(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(k => values.Contains(k.NgayTao));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByChuThich(this IQueryable<INVENTORY.Data.KhSanPham> queryable, string chuThich)
        {
            // support nulls
            return chuThich == null 
                ? queryable.Where(k => k.ChuThich == null) 
                : queryable.Where(k => k.ChuThich == chuThich);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByChuThich(this IQueryable<INVENTORY.Data.KhSanPham> queryable, ContainmentOperator containmentOperator, string chuThich)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByChuThich(this IQueryable<INVENTORY.Data.KhSanPham> queryable, string chuThich, params string[] additionalValues)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhSanPham.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhSanPham> ByChuThich(this IQueryable<INVENTORY.Data.KhSanPham> queryable, IEnumerable<string> values)
        {
            // creating dynamic expression to support nulls
            var expression = DynamicExpression.BuildExpression<INVENTORY.Data.KhSanPham, bool>("ChuThich", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.KhSanPham> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.KhSanPham.FirstOrDefault(k => k.Id == id));

        }
        #endregion
    }
}
#pragma warning restore 1591
