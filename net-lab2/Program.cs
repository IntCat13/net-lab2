using net_lab2;

UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();
Console.WriteLine($"USD course: {UsdCourse.Current}");

List<Fruit> fruits = new List<Fruit>();
for (int i = 0; i < 15; i++)
    fruits.Add(Fruit.Create());

foreach(var fruit in fruits.Where( f => f.IsSweet))
    Console.WriteLine(fruit.ToString());