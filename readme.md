<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/188187813/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828693)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-use-different-caches&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-use-different-caches&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
