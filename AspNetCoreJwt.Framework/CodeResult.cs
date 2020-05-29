using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreJwt.Framework
{
    public class CodeResult
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public static CodeResult Success()
        {
            return new CodeResult { Code = 0, Msg = "成功" };
        }
    }

    public class CodeResult<T>: CodeResult
    {
        public T Data { get; set; }
    }
}
