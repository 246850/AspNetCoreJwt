using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreJwt.Restful
{
    public sealed class RsaKeys
    {
        public static readonly string RsaPublicKey = @"MIIBCgKCAQEAt46Ij6URKx3OtJvlOgHNHofVHwBMXZLVe+tSgq+hNw7MD1f+susBYTgm/IoUs+KOsyv+CsXvBPwfx1jkdqT2V7SlSoCQSy6aMWv3ALtnhJALdJq2byhQO9vQ04KmayjCX5l6YOvvGlDjBISYd/k+IqQpMRtUPsYJs2Flv6WAjzNclLRFqmftYD4TtvYQcyyyZPGLYN/Pdx4/2Q4M0o+6BNJVMvEOa48FMVfqG1VzcEK9+LlwgoGBDcmrtIci5dX2LMb+LC1523MI4B4Rf9Tl/5uszUlr5dLngB/IEluopSsuuc74UGCdtOryJXyTTJ41gjco3K3MKxPFL7d+lncnmwIDAQAB";
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
    }
}
