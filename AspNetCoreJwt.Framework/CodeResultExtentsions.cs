using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreJwt.Framework
{
    public static class CodeResultExtentsions
    {
        public static CodeResult<T> Success<T>(this T source)
        {
            return new CodeResult<T>
            {
                Data = source,
                Code = 0,
                Msg = "成功"
            };
        }
    }
}
