## 範例1 - myWebApp
單純的 WebApp\
執行以下指令, 即可在瀏覽器開啟網頁察看結果
- Push Image
  - `cd myWebApp` 
  - `docker build -t billyao78/dotnet-kub-app-1 .`
  - `docker push billyao78/dotnet-kub-app-1`
- Run minikube
  - `cd Kubernetes` 
  - `kubectl apply -f deployment.yml -f service.yml`
  - `minikube service dotnet-service-1`

## 範例2 - myWebApp2
WebApp + postgreSQL
- Push Image
  - `cd myWebApp2`
  - `docker build -t billyao78/dotnet-kub-app-2 .`
  - `docker push billyao78/dotnet-kub-app-2`
- Apply yml
  - `cd Kubernetes`   
  - `kubectl apply -f postgres-pv.yml -f postgres-pvc.yml`
  - `kubectl apply -f environment.yml`
  - `kubectl apply -f postgres-db.yml -f dotnet-kub-app-2.yml`
- Run minikube
  - `minikube service postgres-service adminer-service dotnet-service-2`
> `appsettings.json`連線字串內`Host`的值必須等於`postgres-service`(db 的 ServiceName)
