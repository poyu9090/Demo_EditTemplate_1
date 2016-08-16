using Lib.Refactor;
using Lib.Refactor.Enums;
using Ploeh.AutoFixture;
using Refactor.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Repository
{
    /// <summary>
    /// POI B供應商
    /// </summary>
    internal class BSupplierRepository : ISupplierRepository
    {
        public List<POI> Get()
        {
            Random rnd = new Random();

            //隨機建立十筆Supplier為B的資料回傳
            var fixture = new Fixture();
            var Result = fixture.Build<POI>()
                            .With(x => x.Name, string.Concat("捷運", rnd.Next(1, 100)))
                            .With(x => x.Supplier, SupplierEnum.B)
                            .CreateMany().ToList();

            return Result;
        }
    }
}
