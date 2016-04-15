using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Data> list = new List<Data>()
            //{
            //    new Data() {Id = "张三",Right = 1},
            //    new Data() {Id = "李四",Right = 3},
            //    new Data() {Id = "王五",Right = 2},
            //    new Data() {Id = "赵六",Right = 1},
            //    new Data() {Id = "赵七",Right = 1},
            //    new Data() {Id = "钱八",Right = 1},
            //    new Data() {Id = "孙九",Right = 10},
            //    new Data() {Id = "李十",Right = 3},
            //    new Data() {Id = "王尼玛",Right = 5},
            //    new Data() {Id = "曹妮梅",Right = 1},
            //    new Data() {Id = "史丹利",Right = 1},
            //    new Data() {Id = "飞机",Right = 1},
            //};
            //var ids = new List<string>();
            //foreach (var data in list)
            //{
            //    var lenght = data.Right;
            //    for (var i = 0; i < lenght; i++)
            //    {
            //        ids.Add(data.Id);
            //    }
            //}
            //var total = list.Sum(x => x.Right);

            //var random = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(random.Next(1) + "，恭喜您！");
            //}
            string[] strs = new[] {"123", "456", "789"};
            Console.WriteLine(strs.Any(m => "1s,789".Split(',').Contains(m)));
            Console.WriteLine(strs.Intersect("1s,789".Split(',')).Any());
            Console.ReadKey();

        }
    }

    public class Data
    {
        public string Id { get; set; }
        public int Right { get; set; }
    }
}
