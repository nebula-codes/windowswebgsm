#pragma checksum "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "986bceb78cc416d846fc896e69edc3282dba343d"
// <auto-generated/>
#pragma warning disable 1591
namespace windowswebgsm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using windowswebgsm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using windowswebgsm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Panda\source\repos\windowswebgsm\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
using windowswebgsm.Data.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 3 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                         currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(9);
                __builder2.AddAttribute(10, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                        1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Fixed", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(14);
                    __builder3.AddAttribute(15, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 10 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        \r\n\r\n");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(20);
                    __builder3.AddAttribute(21, "Label", "Server");
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(23);
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(25, "Install Game Server");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n     ");
                        __builder4.OpenComponent<MudBlazor.MudDivider>(27);
                        __builder4.AddAttribute(28, "Class", "my-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n    ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(30);
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(32, "Delete Game Server");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(34);
                    __builder3.AddAttribute(35, "Style", "float:right;");
                    __builder3.AddAttribute(36, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                                   (e) => DarkMode()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Toggle Dark/Light Mode");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    \r\n        ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(40);
                __builder2.AddAttribute(41, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<windowswebgsm.Shared.NavMenu>(44);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(46);
                __builder2.AddAttribute(47, "Style", "padding-top:5em;");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(49);
                    __builder3.AddAttribute(50, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 28 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
                                MaxWidth.ExtraLarge

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 29 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
__builder4.AddContent(52, Body);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n        ");
                    __builder3.OpenComponent<windowswebgsm.Shared.Footer>(54);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Panda\source\repos\windowswebgsm\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;
    

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

     protected override void OnInitialized()
    {
        currentTheme = darkTheme;
    }

    void DarkMode()
    {
        if (currentTheme == defaultTheme)
        {
            currentTheme = darkTheme;
        }
        else
        {
            currentTheme = defaultTheme;
        }
    }

    MudTheme currentTheme = new MudTheme();
    MudTheme defaultTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#272c34"
        }
    };
     MudTheme darkTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "rgba(255,255,255, 0.70)",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)"
        }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
