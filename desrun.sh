rm -rf tuto
docker rm -f $(docker ps -lq)
docker rmi -f tuto