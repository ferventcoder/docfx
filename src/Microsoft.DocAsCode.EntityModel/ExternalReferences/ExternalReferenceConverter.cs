﻿namespace Microsoft.DocAsCode.EntityModel
{
    using Microsoft.DocAsCode.EntityModel.ViewModels;
    using System;
    using System.Collections.Generic;

    public class ExternalReferenceConverter
    {
        public static IEnumerable<ReferenceViewModel> ToExternalReferenceViewModel(PageViewModel page, Uri baseUri)
        {
            foreach (var item in page.Items)
            {
                yield return new ReferenceViewModel
                {
                    Uid = item.Uid,
                    Name = item.Name,
                    NameForCSharp = item.NameForCSharp,
                    NameForVB = item.NameForVB,
                    Fullname = item.Fullname,
                    FullnameForCSharp = item.FullnameForCSharp,
                    FullnameForVB = item.FullnameForVB,
                    Type = item.Type,
                    Href = new Uri(baseUri, item.Href).ToString(),
                };
            }
        }
    }
}