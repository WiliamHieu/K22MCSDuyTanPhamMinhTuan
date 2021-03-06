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
    /// The query extension class for DmNhomVatTu.
    /// </summary>
    public static partial class DmNhomVatTuExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.DmNhomVatTu GetByKey(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.DmNhomVatTu>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, id);

            return queryable.FirstOrDefault(d => d.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.DmNhomVatTu> table, System.Guid id)
        {
            return table.Delete(d => d.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ById(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, System.Guid id)
        {
            return queryable.Where(d => d.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ById(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, ComparisonOperator comparisonOperator, System.Guid id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(d => d.Id != id);
                default:
                    return queryable.Where(d => d.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ById(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ById(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(d => values.Contains(d.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Ten"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ten">Ten to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTen(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, string ten)
        {
            return queryable.Where(d => d.Ten == ten);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Ten"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ten">Ten to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTen(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, ContainmentOperator containmentOperator, string ten)
        {
            if (ten == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("ten", "Parameter 'ten' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(d => d.Ten.Contains(ten));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(d => d.Ten.StartsWith(ten));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(d => d.Ten.EndsWith(ten));
                case ContainmentOperator.NotContains:
                    return queryable.Where(d => d.Ten.Contains(ten) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(d => d.Ten != ten);
                default:
                    return queryable.Where(d => d.Ten == ten);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Ten"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="ten">Ten to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTen(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, string ten, params string[] additionalValues)
        {
            var tenList = new List<string> { ten };

            if (additionalValues != null)
                tenList.AddRange(additionalValues);

            if (tenList.Count == 1)
                return queryable.ByTen(tenList[0]);

            return queryable.ByTen(tenList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.Ten"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTen(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, IEnumerable<string> values)
        {
            return queryable.Where(d => values.Contains(d.Ten));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ThuTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thuTu">ThuTu to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByThuTu(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, int thuTu)
        {
            return queryable.Where(d => d.ThuTu == thuTu);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ThuTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thuTu">ThuTu to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByThuTu(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, ComparisonOperator comparisonOperator, int thuTu)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(d => d.ThuTu > thuTu);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(d => d.ThuTu >= thuTu);
                case ComparisonOperator.LessThan:
                    return queryable.Where(d => d.ThuTu < thuTu);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(d => d.ThuTu <= thuTu);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(d => d.ThuTu != thuTu);
                default:
                    return queryable.Where(d => d.ThuTu == thuTu);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ThuTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="thuTu">ThuTu to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByThuTu(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, int thuTu, params int[] additionalValues)
        {
            var thuTuList = new List<int> { thuTu };

            if (additionalValues != null)
                thuTuList.AddRange(additionalValues);

            if (thuTuList.Count == 1)
                return queryable.ByThuTu(thuTuList[0]);

            return queryable.ByThuTu(thuTuList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ThuTu"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByThuTu(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, IEnumerable<int> values)
        {
            return queryable.Where(d => values.Contains(d.ThuTu));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTrangThai(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, int trangThai)
        {
            return queryable.Where(d => d.TrangThai == trangThai);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTrangThai(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, ComparisonOperator comparisonOperator, int trangThai)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(d => d.TrangThai > trangThai);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(d => d.TrangThai >= trangThai);
                case ComparisonOperator.LessThan:
                    return queryable.Where(d => d.TrangThai < trangThai);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(d => d.TrangThai <= trangThai);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(d => d.TrangThai != trangThai);
                default:
                    return queryable.Where(d => d.TrangThai == trangThai);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="trangThai">TrangThai to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTrangThai(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, int trangThai, params int[] additionalValues)
        {
            var trangThaiList = new List<int> { trangThai };

            if (additionalValues != null)
                trangThaiList.AddRange(additionalValues);

            if (trangThaiList.Count == 1)
                return queryable.ByTrangThai(trangThaiList[0]);

            return queryable.ByTrangThai(trangThaiList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.TrangThai"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByTrangThai(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, IEnumerable<int> values)
        {
            return queryable.Where(d => values.Contains(d.TrangThai));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByChuThich(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, string chuThich)
        {
            // support nulls
            return chuThich == null 
                ? queryable.Where(d => d.ChuThich == null) 
                : queryable.Where(d => d.ChuThich == chuThich);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByChuThich(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, ContainmentOperator containmentOperator, string chuThich)
        {
            if (chuThich == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("chuThich", "Parameter 'chuThich' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(d => d.ChuThich.Contains(chuThich));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(d => d.ChuThich.StartsWith(chuThich));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(d => d.ChuThich.EndsWith(chuThich));
                case ContainmentOperator.NotContains:
                    return queryable.Where(d => d.ChuThich.Contains(chuThich) == false);
                case ContainmentOperator.NotEquals:
                    return chuThich == null 
                        ? queryable.Where(d => d.ChuThich != null) 
                        : queryable.Where(d => d.ChuThich != chuThich);
                default:
                    return chuThich == null 
                        ? queryable.Where(d => d.ChuThich == null) 
                        : queryable.Where(d => d.ChuThich == chuThich);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="chuThich">ChuThich to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByChuThich(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, string chuThich, params string[] additionalValues)
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
        /// Gets a query for <see cref="INVENTORY.Data.DmNhomVatTu.ChuThich"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.DmNhomVatTu> ByChuThich(this IQueryable<INVENTORY.Data.DmNhomVatTu> queryable, IEnumerable<string> values)
        {
            // creating dynamic expression to support nulls
            var expression = DynamicExpression.BuildExpression<INVENTORY.Data.DmNhomVatTu, bool>("ChuThich", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.DmNhomVatTu> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.DmNhomVatTu.FirstOrDefault(d => d.Id == id));

        }
        #endregion
    }
}
#pragma warning restore 1591
