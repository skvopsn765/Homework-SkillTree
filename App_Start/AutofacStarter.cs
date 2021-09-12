using Autofac;
using Homework_SkillTree.Models;
using Homework_SkillTree.Service;

namespace Homework_SkillTree
{
    public class IocHelper
    {
        public static IocHelper Instance { get; set; } = new IocHelper();

        public IContainer Container { get; set; }

        public static T Resolve<T>()
        {
            return Instance.Container.Resolve<T>();
        }
    }

    public class AutofacStarter
    {
        private static readonly AutofacStarter Starter = new AutofacStarter();

        public static void RegisterAutofac()
        {
            Starter.Configuration();
        }

        private void Configuration()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);
            Build(builder);
        }

        private void Build(ContainerBuilder builder)
        {
            var container = builder.Build();
            IocHelper.Instance.Container = container;
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            // builder.RegisterType<AccountService>().As<IAccountService>().SingleInstance();
            builder.RegisterType<AccountService>();
            builder.RegisterType<Model1>();
        }
    }
}