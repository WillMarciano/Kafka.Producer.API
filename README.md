# Kafka.Producer.API

A API de produtor do Kafka é responsável por enviar mensagens para um tópico do Kafka. Para isso, 
e chamar o método `SendMessage` passando a mensagem a ser enviada.

## Dependências do projeto

- [Docker Desktop](https://www.docker.com/products/docker-desktop) - Caso deseje rodar por meio de containers
- [kafka](https://kafka.apache.org/quickstart) - Para instalar o Kafka
- [obsidiandynamics/kafdrop](https://github.com/obsidiandynamics/kafdrop) - FrontEnd para visualizações das Mensagens no Kafka
- [ZooKeeper](https://zookeeper.apache.org/) - Zookeeper é um serviço de coordenação distribuída para Apache Kafka


## Rodando o projeto

Para rodar o projeto, pode ser feito pelo Visual Studio ou pelo terminal.
pelo terminal o comando é 

```
 dotnet run --urls="http://localhost:5001"
```

isso irá rodar o projeto na porta 5001.

## Testando a API

Para testar a API, pode ser feito pelo Postman ou Insomnia

abra o Postman e faça uma requisição POST para a URL `http://localhost:5001/?message=teste` passando a mensagem que deseja enviar no header.

## Visualizando as mensagens no KafDrop

Para visualizar as mensagens no KafDrop, acesse o endereço `http://localhost:19000/` e selecione o tópico que deseja visualizar as mensagens.
obs: Verificar a porta que o KafDrop está rodando, pois pode ser diferente da porta 19000.

## Autor

- **Willian Marciano** - [willMarciano](https://github.com/WillMarciano)


