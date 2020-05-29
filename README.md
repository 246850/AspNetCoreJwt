# AspNetCoreJwt
asp.net core api 3.1 json web token授权案例，集成Swagger
# 配置文件
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "Jwt": {
    "Issuer": "AspNetCoreJwt",
    "Audience": "AspNetCoreJwt",
    "SecurityKey": "this is a test jwt demo"
  }
}

```
# 演示站点
[http://101.132.140.8:3612/swagger/index.html](http://101.132.140.8:3612/swagger/index.html)
![](https://images.cnblogs.com/cnblogs_com/GodX/572372/o_2005290816085FAC979D-4405-4d05-B2FA-C7733B0F68AB.png)
