#pragma checksum "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5a1031327dd0505e83eb8961178ada24d36357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordenes_Index), @"mvc.1.0.view", @"/Views/Ordenes/Index.cshtml")]
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
#line 1 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/_ViewImports.cshtml"
using CatalogoProductos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/_ViewImports.cshtml"
using CatalogoProductos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b5a1031327dd0505e83eb8961178ada24d36357", @"/Views/Ordenes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246d36adb762126de7ae9eeef8180c1b01c1ff4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ordenes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CatalogoProductos.Models.Orden>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h1>Lista De Ordenes</h1>\n</div>\n<a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 121, "\"", 148, 1);
#nullable restore
#line 6 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
WriteAttributeValue("", 128, Url.Action("Crear"), 128, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" enctype=\"multipart/form-data\">Crear Orden</a> | <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 224, "\"", 271, 1);
#nullable restore
#line 6 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
WriteAttributeValue("", 231, Url.Action("ReporteOrdenes", "Ordenes"), 231, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Generar Reporte</a>
<br />

<br />
<table class=""table"">
    <thead class=""table-dark"">
        <tr>
            <th>Fecha</th>
            <th>Cliente</th>
            <th>Estatus</th>
            <th>Nombre</th>
            <th>Descripcion</th>
            <th>Precio</th>
            <th>Total de Ordenes</th>
      
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
         foreach (var orden in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
             foreach (var producto in orden.Productos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 29 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(orden.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(orden.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(orden.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(producto.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(producto.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                   Write(orden.Cliente.Ordenes.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n\n                   \n                </tr>\n");
#nullable restore
#line 41 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CatalogoProductos.Models.Orden>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
