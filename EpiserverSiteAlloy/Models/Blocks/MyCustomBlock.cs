using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverSiteAlloy.Models.Blocks
{
    [ContentType(DisplayName = "MyCustomBlock", GUID = "63b30fe9-8534-4d46-ab5a-e3f9146017f2", Description = "")]
    public class MyCustomBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Heading field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(GroupName = SystemTabNames.Content)]
        public virtual Url MainImage { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Display(Name ="Description", GroupName = SystemTabNames.Content)]
        public virtual string Description { get; set; }
    }
}