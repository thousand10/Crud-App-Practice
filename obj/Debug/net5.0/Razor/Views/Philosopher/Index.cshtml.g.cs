#pragma checksum "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de15dffb104bcd54a01d146516a8e8ed92f2c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Philosopher_Index), @"mvc.1.0.view", @"/Views/Philosopher/Index.cshtml")]
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
#line 1 "C:\Users\Aconte\Desktop\net projects\three\Views\_ViewImports.cshtml"
using three;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aconte\Desktop\net projects\three\Views\_ViewImports.cshtml"
using three.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de15dffb104bcd54a01d146516a8e8ed92f2c35", @"/Views/Philosopher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04790afa01c6659ad97752fbf3e5827bf2f34fb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Philosopher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcPhilosopher.Models.Philosopher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Philosopher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-sans text-lg bg-green-600 py-1 px-7 transition ease-in-out duration-150 hover:bg-green-700 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-sans text-lg bg-red-600 py-1 px-7 transition ease-in-out duration-150 hover:bg-red-700 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
  
    ViewData["heading"] = "this is the Philosopher app";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mx-auto pt-16 pb-10 max-w-3xl px-6\">\r\n");
#nullable restore
#line 8 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"font-sans text-3xl  text-center pb-2\"><span class=\"font-bold \"> ");
#nullable restore
#line 10 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> Philosophers in the database</h1>\r\n");
#nullable restore
#line 11 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"font-sans text-3xl text-center pb-2\"><span class=\"font-bold text-red-600\"> ");
#nullable restore
#line 14 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> Philosophers in the database</h1>\r\n");
#nullable restore
#line 15 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"font-sans text-2xl underline tracking-wide text-center\">List of Philosophers</h2>\r\n    <div class=\"pt-28\">\r\n");
#nullable restore
#line 18 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
         if (Model.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
             foreach(var philo in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""grid grid-cols-2 mb-4 border-2 border-gray-300 py-2 px-3 mx-auto bg-transparent transition ease-in-out duration-200 hover:bg-gray-200 hover:border-transparent"">
                <div class=""flex gap-4 "">
                    <h1 class=""font-sans text-xl tracking-wide"">");
#nullable restore
#line 24 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                           Write(philo.First);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h1 class=\"font-sans text-xl tracking-wide\">");
#nullable restore
#line 25 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                           Write(philo.Last);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n                <div class=\"flex gap-6 items-center justify-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de15dffb104bcd54a01d146516a8e8ed92f2c358313", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                                         WriteLiteral(philo.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de15dffb104bcd54a01d146516a8e8ed92f2c3510798", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
                                                                           WriteLiteral(philo.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
             
        }
        else 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"h-64 flex flex-col items-center\">\r\n               <h1 class=\"text-red-600 text-4xl tracking-wide\">No data at the moment</h1>\r\n           </div>\r\n");
#nullable restore
#line 39 "C:\Users\Aconte\Desktop\net projects\three\Views\Philosopher\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcPhilosopher.Models.Philosopher>> Html { get; private set; }
    }
}
#pragma warning restore 1591