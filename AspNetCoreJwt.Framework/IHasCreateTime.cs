using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreJwt.Framework
{
    public interface IHasCreateTime
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreateTime { get; set; }
    }
}
