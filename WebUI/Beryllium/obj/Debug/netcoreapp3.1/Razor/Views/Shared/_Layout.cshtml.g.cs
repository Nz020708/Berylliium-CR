#pragma checksum "C:\Users\99470\Desktop\Unfinished\WebUI\Beryllium\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc79c1e55b0c85bf677086c3e7926d64e40770d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc79c1e55b0c85bf677086c3e7926d64e40770d", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc79c1e55b0c85bf677086c3e7926d64e40770d2733", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous""
          referrerpolicy=""no-referrer"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor""
          crossorigin=""anonymous"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""
            integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ==""
            crossorigin=""anonymous""
            referrerpolicy=""no-refer");
                WriteLiteral("rer\"></script>\r\n    <link rel=\"stylesheet\" href=\"./assets/css/main.css\" />\r\n    <title>Beryllium</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc79c1e55b0c85bf677086c3e7926d64e40770d4907", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg bg-light nav-space"">
            <div class=""container-fluid myContainer"">
                <a class=""navbar-brand logo"" href=""#"">BERYLLIUM</a>
                <button class=""navbar-toggler""
                        type=""button""
                        data-bs-toggle=""collapse""
                        data-bs-target=""#navbarNavDropdown""
                        aria-controls=""navbarNavDropdown""
                        aria-expanded=""false""
                        aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse navbar-list""
                     id=""navbarNavDropdown"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">HOME</a>
                        </li>
                        <li class=""n");
                WriteLiteral(@"av-item"">
                            <a class=""nav-link"" href=""#"">ABOUT</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle drpdwn""
                               id=""navbarDropdownMenuLink""
                               role=""button""
                               data-bs-toggle=""dropdown""
                               aria-expanded=""false""
                               href=""#"">SERVICES</a>
                            <ul class=""dropdown-menu drpdwn-menu""
                                aria-labelledby=""navbarDropdownMenuLink"">
                                <div class=""square""></div>
                                <li><a class=""dropdown-item"" href=""#"">Web Design</a></li>
                                <li><a class=""dropdown-item"" href=""#"">eCommerce</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Branding </a></li>
                                <li><a cl");
                WriteLiteral(@"ass=""dropdown-item"" href=""#"">API </a></li>
                            </ul>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle drpdwn-second""
                               href=""#""
                               id=""navbarDropdownMenuLink""
                               role=""button""
                               data-bs-toggle=""dropdown""
                               aria-expanded=""false"">
                                DROPDOWN
                            </a>
                            <ul class=""dropdown-menu drpdwn-menu-second""
                                aria-labelledby=""navbarDropdownMenuLink"">
                                <div class=""square""></div>
                                <li><a class=""dropdown-item"" href=""#"">HTML5</a></li>
                                <li><a class=""dropdown-item"" href=""#"">CSS3</a></li>
                                <li><a class=""dropdown-item"" hr");
                WriteLiteral(@"ef=""#"">Sass</a></li>
                                <li><a class=""dropdown-item"" href=""#"">jQuery</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">PORTFOLIO</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">CONTACT</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    ");
#nullable restore
#line 91 "C:\Users\99470\Desktop\Unfinished\WebUI\Beryllium\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer></footer>

    <link rel=""stylesheet"" type=""text/css"" href=""./assets/slick/slick.css"" />
    <link rel=""stylesheet""
          type=""text/css""
          href=""./assets/slick/slick-theme.css"" />
    <script type=""text/javascript""
            src=""//code.jquery.com/jquery-1.11.0.min.js""></script>
    <script type=""text/javascript""
            src=""//code.jquery.com/jquery.min.js""></script>
    <script type=""text/javascript""
            src=""//code.jquery.com/jquery-migrate-1.2.1.min.js""></script>
    <script type=""text/javascript"" src=""./assets/slick/slick.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
    <script src=""./assets/js/main.js""></script>
");
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
