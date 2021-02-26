$CONTAINER_TAG = "poc-docker"
$CONTAINER_NAME = "poc-app"

dotnet publish -c Release

docker stop $CONTAINER_NAME
docker rm $CONTAINER_NAME

docker build -t $CONTAINER_TAG -f Dockerfile .
docker run -d -p "80:80" --name $CONTAINER_NAME $CONTAINER_TAG 