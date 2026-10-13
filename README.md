# Orientação a Objetos com C# e .NET

Projeto de estudos desenvolvido durante o curso **Fundamentos da Orientação a Objetos**, da [BALTA.IO](https://balta.io), como parte da carreira **.NET Developer Fundamentals**.

O objetivo é colocar em prática os fundamentos da orientação a objetos em C#, modelando uma plataforma de ensino com artigos, cursos, carreiras, alunos e assinaturas. Este repositório registra meu aprendizado e a aplicação dos conceitos apresentados nas aulas.

## Formação e certificados

Concluí a carreira **.NET Developer Fundamentals** em **13/10/2026**, com carga horária total de **16 horas e 17 minutos**, composta pelos dois cursos abaixo.

| Formação na BALTA.IO | Conclusão | Carga horária | Certificado |
| --- | --- | --- | --- |
| **.NET Developer Fundamentals** (carreira) | 13/10/2026 | **16h 17min** | [Visualizar](docs/certificados/dotnet-developer-fundamentals.png) |
| Fundamentos do C# | 03/10/2026 | 12h 9min | [Visualizar](docs/certificados/fundamentos-csharp.png) |
| Fundamentos da Orientação a Objetos | 13/10/2026 | 4h 8min | [Visualizar](docs/certificados/fundamentos-orientacao-objetos.png) |

Os certificados estão disponíveis em imagem, extraída dos PDFs originais emitidos pela BALTA.IO.

## Conceitos praticados

- Classes, objetos, construtores e propriedades.
- Herança e classes abstratas para compartilhar identidade e comportamento.
- Composição de objetos: carreiras contêm cursos, cursos contêm módulos e módulos contêm aulas.
- Coleções com `List<T>` e `IList<T>`, ordenação e consultas com LINQ.
- Enumerações para representar níveis de conteúdo.
- Notificações para registrar validações de domínio.
- Propriedades calculadas para verificar assinaturas ativas e alunos premium.
- Organização de classes por contexto e identificação de entidades com `Guid`.

## Organização do projeto

```text
OrientacaoObjetos/
├── ContentContext/         # Artigos, cursos, carreiras, módulos e aulas
│   └── Enum/               # Níveis de conteúdo
├── NotificactionContext/   # Notificações e validações
├── SharedContext/          # Classe base compartilhada pelas entidades
├── SubscriptionContext/    # Alunos, usuários, planos e assinaturas
├── docs/certificados/      # Certificados da formação
├── OrientacaoObjetos.csproj
└── Program.cs              # Exemplo executável no console
```

## Como executar

É necessário ter o **SDK do .NET 10** instalado e o Git para clonar o repositório.

```bash
git clone https://github.com/LuanEvangelista/OrientacaoObjetos.git
cd OrientacaoObjetos
dotnet run --project OrientacaoObjetos.csproj
```

O exemplo cria artigos e cursos, organiza os cursos de uma carreira por ordem e exibe uma notificação quando um item é criado sem curso. Também demonstra a criação de uma assinatura para um aluno.

Parte da saída esperada:

```text
Especialista .NET
1.  - Domine por aqui
Fundamentos OOP
...
Curso inválido - Course
```

O projeto é uma aplicação de console para estudo. As classes de assinatura representam o domínio; as integrações com PayPal e Pagar.me são apenas exemplos de modelagem. A compilação pode exibir avisos de nulabilidade em propriedades ainda não inicializadas e no exemplo de curso inválido.

## Autor e referência

**[Luan Pereira Evangelista](https://github.com/LuanEvangelista)**

Desenvolvido durante meus estudos na **[BALTA.IO](https://balta.io)**, com base nos exemplos e exercícios do curso Fundamentos da Orientação a Objetos.
