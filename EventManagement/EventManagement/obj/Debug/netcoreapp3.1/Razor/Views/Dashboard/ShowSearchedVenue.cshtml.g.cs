#pragma checksum "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684578c5e0456f571f5b4e5230df8f1707525c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ShowSearchedVenue), @"mvc.1.0.view", @"/Views/Dashboard/ShowSearchedVenue.cshtml")]
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
#line 1 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\_ViewImports.cshtml"
using EventManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\_ViewImports.cshtml"
using EventManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684578c5e0456f571f5b4e5230df8f1707525c1e", @"/Views/Dashboard/ShowSearchedVenue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ada8587a3cd18c4c943a5dee629336e11b579d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ShowSearchedVenue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventManagement.Models.VenueAllDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/IndexStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "684578c5e0456f571f5b4e5230df8f1707525c1e4507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
      
        ViewData["Title"] = "ShowSearchedVenue";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h3>Searched Venue</h3>\r\n    <h4 class=\"text-danger\">");
#nullable restore
#line 9 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
                       Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 10 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Event_Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Event_Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Event_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Event_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Guest_Capability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Guest_Capability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Per_Guest_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Per_Guest_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.DJ_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.DJ_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Stage_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Stage_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayNameFor(model => model.Mike_Speaker_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 55 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
           Write(Html.DisplayFor(model => model.Mike_Speaker_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\SHUBHAM\Desktop\C# Assignment 3 code push\New folder (2)\Event\EventManagement\EventManagement\Views\Dashboard\ShowSearchedVenue.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "684578c5e0456f571f5b4e5230df8f1707525c1e12666", async() => {
                WriteLiteral("Back to Search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventManagement.Models.VenueAllDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
