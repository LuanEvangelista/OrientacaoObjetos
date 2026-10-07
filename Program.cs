using OrientacaoObjetos.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));


// foreach (var item in articles)
// {
//     Console.WriteLine(item.Id);
//     Console.WriteLine(item.Title);
//     Console.WriteLine(item.Url);
// }


var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos de C#", "fundamentos-csharp");
var courseDotnet = new Course("Fundamentos do .NET", "fundamentos-dotnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseDotnet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

var careerItem = new CareerItem(3, "Comece por aqui", "Fundamentos do .NET", courseDotnet);
var careerItem2 = new CareerItem(2, "Avance para aqui", "Programação com C#", courseCsharp);
var careerItem3 = new CareerItem(1, "Domine por aqui", "Desenvolvimento OOP", courseOOP);


careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem3);
careerDotNet.Items.Add(careerItem2);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(i => i.Order))
    {
        Console.WriteLine($"{item.Order}.  - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Level);

    }
}