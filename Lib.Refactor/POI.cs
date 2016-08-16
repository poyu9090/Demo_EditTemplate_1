using Lib.Refactor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Refactor
{
    public class POI
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SupplierEnum Supplier { get; set; }
    }
}
