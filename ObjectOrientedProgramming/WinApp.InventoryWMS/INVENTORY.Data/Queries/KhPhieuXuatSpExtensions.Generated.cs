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
    /// The query extension class for KhPhieuXuatSp.
    /// </summary>
    public static partial class KhPhieuXuatSpExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.KhPhieuXuatSp GetByKey(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.KhPhieuXuatSp>;
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
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.KhPhieuXuatSp> table, System.Guid id)
        {
            return table.Delete(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ById(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid id)
        {
            return queryable.Where(k => k.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ById(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, ComparisonOperator comparisonOperator, System.Guid id)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ById(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ById(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdPhieuXuatCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuXuatCt">IdPhieuXuatCt to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdPhieuXuatCt(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid idPhieuXuatCt)
        {
            return queryable.Where(k => k.IdPhieuXuatCt == idPhieuXuatCt);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdPhieuXuatCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuXuatCt">IdPhieuXuatCt to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdPhieuXuatCt(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, ComparisonOperator comparisonOperator, System.Guid idPhieuXuatCt)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(k => k.IdPhieuXuatCt != idPhieuXuatCt);
                default:
                    return queryable.Where(k => k.IdPhieuXuatCt == idPhieuXuatCt);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdPhieuXuatCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idPhieuXuatCt">IdPhieuXuatCt to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdPhieuXuatCt(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid idPhieuXuatCt, params System.Guid[] additionalValues)
        {
            var idPhieuXuatCtList = new List<System.Guid> { idPhieuXuatCt };

            if (additionalValues != null)
                idPhieuXuatCtList.AddRange(additionalValues);

            if (idPhieuXuatCtList.Count == 1)
                return queryable.ByIdPhieuXuatCt(idPhieuXuatCtList[0]);

            return queryable.ByIdPhieuXuatCt(idPhieuXuatCtList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdPhieuXuatCt"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdPhieuXuatCt(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdPhieuXuatCt));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid idSanPham)
        {
            return queryable.Where(k => k.IdSanPham == idSanPham);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, ComparisonOperator comparisonOperator, System.Guid idSanPham)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idSanPham">IdSanPham to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, System.Guid idSanPham, params System.Guid[] additionalValues)
        {
            var idSanPhamList = new List<System.Guid> { idSanPham };

            if (additionalValues != null)
                idSanPhamList.AddRange(additionalValues);

            if (idSanPhamList.Count == 1)
                return queryable.ByIdSanPham(idSanPhamList[0]);

            return queryable.ByIdSanPham(idSanPhamList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.IdSanPham"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> ByIdSanPham(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(k => values.Contains(k.IdSanPham));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, int soLuong)
        {
            return queryable.Where(k => k.SoLuong == soLuong);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, ComparisonOperator comparisonOperator, int soLuong)
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
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="soLuong">SoLuong to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, int soLuong, params int[] additionalValues)
        {
            var soLuongList = new List<int> { soLuong };

            if (additionalValues != null)
                soLuongList.AddRange(additionalValues);

            if (soLuongList.Count == 1)
                return queryable.BySoLuong(soLuongList[0]);

            return queryable.BySoLuong(soLuongList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.KhPhieuXuatSp.SoLuong"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.KhPhieuXuatSp> BySoLuong(this IQueryable<INVENTORY.Data.KhPhieuXuatSp> queryable, IEnumerable<int> values)
        {
            return queryable.Where(k => values.Contains(k.SoLuong));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, System.Guid, INVENTORY.Data.KhPhieuXuatSp> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, System.Guid id) =>
                        db.KhPhieuXuatSp.FirstOrDefault(k => k.Id == id));

        }
        #endregion
    }
}
#pragma warning restore 1591
