using Lib.Refactor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Refactor
{
    public class Channel
    {
        public string ID { get; set; }
        public List<Category> Categorys { get; set; }

        public class Category
        {
            public string Name { get; set; }
            public List<SupplierEnum> Supplier { get; set; }
        }
    }
}
