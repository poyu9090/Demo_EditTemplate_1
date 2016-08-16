using Lib.Refactor;
using Lib.Refactor.Enums;
using Refactor.Repository;
using Refactor.Repository.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Service
{
    public class POIService
    {
        public List<POI> Get(string channelID)
        {
            var Result = new List<POI>();

            var channel = GetChannel(channelID);

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


        /// <summary>
        /// 模擬頻道類別對應表
        /// </summary>
        /// <param name="channelID">The channel identifier.</param>
        /// <returns>Channel.</returns>
        Channel GetChannel(string channelID)
        {
            if (channelID == "1")
            {
                return new Channel
                {
                    ID = "1",
                    Categorys = new List<Channel.Category>
                    {
                        new Channel.Category
                        {
                            Name = "交通",
                            Supplier =new List<SupplierEnum> { SupplierEnum.A }
                        }
                    }
                };
            }

            return new Channel
            {
                ID = channelID,
                Categorys = new List<Channel.Category>
                {
                    new Channel.Category
                    {
                        Name = "交通",
                        Supplier = new List<SupplierEnum> { SupplierEnum.A , SupplierEnum.B }
                    }
                }
            };
        }
    }
}
