# Vendinha Control

Sistema desktop de gerenciamento de clientes e controle de dívidas, desenvolvido em C# com Windows Forms e Entity Framework Core.

## 1. Sobre o projeto

O **Vendinha Control** é um sistema CRUD desenvolvido como parte do cenário 1 proposto para a avaliação P2.

O sistema permite realizar o cadastro, consulta, atualização e exclusão de clientes, além do gerenciamento de suas respectivas dívidas.

## 2. Como executar o projeto

O projeto é aberto e não possui um build ou executável pré-compilado disponibilizado para utilização direta.

Para executá-lo, é necessário:

1. Clonar ou baixar o repositório.
2. Abrir a solução (`.sln`) utilizando o Visual Studio.
3. Verificar se as dependências NuGet foram restauradas.
4. Configurar o acesso ao banco de dados, caso necessário.
5. Executar os scripts SQL conforme as instruções da seção seguinte.
6. Iniciar o projeto Windows Forms pelo Visual Studio.

## 3. Configuração do banco de dados

Na pasta do projeto estão disponibilizados dois scripts SQL: **DDL** e **DML**.

Eles possuem finalidades diferentes:

- **DDL (obrigatório):** responsável pela criação da estrutura do banco de dados, incluindo as tabelas e seus relacionamentos. Deve ser executado antes da primeira utilização do sistema.
- **DML (opcional):** responsável pela inserção de dados iniciais para facilitar a utilização e os testes do sistema.

### Ordem de execução

1. Execute o script DDL no PostgreSQL para criar as tabelas.
2. Opcionalmente, execute o script DML para inserir registros iniciais.
3. Após a configuração, execute o projeto pelo Visual Studio.

**Importante:** a execução do DDL é obrigatória. Sem a estrutura do banco de dados, o sistema não poderá funcionar corretamente.

## 4. Funcionalidades do sistema

O sistema possui duas telas principais: **Clientes** e **Devedores**.

### 4.1. Tela de Clientes

A tela de Clientes apresenta todos os clientes cadastrados no sistema, permitindo consultar suas informações e realizar operações de gerenciamento.

Principais elementos:

- **Adicionar Cliente:** abre o formulário para cadastrar um novo cliente.
- **Atualizar Cliente:** permite modificar os dados do cliente selecionado.
- **Excluir Cliente:** realiza a exclusão do cliente selecionado.
- **Info. do Cliente:** apresenta informações adicionais sobre o cliente selecionado.
- **Busca por Nome/CPF:** permite localizar clientes utilizando seu nome ou CPF.
- **Tabela de Clientes:** exibe nome, idade, CPF e situação financeira do cliente.
- **Paginação:** permite navegar entre as páginas da listagem.

A coluna Situação informa se o cliente está em dia ou possui dívidas pendentes.

### 4.2. Tela de Devedores

A tela de Devedores apresenta as dívidas em aberto cadastradas no sistema, permitindo acompanhar e administrar os débitos dos clientes.

Principais elementos:

- **Adicionar Dívida:** permite cadastrar uma nova dívida vinculada a um cliente.
- **Atualizar Dívida:** permite modificar os dados da dívida selecionada.
- **Excluir Dívida:** remove a dívida selecionada.
- **Pagar:** permite marcar uma dívida como paga.
- **Busca por CPF:** permite localizar dívidas utilizando o CPF do cliente.
- **Tabela de Dívidas:** apresenta nome do cliente, CPF, valor da dívida e data de criação.
- **Total em Dívidas:** exibe o valor total correspondente às dívidas em aberto.

A listagem considera as dívidas pendentes, facilitando o acompanhamento dos valores ainda não quitados.

## 5. Acesso rápido

O sistema também disponibiliza atalhos de acesso rápido para facilitar a utilização das funcionalidades.

Esses atalhos permitem acessar diretamente operações e formulários que também estão disponíveis nas telas principais, reduzindo a necessidade de navegar entre diferentes páginas.

## 6. Tecnologias utilizadas

- C#
- .NET / Windows Forms
- Entity Framework Core
- PostgreSQL
- SQL (DDL e DML)

## 7. Informações do projeto

**Projeto:** Vendinha Control (4º termo).
**Finalidade:** Cenário 1 proposto para a avaliação P2.

**Aluno:** Pedro Gabriel Aiello  
**RA:** 203956-4