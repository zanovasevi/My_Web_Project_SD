#pragma checksum "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450b7c698cc34f159fd9dc6d97a76c4998c6416f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuitarAndBassInstruments_ElectricGuitarsAll), @"mvc.1.0.view", @"/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml")]
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
#nullable restore
#line 1 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
using static SoundAndDance_v2.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
using static SoundAndDance_v2.Data.DataConstants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450b7c698cc34f159fd9dc6d97a76c4998c6416f", @"/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83d33eed37112b63566c3ead5d733e76919be98", @"/Views/_ViewImports.cshtml")]
    public class Views_GuitarAndBassInstruments_ElectricGuitarsAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstrumentTotalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GuitarAndBassInstruments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddElectricGuitar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-add offset-10 col-xs-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.1vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditElectricGuitar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:5px; font-size: 1.1vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_DeleteConfirmationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:9px; font-size: 1.1vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
  
    var dict = Model.dictElectricGuitarViewModel;
    var allIds = Model.allIds;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
  
    ViewData["Title"] = "SD Electric Guitars";

    var isAdmin = User.IsInRole(AdministratorRoleName);

    var counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450b7c698cc34f159fd9dc6d97a76c4998c6416f9644", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <style>
        table {
            width: 100%;
        }

        tr.border_header {
            border: solid;
            background-color: royalblue;
        }

        .tdStyle {
            font-weight: bold;
            border-top: double;
            border-bottom: double;
            border-bottom-color: royalblue;
            border-top-color: royalblue;
        }

        tr.border_bottom td {
            border-bottom: 1px solid black;
        }

        th.first_col {
            width: 15%;
        }

        .btn-add {
            margin-bottom: 15px;
        }
    </style>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450b7c698cc34f159fd9dc6d97a76c4998c6416f11224", async() => {
                WriteLiteral("\n    <h4 class=\"margin-h4\">\n        ELECTRIC GUITARS\n");
#nullable restore
#line 56 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
         if (isAdmin)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450b7c698cc34f159fd9dc6d97a76c4998c6416f11830", async() => {
                    WriteLiteral("ADD NEW ELECTRIC GUITAR");
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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                                                                  WriteLiteral(CategoryIdElectricGuitars);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("input", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 60 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </h4>\n\n\n");
#nullable restore
#line 64 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
     if (!dict.Any())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\n            There are no Electric Guitars in the system!\n        </div>\n");
#nullable restore
#line 69 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table class=""table table-striped"">
            <thead>
                <tr class=""border_header"">
                    <th class=""first_col"" scope=""col"">#</th>
                    <th scope=""col"">MODEL</th>
                    <th scope=""col"" class=""text-center"">SERIAL NUMBER</th>
                    <th scope=""col"" class=""text-center"">NOTES</th>
                    <th scope=""col"" class=""text-center"">COUNT</th>
");
#nullable restore
#line 80 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                     if (isAdmin)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th scope=\"col\" class=\"text-center\">UNIT PRICE</th>\n                        <th scope=\"col\" class=\"text-center\">TOTAL PRICE</th>\n");
#nullable restore
#line 84 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th></th>\n                        <th></th>\n");
#nullable restore
#line 89 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th></th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 95 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                 foreach (var elGuitar in dict.OrderBy(c => c.Key))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr class=\"tdStyle\" style=\"background-color:lightcyan\">\n                        <th scope=\"row\">");
#nullable restore
#line 98 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                    Write(counter++);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 98 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                 Write(elGuitar.Key.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</th>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
");
#nullable restore
#line 108 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                     foreach (var item in elGuitar.Value.OrderBy(i => i.Brand).ThenBy(i => i.Model))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 111 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                           Write(item.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 112 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                           Write(item.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"text-center\">");
#nullable restore
#line 113 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                               Write(item.SerialNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 114 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                           Write(item.Notes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td class=\"text-center\">");
#nullable restore
#line 115 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                               Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 116 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                             if (isAdmin)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"text-center\">");
#nullable restore
#line 118 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                   Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td class=\"text-center\">");
#nullable restore
#line 119 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                    Write(item.Count * item.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td class=\"text-right\" style=\"padding:0px; padding-bottom:10px\">\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450b7c698cc34f159fd9dc6d97a76c4998c6416f22529", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                                                                         WriteLiteral(CategoryIdElectricGuitars);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </td>\n                                <td class=\"text-right\" style=\"padding:0px; padding-bottom:10px\">\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "450b7c698cc34f159fd9dc6d97a76c4998c6416f26059", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                                                                                                                 WriteLiteral(CategoryIdElectricGuitars);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </td>\n");
#nullable restore
#line 126 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td></td>\n                                <td></td>\n                                <td></td>\n                                <td></td>\n");
#nullable restore
#line 133 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\n");
#nullable restore
#line 135 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
");
#nullable restore
#line 147 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 150 "/Users/macbookpro/Desktop/My_Web_Project_SD-401ee1e72af93c6eae8ece93ba213a2ed234e018/Views/GuitarAndBassInstruments/ElectricGuitarsAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstrumentTotalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
