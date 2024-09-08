git clone https://github.com/chupino/lab5daea2.git tuto
cd tuto
git clone https://github.com/MicrosoftDocs/mslearn-interact-with-data-blazor-web-apps.git PizzaApp

docker build -t tuto .

if [ $? -eq 0 ]; then
    echo "todo bien"
else
    echo "mal"
    exit 1
fi

docker run -dp 8000:8000 tuto
docker exec -it $(docker ps -lq) sh