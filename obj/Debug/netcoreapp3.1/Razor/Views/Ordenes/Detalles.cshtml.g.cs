#pragma checksum "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c44a69c8d3fcdbcce5cbbf2593fa0e87b7d08fc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordenes_Detalles), @"mvc.1.0.view", @"/Views/Ordenes/Detalles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44a69c8d3fcdbcce5cbbf2593fa0e87b7d08fc6", @"/Views/Ordenes/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246d36adb762126de7ae9eeef8180c1b01c1ff4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ordenes_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogoProductos.Models.Orden>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Detalles de la orden de pedido</h2>\n\n<div>\n    <label>Fecha:</label>\n    <span>");
#nullable restore
#line 7 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
     Write(Model.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</div>\n<div>\n    <label>Cliente:</label>\n    <span>");
#nullable restore
#line 11 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
     Write(Model.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</div>\n<div>\n    <label>Estatus:</label>\n    <span>");
#nullable restore
#line 15 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
     Write(Model.Estatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</div>\n<div>\n    <label>Productos:</label>\n    <ul>\n");
#nullable restore
#line 20 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
         foreach (var producto in Model.Productos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 22 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
           Write(producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 23 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</div>\n\n<p>\n    <a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 511, 1);
#nullable restore
#line 28 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Ordenes/Detalles.cshtml"
WriteAttributeValue("", 491, Url.Action("Index"), 491, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Volver a la lista</a>\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogoProductos.Models.Orden> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
