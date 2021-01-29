#pragma checksum "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ce2fda9f181513cfa384326e4686c1b72718d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\_ViewImports.cshtml"
using HousePlants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\_ViewImports.cshtml"
using HousePlants.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ce2fda9f181513cfa384326e4686c1b72718d3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17698c71356333e20ff018b03b97b34b0047f55f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\"></script>\r\n");
            WriteLiteral(@"
<div class=""text-center"">

    <header><h1>House Plant Catalog</h1></header>
    <div class=""container"">
        <section id=""owned"">
            <div class=""plant"">
                <aside class=""plant-header"">
                    <h2 class=""plant-name"">Pothos</h2>
                    <img class=""sun"" src=""/sun-icons/shade.png"" alt=""sun need"" />
                </aside>
                <aside class=""plant-info"">
                    <img src=""/plant-images/pothos.jpg"" alt=""plant photo"" class=""image"">
                    <p class=""water-frequency"">💧 2 times per week</p>
                    <p class=""fertilize"">∴ monthy during growing season</p>
                </aside>
            </div>
            <div class=""plant"">
                <aside class=""plant-header"">
                    <h2 class=""plant-name"">Spider Plant</h2>
                    <img class=""sun"" src=""/sun-icons/shade.png"" alt=""sun need"" />
                </aside>
                <aside class=""plant-info"">
                ");
            WriteLiteral(@"    <img src=""/plant-images/spider-plant.jpg"" alt=""plant photo"" class=""image"">
                    <p class=""water-frequency"">💧 1 time per week</p>
                    <p class=""fertilize"">∴ monthy during growing season</p>
                </aside>
            </div>
            <div class=""plant"">
                <aside class=""plant-header"">
                    <h2 class=""plant-name"">Aloe Vera</h2>
                    <img class=""sun"" src=""/sun-icons/full-sun.png"" alt=""sun need"" />
                </aside>
                <aside class=""plant-info"">
                    <img src=""/plant-images/aloe-vera.jpg"" alt=""plant photo"" class=""image"">
                    <p class=""water-frequency"">💧 1 time per 3 weeks</p>
                    <p class=""fertilize"">∴ monthy during growing season</p>
                </aside>
            </div>


");
#nullable restore
#line 46 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
             foreach (var plant in Model.plantList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"plant\">\r\n                    <aside class=\"plant-header\">\r\n                        <h2 class=\"plant-name\">");
#nullable restore
#line 50 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
                                          Write(plant.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <img class=\"sun\"");
            BeginWriteAttribute("src", " src=\"", 2237, "\"", 2253, 1);
#nullable restore
#line 51 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
WriteAttributeValue("", 2243, plant.sun, 2243, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"sun need\" />\r\n                    </aside>\r\n                    <aside class=\"plant-info\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2380, "\"", 2398, 1);
#nullable restore
#line 54 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
WriteAttributeValue("", 2386, plant.image, 2386, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"plant photo\" class=\"image\">\r\n                        <p class=\"water-frequency\">💧 ");
#nullable restore
#line 55 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
                                                 Write(plant.water);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"fertilize\">∴ ");
#nullable restore
#line 56 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
                                          Write(plant.fertilize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </aside>\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Users\amcclain\source\repos\HousePlants\HousePlants\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n        <section class=\"section wanted\"></section>\r\n\r\n\r\n\r\n\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591