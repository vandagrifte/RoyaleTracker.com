#pragma checksum "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c6bead7642dcc0c10691058a2953514e22d41bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Clans), @"mvc.1.0.view", @"/Views/Players/Clans.cshtml")]
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
#line 1 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\_ViewImports.cshtml"
using ClashCreative;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\_ViewImports.cshtml"
using ClashCreative.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c6bead7642dcc0c10691058a2953514e22d41bd", @"/Views/Players/Clans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bf67fedd148ed26939cd2338821cb41e8b3f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Clans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClansModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\" style=\"background-color:#D4E6F1\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
     if (Model.SearchedClan != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n");
#nullable restore
#line 11 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
         if (Model.SearchedClan.Tag != "invalid")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h1>");
#nullable restore
#line 15 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                   Write(Model.SearchedClan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 15 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                                              Write(Model.SearchedClan.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n                <div class=\"card card-body\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
               Write(Html.Raw(Model.SearchedClan.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>*Not a valid Clan Tag*</h1>");
#nullable restore
#line 23 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h2 class=\"mb-3\">All Logged Clans</h2>\r\n        <hr />\r\n");
#nullable restore
#line 31 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
         if(Model.Clans != null)
        { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
         foreach (Clan clan in Model.Clans)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-outline-secondary text-dark mb-1\" style=\"width:100%\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1115, 1);
#nullable restore
#line 35 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
WriteAttributeValue("", 1089, Model.SetHrefId(clan.Tag), 1089, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\">\r\n                <div class=\"container-fluid d-inline-flex\">\r\n                    <div class=\"col-3\"><b>Clan Score:</b>");
#nullable restore
#line 37 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                                                    Write(clan.ClanScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-6\"><b>Name:</b>");
#nullable restore
#line 38 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                                              Write(clan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-3\"><b>Required Trophies</b>");
#nullable restore
#line 39 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
                                                          Write(clan.RequiredTrophies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </a>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1533, "\"", 1564, 1);
#nullable restore
#line 42 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
WriteAttributeValue("", 1538, Model.GetHrefID(clan.Tag), 1538, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card card-body\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
               Write(Html.Raw(clan.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Players\Clans.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClansModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
