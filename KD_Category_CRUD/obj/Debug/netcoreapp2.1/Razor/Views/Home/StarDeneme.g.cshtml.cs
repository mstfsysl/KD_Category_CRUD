#pragma checksum "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da667a237ee537211f1c7765675db1c5ed4ce22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StarDeneme), @"mvc.1.0.view", @"/Views/Home/StarDeneme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StarDeneme.cshtml", typeof(AspNetCore.Views_Home_StarDeneme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da667a237ee537211f1c7765675db1c5ed4ce22", @"/Views/Home/StarDeneme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e300e964d68dfd329e05571533c94240d8e670c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StarDeneme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Puan>
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
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(42, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(71, 1907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc4ee8b51474b488390427adb63b293", async() => {
                BeginContext(77, 115, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>StarDeneme</title>\r\n\r\n    <style>\r\n        ");
                EndContext();
                BeginContext(193, 1778, true);
                WriteLiteral(@"@import url(//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css);

        fieldset, label {
            margin: 0;
            padding: 0;
        }

        body {
            margin: 20px;
        }

        h1 {
            font-size: 1.5em;
            margin: 10px;
        }

        /****** Style Star Rating Widget *****/

        .rating {
            border: none;
            float: left;
        }

            .rating > input {
                display: none;
            }

            .rating > label:before {
                margin: 5px;
                font-size: 1.25em;
                font-family: FontAwesome;
                display: inline-block;
                content: ""\f005"";
            }

            .rating > .half:before {
                content: ""\f089"";
                position: absolute;
            }

            .rating > label {
                color: #ddd;
                float: right;
            }

            /***** C");
                WriteLiteral(@"SS Magic to Highlight Stars on Hover *****/

            .rating > input:checked ~ label, /* show gold star when clicked */
            .rating:not(:checked) > label:hover, /* hover current star */
            .rating:not(:checked) > label:hover ~ label {
                color: #FFD700;
            }
                /* hover previous stars in list */

                .rating > input:checked + label:hover, /* hover current star when changing rating */
                .rating > input:checked ~ label:hover,
                .rating > label:hover ~ input:checked ~ label, /* lighten current selection */
                .rating > input:checked ~ label:hover ~ label {
                    color: #FFED85;
                }
    </style>

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
            BeginContext(1978, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1980, 2340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33eb2885cf5745f5b46f1bee0d36bede", async() => {
                BeginContext(1986, 1312, true);
                WriteLiteral(@"
    <fieldset class=""rating"">
        <input type=""radio"" id=""star5"" name=""rating"" value=""10"" /><label class=""full"" for=""star5"" title=""10 puan""></label>
        <input type=""radio"" id=""star4half"" name=""rating"" value=""9"" /><label class=""half"" for=""star4half"" title=""9 puan""></label>
        <input type=""radio"" id=""star4"" name=""rating"" value=""8"" /><label class=""full"" for=""star4"" title=""8 puan""></label>
        <input type=""radio"" id=""star3half"" name=""rating"" value=""7"" /><label class=""half"" for=""star3half"" title=""7 puan""></label>
        <input type=""radio"" id=""star3"" name=""rating"" value=""6"" /><label class=""full"" for=""star3"" title=""6 puan""></label>
        <input type=""radio"" id=""star2half"" name=""rating"" value=""5"" /><label class=""half"" for=""star2half"" title=""5 puan""></label>
        <input type=""radio"" id=""star2"" name=""rating"" value=""4"" /><label class=""full"" for=""star2"" title=""4 puan""></label>
        <input type=""radio"" id=""star1half"" name=""rating"" value=""3"" /><label class=""half"" for=""star1half"" title=");
                WriteLiteral(@"""3 puan""></label>
        <input type=""radio"" id=""star1"" name=""rating"" value=""2"" /><label class=""full"" for=""star1"" title=""2 puan""></label>
        <input type=""radio"" id=""starhalf"" name=""rating"" value=""1"" /><label class=""half"" for=""starhalf"" title=""1 puan""></label>
    </fieldset>

");
                EndContext();
#line 92 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
                BeginContext(3345, 34, false);
#line 94 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml"
   Write(Html.TextBoxFor(a => a.PuanDegeri));

#line default
#line hidden
                EndContext();
                BeginContext(3381, 45, true);
                WriteLiteral("        <button type=\"submit\">Oyla</button>\r\n");
                EndContext();
#line 96 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml"
    }

#line default
#line hidden
                BeginContext(3433, 45, true);
                WriteLiteral("\r\n\r\n\r\n    <script>\r\n        var puanDegeri = ");
                EndContext();
                BeginContext(3479, 16, false);
#line 101 "C:\Users\mustafa.soysal\source\repos\KD_Category_CRUD\KD_Category_CRUD\Views\Home\StarDeneme.cshtml"
                    Write(Model.PuanDegeri);

#line default
#line hidden
                EndContext();
                BeginContext(3495, 818, true);
                WriteLiteral(@";

        var puanVerilmisMi = puanDegeri != 0;

        if (puanVerilmisMi) {
            alert(puanDegeri + "" Puan verdiniz"");
        }

        var puanDegeriAlani = document.getElementById(""PuanDegeri"");
        puanDegeriAlani.style.display = ""none"";

        var radioButons = document.getElementsByName(""rating"");

        for (var i = 0; i < radioButons.length; i++) {
            radioButons[i].addEventListener('click', function () {
                puanDegeriAlani.value = this.value;
            })

            if (puanVerilmisMi && radioButons[i].value == puanDegeri) {
                radioButons[i].checked = true;
            }
        }

            //for(var i = 0; i < radioButons.length;i++) {if(radioButons[i].checked){console.log(radioButons[i].value)}}
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
            BeginContext(4320, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Puan> Html { get; private set; }
    }
}
#pragma warning restore 1591