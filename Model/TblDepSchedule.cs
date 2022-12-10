using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblDepSchedule
    {
        public string AssetCode { get; set; }
        public int? Installment { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? YearlyDep { get; set; }
        public decimal? MonthlyDep { get; set; }
        public int? Status { get; set; }
    }
}
