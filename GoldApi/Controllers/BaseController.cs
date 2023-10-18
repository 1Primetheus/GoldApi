using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GoldApi.Core.Models;

namespace GoldApi.Controllers;

[Authorize]
[ApiController]
public class BaseController : ControllerBase
{

}