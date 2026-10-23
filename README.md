# BlazorPokeApi

Aplicação **Blazor WebAssembly (.NET)** que consome a [PokéAPI](https://pokeapi.co) para buscar um Pokémon pelo nome e exibir seus dados.

Projeto da disciplina **Desenvolvimento Web – Usabilidade, Dev. Web, Mobile e Jogos** (Ânima Educação).

## Funcionalidades

- Campo para digitar o nome do Pokémon (botão **Buscar** ou tecla **Enter**)
- Consumo do endpoint `https://pokeapi.co/api/v2/pokemon/{nome}`
- Exibição de:
  - **Imagem**: obtida de `sprites.other["official-artwork"].front_default`
  - **ID**
  - **Nome**
  - **Altura** (convertida de decímetros para metros)
  - **Peso** (convertido de hectogramas para quilogramas)
- Tratamento de erros: nome vazio, Pokémon não encontrado e falha de conexão

## Tecnologias

- C# / .NET 8
- Blazor WebAssembly
- Bootstrap 5 (via CDN)

## Como executar

### Visual Studio
1. Abra o arquivo `BlazorPokeApi.sln`.
2. Pressione **F5** (ou Ctrl+F5).

### Linha de comando
```bash
git clone https://github.com/miudo-rsn/blazor-pokeapi.git
cd blazor-pokeapi/BlazorPokeApi
dotnet run
```
Acesse o endereço exibido no terminal (ex.: `http://localhost:5065`).

> É necessário ter conexão com a Internet para consultar a PokéAPI.
> Para usar outra versão do .NET, altere `<TargetFramework>` (e as versões dos pacotes) em `BlazorPokeApi/BlazorPokeApi.csproj`.

## Estrutura

```
blazor-pokeapi/
├── BlazorPokeApi.sln
├── LICENSE
├── README.md
└── BlazorPokeApi/
    ├── Models/Pokemon.cs        # modelos do JSON da API
    ├── Pages/Home.razor         # tela de busca e exibição
    ├── Pages/About.razor
    ├── Layout/                  # layout e menu lateral
    ├── wwwroot/                 # index.html e CSS
    └── Program.cs
```

## Equipe

- Fabricio ([@miudo-rsn](https://github.com/miudo-rsn))

## Licença

Distribuído sob a licença MIT. Veja o arquivo [LICENSE](LICENSE).
