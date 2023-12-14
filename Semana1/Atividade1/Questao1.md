#Questao 1

Você pode utilizar o comando "dotnet new console" para criar um novo projeto em .net, podendo utilizar o "dotnet build" e "dotnet run", se o .net estiver corretamente instalando, o projeto deve ser capaz de compilar e executar. 

Para verificar as versões do sdk instaladas pode ser usado o comando "dotnet --list-sdks", e o "dotnet --list-runtimes" para verificar as Runtimes instaladas.

Para atualizar o .net pode ser utilizado o comando admin para linux "sudo apt upgrade dotnet-sdk" ou ainda o comando "./dotnet-install.sh --version latest".

Já para a remoção, pode ser utilizado o comando "sudo apt-get remove dotnet-sdk-versão_a_ser_removida".

Note que após a instalação, é necessário definir as variáveis de ambiente. Os comandos "export DOTNET_ROOT=$HOME/.dotnet" e "export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools" devem ser utilizados, e são encontrados nas páginas de tutorial da Microsoft.