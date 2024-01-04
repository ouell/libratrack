# LibraTrack 📚

![.NET 8](https://img.shields.io/badge/.NET-8-blue.svg)
![SQL Server](https://img.shields.io/badge/SQL_Server-2019-red.svg)

Projeto de estudo de um sistema de gerenciamento de bibliotecas moderno e eficiente, desenvolvido com .NET 8 e SQL Server. O LibraTrack permite o gerenciamento de livros, usuários, empréstimos e penalidades de forma intuitiva e robusta.

## Recursos 🌟

- **Cadastro e Gerenciamento de Livros**: Mantenha um registro atualizado de todos os livros disponíveis na biblioteca.
- **Gerenciamento de Usuários**: Controle quem pode emprestar livros, com categorias de usuários e informações detalhadas.
- **Sistema de Empréstimos e Devoluções**: Gerencie empréstimos, renovações e devoluções de forma eficiente.
- **Relatórios Detalhados**: Gere relatórios para ter insights sobre as operações da biblioteca.

## Tecnologias Utilizadas 💻

- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Bibliotecas Principais 📚

- [NSubstitute](https://nsubstitute.github.io/): Biblioteca para criação de mock objects em testes unitários.
- [Hangfire](https://www.hangfire.io/): Biblioteca para execução de tarefas em background.
- [Bogus](https://github.com/bchavez/Bogus): Biblioteca para geração de dados falsos (fake data) para testes.
- [xUnit](https://xunit.net/): Framework para testes unitários.
- [MediatR](https://github.com/jbogard/MediatR): Biblioteca para implementação de padrões de Mediator.


## Configuração e Instalação 🛠️

1. Clone o repositório:
   ```bash
   git clone https://github.com/ouell/libratrack.git
   ```

2. Navegue até a pasta do projeto e restaure os pacotes:
   ```bash
   cd LibraTrack
   dotnet restore
   ```

3. Configure o SQL Server e atualize a string de conexão no arquivo:


   &nbsp; 
   **appsettings.json**

4. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Inicie o projeto:
   ```bash
   dotnet run
   ```

## Contato 📩

Wellington M. Alves - wellmalves@gmail.com

Link do Projeto: [https://github.com/seu-usuario/LibraTrack](https://github.com/ouell/libratrack)

