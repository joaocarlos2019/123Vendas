# 123Vendas
Projeto Criado para o teste da empresa NTT-DATA

#Para teste Da Aplicação.
A aplicação foi desenvolvida em .net core 8,portanto necessário utilizar o visual studio 2022 para teste da mesma.Para teste rodar a aplicação no Perfil IIS Express será levantado o Swagger com as 4 operações de vendas necessárias solicitadas no teste(POST-Incluir Venda,PUT-Alterar Venda,DELETE-Deletar a Venda e GET-Consultar a Venda).Os testes da operações podem ser realizados através da pagina do Swagger.
Sugestão de Cenário de teste
1-Incluir uma Venda pela Página do Swagger.
2-Utilizar o Get para buscar a mesma venda inserida.
3-Utilizar o método Put para alterar a venda inserida.
4-Excluir a venda através do metodo de exclusão na pagina do swagger.

Pode se rodar os testes unitários se necessário para testar alguns métodos da camada de repository.

#Sobre o Desenvolvimento da Aplicação
A camada do repositório foi desenvolvida utilizando List para facilitar o teste e desenvolvimento da aplicação sem a necessidade de inclusão de um banco ou entity framework objetivando deixar mais fácil o start da aplicação para quem for testar.Foram Criados os eventos de publicação com utilizando NotificationHandler do pattern Mediator.Foram Incluidos alguns testes unitários para testar a camada de Repositório.
