# FELIPE HILST D3 AVALIACAO

Avaliação para a disciplina 3 do CTEDS

## DATABASE

Na pasta `database/sql` está a query de inicialialização para PostgreSQL, essa executada automáticamente ao subir o container, e na pasta `database/tsql` está a query para SQLServer.

Ambas as queries inciam uma tabela `users` se ela não existir e incluem duas entradas, com `id` 1 e 2

Nos outros arquivos e pastas de `database` estão o necessário para subir um banco postgre num container docker. Ao executar pelo terminal na pasta `database` o seguinte comando:

```batch
docker-compose up
```

Também é possível subir um pgadmin4 para gerência do banco. Para isso é necessário descomentar as linhas de 19 à 29 do arquivo `docker-compose.yml` antes de subir o container. Ao fazer isso basta acessar `localhost:5050` com o acesso:

```text
email: admin@admin.com
senha: admin
```

E acessar o servidor pré registrado, `felipehilst-d3-avaliacao` com a senha `root`

## PROGRAMA

Antes de executar a solução, confira se no arquivo [config.json](./felipehilst-d3-avaliacao/felipehilst-d3-avaliacao/config.json) as informações da `connection string` estão corretos e se o tipo de conneção condiz com o banco que será usado. Se for um SQL Server o valor deve ser `"SQLServer"`, se for o Postgre deve ser `"PostgreSQL"`.

O programa executa escopo descrito para a avaliacão descrito em [aqui](https://github.com/cteds/programacao_avancada_csharp/blob/main/avaliacao/escopo.pdf). Os logs do sistema poderão ser encontrados no seguinte _path_ `logs/log.txt`
