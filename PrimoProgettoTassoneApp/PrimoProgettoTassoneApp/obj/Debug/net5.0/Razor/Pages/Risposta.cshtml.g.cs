#pragma checksum "C:\Users\Utente\Desktop\primawebapp-AnthonyTassone\PrimoProgettoTassoneApp\PrimoProgettoTassoneApp\Pages\Risposta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fe718f708ef5bec5610f3339cca03203d54e7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Risposta), @"mvc.1.0.razor-page", @"/Pages/Risposta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fe718f708ef5bec5610f3339cca03203d54e7a", @"/Pages/Risposta.cshtml")]
    public class Pages_Risposta : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fe718f708ef5bec5610f3339cca03203d54e7a2578", async() => {
                WriteLiteral("\r\n    <h1>Risposta, nea</h1>\r\n    <p>Il testo scritto dall\'utente ");
#nullable restore
#line 8 "C:\Users\Utente\Desktop\primawebapp-AnthonyTassone\PrimoProgettoTassoneApp\PrimoProgettoTassoneApp\Pages\Risposta.cshtml"
                               Write(Model.Cognome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\Utente\Desktop\primawebapp-AnthonyTassone\PrimoProgettoTassoneApp\PrimoProgettoTassoneApp\Pages\Risposta.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ?? <b>");
#nullable restore
#line 8 "C:\Users\Utente\Desktop\primawebapp-AnthonyTassone\PrimoProgettoTassoneApp\PrimoProgettoTassoneApp\Pages\Risposta.cshtml"
                                                               Write(Model.Testo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n");
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
            WriteLiteral("\r\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimoProgettoTassoneApp.Pages.RispostaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrimoProgettoTassoneApp.Pages.RispostaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrimoProgettoTassoneApp.Pages.RispostaModel>)PageContext?.ViewData;
        public PrimoProgettoTassoneApp.Pages.RispostaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
