using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFaancilaryCostTran
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public string CostCode { get; set; }
        public decimal? Amount { get; set; }
        public byte[] TranDate { get; set; }
        public string Narration { get; set; }
        public int? ExpMethod { get; set; }
        public string Draccount { get; set; }
        public string Craccount { get; set; }
        public decimal? MonthlyRunRate { get; set; }
        public DateTime? NextAmortDate { get; set; }
        public decimal? AmountPaid { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
