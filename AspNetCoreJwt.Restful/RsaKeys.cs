using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreJwt.Restful
{
    public static class RsaKeys
    {
        /// <summary>
        /// pkcs 1
        /// </summary>
        public static readonly string RsaPublicKey = @"MIIBCgKCAQEAt46Ij6URKx3OtJvlOgHNHofVHwBMXZLVe+tSgq+hNw7MD1f+susBYTgm/IoUs+KOsyv+CsXvBPwfx1jkdqT2V7SlSoCQSy6aMWv3ALtnhJALdJq2byhQO9vQ04KmayjCX5l6YOvvGlDjBISYd/k+IqQpMRtUPsYJs2Flv6WAjzNclLRFqmftYD4TtvYQcyyyZPGLYN/Pdx4/2Q4M0o+6BNJVMvEOa48FMVfqG1VzcEK9+LlwgoGBDcmrtIci5dX2LMb+LC1523MI4B4Rf9Tl/5uszUlr5dLngB/IEluopSsuuc74UGCdtOryJXyTTJ41gjco3K3MKxPFL7d+lncnmwIDAQAB";

        /// <summary>
        /// pkcs 1
        /// </summary>
        public static readonly string RsaPrivateKey = @"MIIEpQIBAAKCAQEAt46Ij6URKx3OtJvlOgHNHofVHwBMXZLVe+tSgq+hNw7MD1f+
susBYTgm/IoUs+KOsyv+CsXvBPwfx1jkdqT2V7SlSoCQSy6aMWv3ALtnhJALdJq2
byhQO9vQ04KmayjCX5l6YOvvGlDjBISYd/k+IqQpMRtUPsYJs2Flv6WAjzNclLRF
qmftYD4TtvYQcyyyZPGLYN/Pdx4/2Q4M0o+6BNJVMvEOa48FMVfqG1VzcEK9+Llw
goGBDcmrtIci5dX2LMb+LC1523MI4B4Rf9Tl/5uszUlr5dLngB/IEluopSsuuc74
UGCdtOryJXyTTJ41gjco3K3MKxPFL7d+lncnmwIDAQABAoIBAQC0Nm0e0oobkcU6
jwArxk7zVZrJOArBqAKPCkfU5Mfb/VwdCGCYmp+dKnskYBDZV2qQwHVHcHMtqrcs
ibqsPWNaUpIhpj2EgrmCIiS8hEGq5Z1JmwfX9HVpf3Pz5QasmLTVFSMQezMh3B42
dlQXHg6CBjgm7VT12Ir3oX06/itM6w9q588aDMgEST8tWn5OUbNlI32/il/Xj/j3
7GU29LbQNijwwbREU9D7v5rJMdpRRPYEJBjaGukP6atn5RErmBjDrI2glUOSlo3N
OhNELxjjRsOCcYD/xqzcDUIfr3P9LAV4EYLYrsu8fn93xA5BqTdsrtXef657SRvJ
IKbrS1B5AoGBAOAkst8iGKZZSfU/GF0yGd1vxpqc6H5zobvr+fb484EJ2C56Cz6z
sf5M7O0AL0GX4/jEy2ydqV1A+QXllm6VmlgEsHceVxfh/auTdazT5D6atpFRQdpM
En9E0rXxsR6VQOoy2+S3Vax5Nyzurkn0WdAfFPvGRaoHlD4k5oLzxs6NAoGBANGl
HrILWQ2D3v2K02KGCzzaf8Y3p1DQn6w8BqEAu5x8xQgF6xhRJ0y0L6H2nEegwlXo
K9sWeq8dN5pGogSOhJvzB/TZXPPv0Eqk8O42pa/3eIWsr0vLKPvw7FcsfQ5uJWNl
uD1/Gmrui/rSXK3lIV4QGflPyf4zDGd6fPP/JPjHAoGBAKfIkOUavtz3BbfBjVlm
AZqS61YdkqPlpvHnCOxpGs5DMkJINVawaNL1fn1CoB03t/0mQyiBNKCL3F0fqWYK
MskkaXwhiAxmrN7cuT+wNbDvWy6YZvUj8My4FgsAaxd7nmYxwA0Ld+RtsHHAEVNm
yDxUp/54QvmuRrfmI29vUCiZAoGAT50dIxAcKX3C2RY3YFr3OYzgqS3JZG9Vs9q3
yby1gp//UySsOvfWrNJgpGk6wBjUtDsPLIxE2uuFihj4vjJBOdf5VYqWOi0ANNie
hlhKY6DfLCSADZCBZ+v+VLyYYTqDCFRAu1nhdmpQzlfEymURXt9OfddHJjnMpB9o
BGEIcVECgYEA2nfsDfdf7Toi6bHMj9jlzScUxcFcM6+TOcifj60sFmEhcq58LgsB
6MFANL9EJQDQolOWDcrH9OICn/8xGsbgYquxMJSBc3boOFO53F6a/94YbOF8HgmO
aWPUejhKgvXDK3ldLnYNelJcf4Sgca6nVCnYNAoFzzSn3GFjZVxAcwE=";

        /// <summary>
        /// pkcs 8
        /// </summary>
        public static readonly string RsaPublicKey8 = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqqMTAmYFsEb5bIVb83m2
7VaxpYqFxaWF/0/G9RYVtbpRVomouE/pt9ajrZjXxkt6qtGH4rczXTyaov+e9KUe
7WLSvpSTd10s8tzJ0lftXB/AmpY+q8Y9PIMmkQQY28MD5Ffsby0AZyrpY5HHASQt
OlmCD/Fv2E2Qysf8896I76ggb619CPI4gMsvgWrrkFrOllgo7z9ClkM9uVEoj2O0
F5sgNZljlhWE2wtGwAxHQFAliZOW5NFbXsqrWJ0q7l5NPG3aVBPGVApx8MW/R8m0
cC71nUib5n8N0b5eGJ7wbMtG4f7waJZsEHvOZXQ5un3twmTAdQIyT8IGkaJZnx9E
8wIDAQAB";

        /// <summary>
        /// pkcs 8
        /// </summary>
        public static readonly string RsaPrivateKey8 = @"MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCqoxMCZgWwRvls
hVvzebbtVrGlioXFpYX/T8b1FhW1ulFWiai4T+m31qOtmNfGS3qq0YfitzNdPJqi
/570pR7tYtK+lJN3XSzy3MnSV+1cH8Calj6rxj08gyaRBBjbwwPkV+xvLQBnKulj
kccBJC06WYIP8W/YTZDKx/zz3ojvqCBvrX0I8jiAyy+BauuQWs6WWCjvP0KWQz25
USiPY7QXmyA1mWOWFYTbC0bADEdAUCWJk5bk0VteyqtYnSruXk08bdpUE8ZUCnHw
xb9HybRwLvWdSJvmfw3Rvl4YnvBsy0bh/vBolmwQe85ldDm6fe3CZMB1AjJPwgaR
olmfH0TzAgMBAAECggEAdsrqu/u8sBjpIhTBjAJLSHXXXNDQCmYOoEywzQUf/hEE
+UMCs7XmlvaVopBKf6Eid/NBL6Os3ZcIbLuatOSTYF4xKz6SX0H9veHZm1ddRopQ
cw5v+PQcw5jma4S3rZ7Zgcl4L3nb0vb73japnXDLD9kqg+DopWRyjcmmnzxohraY
53FEENb4s9Jwa5tlLbwbBRR+CqqaGHXFq4Ispjr8EXuqKkJnfeBlCUHy4cDULAzf
7r2xujVzQFBaQG2aHeDqLwBdksUK0N0MQ/wA3i7Ji2V9Nw45d8ulSd1ZMIaBxRI+
yYeaEWU2N/DYQtEop911Py8sIhmLDNTChQQLGGNU4QKBgQDbpydWote5XoUKl7n9
utwXVFioBBNfghpQ52aSr038/lCZEajUa+hvRv4OqXfschcpWVPuGq1bWUqrcDy3
Eywor2o6T9oXk4LEyd75h/cP5va0XheQlAsLHGHz88LsO2HdRvj6A+J3feX4uLAV
S98bZyeGLueXAzzfs44GTlAe8QKBgQDG34crGDkikMDDxSMDI1b/S73N3z6Z1TvT
4iCVnW2+b3ALc+0jUJ9/cqZRpdWjfZfFaSyHaRqMdDH54I5QQINFcsekBDAuE5Qc
ColbPySdYBo6Kapch4Ve04h9B/tF+981tJiKMRBQXIX6GmV3SIylraf8Tg0Fi8G2
7K0LPY+qIwKBgQCvjl2mpOh+Q8lZugLxhJO8IbHqN7e0MiwOVaRpwKs4dZq9fJvP
i59usPMFjPVIibdxWO/38mJ0DF3dwAsG19AHhIwGpyPMjB2MYzxPfBg/IX40kq+K
4oghDUJM1JsKbDu/u6XrTYeHsZxIunQh0U40fLHeUUbQL8pLkRsGdzkaQQKBgF8C
v4L5KaK34UAmWJnRMmj5eI54j2HTG6gYqlSQR7PpbXArTCnJBMpQreDoB276O54W
py1yKzra8F1eyN7SU2TEd1iGn7YDqIjVB9ZODmIZXa5X5YobPL6W9Og2/fbrZDI2
O4IZ+p9J9MAOCFe6k2c71buWVmZF5KBN5kYufQpdAoGAXpuOq5V1tSVSJ2HhdyqT
8Ow6Ib5TmqC2o7xxHeMHzW/IMsP6+HdAszRLjpQC3Ol+aJnIpyyF96fzYME9sIvI
BLRxL0/6TjdYEiC9JEWujy97qYDrzsGtwR8KgmXPOz1ZKeqezLAFePbI/VxRpsDc
Znylzj331QW4lubRVMdvZ/A=";


        public static byte[] FromBase64Url(string base64Url)
        {
            string padded = base64Url.Length % 4 == 0
                ? base64Url : base64Url + "====".Substring(base64Url.Length % 4);
            string base64 = padded.Replace("_", "/")
                                    .Replace("-", "+");
            byte[] bytes = Convert.FromBase64String(base64);
            if (bytes[0] == 0)
            {
                byte[] tmp = new byte[bytes.Length - 1];
                Buffer.BlockCopy(bytes, 1, tmp, 0, tmp.Length);
                bytes = tmp;
            }

            return bytes;
        }

        public static string GetCorrectRsaKey(this string key)
        {
            return key.Replace(@"\r", string.Empty).Replace(@"\n", string.Empty).Replace(@"\s", string.Empty);
        }
    }
}
