#pragma checksum "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\Home\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b54381845777014364bd599ebc32c5460d8a89c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editar), @"mvc.1.0.view", @"/Views/Home/Editar.cshtml")]
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
#line 1 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\_ViewImports.cshtml"
using AppAspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\_ViewImports.cshtml"
using AppAspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b54381845777014364bd599ebc32c5460d8a89c", @"/Views/Home/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a026e7d869cbc30380bfb63d6070f39b76915423", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ToDo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\Home\Editar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">Remover a tarefa</div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 9 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\Home\Editar.cshtml"
         using (Html.BeginForm("Editar", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label>Nome da tarefa</label>\r\n\r\n                ");
#nullable restore
#line 14 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\Home\Editar.cshtml"
           Write(Html.TextBoxFor(d => d.Tarefa, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <input type=\"submit\" class=\"btn btn-success btn-sn\" />\r\n");
#nullable restore
#line 18 "C:\Users\roger\Desktop\repositorio\App-.Net-Core\Todo\AppAspNetCore\Views\Home\Editar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ToDo> Html { get; private set; }
    }
}
#pragma warning restore 1591
