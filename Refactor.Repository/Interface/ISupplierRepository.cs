using Lib.Refactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Repository.Interface
{
    /// <summary>
    /// Interface ISupplierRepository
    /// </summary>
    public interface ISupplierRepository
    {
        /// <summary>
        /// 取得POI資料
        /// </summary>
        /// <returns>List&lt;POI&gt;.</returns>
        List<POI> Get();
    }
}
