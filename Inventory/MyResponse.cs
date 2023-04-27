using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory
{
    public class MyResponse
    {
        public List<tblItem> MyItemList { get; set; }
        public string StartTime { get; set; }
        public int CountDown { get; set; }

    }
}