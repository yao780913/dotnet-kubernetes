# Kubernetes 加入 postgres db
## 準備程式
- `install package Npgsql.EntityFrameworkCore.PostgreSQL`
- DbContext - `SchoolContext`
- Entity - `Student`
- Display StudentName in Index.cshtml

## Local 測試
**`Docker compose up`**
- **app** - http://localhost:5000/
- **adminer** - http://localhost:8080/

## Push Image to Docker Hub
`docker build -t billyao78/dotnet-kub-app-2 .`
`docker push billyao78/dotnet-kub-app-2`
