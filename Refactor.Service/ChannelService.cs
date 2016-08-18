using Lib.Refactor;
using Lib.Refactor.Enums;
using Refactor.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Service
{
    public class ChannelService : IChannelService
    {
        /// <summary>
        /// 模擬頻道類別對應表
        /// </summary>
        /// <param name="channelID">The channel identifier.</param>
        /// <returns>Channel.</returns>
        public Channel Get(string channelID)
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
