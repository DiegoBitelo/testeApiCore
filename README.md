# testeApiCore
Teste Api .net core com migration


1- Para rodar basta ter sql server Express intalado na máquina .

2- Url para rodar Postman:

Get por Id (Get)
https://localhost:44375/produto/getbyid/{id}

Insert (Post)
https://localhost:44375/produto/create/
{
    
    "Nome": "",
    "Descricao": "",
    "ValorUnitario": 0.00,
    "Quantidade": 0,
    "IdTipoProduto":0
}

Update (Post)
https://localhost:44375/produto/update/

{

        "id": 0,
        "nome": "",
        "descricao": "",
        "valorUnitario": 0.00,
        "quantidade": 0,
        "idTipoProduto": 0
}

Delete (Get)
https://localhost:44375/produto/delete/{id}

GetAll (Get)
https://localhost:44375/produto/getall

GetAll (Get) Tipos de produto
https://localhost:44375/produto/GetAllTipoProdutos
