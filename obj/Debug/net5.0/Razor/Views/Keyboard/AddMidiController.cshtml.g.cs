#pragma checksum "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/Keyboard/AddMidiController.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7398dc4ed6c0aaa3aeaeebb77f5a500ca1722e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Keyboard_AddMidiController), @"mvc.1.0.view", @"/Views/Keyboard/AddMidiController.cshtml")]
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
#line 1 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models.Drums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models.Bass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models.Guitar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models.Keyboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Models.GuitarAndBassInstrument;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/_ViewImports.cshtml"
using SoundAndDance_v2.Services.ServiceModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc7398dc4ed6c0aaa3aeaeebb77f5a500ca1722e", @"/Views/Keyboard/AddMidiController.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83d33eed37112b63566c3ead5d733e76919be98", @"/Views/_ViewImports.cshtml")]
    public class Views_Keyboard_AddMidiController : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MidiControllerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainFormPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/Keyboard/AddMidiController.cshtml"
  
    ViewData["Title"] = "SD Add Midi Controller";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style>\n    .h4 {\n        margin-bottom: 40px;\n        margin-top: 40px;\n    }\n</style>\n\n<h4 class=\"h4 offset-2 col-xs-4\">ADD NEW MIDI CONTROLLER</h4>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc7398dc4ed6c0aaa3aeaeebb77f5a500ca1722e5632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/Keyboard/AddMidiController.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc7398dc4ed6c0aaa3aeaeebb77f5a500ca1722e7315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MidiControllerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
