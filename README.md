# Instruções para instalação
``` bash
git clone git@github.com:torneseumprogramador/smk-travel.git
cd smk-travel/
dotnet build
# alterar a senha do banco de dados em DefaultConnection no arquivo abaixo:
vim appsettings.json
dotnet ef database update
dotnet run
```

# Itens utilizados ao criar o sistema

SQL Server by docker

```shell

docker pull mcr.microsoft.com/mssql/server:2022-latest

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SSeQrLv8e9r0My" \
   -p 1433:1433 --name sql1 --hostname sql1 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest

```

# Comandos para migração:
``` bash
dotnet tool install --global dotnet-ef

export PATH="$PATH:$HOME/.dotnet/tools/"

dotnet ef migrations add ClienteAdd
dotnet ef database update
```

# Instalação do code generator
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de clientes
``` bash
dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
