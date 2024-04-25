# Kafka.Producer.API

A API de produtor do Kafka é responsável por enviar mensagens para um tópico do Kafka.

## Dependências do projeto

- [Dotnet Core 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) - SDK do Dotnet Core
- [Docker Desktop](https://www.docker.com/products/docker-desktop) - Caso deseje rodar por meio de containers
- [Kafka](https://kafka.apache.org/quickstart) - Para instalar o Kafka
- [Kafdrop](https://github.com/obsidiandynamics/kafdrop) - FrontEnd para visualizações das Mensagens no Kafka
- [ZooKeeper](https://zookeeper.apache.org/) - Zookeeper é um serviço de coordenação distribuída para Apache Kafka


## Rodando o projeto

Para rodar o projeto, pode ser feito pelo Visual Studio ou pelo terminal.
pelo terminal o comando é 

```
 dotnet run --urls="http://localhost:5001"
```

isso irá rodar o projeto na porta 5001.

![image](https://github.com/WillMarciano/Kafka.Producer.API/assets/34887614/e95775be-992b-48ef-9b26-aa7046f66302)


## Testando a API

Para testar a API, pode ser feito pelo Postman ou Insomnia

abra o Postman e faça uma requisição POST para a URL `http://localhost:5001` passando a mensagem que deseja enviar no corpo da requisição.

json da chamada tem que ter esses campos, "de", "para" e "assunto".

```json
{
	"de": "Will",
	"para": "Marciano",
	"assunto": "Teste"
}
```



![image](https://github.com/WillMarciano/Kafka.Producer.API/assets/34887614/aa72aa18-7aaa-4e78-af03-07bb2673ab6b)



## Visualizando as mensagens no KafDrop

Para visualizar as mensagens no KafDrop, acesse o endereço `http://localhost:19000/` e selecione o tópico que deseja visualizar as mensagens.
obs: Verificar a porta que o KafDrop está rodando, pois pode ser diferente da porta 19000.

![image](https://github.com/WillMarciano/Kafka.Producer.API/assets/34887614/bd2bedeb-eb70-4a9d-ba63-696f7a3eada0)