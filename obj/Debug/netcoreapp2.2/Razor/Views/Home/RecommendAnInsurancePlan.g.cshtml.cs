#pragma checksum "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\Home\RecommendAnInsurancePlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1144ded3d97010d02c4109665cd0a8be9b81e34c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecommendAnInsurancePlan), @"mvc.1.0.view", @"/Views/Home/RecommendAnInsurancePlan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RecommendAnInsurancePlan.cshtml", typeof(AspNetCore.Views_Home_RecommendAnInsurancePlan))]
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
#line 1 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\_ViewImports.cshtml"
using HealthCareProject;

#line default
#line hidden
#line 2 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\_ViewImports.cshtml"
using HealthCareProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1144ded3d97010d02c4109665cd0a8be9b81e34c", @"/Views/Home/RecommendAnInsurancePlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fc26877fe15be3fa6158cf54ef3c36398e656b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecommendAnInsurancePlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthCareProject.Models.PatientInformationForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\Home\RecommendAnInsurancePlan.cshtml"
  
    ViewData["Title"] = "RecommendAnInsurancePlan";

#line default
#line hidden
            BeginContext(116, 44, true);
            WriteLiteral("\r\n<h2>Recommend An Insurance Plan</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\Home\RecommendAnInsurancePlan.cshtml"
 foreach (var element in Model.PatientDatabase)
{

#line default
#line hidden
            BeginContext(212, 9, true);
            WriteLiteral("    <p>  ");
            EndContext();
            BeginContext(222, 41, false);
#line 11 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\Home\RecommendAnInsurancePlan.cshtml"
    Write(element.RecommendAnInsurancePlan(element));

#line default
#line hidden
            EndContext();
            BeginContext(263, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\ADG\source\repos\HealthCareProject\HealthCareProject\Views\Home\RecommendAnInsurancePlan.cshtml"
}

#line default
#line hidden
            BeginContext(272, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthCareProject.Models.PatientInformationForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
