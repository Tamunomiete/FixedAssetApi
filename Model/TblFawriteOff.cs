using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFawriteOff
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public decimal? DisposalAmt { get; set; }
        public decimal? OtherCostWriteoff { get; set; }
        public byte[] TranDate { get; set; }
        public string Narration { get; set; }
        public string Drgl { get; set; }
        public string Crgl { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
