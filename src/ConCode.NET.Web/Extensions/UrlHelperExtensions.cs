﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace ConCode.NET.Web.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string AbsoluteContent(this IUrlHelper url, string contentPath)
        {
            var request = url.ActionContext.HttpContext.Request;
            return new Uri(new Uri(request.Scheme + "://" + request.Host.Value), url.Content(contentPath)).ToString();
        }
    }
}
