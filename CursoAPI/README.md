# INICIO ---- INSTALANDO SUPORTE AO SWAGGER
** Botão direto no projeto "Manage Nuget Packege " procurar e instalar o SwashbuckeAspNetCore, pode ser que já esteja instalado.

# CONFIGURANDO O SWAGGER
** Botão direto no projeto Selecionar Propriedades
** Clicar em BUILD ou COMPILAR
** Ativar/Marcar a opção de Arquivo de Documentação XML (XML documentation file).
** Salvar
** Em Depurar mudar o inciar Navegador para swagger
** Salvar

# STARTUP.cs
* Adicionar o comando abaixo no ConsgureServices
     services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "CursoAPI", Version = "v1" });
        });
*Adicionar os middlewares em Configure
   app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CursoAPI v1"));
# FIM ---- INSTALANDO SUPORTE AO SWAGGER

# Executando dois projeto em paralelo
* Botão direito na Solution, Propriedades, em Projeto de Inicialização selecionar Vários projetos e em ação marcar Iniciar ou Iniciar sem Depurar

## PUBLICANDO NA AZURE
Precisa estar logado no Visual Studio com a mesma conta da Azure
Se estiver usando uma versão do NET Core acima 3.0 precisa executar o comando abaixo dentro da pasta de migrations
**** dotnet tool install --global dotnet-ef --version 3.0.0

Clicar no Porjeto MVC  botão direto e clicar em publicar
Clicar em avançado, nesse momento pode ser feito a alteração da string de conexao