# 📚 EditoraSpread -- Backend & Frontend

Este repositório contém instruções para rodar o **projeto completo**
(API + Frontend).\
⚠️ Os projetos estão em repositórios separados, mas este guia mostra
como configurar e executar ambos localmente.

------------------------------------------------------------------------

## 🚀 Tecnologias

-   **Back-end:** .NET 8, DDD, Entity Framework / Dapper, SQLServer\
-   **Front-end:** Angular 20, TypeScript\
-   **Banco de Dados:** SQLServer

------------------------------------------------------------------------

## 📦 Pré-requisitos

Antes de rodar o projeto, instale:

-   [Node.js (LTS)](https://nodejs.org/)\
-   [Angular CLI](https://angular.dev/cli)\
-   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)\
-   [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) \
-   Git

------------------------------------------------------------------------

## ⚙️ Configuração do Backend

1.  Clone o repositório do backend:

    ``` bash
    git clone https://github.com/seu-usuario/editora-back.git
    cd editora-back
    ```

2.  Configure o banco de dados no `appsettings.Development.json`:

    ``` json
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EditoraSpreadDB;Trusted_Connection=True;"
    }
    ```

3.  Execute as migrações (se estiver usando EF):

    ``` bash
    dotnet ef database update
    ```

4.  Rode o projeto:

    ``` bash
    dotnet run --project src/EditoraSpread.Api
    ```

    A API ficará disponível em:

        http://localhost:5000

------------------------------------------------------------------------

## 🎨 Configuração do Frontend

1.  Clone o repositório do frontend:

    ``` bash
    git clone https://github.com/seu-usuario/editora-front.git
    cd editora-front
    ```

2.  Instale as dependências:

    ``` bash
    npm install
    ```

3.  Configure a URL da API no `environment.ts`:

    ``` ts
    export const environment = {
      apiUrl: 'http://localhost:5000'
    };
    ```

4.  Rode o projeto:

    ``` bash
    ng serve -o
    ```

    O frontend ficará disponível em:

        http://localhost:4200

------------------------------------------------------------------------

## ✅ Fluxo de Execução Local

1.  Subir o **Backend** (`dotnet run` ou `docker run`)\
2.  Subir o **Frontend** (`ng serve` ou `docker run`)\
3.  Acessar o sistema em:\
    👉 `http://localhost:4200` (Frontend)\
    👉 `http://localhost:5000` (API)

------------------------------------------------------------------------

## 🧪 Testes

### Backend

``` bash
dotnet test
```

### Frontend

``` bash
ng test
```
