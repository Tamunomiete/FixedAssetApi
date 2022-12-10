using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFarevaluation
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public decimal? PrevValue { get; set; }
        public decimal? CurrentValue { get; set; }
        public byte[] RevDate { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
