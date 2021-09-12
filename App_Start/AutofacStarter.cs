using Autofac;
using Homework_SkillTree.Helper;
using Homework_SkillTree.Models;
using Homework_SkillTree.Service;

namespace Homework_SkillTree
{
    public static class AutofacStarter
    {
        public static void RegisterAutofac()
        {
            Configuration();
        }

        private static void Configuration()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);
            Build(builder);
        }

        private static void Build(ContainerBuilder builder)
        {
            var container = builder.Build();
            IocHelper.Instance.Container = container;
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<AccountService>();
            builder.RegisterType<Model1>();
        }
    }
}