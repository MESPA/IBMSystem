#pragma checksum "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Clientes/Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde4440b0e677a0dc98c97af868f1c647c675b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Editar), @"mvc.1.0.view", @"/Views/Clientes/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde4440b0e677a0dc98c97af868f1c647c675b56", @"/Views/Clientes/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246d36adb762126de7ae9eeef8180c1b01c1ff4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogoProductos.Models.Cliente>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formularioEditar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde4440b0e677a0dc98c97af868f1c647c675b563944", async() => {
                WriteLiteral("\n    <div class=\"form-group\">\n        <label class=\"col-lg-8 control-label\" for=\"nombre\">Nombre:</label>\n        <input class=\"form-control\" type=\"text\" id=\"nombre\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 315, "\"", 336, 1);
#nullable restore
#line 6 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Clientes/Editar.cshtml"
WriteAttributeValue("", 323, Model.Nombre, 323, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\n    </div>\n    <div class=\"form-group\">\n        <label class=\"col-lg-8 control-label\" for=\"direccion\">Dirección:</label>\n        <input class=\"form-control\" type=\"text\" id=\"direccion\" name=\"direccion\"");
                BeginWriteAttribute("value", " value=\"", 548, "\"", 572, 1);
#nullable restore
#line 10 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Clientes/Editar.cshtml"
WriteAttributeValue("", 556, Model.Direccion, 556, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\n    </div>\n    <div>\n        <button class=\"btn btn-success\" type=\"submit\">Guardar Cliente</button>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 3 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Clientes/Editar.cshtml"
AddHtmlAttributeValue("", 91, Url.Action("Editar", new { id = Model.Id }), 91, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $('#formularioEditar').submit(function (e) {
            e.preventDefault();

            // Obtener los valores del formulario
            var nombre = $('#nombre').val();
            var direccion = $('#direccion').val();

            // Realizar una petición AJAX para enviar los datos al servidor
            $.ajax({
                url: $(this).attr('action'),
                method: $(this).attr('method'),
                data: {
                    nombre: nombre,
                    direccion: direccion
                },
                success: function (response) {
                    // Manejar la respuesta del servidor
                    // Por ejemplo, redirigir a la página de detalles del cliente
                    window.location.href = '");
#nullable restore
#line 37 "/Users/manuel/Desktop/IBSystem/CatalogoProductos/CatalogoProductos/Views/Clientes/Editar.cshtml"
                                       Write(Url.Action("Detalles", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\n                },\n                error: function (error) {\n                    // Manejar errores\n                    console.log(error);\n                }\n            });\n        });\n    });\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogoProductos.Models.Cliente> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591