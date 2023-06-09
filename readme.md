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
