using Lib.Refactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.Service.Interface
{
    public interface IChannelService
    {
        Channel Get(string channelID);
    }
}
