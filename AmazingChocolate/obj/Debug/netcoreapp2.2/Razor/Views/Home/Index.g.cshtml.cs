#pragma checksum "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b856c7f08e7174b01b35da2cbc96cb7239fe67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\_ViewImports.cshtml"
using AmazingChocolate;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\_ViewImports.cshtml"
using AmazingChocolate.Models;

#line default
#line hidden
#line 1 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
using AmazingChocolate.DomainModel.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b856c7f08e7174b01b35da2cbc96cb7239fe67", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe21c49cf364e3c6ab4e964edc53b7406099ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AdicionarProduto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(115, 75, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Jenny Doces</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(233, 131, true);
            WriteLiteral("        <div class=\"card-columns\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 364, "\"", 390, 1);
#line 15 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
WriteAttributeValue("", 370, item.FotoProdutoURL, 370, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 391, "\"", 414, 1);
#line 15 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
WriteAttributeValue("", 397, item.NomeProduto, 397, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(415, 87, true);
            WriteLiteral(">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(503, 16, false);
#line 17 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
                                      Write(item.NomeProduto);

#line default
#line hidden
            EndContext();
            BeginContext(519, 27, true);
            WriteLiteral("</h5>\r\n                    ");
            EndContext();
            BeginContext(546, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b856c7f08e7174b01b35da2cbc96cb7239fe676108", async() => {
                BeginContext(592, 61, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"produto\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 653, "\"", 669, 1);
#line 19 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
WriteAttributeValue("", 661, item.Id, 661, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(670, 335, true);
                WriteLiteral(@"/>
                        <!--<p class=""card-text"">Um exemplo de texto rápido para construir o título do card e fazer preencher o conteúdo do card.</p>-->
                        <input type=""number"" name=""quantidade"" />
                        <button type=""submit"" class=""btn btn-primary"">Adicionar</button>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1012, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\user\Desktop\Trabalho Pós\AmazingChocolate\AmazingChocolate\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1081, 9, true);
            WriteLiteral("</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
