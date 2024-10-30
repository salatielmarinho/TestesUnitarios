<h1 align="center">:bar_chart: Dotnet Core Cobertura de Teste - FIAP</h1>

## :computer: Projeto

Repositório de uma aplicação console para simular o uso de uma simples calculadora, com a realização de testes unitários usando a biblioteca [XUnit](https://xunit.net/) 
e a geraração de um relatório para cobertura de testes.

Para gerar esse relatório com a cobertura de código nesse projeto foi feito o uso de uma biblioteca chamada [Coverlet](https://github.com/coverlet-coverage/coverlet), 
uma ferramenta Cross que faz parte do .NET Foundation, onde é feita uma coleta dos dados de execução de teste 
e como resultado é gerado um relatório com essas informações.

Para se obter uma interface gráfica amigável desse relatório é necessário a utilização do [ReportGenerator](https://github.com/danielpalme/ReportGenerator), 
uma ferramenta open source que usa vários formatos legíveis com detalhamento dessas informações.

## :wrench: Recursos Utilizados

- [Visual Studio Code v1.95](https://code.visualstudio.com/).
- [.NET Core v8.0](https://dotnet.microsoft.com/download/dotnet/8.0).
- [C#](https://code.visualstudio.com/).
- [XUnit v2.9.2](https://xunit.net/).
- [XUnit.Runner.VisualStudio v2.8.2](https://xunit.net/).
- [Coverlet.Collector v6.0.2](https://github.com/coverlet-coverage/coverlet).
- [Coverlet.Msbuild v6.0.2](https://github.com/coverlet-coverage/coverlet).
- [ReportGenerator v5.3.11](https://github.com/danielpalme/ReportGenerator).
- [Microsoft.CodeCoverage 17.11.1](https://github.com/microsoft/vstest).
- [Microsoft.NET.Test.Sdk 17.11.1](https://github.com/microsoft/vstest).
- [Microsoft.Testing.Extensions.CodeCoverage 17.12.6](https://github.com/microsoft/codecoverage).


## :floppy_disk: Clonar repositório

```git clone https://github.com/salatielmarinho/TestesUnitarios.git```

Ao fazer o clone do projeto basta utilizar o prompt de comando ir ate a pasta ``` src ``` e executar o comando ``` dotnet restore ``` para restaurar os pacotes da aplicação.  

## :arrow_down: Bibliotecas adicionadas

Para a criação de um projeto de teste com XUnit, tem um passo a passo na documentação da [Microsoft](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test).

Foram utilizados os seguintes comandos para adição de pacotes nesse projeto:

Coverlet: ```dotnet add package coverlet.msbuild```
<br/>
ReportGenerator: ```dotnet add package ReportGenerator```

No caso do ReportGenerator também é necessário fazer seu [Download](https://github.com/danielpalme/ReportGenerator/releases) e salvar em um local de fácil acesso,
para que o relatório possa ser gerado.

## :arrow_forward: Gerando a cobertura de código

Executando o seguinte comando, será gerado um arquivo chamado ```coverage.json``` que é o seu formato padrão, 
mas outros formatos também pode ser gerados.  

```dotnet test /p:CollectCoverage=true```

Para alterar o formato do arquivo para opencover que é o desejado para esse projeto, deve ser executado o seguinte comando:

```dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover```

Como resultado é gerado o arquivo ```coverage.opencover.xml``` e um relatório simples no prompt de comando:

![execucao_coverage](https://github.com/salatielmarinho/TestesUnitarios/blob/main/assets/Execucao_Coverage.png)

Com o arquivo no formato opencover gerado pelo Coverlet, um relatório em HTML pode ser gerado, 
para isso abro um novo prompt e navego ate o local onde o ReportGenerator foi salvo e executo o seguinte comando:

```ReportGenerator.exe -reports:-targetdir:\coverage.opencover.xml" -targetdir:./report"```

O targetdir indica o local onde os arquivos do relatório serão gerados, report é a pasta que vai conter os arquivos desse relatório, 
no meu caso o comando que utilizei foi:

```ReportGenerator.exe -reports:"C:\Users\Public\repositorio\LivesFiap\TestesUnitarios1\src\TesteUnitarioFiap.Test\coverage.opencover.xml" -targetdir:"C:\Users\Public\repositorio\LivesFiap\TestesUnitarios1\src\TesteUnitarioFiap.Test\report"```

![execucao_coverage1](https://github.com/salatielmarinho/TestesUnitarios/blob/main/assets/Execucao_Coverage1.png)

Vou na pasta report onde se encontram os arquivo salvos e clico no ```index.html``` para ser aberta uma página com o relatório:

![execucao_coverage2](https://github.com/salatielmarinho/TestesUnitarios/blob/main/assets/Execucao_Coverage2.png)

Com esse relatório é posível visualizar as informações sobre a cobertura de código:

![execucao_coverage3](https://github.com/salatielmarinho/TestesUnitarios/blob/main/assets/Execucao_Coverage3.png)

Referência:[ Usar cobertura de código para teste de unidade](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-code-coverage?tabs=windows).

## Author

:boy: [Salatiel Marinho](https://github.com/salatielmarinho)

