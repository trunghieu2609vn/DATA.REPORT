using DATA.REPORT.Library.Util;

namespace DATA.REPORT.Core
{
    public static class Startup
    {
        /// <summary>
        /// Inject for app
        /// </summary>
        /// <param name="services"></param>
        public static void AddDependenceInjection(this IServiceCollection services)
        {
            services.AddTransient<ISerializeUtil, SerializeUtil>();
            services.AddTransient<IConfigUtil, ConfigUtil>();

        }
    }
}
