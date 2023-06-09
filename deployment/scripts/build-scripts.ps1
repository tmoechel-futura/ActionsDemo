Set-Location -Path "C:\Entwicklung\Learning\FS.TechDemo"
docker build . -t tmoechel/order-service:1.6 -f FS.TechDemo.OrderService/Dockerfile
docker build . -t tmoechel/delivery-service:1.6 -f FS.TechDemo.DeliveryService/Dockerfile
docker build . -t tmoechel/buyer-bff:1.6 -f FS.TechDemo.BuyerBFF/Dockerfile

docker image push tmoechel/order-service:1.6
docker image push tmoechel/delivery-service:1.6
docker image push tmoechel/buyer-bff:1.6
