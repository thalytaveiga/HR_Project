#pragma checksum "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56797d979d69432889c3a200349e0c8d195628a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Details), @"mvc.1.0.view", @"/Views/Department/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Department/Details.cshtml", typeof(AspNetCore.Views_Department_Details))]
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
#line 1 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\_ViewImports.cshtml"
using HR_Project;

#line default
#line hidden
#line 2 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\_ViewImports.cshtml"
using HR_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56797d979d69432889c3a200349e0c8d195628a6", @"/Views/Department/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"687ace2e134967029023c3e7c5ccc5059ef0036d", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HR_Project.Models.Department>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Department</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 44, false);
#line 14 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeptName));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 40, false);
#line 17 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeptName));

#line default
#line hidden
            EndContext();
            BeginContext(335, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(379, 48, false);
#line 20 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeptLocation));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(471, 44, false);
#line 23 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeptLocation));

#line default
#line hidden
            EndContext();
            BeginContext(515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(559, 45, false);
#line 26 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employees));

#line default
#line hidden
            EndContext();
            BeginContext(604, 417, true);
            WriteLiteral(@"
        </dt>
        <dd>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            First Name
                        </th>
                        <th>
                            Last Name
                        </th>
                        <th>
                            Job Role
                        </th>
");
            EndContext();
            BeginContext(1126, 310, true);
            WriteLiteral(@"                        <th>
                            Hire Date
                        </th>
                        <th>
                            Salary
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 54 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                     foreach (var item in Model.Employees)
                    {

#line default
#line hidden
            BeginContext(1519, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1616, 44, false);
#line 58 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1764, 43, false);
#line 61 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1911, 51, false);
#line 64 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.JobRoles.JobName));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(2162, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2229, 43, false);
#line 70 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2272, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2376, 41, false);
#line 73 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 76 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2508, 93, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2601, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6336ffe6dfd4fb9be42c9b22f56dd58", async() => {
                BeginContext(2675, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "D:\Centennial\Software-Engineering\3-Summer-2019\COMP229-Web-Application\HR_Project\HR_Project\Views\Department\Details.cshtml"
                           WriteLiteral(Model.DeptId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2683, 7, true);
            WriteLiteral(" \r\n    ");
            EndContext();
            BeginContext(2690, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d706216ff2949cbbfcf526aa18dce32", async() => {
                BeginContext(2733, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2749, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Project.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
