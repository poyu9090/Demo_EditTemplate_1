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
            //TransientLifetimeManager���o�ӹ��骺�ЫإͩR�g��
            //��ܰ���{���ɡA�C���I��IPOIService���|�hnew �@�ӷs��POIService
            //Unity���\�h�ͩR�g���i�H�ϥΡA�i�H�Ѧҩx�誺���
            //�ҦpPerResolveLifetimeManager�N�O����Request�u��New�@������A�p�G�P��Request�I��h��
            //���٬O�|��^�Ĥ@��New������A����Reqeust�����~�|�Q������,Singleton������
            container.RegisterType<IPOIService, POIService>(new TransientLifetimeManager());
            container.RegisterType<IChannelService, ChannelService>(new TransientLifetimeManager());
        }
    }
}
