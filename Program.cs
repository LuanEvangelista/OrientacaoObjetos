using OrientacaoObjetos.ContentContext;
using OrientacaoObjetos.ContentContext.Enum;

var course = new Course();
course.Level = EContentLevel.Advanced;


foreach (var item in course.Modules)
{
    Console.WriteLine(item);
}


