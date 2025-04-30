# 📝 Documentação do Repositório: **jwtRegisterLogin**

Este repositório contém a implementação de autenticação JWT (JSON Web Token) em uma API .NET, permitindo funcionalidades de registro e login de usuários. A seguir, a descrição da estrutura do repositório.

## 📁 Estrutura do Repositório

- **Controllers**: Contém os controladores responsáveis pelas operações de autenticação e gerenciamento de usuários. 
    - Exemplo: `AuthController` para login e registro de usuários.

- **Data**: Pasta responsável pelo gerenciamento do contexto do banco de dados e interações com a camada de dados.

- **Dtos (Data Transfer Objects)**: Contém classes usadas para transferência de dados entre as camadas da aplicação. Aqui, são definidos os DTOs usados nas operações de autenticação.

- **Enum**: Define os enumeradores usados no sistema, como os tipos de cargos de usuários ou status de autenticação.

- **Migrations**: Contém os arquivos de migração para o banco de dados, responsáveis por gerenciar alterações no esquema de banco de dados.

- **Models**: Define os modelos de dados que representam as entidades da aplicação, como **Usuario** e **Cargo**.

- **Properties**: Contém propriedades do projeto, como o arquivo de informações do assembly.

- **Services**: Contém a lógica de negócios e serviços para autenticação, manipulação de senhas, gerenciamento de usuários, etc. Exemplo: `AuthService` e `UsuarioService`.

- **bin/Debug/net6.0**: Diretório de compilação onde os arquivos binários gerados durante a execução do projeto são armazenados.

- **obj**: Diretório usado para armazenar arquivos temporários gerados durante o processo de compilação.

- **Program.cs**: Arquivo de configuração principal da aplicação, onde são configurados serviços como autenticação JWT e outros componentes do projeto.

- **appsettings.json**: Arquivo de configuração da aplicação, utilizado para definir configurações de banco de dados, chaves secretas para JWT e outras variáveis de ambiente.

- **jwtRegisterLogin.csproj**: Arquivo do projeto que define as dependências e configurações para o .NET.

- **jwtRegisterLogin.sln**: Arquivo da solução que agrupa todos os projetos relacionados ao repositório.

## 🚀 Funcionalidades

- **Registro de Usuários**: A API oferece um endpoint `/api/Auth/register` que permite o registro de novos usuários.
- **Login de Usuários**: O endpoint `/api/Auth/login` autentica um usuário e retorna um JWT para o acesso protegido a recursos da API.
- **Autenticação e Autorização com JWT**: O sistema utiliza tokens JWT para garantir a autenticação e autorização de usuários em endpoints protegidos.

## ⚙️ Como Executar o Projeto Localmente

1. Clone o repositório:
   ```bash
   git clone https://github.com/juniorti91/Autenticacao_JWT_.NET.git

Navegue até o diretório do projeto:
cd jwtRegisterLogin

Restaure as dependências:
dotnet restore

Execute o projeto:
dotnet run

A API estará acessível em https://localhost:5001.
