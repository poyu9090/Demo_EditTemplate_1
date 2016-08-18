using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Refactor.Service.Interface;
using Refactor.Service;

namespace Refactor.Application.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            //TransientLifetimeManager為這個實體的創建生命週期
            //表示執行程式時，每次碰到IPOIService都會去new 一個新的POIService
            //Unity有許多生命週期可以使用，可以參考官方的文件
            //例如PerResolveLifetimeManager就是本次Request只有New一次實體，如果同個Request碰到多次
            //都還是會返回第一次New的實體，直到Reqeust結束才會被消滅掉,Singleton的概念
            container.RegisterType<IPOIService, POIService>(new TransientLifetimeManager());
            container.RegisterType<IChannelService, ChannelService>(new TransientLifetimeManager());
        }
    }
}
