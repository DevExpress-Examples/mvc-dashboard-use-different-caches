_Files to look at:_

- [Index.cshtml](/CS/MvcDashboardUseDifferentCaches/Views/Home/Index.cshtml) (VB: [Index.cshtml](/VB/MvcDashboardUseDifferentCaches/Views/Home/Index.cshtml))
- [HomeController.cs](/CS/MvcDashboardUseDifferentCaches/Controllers/HomeController.cs) (VB: [HomeController.vb](/VB/MvcDashboardUseDifferentCaches/Controllers/HomeController.vb))
- [Global.asax.cs](/CS/MvcDashboardUseDifferentCaches/Global.asax.cs) (VB: [Global.asax.vb](/VB/MvcDashboardUseDifferentCaches/Global.asax.vb))
- [CacheManager.cs](/CS/MvcDashboardUseDifferentCaches/CacheManager.cs) (VB: [CacheManager.vb](/VB/MvcDashboardUseDifferentCaches/CacheManager.vb))

# How to Reset the Cache Forcedly in MVC Dashboard

To refresh the data source cache on the server side, pass a unique parameter value to the [DashboardConfigurator.CustomParameters](http://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.CustomParameters) event.

For instance, you can store a unique GUID value within a session as a parameter and update its value in your code when it is necessary to refresh the cache.

Use the **Refresh Cache** button to update the cache forcedly.

Note that you can refresh the data source cache on the client side. For this, call the [ASPxClientDashboard.ReloadData](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_ASPxClientDashboard_ReloadData) or [DashboardControl.reloadData](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl#js_DevExpress_Dashboard_DashboardControl_reloadData) client methods.

See [Manage an In-Memory Data Cache](https://docs.devexpress.com/Dashboard/400983) for details.
