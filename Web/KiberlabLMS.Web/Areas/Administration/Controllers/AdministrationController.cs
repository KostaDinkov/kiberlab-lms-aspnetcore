namespace KiberlabLMS.Web.Areas.Administration.Controllers
{
    using KiberlabLMS.Common;
    using KiberlabLMS.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
