# Sistema de Gerenciamento de Estoque


##  Sobre o Projeto

O **Sistema de Gerenciamento de Estoque** é uma aplicação Desktop desenvolvida em **C# utilizando Windows Forms**, com o objetivo de permitir o cadastro, gerenciamento e consulta de produtos de forma simples e intuitiva.

O sistema foi desenvolvido com foco no aprendizado dos conceitos de programação orientada a objetos, manipulação de listas, validação de dados e operações CRUD.

---

#  Objetivos

- Cadastrar produtos.
- Atualizar informações dos produtos.
- Excluir produtos.
- Pesquisar produtos.
- Exibir os produtos cadastrados em uma tabela.
- Calcular automaticamente o valor total em estoque.

---

#  Tecnologias Utilizadas

- C#
- Windows Forms
- .NET Framework
- LINQ
- Programação Orientada a Objetos (POO)

---

#  Estrutura do Projeto

O projeto possui uma classe principal chamada **Produto**, responsável por representar cada item do estoque.

Ela possui as seguintes propriedades:

| Propriedade | Descrição |
|-------------|-----------|
| Código | Identificador único do produto |
| Nome | Nome do produto |
| Categoria | Categoria do produto |
| Preço | Valor unitário |
| Quantidade | Quantidade em estoque |
| Valor em Estoque | Calculado automaticamente (Preço × Quantidade) |

---

#  Funcionalidades

## Cadastro de Produto

Permite cadastrar um novo produto informando:

- Código
- Nome
- Categoria
- Preço
- Quantidade

Antes do cadastro, o sistema realiza diversas validações para garantir que os dados sejam válidos.

Ao finalizar o cadastro é exibida uma mensagem de sucesso.

---

##  Pesquisa de Produtos

O sistema possui um campo de pesquisa.

A pesquisa acontece automaticamente conforme o usuário digita.

É possível pesquisar por:

- Código
- Nome
- Categoria

---

## ✏ Atualização de Produto

Ao selecionar um produto na tabela, seus dados são carregados automaticamente nos campos do formulário.

Depois disso basta alterar as informações desejadas e clicar em **Atualizar**.

---

##  Exclusão de Produto

O usuário pode excluir qualquer produto selecionado na tabela.

Antes da exclusão o sistema solicita uma confirmação para evitar exclusões acidentais.

---

##  DataGridView

Todos os produtos cadastrados são exibidos em uma tabela contendo:

- Código
- Nome
- Categoria
- Preço
- Quantidade
- Valor em Estoque

Os valores monetários são formatados automaticamente em Real (R$).

---

##  Valor em Estoque

Cada produto possui uma propriedade calculada:

```
Valor em Estoque = Preço × Quantidade
```

Essa informação é exibida automaticamente na tabela.

---

# ✔ Validações Implementadas

O sistema possui validações para evitar erros de cadastro.

## Código

- Obrigatório
- Deve ser numérico
- Deve ser maior que zero
- Não permite códigos repetidos

---

## Nome

- Obrigatório

---

## Categoria

- Deve selecionar uma categoria válida

---

## Preço

- Obrigatório
- Deve ser maior que zero

---

## Quantidade

- Obrigatória
- Não pode ser negativa

---

# 💬 MessageBox

Durante a utilização do sistema são exibidas mensagens para orientar o usuário.

Exemplos:

- Cadastro realizado com sucesso
- Produto atualizado
- Produto excluído
- Confirmação de exclusão
- Campos inválidos
- Código já cadastrado

Cada mensagem utiliza um ícone apropriado para melhorar a experiência do usuário.

---

# 🛠 Organização do Código

O projeto foi dividido em métodos para facilitar a manutenção.

## Inicialização

Responsável por configurar:

- DataGridView
- ComboBox
- Carregamento inicial

---

## CRUD

### Adicionar

Insere um novo produto na lista.

---

### Atualizar

Altera os dados de um produto existente.

---

### Excluir

Remove um produto da lista.

---

### Pesquisar

Filtra os produtos utilizando LINQ.

---

## Métodos Auxiliares

O projeto também possui métodos responsáveis por:

- Validar campos
- Atualizar a tabela
- Carregar produto selecionado
- Limpar formulário
- Verificar produtos repetidos

---

#  Conceitos Aplicados

Durante o desenvolvimento foram utilizados conceitos importantes de programação:

- Programação Orientada a Objetos
- Encapsulamento
- Classes
- Objetos
- Propriedades
- Construtores
- Propriedades Calculadas
- List<T>
- LINQ
- Eventos
- DataGridView
- ComboBox
- MessageBox
- Validação de Dados

---

# Como Executar

1. Clone o repositório

```
git clone https://github.com/SEU-USUARIO/NOME-DO-REPOSITORIO.git
```

2. Abra a solução no Visual Studio.

3. Compile o projeto.

4. Execute a aplicação.

---

# Funcionamento

O fluxo básico do sistema é:

Cadastro → Validação → Armazenamento → Exibição na Tabela → Pesquisa → Atualização → Exclusão

---

# Aprendizados

Este projeto foi desenvolvido para praticar:

- Desenvolvimento Desktop
- Windows Forms
- Manipulação de Listas
- LINQ
- CRUD
- Programação Orientada a Objetos
- Validação de Dados
- Interface Gráfica

---

#  Autor

**Gabriel Fagundes Souza**

Projeto desenvolvido para fins acadêmicos e prática de desenvolvimento em C# Windows Forms.
