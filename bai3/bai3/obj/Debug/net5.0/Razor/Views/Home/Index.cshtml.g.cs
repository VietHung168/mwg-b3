#pragma checksum "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d415e7a251d403956927de92452299ed777cc5f8"
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
#line 1 "E:\mwg\bai3_locsp\bai3\bai3\Views\_ViewImports.cshtml"
using bai3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\mwg\bai3_locsp\bai3\bai3\Views\_ViewImports.cshtml"
using bai3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d415e7a251d403956927de92452299ed777cc5f8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bb87af74b4f5bc930422a581e7654a12f48c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bai3.Models.FakeData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("range-price"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
   //int i = 0;
    string ii = "";
    //String i = (String)Url.ActionContext.RouteData.Values["id"];
    int j = 0;
    if ((String)Url.ActionContext.RouteData.Values["id"] == null)
    {
        ii = "0";
    }
    else
    {
        ii = (String)Url.ActionContext.RouteData.Values["id"];
    }
    j = Int32.Parse(ii);

    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
 //   string af = Model.Price.ToString("#,###", cul.NumberFormat);

    //  decimal priceNew = Model.Price - (Model.Price * Model.Discount) / 100;

    //   string aff = priceNew.ToString("#,###", cul.NumberFormat);

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n    <div class=\"boxtop\">\r\n\r\n        <p class=\"txt01\">\r\n            ");
#nullable restore
#line 31 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
       Write(Model.listProduct.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" S???N PH???M T?? CHO B??
        </p>

    </div>

    <div class=""box-filter"">
        <div class=""warpper-filfer"">
            <div class=""filter-item filter-total"">
                <div class=""filter-item__title jsTitle"">
                    <i class=""icon-filter""></i>
                    L???c
                    <strong id=""number"">0</strong>
                </div>

                <div class=""filter-show show-total ishow"" id=""wrapper"">
                    <div class=""show-total__main"">
                        <div class=""close-filtertotal"">
                            ????ng
                            <i class=""icon-closefilter""></i>
                        </div>
");
            WriteLiteral("\r\n\r\n                        <div class=\"show-total-item clearfix\">\r\n                            <p class=\"show-total-txt\" data-item=\"H??ng\">H??ng:</p>\r\n                            <div class=\"filter-list filter-list--hang manu insight\" data-sight=\"0\">\r\n");
#nullable restore
#line 63 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                  
                                    for (int i = 0; i < @Model.ListLogo.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"c-btnbox filter-manu \" data-href=\"\" data-id=");
#nullable restore
#line 66 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                          Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-name=");
#nullable restore
#line 66 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=");
#nullable restore
#line 66 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-typeFilter=\"Hang\" data-indexFilter=");
#nullable restore
#line 66 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=", 2612, "", 2635, 1);
#nullable restore
#line 67 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2617, Model.ListLogo[i], 2617, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"67\" height=\"33\">\r\n                                        </a>\r\n");
#nullable restore
#line 69 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                        </div>
                        <div class=""show-total-item"">
                            <p class=""show-total-txt"" data-item=""Gi??"">Gi??:</p>
                            <div class=""filter-list price insight"" data-sight=""0"">
");
#nullable restore
#line 78 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                  
                                    int id = 0;
                                    foreach (var pr in Model.listPriceLimit)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a data-href=\"\" class=\"c-btnbox \" data-id=\"\" data-name=");
#nullable restore
#line 82 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                          Write(pr.tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"2\" data-typeFilter=\"Gia\" data-indexFilter=");
#nullable restore
#line 82 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                               Write(id++);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 82 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(pr.tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??</a>\r\n");
#nullable restore
#line 83 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""price-slider text-active"" data-activetxt="""">
                                <p class=""range-toggle"">
                                    <a href=""javascript:;"" onclick=""loadPriceRangeSlider(this)"">
                                        <i class=""iconcate-range""></i>
                                        <span class=""down"">Ho???c ch???n m???c gi?? ph?? h???p v???i b???n</span>
                                    </a>
                                </p>
                                <div class=""container"">
                                    <div class=""row-input"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d415e7a251d403956927de92452299ed777cc5f810916", async() => {
                WriteLiteral(@"
                                            <span class=""range-left"">
                                                <input type=""tel"" maxlength=""8"" name=""price-min-value"" data-minvalue=""0"" value=""0"">
                                                <label class=""place-holder"">.000??</label>
                                            </span>
                                            <span class=""range-right"">
                                                <input type=""tel"" maxlength=""8"" name=""price-max-value"" data-maxvalue=""500000"" value=""500"">
                                                <label class=""place-holder"">.000??</label>
                                            </span>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <div id=""slider-range-total"" class=""noUi-target noUi-ltr noUi-horizontal noUi-background"">
                                        <div class=""noUi-base"">
                                            <div class=""noUi-origin noUi-connect"" style=""left: 0%;"">
                                                <div class=""noUi-handle noUi-handle-lower""></div>
                                            </div>
                                            <div class=""noUi-origin noUi-background"" style=""left: 100%;"">
                                                <div class=""noUi-handle noUi-handle-upper"">

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                      ");
            WriteLiteral("  <div class=\"show-total-item \" data-hiddenbyone=\"False\">\r\n                            <p class=\"show-total-txt\" data-item=\"Lo???i\">Lo???i:</p>\r\n                            <div class=\"filter-list props insight\" data-propid=\"30200\" data-sight=\"0\">\r\n\r\n");
#nullable restore
#line 127 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                  
                                    for (int i = 0; i < @Model.listType.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 130 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                              Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                           data-name=");
#nullable restore
#line 131 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                Write(Model.listType[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"3\" data-typeFilter=\"Loai\" data-indexFilter=");
#nullable restore
#line 131 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 131 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.listType[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 132 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""show-total-item "" data-hiddenbyone=""False"">
                            <p class=""show-total-txt"" data-item=""C??n n???ng"">C??n n???ng:</p>
                            <div class=""filter-list props insight"" data-propid=""31319"" data-sight=""0"">
");
#nullable restore
#line 140 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                  
                                    for (int i = 0; i < @Model.listWeight.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 143 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                              Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                           data-name=");
#nullable restore
#line 144 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                Write(Model.listWeight[i].tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"4\" data-typeFilter=\"CanNang\" data-indexFilter=");
#nullable restore
#line 144 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 144 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                            Write(Model.listWeight[i].tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 145 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""show-total-item "" data-hiddenbyone=""False"">
                            <p class=""show-total-txt"" data-item=""Size"">Size:</p>
                            <div class=""filter-list props insight"" data-propid=""29979"" data-sight=""0"">
");
#nullable restore
#line 153 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                  
                                    for (int i = 0; i < @Model.ListSize.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 156 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                              Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                           data-name=");
#nullable restore
#line 157 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                Write(Model.ListSize[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"5\" data-typeFilter=\"Size\" data-indexFilter=");
#nullable restore
#line 157 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 157 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                            Write(Model.ListSize[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 158 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""filter-button-total"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">Ch???n l???i</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore "">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>

            </div>

            <div class=""filter-item"">
                <div class=""filter-item__title jsTitle"">
                    <span data-item=""H??ng"">H??ng</span>
                </div>
                <div class=""filter-show"">
                    <div class=""filter-list filter-list--column manu outsight"" data-sight=""1"">
");
#nullable restore
#line 178 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                          
                            for (int i = 0; i < @Model.ListLogo.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"c-btnbox filter-manu \" data-href=\"\" data-id=");
#nullable restore
#line 181 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-name=");
#nullable restore
#line 181 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=");
#nullable restore
#line 181 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-typeFilter=\"Hang\" data-indexFilter=");
#nullable restore
#line 181 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 9597, "", 9620, 1);
#nullable restore
#line 182 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
WriteAttributeValue("", 9602, Model.ListLogo[i], 9602, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"67\" height=\"33\">\r\n                                </a>\r\n");
#nullable restore
#line 184 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""filter-button"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">B??? ch???n</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore "">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>
            </div>
            <div class=""filter-item"">
                <div class=""filter-item__title jsTitle"">
                    <span data-item=""Lo???i"">Lo???i</span>
                </div>
                <div class=""filter-show"">
                    <div class=""filter-list filter-list--column manu outsight"" data-sight=""1"">

");
#nullable restore
#line 200 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                          
                            for (int i = 0; i < @Model.listType.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 203 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                      Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   data-name=");
#nullable restore
#line 204 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                        Write(Model.listType[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"3\" data-typeFilter=\"Loai\" data-indexFilter=");
#nullable restore
#line 204 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 204 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                    Write(Model.listType[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 205 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""filter-button"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">B??? ch???n</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore "">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>
            </div>

            <div class=""filter-item"">
                <div class=""filter-item__title jsTitle"">
                    <span data-item=""Gi??"">Gi?? </span>
                </div>
                <div class=""filter-show""");
            BeginWriteAttribute("style", " style=\"", 11469, "\"", 11477, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"filter-list props outsight\" data-propid=\"30200\" data-sight=\"1\">\r\n");
#nullable restore
#line 222 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                          
                            int dem = 0;
                            foreach (var pr in Model.listPriceLimit)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a data-href=\"\" class=\"c-btnbox \" data-id=\"\" data-name=");
#nullable restore
#line 226 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                  Write(pr.tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"2\" data-typeFilter=\"Gia\" data-indexFilter=");
#nullable restore
#line 226 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                       Write(dem++);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 226 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                                               Write(pr.tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??</a>\r\n");
#nullable restore
#line 227 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""filter-button"" style=""display: block;"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">Ch???n l???i</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore"">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>
            </div>
            <div class=""filter-item"">
                <div class=""filter-item__title jsTitle"">
                    <span data-item=""C??n n???ng"">C??n n???ng</span>
                </div>
                <div class=""filter-show""");
            BeginWriteAttribute("style", " style=\"", 12620, "\"", 12628, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"filter-list props outsight\" data-propid=\"31319\" data-sight=\"1\">\r\n");
#nullable restore
#line 243 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                          
                            for (int i = 0; i < @Model.listWeight.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 246 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                      Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   data-name=");
#nullable restore
#line 247 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                        Write(Model.listWeight[i].tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"4\" data-typeFilter=\"CanNang\" data-indexFilter=");
#nullable restore
#line 247 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 247 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                                    Write(Model.listWeight[i].tostring());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 248 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""filter-button"" style=""display: block;"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">Ch???n l???i</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore"">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>
            </div>
            <div class=""filter-item"">
                <div class=""filter-item__title jsTitle"">
                    <span data-item=""Size"">Size</span>
                </div>
                <div class=""filter-show """);
            BeginWriteAttribute("style", " style=\"", 13817, "\"", 13825, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"filter-list props outsight\" data-propid=\"29979\" data-sight=\"1\">\r\n");
#nullable restore
#line 264 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                          
                            for (int i = 0; i < @Model.ListSize.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a data-href=\"\" class=\"c-btnbox \" data-smooth=\"0\" data-id=");
#nullable restore
#line 267 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                      Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   data-name=");
#nullable restore
#line 268 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                        Write(Model.ListSize[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-type=\"5\" data-typeFilter=\"Size\" data-indexFilter=");
#nullable restore
#line 268 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 268 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                                                                                    Write(Model.ListSize[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 269 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""filter-button"" style=""display: block;"">
                        <a href=""javascript:void(0)"" class=""btn-filter-close"">Ch???n l???i</a>
                        <a href=""javascript:void(0)"" class=""btn-filter-readmore"">Xem (<b class=""total-reloading"">117</b> k???t qu???)</a>
                    </div>
                </div>
            </div>

        </div>


    </div>
    <div class=""box-quicklink"">
        <div class=""boxleft"">
            <p class=""box-quicklink__txt""> Ph??? bi???n:</p>
");
#nullable restore
#line 287 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
              
                for (int i = 0; i < @Model.ListLogo.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/\" data-href=\"/\" data-index=");
#nullable restore
#line 290 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                                                     Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"box-quicklink__item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 15143, "", 15166, 1);
#nullable restore
#line 291 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
WriteAttributeValue("", 15148, Model.ListLogo[i], 15148, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" height=\"20\" class=\"no-text\">\r\n                    </a>\r\n");
#nullable restore
#line 293 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""sort-select"">
            <p class=""click-sort"">
                X???p theo:
                <span class=""sort-show"">
                    N???i b???t
                </span>

            </p>
            <div class=""sort-select-main"">
                <p class=""sort active"" data-id=""9""><i></i>N???i b???t</p>
                <p class=""sort"" data-id=""7""><i></i>B??n ch???y</p>
                <p class=""sort"" data-id=""5""><i></i>% Gi???m Nhi???u</p>
                <p class=""sort"" data-id=""3""><i></i>G??a th???p t???i cao</p>
                <p class=""sort"" data-id=""2""><i></i>G??a cao t???i th???p</p>
            </div>
        </div>
    </div>
    <div class=""others-toy"" id=""toy-grid"">
");
#nullable restore
#line 316 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("ToyBoxes", Model.listProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </div>
    <div id=""paging"">
        <div class=""pagbreak fInter"" data-total-page=""4"">
            <a href=""javascript:;"" onclick=""gotoPageIndex(-1)"" id=""_pgPreviousPage"" class=""button-pagbreak button-pagbreak-prev disabled"" data-page=""0""></a>

            <span onclick=""PageIndex(this)"" data-page=""1"" class=""page-item active"">1</span>
            <span onclick=""PageIndex(this)"" data-page=""2"" class=""page-item"">2</span>
            <span onclick=""PageIndex(this)"" data-page=""3"" class=""page-item"">3</span>
            <span onclick=""PageIndex(this)"" data-page=""4"" class=""page-item"">4</span>
");
            WriteLiteral("\r\n            <a href=\"javascript:;\" class=\"button-pagbreak button-pagbreak-next \" id=\"_pgNextPage\" onclick=\"gotoPageIndex(1)\" data-page=\"2\"></a>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bai3.Models.FakeData> Html { get; private set; }
    }
}
#pragma warning restore 1591
