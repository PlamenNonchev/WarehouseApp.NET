namespace WarehouseApp.Web.Areas.Administration.Controllers
{
    using WarehouseApp.Common;
    using WarehouseApp.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
