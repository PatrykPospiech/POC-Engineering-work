docker stop db1
docker stop db2

docker rm db1
docker rm db2

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Warehouse!' -p 1401:1433 -d  --name db1 mcr.microsoft.com/mssql/server:2017-CU8-ubuntu
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Warehouse!' -p 1402:1433 -d  --name db2 mcr.microsoft.com/mssql/server:2017-CU8-ubuntu
#docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=warehouse' -p 1433:1434 -d mcr.microsoft.com/mssql/server:2017-CU8-ubuntu