using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreJwt.RequestDTO
{
    /// <summary>
    /// 根据Id获取用户信息 请求模型
    /// </summary>
    public class UserInfoGetRequestDTO
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
    }
}
