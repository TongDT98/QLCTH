#pragma checksum "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2514045b96b8a643a06770c4213cfee207cea1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\QLCTH\StudyProgram\StudyProgram\Views\_ViewImports.cshtml"
using StudyProgram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\QLCTH\StudyProgram\StudyProgram\Views\_ViewImports.cshtml"
using StudyProgram.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2514045b96b8a643a06770c4213cfee207cea1bf", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6bb080342015ccf6ca98298bd0caebda501263", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ProgramStudy/select2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf6973", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Thăng long</title>
    <link rel=""stylesheet"" href=""style.css"">

    <link rel=""shortcut icon"" href=""img/favicon.png"">
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- bootstrap theme -->
    <link href=""css/bootstrap-theme.css"" rel=""stylesheet"">
    <!--external css-->
    <!-- font icon -->
    <link href=""css/elegant-icons-style.css"" rel=""stylesheet"" />
    <link href=""css/font-awesome.min.css"" rel=""stylesheet"" />
    <!-- Custom styles -->
    <link href=""css/style.css"" rel=""stylesheet"">
    <link href=""css/style-responsive.css"" rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2514045b96b8a643a06770c4213cfee207cea1bf7977", async() => {
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
                WriteLiteral("    <!-- Bootstrap CSS -->\r\n");
                WriteLiteral("    <!-- Select2 CSS -->\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2514045b96b8a643a06770c4213cfee207cea1bf9318", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf11200", async() => {
                WriteLiteral("\r\n    <section id=\"container\"");
                BeginWriteAttribute("class", " class=\"", 1216, "\"", 1224, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <!--header start-->\r\n\r\n        <header class=\"header dark-bg\">\r\n            <!--logo start-->\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1345, "\"", 1352, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo"">Thăng Long <span class=""lite""></span></a>
            <!--logo end-->

            <div class=""nav search-row"" id=""top_menu"">
                <!--  search form start -->
                <ul class=""nav top-menu"">
                    <li>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf12219", async() => {
                    WriteLiteral("\r\n                            <input class=\"form-control\" placeholder=\"Search\" type=\"text\">\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                </ul>
                <!--  search form end -->
            </div>

            <div class=""top-nav notification-row"">
                <!-- notificatoin dropdown start-->
                <ul class=""nav pull-right top-menu"">

                    <!-- task notificatoin start -->
                    <!-- task notificatoin end -->
                    <!-- inbox notificatoin start-->
                    <li id=""mail_notificatoin_bar"" class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                            <i class=""icon-envelope-l""></i>

                        </a>

                    </li>

                    <li class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                            <span class=""profile-ava"">

                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2514045b96b8a643a06770c4213cfee207cea1bf14683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </span>
                            <span class=""username"">TongDT</span>
                            <b class=""caret""></b>
                        </a>
                        <ul class=""dropdown-menu extended logout"">
                            <div class=""log-arrow-up""></div>
                            <li class=""eborder-top"">
                                <a href=""#""><i class=""icon_profile""></i> My Profile</a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon_mail_alt""></i> My Inbox</a>
                            </li>
                            <li>
                                <a href=""#"">");
                WriteLiteral(@" Timeline</a>
                            </li>

                            <li>
                                <a href=""login.html""><i class=""icon_key_alt""></i> Log Out</a>
                            </li>
                            <li>
                                <a href=""documentation.html""><i class=""icon_key_alt""></i> Documentation</a>
                            </li>
                            <li>
                                <a href=""documentation.html""><i class=""icon_key_alt""></i> Documentation</a>
                            </li>
                        </ul>
                    </li>
                    <!-- user login dropdown end -->
                </ul>
                <!-- notificatoin dropdown end-->
            </div>
        </header>
        <!--header end-->
        <!--sidebar start-->
        <aside>
            <div id=""sidebar"" class=""nav-collapse "">
                <!-- sidebar menu start-->
                <ul class=""sidebar-menu"">
            ");
                WriteLiteral("        <li");
                BeginWriteAttribute("class", " class=\"", 4546, "\"", 4554, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <a");
                BeginWriteAttribute("class", " class=\"", 4584, "\"", 4592, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"index.html\">\r\n");
                WriteLiteral("                            <span>Dashboard</span>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"sub-menu\">\r\n                        <a href=\"javascript:;\"");
                BeginWriteAttribute("class", " class=\"", 4876, "\"", 4884, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                            <span>Khóa</span>\r\n");
                WriteLiteral("                        </a>\r\n                        <ul class=\"sub\">\r\n                            <li>");
#nullable restore
#line 120 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Danh sach khóa", "Index", "Course"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"sub-menu\">\r\n                        <a href=\"javascript:;\"");
                BeginWriteAttribute("class", " class=\"", 5398, "\"", 5406, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>Khoa</span>\r\n");
                WriteLiteral("                        </a>\r\n                        <ul class=\"sub\">\r\n");
                WriteLiteral("                            <li>");
#nullable restore
#line 130 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Danh sach khoa", "Index", "Faculty"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n                    </li>\r\n                    <li class=\"sub-menu\">\r\n                        <a href=\"javascript:;\"");
                BeginWriteAttribute("class", " class=\"", 5960, "\"", 5968, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>Chuyên Ngành</span>\r\n");
                WriteLiteral("                        </a>\r\n                        <ul class=\"sub\">\r\n");
                WriteLiteral("                            <li>");
#nullable restore
#line 140 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
                           Write(Html.ActionLink("Danh sách chuyên ngành", "Index", "Speciality"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("class", " class=\"", 6504, "\"", 6512, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"chart-chartjs.html\">\r\n                            <span>Chương trình học</span>\r\n\r\n                        </a>\r\n\r\n                    </li>\r\n                    <li class=\"sub-menu \">\r\n                        <a href=\"javascript:;\"");
                BeginWriteAttribute("class", " class=\"", 6752, "\"", 6760, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>Pages</span>\r\n                        </a>\r\n                        <ul class=\"sub\">\r\n                            <li><a");
                BeginWriteAttribute("class", " class=\"", 6918, "\"", 6926, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"profile.html\">Profile</a></li>\r\n                            <li><a");
                BeginWriteAttribute("class", " class=\"", 7000, "\"", 7008, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"login.html\"><span>Login Page</span></a></li>\r\n                            <li><a");
                BeginWriteAttribute("class", " class=\"", 7096, "\"", 7104, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"contact.html\"><span>Contact Page</span></a></li>\r\n                            <li><a class=\"active\" href=\"blank.html\">Blank Page</a></li>\r\n                            <li><a");
                BeginWriteAttribute("class", " class=\"", 7285, "\"", 7293, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"404.html\">404 Error</a></li>\r\n                        </ul>\r\n                    </li>\r\n                    <li>\r\n                        <a");
                BeginWriteAttribute("class", " class=\"", 7441, "\"", 7449, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""/subject"">
                            <span>Môn</span>
                        </a>

                    </li>

                </ul>
                <!-- sidebar menu end-->
            </div>
        </aside>
        <!--sidebar end-->
        <div class=""container main-content"">
            <main role=""main"" class=""pb-3"">
                ");
#nullable restore
#line 176 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <!-- Modal -->
                <div id=""common-modal"" class=""modal"" data-backdrop=""static""></div>
            </main>
        </div>

        <footer class=""border-top footer text-muted"">
            <div class=""container"">
            </div>
        </footer>



        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf23616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf24720", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf25824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 191 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 192 "D:\QLCTH\StudyProgram\StudyProgram\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- javascripts -->
        <script src=""js/jquery.js""></script>
        <script src=""js/bootstrap.min.js""></script>
        <!-- nice scroll -->
        <script src=""js/jquery.scrollTo.min.js""></script>
        <script src=""js/jquery.nicescroll.js"" type=""text/javascript""></script>
        <!--custome script for all page-->
        <script src=""js/scripts.js""></script>
        <!-- jQuery -->
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
        <!-- Select2 -->
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/js/select2.min.js""></script>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2514045b96b8a643a06770c4213cfee207cea1bf28680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <script>\r\n            $(\".single\").select2({\r\n                allowClear: true\r\n            });\r\n        </script>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
