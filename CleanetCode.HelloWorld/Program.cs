// See https://aka.ms/new-console-template for more information
List<string> myInfoList = new List<string>();
myInfoList.Add(System.Environment.NewLine);
myInfoList.Add("Что для меня программирование? ".ToUpper());
myInfoList.Add(" - это создания интересных и нужных мне или клиентам программ. ");

myInfoList.Add(System.Environment.NewLine);
myInfoList.Add("Почему я хочу стать программистом? ".ToUpper());
myInfoList.Add(" - это окно в мир автоматизации ");
myInfoList.Add(" - это может быть интересно ");
myInfoList.Add(" - это позволяет зарабатывать деньги удаленно ");
myInfoList.Add(" - мне нравится делать программы и магия программ, еще со школы) ");


Console.WriteLine(string.Join(System.Environment.NewLine, myInfoList));
