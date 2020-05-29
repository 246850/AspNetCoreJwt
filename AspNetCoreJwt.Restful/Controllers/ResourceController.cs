using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreJwt.Framework;
using AspNetCoreJwt.RequestDTO;
using AspNetCoreJwt.ResponseDTO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreJwt.Restful.Controllers
{
    /// <summary>
    /// 资源控制器
    /// </summary>
    [ApiController]
    [Authorize()]
    [Route("api/[controller]/[action]")]
    public class ResourceController : ControllerBase
    {

        private readonly ILogger<ResourceController> _logger;

        public ResourceController(ILogger<ResourceController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public CodeResult<UserInfoResponseDTO> Get()
        {
            var random = new Random();
            UserInfoResponseDTO item = new UserInfoResponseDTO
            {
                Id = random.Next(1000, 10000),
                Name = "姓名" + random.Next(10, 100),
                Age = random.Next(18, 100)
            };
            return item.Success();
        }

        /// <summary>
        /// 创建用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public CodeResult Create(UserInfoCreateOrUpdateRequestDTO request)
        {
            // 插入数据...

            return CodeResult.Success();
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public CodeResult Update(UserInfoCreateOrUpdateRequestDTO request)
        {
            // 更新数据...

            return CodeResult.Success();
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public CodeResult Delete(UserInfoGetRequestDTO request)
        {
            // 删除数据...

            return CodeResult.Success();
        }
    }
}
