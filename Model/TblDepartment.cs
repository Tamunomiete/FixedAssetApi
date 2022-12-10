using System;
using System.Collections.Generic;

#nullable disable

namespace FixedAssetApi.Model
{
    public partial class TblDepartment
    {
        public string Deptid { get; set; }
        public string DeptName { get; set; }
        public string DeptShortname { get; set; }
        public int? Status { get; set; }
        public string Userid { get; set; }
        public string Authid { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
