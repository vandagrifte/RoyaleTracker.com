#pragma checksum "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65dce6d1a10ecb09bc34ac4ae596430fb886091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cards_Cards), @"mvc.1.0.view", @"/Views/Cards/Cards.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65dce6d1a10ecb09bc34ac4ae596430fb886091", @"/Views/Cards/Cards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bf67fedd148ed26939cd2338821cb41e8b3f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Cards_Cards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Card>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
  
    ViewData["Title"] = "All Cards";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65dce6d1a10ecb09bc34ac4ae596430fb8860913297", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container"" style=""background-color:#D4E6F1"">

    <h1 class=""text-center"">
        All Cards in Clash Royale
    </h1>
    <div class=""text-center"">

        <!--Cycles through all cards in the game displaying them and linking to associated wiki page-->
");
#nullable restore
#line 15 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
         if(Model != null) { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
         foreach (Card card in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-deck d-inline-block\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 506, "\"", 559, 2);
            WriteAttributeValue("", 513, "https://clashroyale.fandom.com/wiki/", 513, 36, true);
#nullable restore
#line 19 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
WriteAttributeValue("", 549, card.Name, 549, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 608, "\"", 623, 1);
#nullable restore
#line 20 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
WriteAttributeValue("", 614, card.Url, 614, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"64px;\" />\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 736, 2);
            WriteAttributeValue("", 690, "https://clashroyale.fandom.com/wiki/", 690, 36, true);
#nullable restore
#line 22 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
WriteAttributeValue("", 726, card.Name, 726, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5 class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
                                     Write(card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Cards.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Card>> Html { get; private set; }
    }
}
#pragma warning restore 1591
