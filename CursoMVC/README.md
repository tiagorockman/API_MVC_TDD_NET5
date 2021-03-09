
 # Instalação Entity framework via Nuget
 * Install-Package Microsoft.EntityFrameworkCore.SqlServer
 * Install-Packege Microsoft.EntityFrameworkCore.Tools
 # Adicionando o Migration (Criando a base)
 * Add-Migration InitialCreate (Cria o Migration)
 * Update-Database (Cria a base de fato)

 # Instalação pela CLI do .NET Core
 * dotnet add package Microsoft.EntityFrameworkCore.SqlServer
 * dotnet add package Microsoft.EntityFrameworkCore.Design
 * dotnet tool install --global dotnet-ef (Instala a ferramenta do Entity Framework Globalmente)

 # Adicionando o Migration (Criando a base)
 * dotnet ef migrations add InitialCreate 
 * dotnet ef database update
 * dotnet ef migrations add Produto (Quando adicionou novo Model para criar também a nova tabela na base)
 * dotnet ef database update (Atualiza a base novamente)

 # Remover Migration
 * dotnet ef migrations remove

 # Restaturar para uma migração exemplo para a primeira
 * dotnet ef database update 0
 * dotnet ef database update

 # CONECTANDO À BASE NO VS STUDIO
 -- Na guia Server Explorer vá na opção connect to database, inclua o nome da conexão (localdb)\mssqllocaldb e acesse à base de dados