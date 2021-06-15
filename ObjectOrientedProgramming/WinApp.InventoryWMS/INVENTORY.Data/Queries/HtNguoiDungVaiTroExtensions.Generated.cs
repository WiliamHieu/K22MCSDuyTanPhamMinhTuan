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
    /// The query extension class for HtNguoiDungVaiTro.
    /// </summary>
    public static partial class HtNguoiDungVaiTroExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.HtNguoiDungVaiTro GetByKey(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.HtNguoiDungVaiTro>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, id);

            return queryable.FirstOrDefault(h => h.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static int Delete(this System.Data.Linq.Table<INVENTORY.Data.HtNguoiDungVaiTro> table, int id)
        {
            return table.Delete(h => h.Id == id);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static INVENTORY.Data.HtNguoiDungVaiTro GetByIdVaiTroIdNguoiDungIdKhoHang(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idVaiTro, int idNguoiDung, int idKhoHang)
        {
            var entity = queryable as System.Data.Linq.Table<INVENTORY.Data.HtNguoiDungVaiTro>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByIdVaiTroIdNguoiDungIdKhoHang.Invoke((INVENTORY.Data.InventoryDbContext)entity.Context, idVaiTro, idNguoiDung, idKhoHang);

            return queryable.FirstOrDefault(h => h.IdVaiTro == idVaiTro 
					&& h.IdNguoiDung == idNguoiDung 
					&& h.IdKhoHang == idKhoHang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ById(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int id)
        {
            return queryable.Where(h => h.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ById(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, ComparisonOperator comparisonOperator, int id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(h => h.Id > id);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(h => h.Id >= id);
                case ComparisonOperator.LessThan:
                    return queryable.Where(h => h.Id < id);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(h => h.Id <= id);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(h => h.Id != id);
                default:
                    return queryable.Where(h => h.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ById(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int id, params int[] additionalValues)
        {
            var idList = new List<int> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ById(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, IEnumerable<int> values)
        {
            return queryable.Where(h => values.Contains(h.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdNguoiDung"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguoiDung">IdNguoiDung to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdNguoiDung(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idNguoiDung)
        {
            return queryable.Where(h => h.IdNguoiDung == idNguoiDung);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdNguoiDung"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguoiDung">IdNguoiDung to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdNguoiDung(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, ComparisonOperator comparisonOperator, int idNguoiDung)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(h => h.IdNguoiDung > idNguoiDung);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(h => h.IdNguoiDung >= idNguoiDung);
                case ComparisonOperator.LessThan:
                    return queryable.Where(h => h.IdNguoiDung < idNguoiDung);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(h => h.IdNguoiDung <= idNguoiDung);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(h => h.IdNguoiDung != idNguoiDung);
                default:
                    return queryable.Where(h => h.IdNguoiDung == idNguoiDung);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdNguoiDung"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idNguoiDung">IdNguoiDung to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdNguoiDung(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idNguoiDung, params int[] additionalValues)
        {
            var idNguoiDungList = new List<int> { idNguoiDung };

            if (additionalValues != null)
                idNguoiDungList.AddRange(additionalValues);

            if (idNguoiDungList.Count == 1)
                return queryable.ByIdNguoiDung(idNguoiDungList[0]);

            return queryable.ByIdNguoiDung(idNguoiDungList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdNguoiDung"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdNguoiDung(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, IEnumerable<int> values)
        {
            return queryable.Where(h => values.Contains(h.IdNguoiDung));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdVaiTro"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idVaiTro">IdVaiTro to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdVaiTro(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idVaiTro)
        {
            return queryable.Where(h => h.IdVaiTro == idVaiTro);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdVaiTro"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idVaiTro">IdVaiTro to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdVaiTro(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, ComparisonOperator comparisonOperator, int idVaiTro)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(h => h.IdVaiTro > idVaiTro);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(h => h.IdVaiTro >= idVaiTro);
                case ComparisonOperator.LessThan:
                    return queryable.Where(h => h.IdVaiTro < idVaiTro);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(h => h.IdVaiTro <= idVaiTro);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(h => h.IdVaiTro != idVaiTro);
                default:
                    return queryable.Where(h => h.IdVaiTro == idVaiTro);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdVaiTro"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idVaiTro">IdVaiTro to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdVaiTro(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idVaiTro, params int[] additionalValues)
        {
            var idVaiTroList = new List<int> { idVaiTro };

            if (additionalValues != null)
                idVaiTroList.AddRange(additionalValues);

            if (idVaiTroList.Count == 1)
                return queryable.ByIdVaiTro(idVaiTroList[0]);

            return queryable.ByIdVaiTro(idVaiTroList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdVaiTro"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdVaiTro(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, IEnumerable<int> values)
        {
            return queryable.Where(h => values.Contains(h.IdVaiTro));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdKhoHang(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idKhoHang)
        {
            return queryable.Where(h => h.IdKhoHang == idKhoHang);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdKhoHang(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, ComparisonOperator comparisonOperator, int idKhoHang)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(h => h.IdKhoHang > idKhoHang);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(h => h.IdKhoHang >= idKhoHang);
                case ComparisonOperator.LessThan:
                    return queryable.Where(h => h.IdKhoHang < idKhoHang);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(h => h.IdKhoHang <= idKhoHang);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(h => h.IdKhoHang != idKhoHang);
                default:
                    return queryable.Where(h => h.IdKhoHang == idKhoHang);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="idKhoHang">IdKhoHang to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdKhoHang(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, int idKhoHang, params int[] additionalValues)
        {
            var idKhoHangList = new List<int> { idKhoHang };

            if (additionalValues != null)
                idKhoHangList.AddRange(additionalValues);

            if (idKhoHangList.Count == 1)
                return queryable.ByIdKhoHang(idKhoHangList[0]);

            return queryable.ByIdKhoHang(idKhoHangList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.IdKhoHang"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByIdKhoHang(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, IEnumerable<int> values)
        {
            return queryable.Where(h => values.Contains(h.IdKhoHang));
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.MacDinh"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="macDinh">MacDinh to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByMacDinh(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, bool macDinh)
        {
            return queryable.Where(h => h.MacDinh == macDinh);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.MacDinh"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="macDinh">MacDinh to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByMacDinh(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, ComparisonOperator comparisonOperator, bool macDinh)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support bool type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(h => h.MacDinh != macDinh);
                default:
                    return queryable.Where(h => h.MacDinh == macDinh);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.MacDinh"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="macDinh">MacDinh to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByMacDinh(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, bool macDinh, params bool[] additionalValues)
        {
            var macDinhList = new List<bool> { macDinh };

            if (additionalValues != null)
                macDinhList.AddRange(additionalValues);

            if (macDinhList.Count == 1)
                return queryable.ByMacDinh(macDinhList[0]);

            return queryable.ByMacDinh(macDinhList);
        }

        /// <summary>
        /// Gets a query for <see cref="INVENTORY.Data.HtNguoiDungVaiTro.MacDinh"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> ByMacDinh(this IQueryable<INVENTORY.Data.HtNguoiDungVaiTro> queryable, IEnumerable<bool> values)
        {
            return queryable.Where(h => values.Contains(h.MacDinh));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, int, INVENTORY.Data.HtNguoiDungVaiTro> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, int id) =>
                        db.HtNguoiDungVaiTro.FirstOrDefault(h => h.Id == id));
            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<INVENTORY.Data.InventoryDbContext, int, int, int, INVENTORY.Data.HtNguoiDungVaiTro> GetByIdVaiTroIdNguoiDungIdKhoHang =
                System.Data.Linq.CompiledQuery.Compile(
                    (INVENTORY.Data.InventoryDbContext db, int idVaiTro, int idNguoiDung, int idKhoHang) =>
                        db.HtNguoiDungVaiTro.FirstOrDefault(h => h.IdVaiTro == idVaiTro 
							&& h.IdNguoiDung == idNguoiDung 
							&& h.IdKhoHang == idKhoHang));

        }
        #endregion
    }
}
#pragma warning restore 1591
