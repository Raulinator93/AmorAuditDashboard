#pragma checksum "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "111ee0cc16c9cb98a59e885b4e0f07dbdc7ddf0e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDashboardApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using BlazorDashboardApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using BlazorDashboardApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using DevExpress.DashboardBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Diplomarbeit\Programmieren\Armorauditdash\BlazorDashboardApp\Client\_Imports.razor"
using DevExpress.DashboardWeb;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.DashboardBlazor.DxDashboard>(0);
            __builder.AddAttribute(1, "Endpoint", "api/dashboard");
            __builder.AddAttribute(2, "style", "width: 100%; height: 800px;");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
