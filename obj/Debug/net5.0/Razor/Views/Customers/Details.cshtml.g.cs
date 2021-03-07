#pragma checksum "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a993ec0deb56edc4b06531876b0dd68bc085a8f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\_ViewImports.cshtml"
using DHSCRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\_ViewImports.cshtml"
using DHSCRM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a993ec0deb56edc4b06531876b0dd68bc085a8f5", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9b9d66f596dd0997f702fb736e19531e897b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DHSCRM.ViewModels.CustomerDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contacts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AddressStreet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AddressStreet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AddressTown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AddressTown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AddressCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AddressCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.AddressPostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.AddressPostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a993ec0deb56edc4b06531876b0dd68bc085a8f59194", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 59 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                           WriteLiteral(Model.Customer.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a993ec0deb56edc4b06531876b0dd68bc085a8f511345", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<hr />
<div>
    <h4>Contacts</h4>
    <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
        Link with href
    </a>
    <table class=""table table-striped table-hover collapse show"" id=""collapseExample"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Email Address</th>
                <th scope=""col"">Telephone</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 79 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
             foreach (var item in Model.Customer.Contacts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a993ec0deb56edc4b06531876b0dd68bc085a8f513505", async() => {
#nullable restore
#line 83 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                                                                                                    Write(item.FirstName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                                                                            WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<hr />\r\n");
#nullable restore
#line 101 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
 if (Model.Customer.Jobs.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <h4>Jobs</h4>
    <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
        Link with href
    </a>
    <table class=""table table-striped table-hover collapse show"" id=""collapseExample"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Total Miles</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 118 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
             foreach (var item in Model.Customer.Jobs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a993ec0deb56edc4b06531876b0dd68bc085a8f518573", async() => {
#nullable restore
#line 122 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                                                                                                Write(item.JobId);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                                                                            WriteLiteral(item.JobId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 125 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 128 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.JobDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 131 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
                   Write(item.TotalMiles);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 134 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 138 "C:\Users\Daniel.Hill\source\repos\DHSCRM\Views\Customers\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DHSCRM.ViewModels.CustomerDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
