using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFamaintenaceHist
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public string Narration { get; set; }
        public decimal? Tranamount { get; set; }
        public byte[] TranDate { get; set; }
        public int? ExpMethod { get; set; }
        public string Drgl { get; set; }
        public string Crgl { get; set; }
        public int? MaintType { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
