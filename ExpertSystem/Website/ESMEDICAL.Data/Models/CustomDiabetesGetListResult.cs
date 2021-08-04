using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Rules;

namespace ESMEDICAL.Data
{
    public partial class CustomDiabetesGetListResult
    {
        // Place custom code here.

        #region Metadata
        // For more information about how to use the metadata class visit:
        // http://www.plinqo.com/metadata.ashx
        [CodeSmith.Data.Audit.Audit]
        internal class Metadata
        {
             // WARNING: Only attributes inside of this class will be preserved.

            public int Id { get; set; }

            public short Age { get; set; }

            [Required]
            public string Gender { get; set; }

            public string Polyuria { get; set; }

            public string Polydipsia { get; set; }

            public string SuddenWeightLoss { get; set; }

            public string Weakness { get; set; }

            public string Polyphagia { get; set; }

            public string GenitalThrush { get; set; }

            public string VisualBlurring { get; set; }

            public string Itching { get; set; }

            public string Irritability { get; set; }

            public string DelayedHealing { get; set; }

            public string PartialParesis { get; set; }

            public string MuscleStiffness { get; set; }

            public string Alopecia { get; set; }

            public string Obesity { get; set; }

            [Required]
            public string Class { get; set; }

            [Now(EntityState.New)]
            [CodeSmith.Data.Audit.NotAudited]
            public System.DateTime CreatedDate { get; set; }

            [Required]
            public string CreatedBy { get; set; }

            public long? RowNumber { get; set; }

            public int? TotalPages { get; set; }

        }

        #endregion
    }
}