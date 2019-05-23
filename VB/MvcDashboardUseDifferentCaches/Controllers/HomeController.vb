Imports System.Web.Mvc

Namespace MvcDashboardUseDifferentCaches.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function Refresh() As ActionResult
			CacheManager.ResetCache()
			Return New EmptyResult()
		End Function
	End Class
End Namespace