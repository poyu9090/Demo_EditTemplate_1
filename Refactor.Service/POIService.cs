using Lib.Refactor;
using Lib.Refactor.Enums;
using Refactor.Repository;
using Refactor.Repository.Factorys;
using Refactor.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Service
{
    public class POIService :IPOIService
    {
        IChannelService _ChannelService;
        public POIService(IChannelService channelService)
        {
            //DI
            _ChannelService = channelService;
        }

        public List<POI> Get(string channelID)
        {
            var Result = new List<POI>();

            //面對抽象
            var channel = _ChannelService.Get(channelID);

            //逐一搜尋頻道底下的各類別
            foreach (var category in channel.Categorys)
            {
                //依據該類別所指定的供應商向Repository要資料
                category.Supplier.ForEach(x =>
                {
                    var Repository = SupplierFactory.Generate(x);
                    var POIs = Repository.Get();
                    Result.AddRange(POIs);
                });
            }

            //並接總合的結果回傳
            return Result;
        }
    }
}
