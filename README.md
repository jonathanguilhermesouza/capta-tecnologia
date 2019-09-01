# O que é este projeto?
Este projeto é um CRUD básico desenvolvido em Angular 7 + boostrap 4, contém autenticação, back-end desenvolvido em .net core, web api, etc.

![Homepage](https://i.ibb.co/ftMgg60/image.png)

## Credenciais do login
As credenciais para logar no sistema são: usuário => admin e senha => admin

## Tecnologias utilizadas
  O app foi desenvolvido utilizando no front:
1. HTML5
2. Bootstrap 4
3. Angular 7
4. SPA (Single Page Application)
5. CSS
6. Type Script

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
2. Abra a solution que está na pasta CaptaTecnologia com visual studio.
>
![Solution](https://i.ibb.co/hBQdRtp/image.png)
>
3. Execute o rebuild na solution para indentificar se está tudo OK.
>
![Build Ok](https://i.ibb.co/pRjJbLZ/image.png)
>
4. Marque o projeto CaptaTecnologia.WebApi para startar como default.
>
![Projeto Default](https://i.ibb.co/DLb33f7/image.png)
>
5. Altere a conection string, informe sua instância no sql server, usuário e senha.
>
![Context](https://i.ibb.co/CPMpRX4/image.png)
>
6. Em package manager console, selecione o projeto Data e execute o comando update-database.
>
![Update-database](https://i.ibb.co/J5WFZGk/image.png)
>
6. Caso ocorra tudo bem, navegue até a pasta DatabaseScript, abra o script 1-Script_Insert_Data_Table_User_And_Gender.sql no Sql Server e execute.
>
![Script Inicial](https://i.ibb.co/PMtThSk/image.png)
>
7. Start a API no visual studio, depois basta inicializar o projeto web (desenvolvido em angular). É preferível que utilize o Visual Studio Code pela sua facilidade em lidar com os frameworks JS. Na solution navegue e vá até o diretório CaptaTecnologia/CaptaTecnologia.Web/ClientApp, basta abrir o VS Code nesse caminho.
>
![VS Code](https://i.ibb.co/y07cMg2/image.png)
>
8. Ative o terminal no VS Code e execute npm install para instalar todas as dependências do projeto.
>
![npm install](https://i.ibb.co/q5TWVqZ/image.png)
>
9. Execute ng serve e abra o site no navegador.
>
![Navegador](https://i.ibb.co/bQ9L2Hr/image.png)
>
10. Caso não funcione, verifique qual a URL da API que está rodando através do IIS Express.
>
![Url api](https://i.ibb.co/zHfDNdJ/image.png)
>
11. Abra o arquivo config.ts conforme imagem e troque a url caso seja necessário (Se não estiver igual ao que está rodando no IIS Express)
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

