using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFaclass
    {
        [Key]
        public int Id { get; set; }
        public string CatCode { get; set; }
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int? DepMethod { get; set; }
        public decimal? DepRate { get; set; }
        public int? LifeSpan { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
