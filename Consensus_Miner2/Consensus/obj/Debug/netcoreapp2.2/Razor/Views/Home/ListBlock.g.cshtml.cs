#pragma checksum "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24468c36118aff24471b83c8c139717f5882871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListBlock), @"mvc.1.0.view", @"/Views/Home/ListBlock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListBlock.cshtml", typeof(AspNetCore.Views_Home_ListBlock))]
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
#line 1 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\_ViewImports.cshtml"
using Consensus;

#line default
#line hidden
#line 2 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\_ViewImports.cshtml"
using Consensus.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24468c36118aff24471b83c8c139717f5882871", @"/Views/Home/ListBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d17b91b3ce19f38347938ee2258e2f64e68696", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/stylesheets/lib/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/stylesheets/blockchain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/stylesheets/lib/bootstrap-horizon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
  
    ViewData["Title"] = "ListBlock";
    Layout = null;

#line default
#line hidden
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e24468c36118aff24471b83c8c139717f58828715617", async() => {
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
            EndContext();
            BeginContext(137, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e24468c36118aff24471b83c8c139717f58828716766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e24468c36118aff24471b83c8c139717f58828717915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(270, 58, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <h2>List Block</h2>\r\n");
            EndContext();
#line 10 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
       
        var blocks = ViewBag.Blocks as List<Block>;
    

#line default
#line hidden
            BeginContext(397, 35, true);
            WriteLiteral("    <div class=\"row row-horizon\">\r\n");
            EndContext();
#line 14 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
           
            var i = 1;
            var j = 1;
        

#line default
#line hidden
            BeginContext(504, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 18 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
         foreach (var block in blocks)
        {

#line default
#line hidden
            BeginContext(555, 133, true);
            WriteLiteral("        <div class=\"col-xs-7\" style=\"\">\r\n            <div id=\"block1chain1well\" class=\"well well-success\" style=\"\">\r\n                ");
            EndContext();
            BeginContext(688, 3214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24468c36118aff24471b83c8c139717f588287110297", async() => {
                BeginContext(718, 405, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""block1chain1number"" class=""col-sm-2 control-label"">Block:</label>
                        <div class=""col-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon"">#</span>
                                <input id=""block1chain1number"" type=""number""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1123, "\"", 1133, 1);
#line 28 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 1131, i, 1131, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1134, 448, true);
                WriteLiteral(@" onchange=""updateChain(1,1)""; onkeyup=""updateChain(1, 1);"" class=""form-control"" />
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""block1chain1nonce"" class=""col-sm-2 control-label"">Nonce:</label>
                        <div class=""col-sm-10"">
                            <input id=""block1chain1nonce"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1582, "\"", 1602, 1);
#line 36 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 1590, block.Proof, 1590, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1603, 289, true);
                WriteLiteral(@" onkeyup=""updateChain(1, 1);"" class=""form-control"" />
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""col-sm-2 control-label"">Tx:</label>
                        <div class=""col-sm-10"">

");
                EndContext();
#line 44 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
                             foreach (var item in block.Transactions)
                            {

#line default
#line hidden
                BeginContext(1994, 216, true);
                WriteLiteral("                                <div class=\"input-group\">\r\n                                    <div class=\"input-group-addon\">$</div>\r\n                                    <input for=\"block1chain1tx0value\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2210, "\"", 2230, 1);
#line 48 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 2218, item.Amount, 2218, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2231, 215, true);
                WriteLiteral(" onkeyup=\"updateChain(1, 1);\" class=\"form-control\" />\r\n                                    <div class=\"input-group-addon\">From:</div>\r\n                                    <input for=\"block1chain1tx0from\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2446, "\"", 2466, 1);
#line 50 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 2454, item.Sender, 2454, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2467, 251, true);
                WriteLiteral(" onkeyup=\"updateChain(1, 1);\" class=\"form-control\" />                                       \r\n                                    <div class=\"input-group-addon\">To :</div>\r\n                                    <input for=\"block1chain1tx0to\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2718, "\"", 2741, 1);
#line 52 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 2726, item.Recipient, 2726, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2742, 95, true);
                WriteLiteral(" onkeyup=\"updateChain(1, 1);\" class=\"form-control\" />\r\n                                </div>\r\n");
                EndContext();
#line 54 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"


                                j++;
                            }

#line default
#line hidden
                BeginContext(2910, 367, true);
                WriteLiteral(@"                        </div>,
                    </div>

                   
                   <div id=""state"" class=""form-group"">
                        <label for=""blockchain1previous"" class=""col-sm-2 control-label"">Prev:</label>
                        <div class=""col-sm-10"">
                                    <input id=""blockchain1Prev"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3277, "\"", 3304, 1);
#line 65 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 3285, block.PreviousHash, 3285, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3305, 427, true);
                WriteLiteral(@" onkeyup=""updateChain(1, 1);""  class=""form-control"" disabled=""""/> 
                            </div>
                    </div>
                    

                   <div id=""state"" class=""form-group"">
                        <label for=""blockchain1hash"" class=""col-sm-2 control-label"">Hash:</label>
                        <div class=""col-sm-10"">
                            <input id=""blockchain1hash"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3732, "\"", 3751, 1);
#line 73 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
WriteAttributeValue("", 3740, block.HASH, 3740, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3752, 143, true);
                WriteLiteral(" onekeyup=\"updateChain(1,1)\" class=\"form-control\" disabled=\"\"/>\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3902, 38, true);
            WriteLiteral("\r\n        </div>\r\n            </div>\r\n");
            EndContext();
#line 80 "C:\Users\Meriem\source\repos\Consensus_Miner2\Consensus\Views\Home\ListBlock.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(3969, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
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