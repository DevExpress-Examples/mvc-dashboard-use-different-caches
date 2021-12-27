Imports System
Imports System.Web.Hosting
Imports System.Web.Routing
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.Excel
Imports DevExpress.DataAccess.Sql

Namespace MvcDashboardUseDifferentCaches
	Public Module DashboardConfig
		Public Sub RegisterService(ByVal routes As RouteCollection)
			routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")

			Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
			DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

			' Uncomment this string to allow end users to create new data sources based on predefined connection strings.
			'DashboardConfigurator.Default.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());

			Dim dataSourceStorage As New DataSourceInMemoryStorage()

			' Registers an SQL data source.
			Dim sqlDataSource As New DashboardSqlDataSource("SQL Data Source", "NWindConnectionString")
			Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("SalesPerson").SelectAllColumns().Build("Sales Person")
			sqlDataSource.Queries.Add(query)
			dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml())

			DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)

			AddHandler DashboardConfigurator.Default.CustomParameters, AddressOf Default_CustomParameters
		End Sub

		Private Sub Default_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
			e.Parameters.Add(New DashboardParameter("UniqueCacheParam", GetType(Guid), CacheManager.UniqueCacheParam))
		End Sub
	End Module
End Namespace