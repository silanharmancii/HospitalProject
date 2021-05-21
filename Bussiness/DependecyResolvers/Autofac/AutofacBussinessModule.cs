using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussiness.Abstract;
using Bussiness.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.DependecyResolvers.Autofac
{
    public class AutofacBussinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClinicManager>().As<IClinicService>().SingleInstance();
            builder.RegisterType<EfClinicDal>().As<IClinicDal>().SingleInstance();

            builder.RegisterType<EquipmentManager>().As<IEquipmentService>().SingleInstance();
            builder.RegisterType<EfEquipmentDal>().As<IEquipmentDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
