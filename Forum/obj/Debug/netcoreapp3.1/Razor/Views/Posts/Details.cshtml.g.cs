#pragma checksum "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665fb680ec0aca9f8e8ec9421694286fcb0391c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
#line 1 "C:\Users\patry\source\repos\Forum\Forum\Views\_ViewImports.cshtml"
using Forum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\patry\source\repos\Forum\Forum\Views\_ViewImports.cshtml"
using Forum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665fb680ec0aca9f8e8ec9421694286fcb0391c5", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac609fd15eba99a48942b04c8579a10a24406fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPoint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Points", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Post</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastEditionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastEditionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Creator.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 51 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
      
        var login = new byte[20];
        var id = new byte[20];
        bool isLogin = Context.Session.TryGetValue("login", out login);
        var userid = "";
        string loginString = "";
        if (login != null)
        {
            loginString = System.Text.Encoding.UTF8.GetString(login);
            Context.Session.TryGetValue("id", out id);
            userid = System.Text.Encoding.UTF8.GetString(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Add a response:</h4><br>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c510838", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c511121", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 66 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "665fb680ec0aca9f8e8ec9421694286fcb0391c512800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 67 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label id=""content"" class=""control-label""></label>
                            <input id=""content"" class=""form-control"" name=""content"" />

                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
     if (userid.Equals(Model.CreatorId.ToString()))
    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c516748", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
                            WriteLiteral(Model.Id);

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
            WriteLiteral("<br>");
#nullable restore
#line 82 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Answers:</h4>\r\n");
#nullable restore
#line 84 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
     foreach (Comment com in Model.Comment)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 87 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(com.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            ");
#nullable restore
#line 88 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(com.Creator.Nick);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 89 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
       Write(com.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            Approved points: ");
#nullable restore
#line 90 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
                        Write(com.Point.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c520345", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 3185, "\"", 3207, 2);
                WriteAttributeValue("", 3190, "commentid_", 3190, 10, true);
#nullable restore
#line 92 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3200, com.Id, 3200, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"commentid\"");
                BeginWriteAttribute("value", " value=\"", 3225, "\"", 3240, 1);
#nullable restore
#line 92 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3233, com.Id, 3233, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 93 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
             if (login != null)
            {
                Point point = new Point();
                point = com.Point.SingleOrDefault(p=>p.CommentId==com.Id && userid.Equals(p.UserId.ToString()));
                
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
             if (point!=null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Is this comment helpful? <input");
                BeginWriteAttribute("id", " id=\"", 3566, "\"", 3578, 1);
#nullable restore
#line 100 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3571, com.Id, 3571, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"ishelpful\" checked /></p>\r\n");
#nullable restore
#line 101 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Is this comment helpful? <input");
                BeginWriteAttribute("id", " id=\"", 3727, "\"", 3739, 1);
#nullable restore
#line 104 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3732, com.Id, 3732, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"ishelpful\" /></p>\r\n");
#nullable restore
#line 105 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
             
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
             if (userid.Equals(com.Creator.Id.ToString()))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c525243", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
                                       WriteLiteral(com.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 111 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div><br>\r\n");
#nullable restore
#line 113 "C:\Users\patry\source\repos\Forum\Forum\Views\Posts\Details.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665fb680ec0aca9f8e8ec9421694286fcb0391c527994", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<button onclick=\"show()\">but</button>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function show() {
            alert(""show"");
        }
        $(document).ready(function () {
            $('input[type=""checkbox""]').click(function () {
                var id = $(this).attr(""id"");
                if ($(this).is("":checked"")) {
                    var val1 = $(""input#commentid_""+id).val();
                    $.ajax(
                        {
                            async: true,
                            url: ""/Points/AddPoint"",
                            data: { commentid: val1},
                            dataType: ""text"",
                            type: 'POST',
                            success: function (msg) {
                            },
                            error: function (error) {
                                console.log(error);
                            }
                        });
                }
                else if ($(this).is("":not(:checked)"")) {
                    $.ajax(
                        {");
                WriteLiteral(@"
                            async: true,
                            type: ""POST"",
                            url: ""/Points/DeletePoint"",
                            data: { commentid: id},
                            dataType: ""text"",
                            success: function (msg) {
                            },
                            error: function (req, status, error) {
                            }
                        });
                }

            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
