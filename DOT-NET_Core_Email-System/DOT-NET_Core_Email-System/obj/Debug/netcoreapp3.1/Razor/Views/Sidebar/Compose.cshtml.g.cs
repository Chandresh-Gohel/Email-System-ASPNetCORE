#pragma checksum "C:\Users\ronak\Desktop\WDDN-Core\Email-System-ASPNetCORE\DOT-NET_Core_Email-System\DOT-NET_Core_Email-System\Views\Sidebar\Compose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660f3620721eda40b700c0eb40f5aff17dac8d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sidebar_Compose), @"mvc.1.0.view", @"/Views/Sidebar/Compose.cshtml")]
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
#line 1 "C:\Users\ronak\Desktop\WDDN-Core\Email-System-ASPNetCORE\DOT-NET_Core_Email-System\DOT-NET_Core_Email-System\Views\_ViewImports.cshtml"
using DOT_NET_Core_Email_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ronak\Desktop\WDDN-Core\Email-System-ASPNetCORE\DOT-NET_Core_Email-System\DOT-NET_Core_Email-System\Views\_ViewImports.cshtml"
using DOT_NET_Core_Email_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660f3620721eda40b700c0eb40f5aff17dac8d75", @"/Views/Sidebar/Compose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e4c758cc635290420f0a859eaf4defc43deee2", @"/Views/_ViewImports.cshtml")]
    public class Views_Sidebar_Compose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"bg-primary m-4\" style=\"color:white\">Compose</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "660f3620721eda40b700c0eb40f5aff17dac8d753537", async() => {
                WriteLiteral(@"
        <div class=""form-group row"">
            <label class=""col-sm-2 col-form-label"">To</label>
            <div class=""col-sm-10"">
                <input type=""email"" class=""form-control"" id=""email"" placeholder=""Email"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-2 col-form-label"">Subject</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-2 col-form-label"">Body</label>
            <div class=""col-sm-10"">
                <textarea id=""body"" class=""form-control"" rows=""5"" cols=""20""></textarea>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-2 col-form-label"">Attachment</label>
            <div class=""col-sm-10"">
                <div class=""custom-file"">
                    <input type=");
                WriteLiteral(@"""file"" class=""custom-file-input"" id=""selectedfile"">
                    <label class=""custom-file-label"" for=""selectedfile"" id=""filelabel"">Choose file</label>
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-2 col-form-label""></label>
            <div class=""col-sm-10"">
                <div class=""d-flex flex-row bd-highlight mb-3"">
                    <div class=""p-2 bd-highlight"">
                        <button type=""submit"" class=""btn btn-primary"">Send</button>
                    </div>
                    <div class=""p-2 bd-highlight"">
                        <button type=""reset"" class=""btn btn-secondary"">Reset</button>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $('#selectedfile').on('change', function () {
            //get the file name
            var fileName = $(this).val().split(""\\"").pop();
            //replace the ""Choose a file"" label
            $(this).next('.custom-file-label').html(fileName);
        })
    </script>
");
            }
            );
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
