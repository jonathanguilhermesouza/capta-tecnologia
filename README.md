# CaptaTecnologia
Este projeto é um CRUD básico desenvolvido em Angular 7 + boostrap 4, contém login, back-end desenvolvido em .net core, web api, etc.

![Homepage WeatherNow](https://i.ibb.co/ftMgg60/image.png)

## Como o app funciona?
Você deve rodar o script para criação do banco de dados, está na pasta DatabaseScript, após isto deve rodar o projeto Api e depois o projeto Web desenvolvido em Angular 7. Inicialmente irá se deparar com a tela de login, deve inserir o usuário admin e senha admin e clicar no botão de login. Pronto!!! Após isto você sera redirecionado para tela de crud.

## Tecnologias utilizadas
  O app foi desenvolvido utilizando no front:
1. HTML5
2. Bootstrap 4
3. Angular 7
4. SPA (Single Page Application)

O app foi desenvolvido utilizando no back:
1. Web Api
2. C#
3. Entity Framework
4. Fluent Api (Code First)
5. .net core
6. Arquitetura DDD (Parcial)

Banco de dados
1. Sql Server

## Passos para rodar o projeto
1. Baixe o projeto em seu computador.
2. Navegue até a pasta DatabaseScript, abra o script 1-Script_Create_Database_With_Schemas_And_Data.sql no Sql Server e execute.
>
![Script Inicial](https://i.ibb.co/ftMgg60/image.png)
>
3. Após criado o banco de dados abra a solution que está na pasta CaptaTecnologia com visual studio.
>
![Solution](https://i.ibb.co/hBQdRtp/image.png)
>
4. Execute o rebuild na solution para indentificar se está tudo OK.
>
![Build Ok](https://i.ibb.co/pRjJbLZ/image.png)
>
5. Marque o projeto CaptaTecnologia.WebApi para startar como default.
>
![Projeto Default](https://i.ibb.co/DLb33f7/image.png)
>
6. Após o start na API, basta inicializar o projeto web (desenvolvido em angular). É preferível que utilize o Visual Studio Code pela sua facilidade em lidar com os frameworks JS. Na solution navegue e vá até o diretório CaptaTecnologia/CaptaTecnologia.Web/ClientApp, basta abrir o VS Code nesse caminho.
>
![VS Code](https://i.ibb.co/y07cMg2/image.png)
>
7. Ative o terminal no VS Code e execute npm install para instalar todas as dependências do projeto.
>
![npm install](https://i.ibb.co/q5TWVqZ/image.png)
>
8. Execute ng serve e abra o site no navegador.
>
![Navegador](https://i.ibb.co/bQ9L2Hr/image.png)
>
9. Caso não funcione, verifique qual a URL da API que está rodando através do IIS Express.
>
![Url api](https://i.ibb.co/zHfDNdJ/image.png)
>
10. Abra o arquivo config.ts conforme imagem e troque a url caso seja necessário (Se não estiver igual ao que está rodando no IIS Express)
>
![Arquivo de configuração](https://i.ibb.co/ZKKJpc0/image.png)
>

## Preview

1. Tela 1
>
![Projeto Capta](https://i.ibb.co/ftMgg60/image.png)
>
2. Tela 2
>
![Projeto Capta](https://i.ibb.co/zfpWPWd/image.png)
>
3. Tela 3
>
![Projeto Capta](https://i.ibb.co/5R4Jq9h/image.png)
>

