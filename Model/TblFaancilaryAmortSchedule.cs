using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFaancilaryAmortSchedule
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public string CostCode { get; set; }
        public decimal? MonthlyRunRate { get; set; }
        public DateTime? NextAmortDate { get; set; }
        public int? Status { get; set; }
    }
}
