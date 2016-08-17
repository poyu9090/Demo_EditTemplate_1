using Lib.Refactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Service.Interface
{
    public interface IPOIService
    {
        /// <summary>
        /// 取得屬於頻道的POI資料
        /// </summary>
        /// <param name="channelID">The channel identifier.</param>
        /// <returns>List&lt;POI&gt;.</returns>
        List<POI> Get(string channelID);
    }
}
