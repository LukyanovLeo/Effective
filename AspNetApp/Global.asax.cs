using NLog;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetApp
{
	public class MvcApplication : System.Web.HttpApplication
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		protected void Application_Start()
		{
			logger.Info("Application started");

			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}

		public void Init()
		{
			logger.Info("Application Init");
		}

		public void Dispose()
		{
			logger.Info("Application Dispose");
		}

		protected void Application_Error()
		{
			logger.Info("Application Error");
		}
		
		protected void Application_End()
		{
			logger.Info("Application End");
		}
	}
}
