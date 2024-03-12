using datalist_remove;
using System;
using System.Collections.Generic;

//IntList datas = new IntList();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);

//int[] result = datas.GetAll();

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}




//stringList.Add("sada");
//stringList.Add("ada");

//foreach( var item in result1)
//{
//    Console.WriteLine(item);
//}

//DataList<int> datas = DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<string> dataList = new DataList<string>();
//dataList.Add("salam");
//dataList.Add("salam2");

//var result2 = dataList2.GetAll();

//foreach(var item in result2)
//{
//    Console.WriteLine(item);
//}

//DataList<bool> datalist1 = new DataList<bool>();
//datalist1.Add(true);
//datalist1.Add(false);
//datalist1.Add(true);
//var result3 = dataList.GetAll();
//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}


DataList<Book> books = new DataList<Book>();

books.Add(new Book { Id = 1, Name = "test1" });
books.Add(new Book { Id = 2, Name = "test2" });
books.Add(new Book { Id = 3, Name = "test3" });

var result = books.GetAll();

foreach (var item in result)
{
    Console.WriteLine(item.Name);
}





























