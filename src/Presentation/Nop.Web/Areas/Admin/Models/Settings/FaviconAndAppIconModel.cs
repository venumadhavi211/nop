using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a favicon and app icons settings model
    /// </summary>
    public partial class FaviconAndAppIconModel : BaseNopModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.FaviconAndAppIcons.PageHeadCode")]
        public string HeadCode { get; set; }
        public bool HeadCode_OverrideForStore { get; set; }

        #endregion
    }
}