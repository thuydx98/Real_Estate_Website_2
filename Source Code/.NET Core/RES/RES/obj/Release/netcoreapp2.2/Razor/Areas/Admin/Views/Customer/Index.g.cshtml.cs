#pragma checksum "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017f4e5f3d1af5f3613e306dd67a9d923d9658c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Customer/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Customer_Index))]
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
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES;

#line default
#line hidden
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES.Models;

#line default
#line hidden
#line 3 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\_ViewImports.cshtml"
using RES.Models.Common;

#line default
#line hidden
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
using RES.Data.DBModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017f4e5f3d1af5f3613e306dd67a9d923d9658c8", @"/Areas/Admin/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdcd4bfcd2d1ebbc40950dcfbe29b8ed6bfd87a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RES.Data.DBModels.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 3px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Bạn có chắc chắn muốn mở khóa tài khoản này?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Block", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Bạn có chắc chắn muốn khóa tài khoản này?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Quản lý người dùng | Admin BDS Miền Trung";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    RealEstateSystemContext _context = new RealEstateSystemContext();

    var notice = TempData["Notice"];

    if (notice != null)
    {
        ViewData["Notice"] = notice;
    }

#line default
#line hidden
            BeginContext(402, 103, true);
            WriteLiteral("\r\n<div class=\"animated fadeIn\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(505, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "017f4e5f3d1af5f3613e306dd67a9d923d9658c88692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 21 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (ViewData["Notice"] == null ? null : ViewData["Notice"].ToString());

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(660, 784, true);
            WriteLiteral(@"
            <div class=""card"">
                <div class=""card-header"">
                    <strong class=""card-title"">Quản lý người dùng</strong>
                </div>
                <div class=""card-body"">
                    <table id=""bootstrap-data-table"" class=""table table-striped table-bordered"">
                        <thead>
                            <tr>
                                <th>Họ tên</th>
                                <th>Email</th>
                                <th>Địa chỉ</th>
                                <th>Số điện thoại</th>
                                <th>Trạng thái</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 39 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                             foreach (var customer in Model)
                            {

#line default
#line hidden
            BeginContext(1537, 80, true);
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(1619, 44, false);
#line 43 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                    Write(customer.LastName + " " + customer.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(1664, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1713, 22, false);
#line 44 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                    Write(customer.Account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1736, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1784, 16, false);
#line 45 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                   Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1848, 20, false);
#line 46 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                   Write(customer.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1868, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                      
                                        if (customer.Block.Count != 0 && (customer.Block.Last().UnBlockDate == null || customer.Block.Last().UnBlockDate > DateTime.Now))
                                        {

#line default
#line hidden
            BeginContext(2129, 92, true);
            WriteLiteral("                                            <td class=\"text-red  text-center\">Bị khóa</td>\r\n");
            EndContext();
#line 51 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2353, 100, true);
            WriteLiteral("                                            <td class=\"text-green text-center\">Đang hoạt động</td>\r\n");
            EndContext();
#line 55 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(2535, 111, true);
            WriteLiteral("                                    <td style=\"display: inline-flex\">\r\n                                        ");
            EndContext();
            BeginContext(2646, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017f4e5f3d1af5f3613e306dd67a9d923d9658c815054", async() => {
                BeginContext(2791, 140, true);
                WriteLiteral("\r\n                                            <input type=\"submit\" class=\"btn-info\" value=\"Xem\" />\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                                                                                                WriteLiteral(customer.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2938, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2980, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017f4e5f3d1af5f3613e306dd67a9d923d9658c818651", async() => {
                BeginContext(3122, 143, true);
                WriteLiteral("\r\n                                            <input type=\"submit\" class=\"btn-primary\" value=\"Sửa\" />\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                                                                                             WriteLiteral(customer.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                         if (customer.Block.Count != 0 && (customer.Block.Last().UnBlockDate == null || customer.Block.Last().UnBlockDate > DateTime.Now))
                                        {

#line default
#line hidden
            BeginContext(3489, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3533, 431, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017f4e5f3d1af5f3613e306dd67a9d923d9658c822730", async() => {
                BeginContext(3805, 152, true);
                WriteLiteral("\r\n                                                <input type=\"submit\" class=\"btn-dark\" value=\"Mở Khóa\" />\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                                                                                                    WriteLiteral(customer.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3964, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 70 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(4098, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4142, 428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017f4e5f3d1af5f3613e306dd67a9d923d9658c826825", async() => {
                BeginContext(4409, 154, true);
                WriteLiteral("\r\n                                                <input type=\"submit\" class=\"btn-danger\" value=\"Khóa TK\" />\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                                                                                                  WriteLiteral(customer.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4570, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 77 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4615, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Thuy Dao Xuan\Desktop\Real_Estate_System\Source Code\.NET Core\RES\RES\Areas\Admin\Views\Customer\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4728, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RES.Data.DBModels.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591