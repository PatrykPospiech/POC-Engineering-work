// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace POC.Calc.API.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using POC.Calc.API.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using POC.Calc.API.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\_Imports.razor"
using POC.Calc.API.ComponentsFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\Pages\ProductsTable.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\Pages\ProductsTable.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class ProductsTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Web\Pages\ProductsTable.razor"
       

    List<DatabaseModel> DatabaseModels = new List<DatabaseModel>();
    //LoadDataFromAPI();

    protected override async Task OnInitializedAsync()
    {
        var databaseModels = new List<DatabaseModel>();

        var httpClient = new HttpClient();

        var response = await httpClient.GetAsync("https://localhost:5001/api/entry");

        response.EnsureSuccessStatusCode();


        //DatabaseModels = databaseModels;

        using var responseStream = await response.Content.ReadAsStreamAsync();
        DatabaseModels = await JsonSerializer.DeserializeAsync
        <List<DatabaseModel>>(responseStream);

    }






#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591