/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sys_ConfigController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/Sys_Config")]
    [PermissionTable(Name = "Sys_Config")]
    public partial class Sys_ConfigController : ApiBaseController<ISys_ConfigService>
    {
        public Sys_ConfigController(ISys_ConfigService service)
        : base(service)
        {
        }
    }
}

