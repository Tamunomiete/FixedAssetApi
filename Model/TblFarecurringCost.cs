using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFarecurringCost
    {
        public int Id { get; set; }
        public string CostCode { get; set; }
        public string CostDesc { get; set; }
        public int? Amortized { get; set; }
        public int? Status { get; set; }
    }
}
