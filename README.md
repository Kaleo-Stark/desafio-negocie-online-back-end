# Desafio Negocie Online Back-End
API feita com ASP.NET core para se conectar e fazer consultas em um banco de dados Postgres utilizando Dapper.

Nesse projeto a API é responsavel por receber e salva dados relacionados a um CEP, esses dados são enviados por um [Front-End feito em Angular](https://github.com/Kaleo-Stark/desafio-negocie-online-front-end), após o recebimento na API os dados são salvos em um banco de dados Postgres, essses dados também podem ser acessados pela API.

Para executar a API é necessario colocar a String de conexão no arquivo `CEPServices.cs`, há uma tag `<String de conexão aqui>`, após a configuração da String de conexão basta executar `dotnet build` e em seguida `dotnet run`, a rota `http://localhost:5000/cep` com os métodos `POST` e `GET`, estarão disponiveis para serem consumidas.
