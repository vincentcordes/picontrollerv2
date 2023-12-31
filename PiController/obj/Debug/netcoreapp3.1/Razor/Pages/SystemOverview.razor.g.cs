#pragma checksum "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51ba70613f63f25cde741d60885ea3d9a85714108884ea4557a63baa7e754318"
// <auto-generated/>
#pragma warning disable 1591
namespace PiController.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using PiController;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using PiController.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/system")]
    public partial class SystemOverview : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>System</h1>\n\n<br>\n");
            __builder.AddMarkupContent(1, "<h3>System Information</h3>\n");
            __builder.OpenElement(2, "h5");
            __builder.AddContent(3, "UpTime: ");
#nullable restore
#line 9 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(4, SystemControl.SystemManager.UpTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "h5");
            __builder.AddContent(7, "Board Model: ");
#nullable restore
#line 10 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(8, SystemControl.SystemManager.BoardModel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.OpenElement(10, "h5");
            __builder.AddContent(11, "Processor Count: ");
#nullable restore
#line 11 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(12, SystemControl.SystemManager.ProcessorCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
            __builder.OpenElement(14, "h5");
            __builder.AddContent(15, "Memory: ");
#nullable restore
#line 12 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(16, SystemControl.SystemManager.MemorySize);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n\n<br>\n");
            __builder.AddMarkupContent(18, "<h3>IP Adapter Information</h3>\n\n");
#nullable restore
#line 18 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
 foreach(var info in SystemControl.SystemManager.IPAdapterInformationList)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "h4");
#nullable restore
#line 20 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(21, info.AdapterType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "h5");
            __builder.AddContent(24, "Interface: ");
#nullable restore
#line 21 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(25, info.InterfaceType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "h5");
            __builder.AddContent(28, "IPAddress: ");
#nullable restore
#line 22 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(29, info.IPAddress);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.OpenElement(31, "h5");
            __builder.AddContent(32, "Operational Status: ");
#nullable restore
#line 23 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(33, info.OperationalStatus);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n    ");
            __builder.OpenElement(35, "h5");
            __builder.AddContent(36, "Dns Enabled: ");
#nullable restore
#line 24 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
__builder.AddContent(37, info.DNSEnabled);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    <br>\n");
#nullable restore
#line 26 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Pages\SystemOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.SystemControl.SystemControlService SystemControl { get; set; }
    }
}
#pragma warning restore 1591
