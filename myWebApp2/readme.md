# Kubernetes 加入 postgres db
## 準備程式
- `install package Npgsql.EntityFrameworkCore.PostgreSQL`
- DbContext - `SchoolContext`
- Entity - `Student`
- Display StudentName in Index.cshtml

## Local 測試
**`Docker compose up`**\
透過 adminer 加入新的 Student 資料，並在網頁看檢視結果
- **app** - http://localhost:5000/
- **adminer** - http://localhost:8080/


## Push Image to Docker Hub
- `docker build -t billyao78/dotnet-kub-app-2 .`
- `docker push billyao78/dotnet-kub-app-2`

## Apply yaml files
-  **pv** and **pvc** - `kubectl apply -f postgres-pv.yml -f postgres-pvc.yml`
- **app** and **db** - `kubectl apply -f postgres-db.yml -f dotnet-kub-app-2.yml`
- **minikube** - `minikube service postgres-service adminer-service dotnet-service-2`

> **Host = {serviceName}**  
> 修改 Host=`postgres-service`;port=5432;Database=SchoolDB;Username=postgres;Password=postgres
