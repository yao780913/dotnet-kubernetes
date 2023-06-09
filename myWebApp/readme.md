# Kubernetes

## Install minikube
[minikube start](https://minikube.sigs.k8s.io/docs/start/)

```shell
New-Item -Path 'c:\' -Name 'minikube' -ItemType Directory -Force
Invoke-WebRequest -OutFile 'c:\minikube\minikube.exe' -Uri 'https://github.com/kubernetes/minikube/releases/latest/download/minikube-windows-amd64.exe' -UseBasicParsing
```

```shell
$oldPath = [Environment]::GetEnvironmentVariable('Path', [EnvironmentVariableTarget]::Machine)
if ($oldPath.Split(';') -inotcontains 'C:\minikube'){ `
  [Environment]::SetEnvironmentVariable('Path', $('{0};C:\minikube' -f $oldPath), [EnvironmentVariableTarget]::Machine) `
}
```

## Install kubectl
[kubectl install](https://kubernetes.io/docs/tasks/tools/install-kubectl-windows/)

- `kubectl version --client --output=yaml`
- `kubectl config view`

## Run minikube
- `minikube start`
  ```shell
    * minikube v1.30.1 on Microsoft Windows 11 Pro 10.0.22621.1702 Build 22621.1702
    * Using the docker driver based on existing profile
    * Starting control plane node minikube in cluster minikube
    * Pulling base image ...
    * docker "minikube" container is missing, will recreate.
    * Creating docker container (CPUs=2, Memory=4000MB) ...
    * Preparing Kubernetes v1.26.3 on Docker 23.0.2 ...
    * Configuring bridge CNI (Container Networking Interface) ...
    * Verifying Kubernetes components...
      - Using image gcr.io/k8s-minikube/storage-provisioner:v5
      - Using image docker.io/kubernetesui/dashboard:v2.7.0
      - Using image docker.io/kubernetesui/metrics-scraper:v1.0.8
    * Some dashboard features require the metrics-server addon. To enable all features please run:
    
            minikube addons enable metrics-server
    
    * Enabled addons: storage-provisioner, default-storageclass, dashboard
    * Done! kubectl is now configured to use "minikube" cluster and "default" namespace by default
    
  ```

- `minikube status`
- `minikube dashboard`