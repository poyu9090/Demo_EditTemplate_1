using Lib.Refactor;
using System.Collections.Generic;
using System.Linq;
using Ploeh.AutoFixture;
using Lib.Refactor.Enums;
using System;
using Refactor.Repository.Interface;

namespace Refactor.Repository
{
    /// <summary>
    /// POI A供應商
    /// </summary>
    internal class ASupplierRepository : ISupplierRepository
    {
        public List<POI> Get()
        {
            Random rnd = new Random();

            //隨機建立十筆Supplier為A的資料回傳
            var fixture = new Fixture();
            var Result = fixture.Build<POI>()
                            .With(x => x.Name, string.Concat("捷運", rnd.Next(1, 100)))
                            .With(x => x.Supplier, SupplierEnum.A)
                            .CreateMany().ToList();

            return Result;
        }
    }
}
