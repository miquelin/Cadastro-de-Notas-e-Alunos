#pragma checksum "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa606e8e42f55e8ece7328e47b24ff26b36324c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Notas), @"mvc.1.0.view", @"/Views/Nota/Notas.cshtml")]
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
#line 1 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\_ViewImports.cshtml"
using SistemaDeNotas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\_ViewImports.cshtml"
using SistemaDeNotas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa606e8e42f55e8ece7328e47b24ff26b36324c", @"/Views/Nota/Notas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557b52a772e2c8e1fd064708c6c06ff948255d4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Notas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaDeNotas.Models.Nota>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml"
  

    List<Aluno> listaAlunos = (List<Aluno>)ViewData["alunos"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<h1>Cadastro de Notas</h1>\r\n<br />\r\n<a href=\"/Nota/AddNotas\" class=\"btn btn-info\">Adicionar Nota</a>\r\n<br />\r\n<br />\r\n\r\n<h1>Notas</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml"
 foreach (var item in Model)

{
    var aluno = listaAlunos.Where(x => x.id == Guid.Parse(item.IdAluno)).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>");
#nullable restore
#line 22 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml"
   Write(aluno.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 464, "\"", 496, 2);
            WriteAttributeValue("", 471, "/Nota/Index/", 471, 12, true);
#nullable restore
#line 24 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml"
WriteAttributeValue("", 483, item.IdAluno, 483, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        Calcular Media\r\n    </a>\r\n    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Cleidiana\Documents\csharp\TrabalhosEnviados\Git\SistemaDeNotas\SistemaDeNotas\Views\Nota\Notas.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaDeNotas.Models.Nota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
