﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblFacategory
    {
        public int Id { get; set; }
        public string CatCode { get; set; }
        public string CatDesc { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string AuthId { get; set; }
    }
}
