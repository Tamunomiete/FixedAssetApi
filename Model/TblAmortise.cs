using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblAmortise
    {
        public int Id { get; set; }
        public string Transtype { get; set; }
        public int? Status { get; set; }
    }
}
