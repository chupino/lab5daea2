git clone https://github.com/chupino/lab5daea2.git tuto
cd tuto

docker build -t tuto .

if [ $? -eq 0 ]; then
    echo "todo bien"
else
    echo "mal"
    exit 1
fi

docker run -itp 8000:8000 tuto