#pragma checksum "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\DataTableDeneme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0850cf05245650de8692243479b8ba5dde9aff81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataTableDeneme), @"mvc.1.0.view", @"/Views/Home/DataTableDeneme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DataTableDeneme.cshtml", typeof(AspNetCore.Views_Home_DataTableDeneme))]
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
#line 1 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\_ViewImports.cshtml"
using KD_Category_CRUD;

#line default
#line hidden
#line 2 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\_ViewImports.cshtml"
using KD_Category_CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0850cf05245650de8692243479b8ba5dde9aff81", @"/Views/Home/DataTableDeneme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e300e964d68dfd329e05571533c94240d8e670c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DataTableDeneme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\DataTableDeneme.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 382, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6762d7f30a8b43d097e2234781831f0b", async() => {
                BeginContext(64, 369, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>DataTableDeneme</title>


    <script src=""https://code.jquery.com/jquery-3.4.0.min.js""></script>
    <link href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(440, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(442, 2687, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "082a7ba4f340453c9bd22ceb61e5d1ca", async() => {
                BeginContext(448, 2674, true);
                WriteLiteral(@"
    <table id=""table"" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th>Başlık1</th>
                <th>Başlık2</th>
                <th>Başlık3</th>
            </tr>
        </thead>
        <tr>
            <td>data1</td>
            <td>data2</td>
            <td>data3</td>
        </tr>
        <tr>
            <td>data4</td>
            <td>data5</td>
            <td>data6</td>
        </tr>
        <tr>
            <td>data7</td>
            <td>data8</td>
            <td>data9</td>
        </tr>
        <tr>
            <td>data10</td>
            <td>data11</td>
            <td>data12</td>
        </tr>
        <tr>
            <td>data13</td>
            <td>data14</td>
            <td>data15</td>
        </tr>
        <tr>
            <td>data16</td>
            <td>data17</td>
            <td>data18</td>
        </tr>
        <tr>
            <td>data19</td>
            <td>data20</td>
            <td>data21</td>
 ");
                WriteLiteral(@"       </tr>
        <tr>
            <td>data22</td>
            <td>data23</td>
            <td>data24</td>
        </tr>
        <tr>
            <td>data25</td>
            <td>data26</td>
            <td>data27</td>
        </tr>
        <tr>
            <td>data28</td>
            <td>data29</td>
            <td>data30</td>
        </tr>
        <tr>
            <td>data1</td>
            <td>data2</td>
            <td>data3</td>
        </tr>
        <tr>
            <td>data4</td>
            <td>data5</td>
            <td>data6</td>
        </tr>
        <tr>
            <td>data7</td>
            <td>data8</td>
            <td>data9</td>
        </tr>
        <tr>
            <td>data10</td>
            <td>data11</td>
            <td>data12</td>
        </tr>
        <tr>
            <td>data13</td>
            <td>data14</td>
            <td>data15</td>
        </tr>
        <tr>
            <td>data16</td>
            <td>data17</td>
            <td>dat");
                WriteLiteral(@"a18</td>
        </tr>
        <tr>
            <td>data19</td>
            <td>data20</td>
            <td>data21</td>
        </tr>
        <tr>
            <td>data22</td>
            <td>data23</td>
            <td>data24</td>
        </tr>
        <tr>
            <td>data25</td>
            <td>data26</td>
            <td>data27</td>
        </tr>
        <tr>
            <td>data28</td>
            <td>data29</td>
            <td>data30</td>
        </tr>
    </table>

    <script>
        $(document).ready(function () {
            $('#table').DataTable();
        });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(3129, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
