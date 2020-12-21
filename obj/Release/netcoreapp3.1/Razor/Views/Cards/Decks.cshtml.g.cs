#pragma checksum "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe8a1ae85b1ecc2e01f08dbbdc7b9ca63b0f151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cards_Decks), @"mvc.1.0.view", @"/Views/Cards/Decks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fe8a1ae85b1ecc2e01f08dbbdc7b9ca63b0f151", @"/Views/Cards/Decks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bf67fedd148ed26939cd2338821cb41e8b3f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Cards_Decks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Deck>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
  
    Console.WriteLine();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\" style=\"background-color:#D4E6F1\">\r\n    <div class=\"text-center\">\r\n        <h1>Top 10 Logged Decks</h1>\r\n\r\n        <!--cycles through displaying the list of top 10 logged decks-->\r\n");
#nullable restore
#line 16 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
             foreach (Deck deck in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-3 p-2 \">\r\n                    <div class=\"container-fluid d-inline-flex\">\r\n                        <div class=\"col-6 border-right\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
                       Write(Html.Raw(deck.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-6 pt-4\">\r\n                            <p><b>Deck Id:</b>");
#nullable restore
#line 26 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
                                         Write(deck.DeckId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Win:</b>");
#nullable restore
#line 27 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
                                     Write(deck.Wins);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Loss:</b>");
#nullable restore
#line 28 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
                                      Write(deck.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Win loss ratio:</b>");
#nullable restore
#line 29 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
                                                Write(deck.WinLossRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\FreshZeph\Desktop\Clash4Bird\ClashCreative\ClashCreative\Views\Cards\Decks.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Deck>> Html { get; private set; }
    }
}
#pragma warning restore 1591
