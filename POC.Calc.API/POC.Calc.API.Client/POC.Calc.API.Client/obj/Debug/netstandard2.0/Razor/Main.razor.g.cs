#pragma checksum "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23dc9e63ca7b5ecba1e6df24c3458ef15f28d480"
// <auto-generated/>
#pragma warning disable 1591
namespace POC.Calc.API.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
    public partial class Main : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.MobileBlazorBindings.Elements.ContentView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.MobileBlazorBindings.Elements.StackLayout>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n\r\n        ");
                    __builder3.OpenComponent<Microsoft.MobileBlazorBindings.Elements.StackLayout>(6);
                    __builder3.AddAttribute(7, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.Thickness?>(
#line 6 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                             new Thickness(20)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(8, "Orientation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.StackOrientation?>(
#line 6 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                                             StackOrientation.Horizontal

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __builder4.OpenComponent<Microsoft.MobileBlazorBindings.Elements.Label>(11);
                        __builder4.AddAttribute(12, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                           $"Hello, World! {CounterState.CurrentCount}"

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(13, "FontSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 7 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                                                                    40

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(14, "HorizontalOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.LayoutOptions?>(
#line 7 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                                                                                           LayoutOptions.StartAndExpand

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<Microsoft.MobileBlazorBindings.Elements.Button>(16);
                        __builder4.AddAttribute(17, "Text", "Increment");
                        __builder4.AddAttribute(18, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 8 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                               CounterState.IncrementCount

#line default
#line hidden
                        )));
                        __builder4.AddAttribute(19, "VerticalOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.LayoutOptions?>(
#line 8 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                                                                             LayoutOptions.Center

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(20, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.Thickness?>(
#line 8 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                                                                                                            10

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\r\n        ");
                    __builder3.OpenComponent<Microsoft.MobileBlazorBindings.Elements.BlazorWebView>(23);
                    __builder3.AddAttribute(24, "VerticalOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.LayoutOptions?>(
#line 11 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
                                        LayoutOptions.FillAndExpand

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<POC.Calc.API.Client.WebUI.App>(27);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 19 "C:\Users\Patryk\Documents\GitHub\POC-Engineering-work\POC.Calc.API\POC.Calc.API.Client\POC.Calc.API.Client\Main.razor"
       

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