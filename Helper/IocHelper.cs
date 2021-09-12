using Autofac;

namespace Homework_SkillTree.Helper
{
    public class IocHelper
    {
        public static IocHelper Instance { get; } = new IocHelper();

        public IContainer Container { get; set; }

        public static T Resolve<T>()
        {
            return Instance.Container.Resolve<T>();
        }
    }
}