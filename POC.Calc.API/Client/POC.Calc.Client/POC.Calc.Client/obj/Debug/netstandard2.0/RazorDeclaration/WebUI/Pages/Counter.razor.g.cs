// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace POC.Calc.Client.WebUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
#line 1 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\_Imports.razor"
using POC.Calc.Client.WebUI.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\Client\POC.Calc.Client\POC.Calc.Client\WebUI\Pages\Counter.razor"
       
    protected override void OnInitialized()
    {
        CounterState.StateChanged += StateHasChanged;
    }

    public void Dispose()
    {
        CounterState.StateChanged -= StateHasChanged;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterState CounterState { get; set; }
    }
}
#pragma warning restore 1591