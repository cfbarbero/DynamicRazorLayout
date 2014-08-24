using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicRazorLayout.Web
{
    public abstract class TestWebViewPage<T> : WebViewPage<T>
    {
        public bool LayoutAssigned
        {
            get
            {
                return (ViewBag.LayoutAssigned == true);
            }
            set
            {
                ViewBag.LayoutAssigned = value;
            }
        }

        public string LayoutName { get; set; }
        public override void ExecutePageHierarchy()
        {
            if (!LayoutAssigned) { base.Layout = "~/Views/Shared/test.cshtml"; LayoutAssigned = true; }
            base.ExecutePageHierarchy();
        }
    }
    public abstract class TestWebViewPage : WebViewPage
    {
        public string LayoutName { get; set; }
        

    }
}