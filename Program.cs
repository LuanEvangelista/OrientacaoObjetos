using OrientacaoObjetos.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));


foreach (var item in articles)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Url);
}