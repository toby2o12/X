﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/Index.cshtml")]
    public partial class _Areas_Admin_Views_Index_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Admin\Views\Index\Index.cshtml"
  
    Layout = null;

    var User = ViewBag.User;
    var Config = ViewBag.Config;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->\r\n\r\n    <title>");

            
            #line 15 "..\..\Areas\Admin\Views\Index\Index.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 15 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                       Write(Config.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 423), Tuple.Create("\"", 443)
, Tuple.Create(Tuple.Create("", 430), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 430), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- bootstrap & fontawesome -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 555), Tuple.Create("\"", 603)
, Tuple.Create(Tuple.Create("", 562), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 562), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 635), Tuple.Create("\"", 686)
, Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 642), false)
);

WriteLiteral(" />\r\n\r\n    <!-- page specific plugin styles -->\r\n    <!-- text fonts -->\r\n    <li" +
"nk");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 787), Tuple.Create("\"", 829)
, Tuple.Create(Tuple.Create("", 794), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-fonts.min.css")
, 794), false)
);

WriteLiteral(" />\r\n\r\n    <!-- ace styles -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 888), Tuple.Create("\"", 924)
, Tuple.Create(Tuple.Create("", 895), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace.min.css")
, 895), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" id=\"main-ace-style\"");

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1012), Tuple.Create("\"", 1056)
, Tuple.Create(Tuple.Create("", 1019), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/css/ui-dialog.css")
, 1019), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1135), Tuple.Create("\"", 1177)
, Tuple.Create(Tuple.Create("", 1142), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-part2.min.css")
, 1142), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" />\r\n    <![endif]-->\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1283), Tuple.Create("\"", 1322)
, Tuple.Create(Tuple.Create("", 1290), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-ie.min.css")
, 1290), false)
);

WriteLiteral(" />\r\n    <![endif]-->\r\n    <!-- inline styles related to this page -->\r\n    <!-- " +
"ace settings handler -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1441), Tuple.Create("\"", 1480)
, Tuple.Create(Tuple.Create("", 1447), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-extra.min.js")
, 1447), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- HTML5shiv and Respond.js for IE8 to support HTML5 elements" +
" and media queries -->\r\n    <!--[if lte IE 8]>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1621), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/html5shiv.min.js")
, 1627), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1680), Tuple.Create("\"", 1713)
, Tuple.Create(Tuple.Create("", 1686), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/respond.min.js")
, 1686), false)
);

WriteLiteral("></script>\r\n    <![endif]-->\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1793), Tuple.Create("\"", 1831)
, Tuple.Create(Tuple.Create("", 1799), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1799), false)
);

WriteLiteral("></script>\r\n</head>\r\n<body");

WriteLiteral(" class=\"no-skin\"");

WriteLiteral(" style=\"overflow: hidden;\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 50 "..\..\Areas\Admin\Views\Index\Index.cshtml"
Write(Html.Partial("_Navbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"main-container\"");

WriteLiteral(" id=\"main-container\"");

WriteLiteral(">\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                try { ace.settings.check(\'main-co" +
"ntainer\', \'fixed\') } catch (e) { }\r\n            });\r\n        </script>\r\n\r\n      " +
"  <!-- #section:basics/sidebar -->\r\n        <div");

WriteLiteral(" id=\"sidebar\"");

WriteLiteral(" class=\"sidebar                  responsive\"");

WriteLiteral(">\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                $(function () {\r\n                    try { ace.settings.check(" +
"\'sidebar\', \'fixed\') } catch (e) { }\r\n                });\r\n            </script>\r" +
"\n\r\n            <div");

WriteLiteral(" class=\"sidebar-shortcuts\"");

WriteLiteral(" id=\"sidebar-shortcuts\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"sidebar-shortcuts-large\"");

WriteLiteral(" id=\"sidebar-shortcuts-large\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-signal\"");

WriteLiteral("></i>\r\n                    </button>\r\n\r\n                    <button");

WriteLiteral(" class=\"btn btn-info\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-pencil\"");

WriteLiteral("></i>\r\n                    </button>\r\n\r\n                    <!-- #section:basics/" +
"sidebar.layout.shortcuts -->\r\n                    <button");

WriteLiteral(" class=\"btn btn-warning\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-users\"");

WriteLiteral("></i>\r\n                    </button>\r\n\r\n                    <button");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-cogs\"");

WriteLiteral("></i>\r\n                    </button>\r\n\r\n                    <!-- /section:basics/" +
"sidebar.layout.shortcuts -->\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"sidebar-shortcuts-mini\"");

WriteLiteral(" id=\"sidebar-shortcuts-mini\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral("></span>\r\n\r\n                    <span");

WriteLiteral(" class=\"btn btn-info\"");

WriteLiteral("></span>\r\n\r\n                    <span");

WriteLiteral(" class=\"btn btn-warning\"");

WriteLiteral("></span>\r\n\r\n                    <span");

WriteLiteral(" class=\"btn btn-danger\"");

WriteLiteral("></span>\r\n                </div>\r\n            </div>\r\n            <!-- /.sidebar-" +
"shortcuts -->\r\n");

WriteLiteral("            ");

            
            #line 99 "..\..\Areas\Admin\Views\Index\Index.cshtml"
       Write(Html.Partial("_Left"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <!-- #section:basics/sidebar.layout.minimize -->\r\n            <div");

WriteLiteral(" class=\"sidebar-toggle sidebar-collapse\"");

WriteLiteral(" id=\"sidebar-collapse\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"ace-icon fa fa-angle-double-left\"");

WriteLiteral(" data-icon1=\"ace-icon fa fa-angle-double-left\"");

WriteLiteral(" data-icon2=\"ace-icon fa fa-angle-double-right\"");

WriteLiteral("></i>\r\n            </div>\r\n\r\n            <!-- /section:basics/sidebar.layout.mini" +
"mize -->\r\n            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                $(function () {\r\n                    try { ace.settings.check(" +
"\'sidebar\', \'collapsed\') } catch (e) { }\r\n                })\r\n            </scrip" +
"t>\r\n        </div>\r\n\r\n        <!-- /section:basics/sidebar -->\r\n        <div");

WriteLiteral(" class=\"main-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"main-content-inner\"");

WriteLiteral(">\r\n                <!-- /section:basics/content.breadcrumbs -->\r\n                " +
"<div");

WriteLiteral(" class=\"page-content\"");

WriteLiteral(" style=\"padding: 0px;\"");

WriteLiteral(">\r\n                    <!-- #section:settings.box -->\r\n                    <div");

WriteLiteral(" class=\"ace-settings-container\"");

WriteLiteral(" id=\"ace-settings-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"btn btn-app btn-xs btn-warning ace-settings-btn\"");

WriteLiteral(" id=\"ace-settings-btn\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"ace-icon fa fa-cog bigger-130\"");

WriteLiteral("></i>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"ace-settings-box clearfix\"");

WriteLiteral(" id=\"ace-settings-box\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"pull-left width-50\"");

WriteLiteral(">\r\n                                <!-- #section:settings.skins -->\r\n            " +
"                    <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                                        <select");

WriteLiteral(" id=\"skin-colorpicker\"");

WriteLiteral(" class=\"hide\"");

WriteLiteral(">\r\n                                            <option");

WriteLiteral(" data-skin=\"no-skin\"");

WriteLiteral(" value=\"#438EB9\"");

WriteLiteral(">#438EB9</option>\r\n                                            <option");

WriteLiteral(" data-skin=\"skin-1\"");

WriteLiteral(" value=\"#222A2D\"");

WriteLiteral(">#222A2D</option>\r\n                                            <option");

WriteLiteral(" data-skin=\"skin-2\"");

WriteLiteral(" value=\"#C6487E\"");

WriteLiteral(">#C6487E</option>\r\n                                            <option");

WriteLiteral(" data-skin=\"skin-3\"");

WriteLiteral(" value=\"#D0D0D0\"");

WriteLiteral(@">#D0D0D0</option>
                                        </select>
                                    </div>
                                    <span>&nbsp; 选择皮肤</span>
                                </div>

                                <!-- /section:settings.skins -->
                                <!-- #section:settings.navbar -->
                                <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-navbar\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-navbar\"");

WriteLiteral(">Fixed Navbar</label>\r\n                                </div>\r\n\r\n                " +
"                <!-- /section:settings.navbar -->\r\n                             " +
"   <!-- #section:settings.sidebar -->\r\n                                <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-sidebar\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-sidebar\"");

WriteLiteral(">Fixed Sidebar</label>\r\n                                </div>\r\n\r\n               " +
"                 <!-- /section:settings.sidebar -->\r\n                           " +
"     <!-- #section:settings.breadcrumbs -->\r\n                                <di" +
"v");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-breadcrumbs\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-breadcrumbs\"");

WriteLiteral(">Fixed Breadcrumbs</label>\r\n                                </div>\r\n\r\n           " +
"                     <!-- /section:settings.breadcrumbs -->\r\n                   " +
"             <!-- #section:settings.rtl -->\r\n                                <di" +
"v");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-rtl\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-rtl\"");

WriteLiteral(">Right To Left (rtl)</label>\r\n                                </div>\r\n\r\n         " +
"                       <!-- /section:settings.rtl -->\r\n                         " +
"       <!-- #section:settings.container -->\r\n                                <di" +
"v");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-add-container\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-add-container\"");

WriteLiteral(@">
                                        Inside
                                        <b>.container</b>
                                    </label>
                                </div>

                                <!-- /section:settings.container -->
                            </div>
                            <!-- /.pull-left -->

                            <div");

WriteLiteral(" class=\"pull-left width-50\"");

WriteLiteral(">\r\n                                <!-- #section:basics/sidebar.options -->\r\n    " +
"                            <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-hover\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-hover\"");

WriteLiteral(">Submenu on Hover</label>\r\n                                </div>\r\n\r\n            " +
"                    <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-compact\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-compact\"");

WriteLiteral(">Compact Sidebar</label>\r\n                                </div>\r\n\r\n             " +
"                   <div");

WriteLiteral(" class=\"ace-settings-item\"");

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"ace ace-checkbox-2\"");

WriteLiteral(" id=\"ace-settings-highlight\"");

WriteLiteral(" />\r\n                                    <label");

WriteLiteral(" class=\"lbl\"");

WriteLiteral(" for=\"ace-settings-highlight\"");

WriteLiteral(@">Alt. Active Item</label>
                                </div>

                                <!-- /section:basics/sidebar.options -->
                            </div>
                            <!-- /.pull-left -->
                        </div>
                        <!-- /.ace-settings-box -->
                    </div>
                    <!-- /.ace-settings-container -->
                    <!-- /section:settings.box -->
                    <iframe");

WriteLiteral(" style=\"width: 100%; height: 100%; margin: 0; padding: 0; border: none;\"");

WriteLiteral(" id=\"main\"");

WriteLiteral(" name=\"main\"");

WriteAttribute("src", Tuple.Create(" src=\"", 10376), Tuple.Create("\"", 10395)
            
            #line 206 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                                              , Tuple.Create(Tuple.Create("", 10382), Tuple.Create<System.Object, System.Int32>(ViewBag.Main
            
            #line default
            #line hidden
, 10382), false)
);

WriteLiteral("></iframe>\r\n                </div>\r\n                <!-- /.page-content -->\r\n    " +
"        </div>\r\n        </div>\r\n        <!-- /.main-content -->\r\n        <div");

WriteLiteral(" class=\"footer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"footer-inner\"");

WriteLiteral(">\r\n                <!-- #section:basics/footer -->\r\n                <div");

WriteLiteral(" class=\"footer-content\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"bigger-120\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"blue bolder\"");

WriteLiteral(">");

            
            #line 217 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                                             Write(Config.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                        ");

            
            #line 218 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                   Write(Config.Company);

            
            #line default
            #line hidden
WriteLiteral(" &copy; 2002-");

            
            #line 218 "..\..\Areas\Admin\Views\Index\Index.cshtml"
                                               Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n\r\n                    ");

WriteLiteral("\r\n                </div>\r\n\r\n                <!-- /section:basics/footer -->\r\n    " +
"        </div>\r\n        </div>\r\n\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"btn-scroll-up\"");

WriteLiteral(" class=\"btn-scroll-up btn btn-sm btn-inverse\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"ace-icon fa fa-angle-double-up icon-only bigger-110\"");

WriteLiteral("></i>\r\n        </a>\r\n    </div>\r\n    <!-- /.main-container -->\r\n    <!-- basic sc" +
"ripts -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11924), Tuple.Create("\"", 11969)
, Tuple.Create(Tuple.Create("", 11930), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 11930), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11993), Tuple.Create("\"", 12035)
, Tuple.Create(Tuple.Create("", 11999), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-ui.custom.min.js")
, 11999), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 12059), Tuple.Create("\"", 12106)
, Tuple.Create(Tuple.Create("", 12065), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery.ui.touch-punch.min.js")
, 12065), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- ace scripts -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 12158), Tuple.Create("\"", 12200)
, Tuple.Create(Tuple.Create("", 12164), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-elements.min.js")
, 12164), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 12224), Tuple.Create("\"", 12257)
, Tuple.Create(Tuple.Create("", 12230), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace.min.js")
, 12230), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 12300), Tuple.Create("\"", 12349)
, Tuple.Create(Tuple.Create("", 12306), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/dist/dialog-plus-min.js")
, 12306), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 12373), Tuple.Create("\"", 12422)
, Tuple.Create(Tuple.Create("", 12379), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/dist/dialog.new.life.js")
, 12379), false)
);

WriteLiteral("></script>\r\n     \r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            var $frmContent = $('#main');
            function fixFrmContentSize() {
                var offset = $frmContent.offset();
                var top = offset.top;
                var height = document.documentElement.clientHeight;
                $frmContent.height(height - top);
            }
            fixFrmContentSize();
            $(window).resize(fixFrmContentSize);

            //增加iframe被嵌套的检测2015-6-4 景裔增加
            if (window != top) {
                top.location.href = location.href;
            }
        });

    </script>
</body>
</html>");

        }
    }
}
#pragma warning restore 1591
