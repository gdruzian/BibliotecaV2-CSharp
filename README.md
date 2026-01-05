# 📚 Sistema de Gestão de Biblioteca (C# + MySQL)

![Badge Concluído](http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge)
![Badge C#](https://img.shields.io/static/v1?label=Language&message=C%23&color=blue&style=for-the-badge&logo=csharp)
![Badge MySQL](https://img.shields.io/static/v1?label=Database&message=MySQL&color=orange&style=for-the-badge&logo=mysql)

## 💻 Sobre o Projeto

Este projeto consiste num sistema de gerenciamento de biblioteca desenvolvido em **C# (Console Application)** com persistência de dados real em banco de dados **MySQL**.

Diferente de projetos comuns que usam ORMs prontos (como Entity Framework), este sistema foi construído utilizando **ADO.NET Puro**. O objetivo foi consolidar o entendimento profundo sobre abertura de conexões, execução de comandos SQL manuais, prevenção de SQL Injection e mapeamento de objetos.

O sistema controla o fluxo de usuários, acervo de livros e realiza empréstimos com validações de regra de negócio diretamente no banco.

## 📸 Demonstração

<div align="center">
  <img src="URL_DA_TUA_IMAGEM_AQUI" alt="Demonstração do Menu" width="600">
</div>

## ✨ Funcionalidades

- **CRUD Completo:**
  - Cadastro e Listagem de **Usuários**.
  - Cadastro e Listagem de **Livros**.
- **Gestão de Empréstimos (Core):**
  - **Validação de Disponibilidade:** O sistema verifica se o livro já está emprestado antes de permitir uma nova saída.
  - **Relacionamentos SQL:** As consultas utilizam `INNER JOIN` para exibir nomes e títulos reais em vez de apenas códigos (IDs).
  - **Devolução:** Atualiza o registro de empréstimo com a data de entrega.
- **Robustez:**
  - Tratamento de exceções (`try-catch`) em todas as operações de banco.
  - Uso de parâmetros SQL (`@Param`) para segurança contra injeção de código.

## 🛠️ Tecnologias Utilizadas

- **C# .NET 8.0**
- **MySQL Server**
- **MySQL Data (ADO.NET)**
- **Visual Studio 2022**

## 🚀 Como Executar o Projeto

### Pré-requisitos
Certifique-se de ter o **.NET SDK** e o **MySQL Server** instalados.

1. **Clone o repositório**
   ```bash
   git clone [https://github.com/gdruzian/BibliotecaV2-CSharp.git](https://github.com/gdruzian/BibliotecaV2L-CSharp.git)
