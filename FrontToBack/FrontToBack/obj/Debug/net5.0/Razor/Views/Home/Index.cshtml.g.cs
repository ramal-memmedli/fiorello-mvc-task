#pragma checksum "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7027ba666f92b28ecc6ea43e4e2963173f203965"
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
#line 1 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7027ba666f92b28ecc6ea43e4e2963173f203965", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"962a43cf4fecba32a82855dcd707cad07602b1f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/h2-sign-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/h1-custom-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!-- SLIDER START -->\r\n\r\n        <section id=\"slider\">\r\n            <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 7 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (Slider slider in Model.Sliders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f2039657066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 235, "~/assets/img/", 235, 13, true);
#nullable restore
#line 9 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 248, slider.ImageUrl, 248, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 10 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""container context pl-lg-5 ml-lg-3"">
                <div class=""row"">
                    <div class=""col-lg-5"">
                        <div class=""text"">
                            <h1>Send <span>flowers</span> like</h1>
                            <h1>you mean it</h1>
                            <p class=""text-black-50 d-none d-sm-block"">Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will
                                make it special cursus a sit amet mauris. </p>
                        </div>
                        <div class=""img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f2039659543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                    </div>
                </div>
            </div>
        </section>

        <!-- SLIDER END -->

        <!-- PRODUCTS START -->

        <section id=""products"">
            <div class=""container"">
                <div class=""row pt-5"">
                    <div class=""col-12 d-flex justify-content-between"">
                        <ul class=""category-mobile d-md-none list-unstyled"">
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1551, "\"", 1558, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                                <i class=\"fas fa-caret-down\"></i>\r\n                                <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1801, "\"", 1808, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 43 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                     foreach (Category category in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2016, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 45 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                           Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 45 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                                     Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 46 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </li>\r\n                        </ul>\r\n                        <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2334, "\"", 2341, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 52 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (Category category in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2518, "\"", 2525, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 54 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                   Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 54 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                             Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 55 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2769, "\"", 2776, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                                <i class=""fas fa-caret-down""></i>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""row"">
                    ");
#nullable restore
#line 66 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Products", new {take = 8}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row justify-content-center my-5\">\r\n                    <div class=\"col-lg-6 d-flex justify-content-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7027ba666f92b28ecc6ea43e4e2963173f20396515832", async() => {
                WriteLiteral("View more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </section>

        <!-- PRODUCTS END -->

        <!-- ABOUT START -->

        <section id=""about"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-lg-6"">
                        <div class=""img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396517875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3781, "~/assets/img/", 3781, 13, true);
#nullable restore
#line 85 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3794, Model.About.VideoThumbnailUrl, 3794, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div
                                class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                                <i class=""fas fa-play fa-lg""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                            <h1>");
#nullable restore
#line 94 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           Write(Model.About.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"py-3\">");
#nullable restore
#line 95 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(Model.About.Paragraph);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 97 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                 for (int i = 0; i < Model.AboutListItems.Count; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396521025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 99 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                                                               Write(Model.AboutListItems[i].Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li class=\"mt-3\">\r\n");
#nullable restore
#line 100 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- ABOUT END -->

        <!-- EXPERTS START -->

        <section id=""experts"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>Flower Experts</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 125 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (Expert expert in Model.Experts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3\">\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396524153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5969, "~/assets/img/", 5969, 13, true);
#nullable restore
#line 130 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5982, expert.ImageUrl, 5982, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"text mt-3\">\r\n                                        <h6>");
#nullable restore
#line 133 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(expert.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 134 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                            Write(expert.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 138 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </section>

        <!-- EXPERTS END -->

        <!-- SUBSCRIBE START -->

        <section id=""subscribe"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-12"">
                        <div class=""content text-center py-5"">
                            <h3>Join The Colorful Bunch!</h3>
                            <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                                <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                                <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SUBSCRIBE END -->

        <!-- BLOG START -->

        <section id=""blog"">
            <div");
            WriteLiteral(@" class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>From our Blog</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 180 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (BlogCard blogCard in Model.BlogCards)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-4\">\r\n                                <div class=\"item\">\r\n                                    <div class=\"img position-relative\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396529110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8370, "~/assets/img/", 8370, 13, true);
#nullable restore
#line 185 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8383, blogCard.ImageUrl, 8383, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                            <span>");
#nullable restore
#line 187 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                             Write(blogCard.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"text mt-3 text-center px-5\">\r\n                                        <h5>");
#nullable restore
#line 191 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(blogCard.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 192 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                            Write(blogCard.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 196 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                </div>
            </div>
        </section>

        <!-- BLOG END -->

        <!-- SAY START -->

        <section id=""say"">
            <div class=""container"">
                <div class=""row py-5 justify-content-center"">
                    <div class=""col-md-8 col-xl-6"">
                        <div class=""owl-carousel say"">
");
#nullable restore
#line 211 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (Testimonial testimonial in Model.Testimonials)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                        <div class=\"item text-center\">\r\n                                            <div class=\"img d-flex justify-content-center\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396533356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9849, "~/assets/img/", 9849, 13, true);
#nullable restore
#line 216 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9862, testimonial.ImageUrl, 9862, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"text text-muted pt-3 pb-5\">\r\n                                                <i>");
#nullable restore
#line 219 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                              Write(testimonial.Paragraph);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                            </div>\r\n                                            <div class=\"author\">\r\n                                                <h6>");
#nullable restore
#line 222 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                               Write(testimonial.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <p class=\"text-black-50\">");
#nullable restore
#line 223 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                    Write(testimonial.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 227 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SAY END -->

        <!-- INSTAGRAM START -->

        <section id=""instagram"">
            <div class=""owl-carousel instagram"">
");
#nullable restore
#line 240 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (InstagramPost instagramPost in Model.InstagramPosts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7027ba666f92b28ecc6ea43e4e2963173f20396537203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10993, "~/assets/img/", 10993, 13, true);
#nullable restore
#line 242 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 11006, instagramPost.ImageUrl, 11006, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 243 "C:\Users\Ramal\Desktop\Desktop\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n                #FIORELLO\r\n            </div>\r\n        </section>\r\n\r\n        <!-- INSTAGRAM END -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
