using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MyBand
{
    public class BundleConfig
    {
        // 번들 작성에 대한 자세한 내용은 http://go.microsoft.com/fwlink/?LinkId=301862 링크를 참조하십시오.
        public static void RegisterBundles(BundleCollection bundles)
        {
            var commonjs = new List<string> {
                "~/Scripts/common/angular.min.js",
                "~/Scripts/common/angular-animate.min.js",
                "~/Scripts/common/angular-route.min.js",
                "~/Scripts/common/angular-cookies.min.js",
                "~/Scripts/common/ng-file-upload-all.js",
                "~/Scripts/common/jquery-1.12.0.min.js",
                "~/Scripts/common/underscore.min.js",
                "~/Scripts/tqoon/common/*.js",
                "~/Scripts/tqoon/tqoonWebV2/common/*.js"
            };
            var commonjsDev = new[] { "~/Scripts/jasmine/jasmine.js", "~/Scripts/jasmine/jasmine-html.js", "~/Scripts/jasmine/boot.js" }
                .Union(commonjs)
                .Union(new[] { "~/Scripts/common/angular-mocks.js" });

            bundles.Add(new ScriptBundle("~/bundles/commonjs").Include(commonjs.ToArray()));
            bundles.Add(new ScriptBundle("~/bundles/commonjsDev").Include(commonjsDev.ToArray()));
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Modernizr의 개발 버전을 사용하여 개발하고 배우십시오. 그런 다음
            //// 프로덕션할 준비가 되면 http://modernizr.com 링크의 빌드 도구를 사용하여 필요한 테스트만 선택하십시오.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/common/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/common/bootstrap.js",
                      "~/Scripts/common/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
