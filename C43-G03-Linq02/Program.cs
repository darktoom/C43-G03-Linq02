using System.Collections;
using System.Linq;
using System.Text;
using static C43_G03_Linq02.ListGenerator;
namespace C43_G03_Linq02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region element operator
            //  var result = ProductList.First();
            //  result= ProductList.Last(); 
            ////  Console.WriteLine(result?.ProductName??"not found");
            //  result = ProductList.FirstOrDefault();
            //  result= ProductList.LastOrDefault();
            //  result = ProductList.First(x => x.UnitsInStock == 0);
            // // Console.WriteLine(result);

            //  result = ProductList.ElementAtOrDefault(77);
            //  Console.WriteLine(result);


            //var result = ProductList.SingleOrDefault(x=>x.UnitPrice==0);
            //Console.WriteLine(result?.ProductName??"not found");

            // hybrid syntax
            //var result = (from p in ProductList
            //            where p.UnitsInStock == 0   
            //             select new
            //             {
            //                 p.ProductName,
            //                 p.UnitPrice,


            //             }).First();

            //Console.WriteLine(result);
            #endregion

            #region aggregate operator

            //var result=ProductList.Count();
            //result = ProductList.Count;
            //result = ProductList.Count(p=>p.UnitsInStock==0);
            //var res= ProductList.Max(p=>p.ProductName.Length); 
            // var result=(from p in ProductList
            //            where p.ProductName.Length == res
            //            select p).FirstOrDefault();

            //var result = ProductList.Sum(p => p.UnitPrice);
            //result=ProductList.Average(p => p.UnitPrice);

            //string[] names = {"ahmed","omar","amr","mohmmed" };

            //var result = names.Aggregate((str1, str2) => $"{str1},{str2}");


            //Console.WriteLine(result);

            //Console.WriteLine(result);

            #endregion

            #region casting operator
            //List<Product>products= ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[] result= ProductList.Where(p=>p.UnitsInStock == 0).ToArray();

            //Dictionary<long,Product> res= ProductList.Where(p=>p.UnitsInStock==0).ToDictionary(p=>p.ProductID);

            //Dictionary<long, string> result2 = ProductList.Where(p => p.UnitsInStock == 0)
            //    .ToDictionary(p=>p.ProductID,p=>p.ProductName);
            //HashSet<Product> result= ProductList.Where(p=>p.UnitsInStock==0).ToHashSet();
            //ArrayList obj = new ArrayList() { 
            //"ahmed","mohmmed","hatem","tarek",1,2,3


            //};

            //var result = obj.OfType<int>();

            //foreach (var item in result)
            //{

            //    Console.WriteLine($"{item}");

            //}


            #endregion

            #region generation operators
            //var res =Enumerable.Range(0,100);
            //res=Enumerable.Repeat(2,100);
            //var res=Enumerable.Repeat(new Product(),100);
            // var arr=Enumerable.Empty<Product>().ToArray();
            // Product[] products = new Product[0]; 

            // var list= Enumerable.Empty<Product>().ToList();
            // List<Product> list2= new List<Product>();   


            //foreach (int i in res) {
            //    Console.Write($"{i} ");

            //}



            #endregion

            #region set operators
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100); 
            //var result=seq1.Union(seq2);
            //var result= seq1.Concat(seq2);
            //result=result.Distinct();
            // var result= seq1.Intersect(seq2);
            //var result =seq1.Except(seq2);
            // result=seq2.Except(seq1);
            //Console.WriteLine("\n=========================seq1===========================");
            //foreach (var item in seq1) {

            //    Console.Write($"{item},");
            //}
            //Console.WriteLine("\n=========================seq2===========================");

            //foreach (var item in seq2) {
            //    Console.Write($",{item},");
            //}

            //Console.WriteLine("\n=========================set_operator=========================");
            //foreach (var item in result) { 
            //        Console.Write($",{item}"  );
            //        }


            #endregion

            #region assignment
            //var res=ProductList.Where(p=>p.UnitsInStock==0).First();
            //Console.WriteLine(res);

            //var res=ProductList.Where(p=>p.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(res);

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res =arr.Where(p=>p%2==1).Count();
            //Console.WriteLine(res);

           // var words = File.ReadLines(@"D:\.net course\5.linq\2").ToList();
            //var result = words.Sum(p => p.Length);
            //var res=words.Min(x => x.Length);
            // res=words.Max(x => x.Length);
            //var reslut=words.Average(x => x.Length);
            // var result=ProductList.Where(p=>p.UnitsInStock==0).GroupBy(p=>p.Category);
            //var result = ProductList.GroupBy(p=>p.Category).Min();
            //var result = ProductList.GroupBy(p => p.Category).Max();
            
           







            #endregion
        }
    }
}
