#pragma checksum "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8142c8e21891067aafa9404ab97bcce8011e7df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8142c8e21891067aafa9404ab97bcce8011e7df", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Usuários cadastrado no sistema</h1>\r\n\r\n    <p class=\"text-danger\">");
#nullable restore
#line 4 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                      Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

    <table class=""table"">
        <thead>
            <tr>
                <th scope='row'>Nome</th>
                <th scope='row'>Login</th>
                <th scope='row'>Tipo</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 16 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
             foreach (Usuario u in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                     if(u.Tipo == Usuario.ADMIN)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Administrador</td>\r\n");
#nullable restore
#line 24 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Padrão</td>\r\n");
#nullable restore
#line 28 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 815, "\"", 844, 2);
            WriteAttributeValue("", 822, "editarUsuario?id=", 822, 17, true);
#nullable restore
#line 30 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 839, u.Id, 839, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 919, 2);
            WriteAttributeValue("", 896, "excluirUsuario?id=", 896, 18, true);
#nullable restore
#line 31 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 914, u.Id, 914, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Jose Eustaquio\Documents\UC7_Senac\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <a href=\"RegistraUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
