#pragma checksum "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ae3e06e4ff83cf1dbf969573976db3e60c3589c1ed4186140299b546da50d3db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ae3e06e4ff83cf1dbf969573976db3e60c3589c1ed4186140299b546da50d3db", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9b5db103c657cb4a6a953429a381ef558c4a1847f99d7078895a1a2ca751d365", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\"> ");
#nullable restore
#line 5 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                   Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n");
#nullable restore
#line 22 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                 if (u.Tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 29 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 765, 2);
            WriteAttributeValue("", 743, "EditarUsuario?id=", 743, 17, true);
#nullable restore
#line 31 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 760, u.Id, 760, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 806, "\"", 836, 2);
            WriteAttributeValue("", 813, "ExcluirUsuario?id=", 813, 18, true);
#nullable restore
#line 32 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 831, u.Id, 831, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Ana - Senac\UC7\UC07 - ATIVIDADE 2 BACKUP\Projeto_Biblioteca\Views\Usuario\ListarUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
