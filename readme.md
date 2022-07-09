# Cadastro de Pessoas Físicas e Jurídicas
Sistema para cadastro de dados de pessoas físicas e jurídicas. Por meio de menus e submenus, o sistema recebe e lista os dados no console. Os dados também podem ser armazenados em arquivos .txt e .csv.

## Funcionalidades

### Pessoa Física
#### Cadastro e listagem de:
- Nome
- Data de nascimento
- CPF
- Rendimento mensal
- Endereço completo (com opção residencial ou comercial)
- Imposto devido (calculado automaticamente pelo sistema a partir do rendimento declarado)

### Pessoa Jurídica
#### Cadastro e listagem de:
- Nome
- Razão Social
- CNPJ (com verificação automática de validade)
- Rendimento mensal
- Endereço completo
- Imposto devido (calculado automaticamente a partir do rendimento declarado)

## Tecnologias utilizadas
Back-End
- C#
- .NET

Editor
- Visual Studio Code

## Organização do Projeto

O projeto está organizado em menus e submenus nos quais o usuário pode optar entre Pessoa Física e Jurídica e, para cada uma delas, entrar com os dados e/ou fazer sua listagem no console.

## Pré-requisitos de instalação
### Hardware
- Processador 1GHz ou mais rápido
- Memória RAM 1GB
- Espaço disponível em disco 2GB

### Software
- SO Windows 8 ou posterior
- .NET Framework

## Execução da Aplicação
Clone o projeto com o comando abaixo:
```bash
    # Clone o repositório
    > git clone https://github.com[usuario]/[nome-projeto].git
    # Entre no diretório
    > cd [nome-projeto]
    #execute o projeto
    > dotnet run
```
## Erros comuns
Pode haver erros de conversão de formato envolvendo datas e valores monetários.

## Contribuidores
VamoQueVamo Desenvolvimento SA


