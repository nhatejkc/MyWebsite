using MyWebsite.Core;
using MyWebsite.Core.Models;
using MyWebsite.Core.Services;
using MyWebsite.Presentation.Controllers;
using MyWebsite.Presentation.Models;
using System;

using Unity;
using Unity.Injection;

namespace MyWebsite.Presentation
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IGenericRepository<Lession>, GenericRepository<Lession>>();
            container.RegisterType<IGenericRepository<Actor>, GenericRepository<Actor>>();
            container.RegisterType<IGenericRepository<Grammar>, GenericRepository<Grammar>>();
            container.RegisterType<IGenericRepository<Topic>, GenericRepository<Topic>>();
            container.RegisterType<IGenericRepository<QuestionItem>, GenericRepository<QuestionItem>>();
            container.RegisterType<IGenericRepository<Question>, GenericRepository<Question>>();
            container.RegisterType<IGenericRepository<SoundConservation>, GenericRepository<SoundConservation>>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<UsersAdminController>(new InjectionConstructor());
            container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<ISoundConservationsService, SoundConservationsService>();

           

        }
    }
}