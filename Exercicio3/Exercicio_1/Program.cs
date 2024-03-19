var list = new List<double>{3, 7, 2, 4, 6};

var newList = list.ConvertAll(valor => valor/2);

newList.ForEach(valor => Console.WriteLine(valor));