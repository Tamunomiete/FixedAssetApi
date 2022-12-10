using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFaschMaintRecord
    {
        public int Id { get; set; }
        public string Facode { get; set; }
        public byte[] MaintDate { get; set; }
        public DateTime? NextMaintDate { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
