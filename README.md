# Aplicativo CRUD de Pessoa Física
Este é um projeto exemplar que demonstra a implementação de um aplicativo CRUD (Create, Read, Update, Delete) para gerenciamento de perfis de Pessoa Física. Desenvolvido com tecnologias modernas e uma arquitetura bem definida, apresenta diversos pontos positivos que o tornam uma escolha sólida para o desenvolvimento de sistemas similares. Abaixo estão os principais aspectos positivos, tecnologias e arquitetura utilizadas:

## Pontos Positivos
- **Facilidade de Uso**: A interface do usuário é amigável e intuitiva, permitindo aos usuários realizar operações de CRUD de forma eficiente.
- **Validação de CPF**: Implementação de validação de CPF para garantir que apenas CPFs válidos sejam inseridos no sistema.
- **Responsividade**: O layout das páginas é responsivo, proporcionando uma experiência consistente em diferentes dispositivos e tamanhos de tela.
- **Organização do Código**: O código-fonte está bem estruturado e organizado, facilitando a manutenção e a adição de novos recursos.
- **Reutilização de Componentes**: O uso de componentes reutilizáveis e de bibliotecas externas (jQuery, jQuery Mask) promove uma abordagem eficiente de desenvolvimento.
- **Feedback ao Usuário**: Mensagens de erro e confirmação fornecem feedback claro ao usuário durante as operações.

## Tecnologias Utilizadas
- **ASP.NET MVC Framework**: Utilizado para criar aplicativos da web baseados em padrões de design MVC (Model-View-Controller).
- **C#**: Linguagem de programação robusta e poderosa utilizada para o desenvolvimento do backend do aplicativo.
- **Entity Framework**: Framework de mapeamento objeto-relacional (ORM) usado para interagir com o banco de dados.
- **HTML, CSS, JavaScript**: Tecnologias fundamentais para o desenvolvimento de interfaces de usuário web.
- **jQuery**: Biblioteca JavaScript amplamente utilizada para simplificar a manipulação do DOM e interações com o servidor.
- **jQuery Mask Plugin**: Plugin jQuery para aplicar máscaras em campos de entrada, como CPF e data de nascimento.
- **APIs**: Utilização de APIs para comunicação entre o frontend e o backend, promovendo uma arquitetura mais flexível e escalável.

## Arquitetura
- **Padrão MVC**: Utilização do padrão Model-View-Controller para separar as preocupações do aplicativo e facilitar a manutenção e expansão do código.
- **DbContext**: Uso do DbContext do Entity Framework para gerenciar a conexão com o banco de dados e as operações CRUD.
- **Views, Controllers, Models**: Divisão clara das responsabilidades entre as diferentes camadas da aplicação, promovendo a modularidade e a reutilização de código.
- **Frontend Separado do Backend**: Separação das responsabilidades entre o frontend (HTML, CSS, JavaScript) e o backend (C# ASP.NET MVC), permitindo o desenvolvimento paralelo e a colaboração entre equipes.

Este projeto exemplar representa uma implementação robusta e eficiente de um aplicativo CRUD de Pessoa Física, destacando-se por sua usabilidade, organização e uso de tecnologias modernas, incluindo a integração de APIs para uma arquitetura mais flexível e escalável.

## Script de Criação da Tabela no SQL Server

Segue abaixo uma parte do script de criação da tabela no banco de dados SQL Server para o cadastro de Pessoa Física:
```sql
-- Cria o banco de dados Pessoa
CREATE DATABASE Pessoa;
GO

-- Altera o contexto para o banco de dados Pessoa
USE Pessoa;
GO

-- CREATE da tabela 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PessoaFisicaModels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [nvarchar](max) NULL,
	[DataNascimento] [datetime] NOT NULL,
	[ValorRenda] [nvarchar](max) NULL,
	[CPF] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.PessoaFisicaModels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
