FROM mihamarkic/sledilec-mono-pi

RUN mkdir -p /etc/app
WORKDIR /etc/app

COPY server /etc/app/

RUN mkdir -p /src/docker/log/server/
VOLUME /src/docker/log/server/
CMD [ "fastcgi-mono-server4",  "/applications=/:/etc/app/", "/socket=tcp:172.26.1.3:80" ]