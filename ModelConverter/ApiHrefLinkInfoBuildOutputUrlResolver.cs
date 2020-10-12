﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Web;
using AutoMapper;

namespace DocFx.Plugins.TypeScriptReference
{
    public class ApiHrefLinkInfoBuildOutputUrlResolver : IValueResolver<LinkInfo, ApiLinkInfoBuildOutput, string>
    {
        public string Resolve(LinkInfo source, ApiLinkInfoBuildOutput destination, string destMember, ResolutionContext context)
        {
            var href = $"<span><a href=\"{HttpUtility.HtmlEncode(source.LinkId)}\">";
            if (!string.IsNullOrEmpty(source.AltText))
            {
                href += HttpUtility.HtmlEncode(source.AltText);
            }
            href += "</a></span>";
            return href;
        }
    }
}
