using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wenli.Search.Interface;
using Wenli.Search.Model;

namespace Wenli.Search.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Wenli.Search test";

            Console.WriteLine("Wenli.Search test" + Environment.NewLine);


            while (true)
            {
                #region 分词测试
                Console.WriteLine("回车开始分词测试");
                Console.ReadLine();

                string str = "当一个资源从与该资源本身所在的服务器的域或端口不同的域或不同的端口请求一个资源时，浏览器会发起一个跨域 HTTP 请求。出于安全考虑，浏览器会限制从脚本内发起的跨域HTTP请求或者拦截了服务器返回内容。例如，XMLHttpRequest 和 Fetch 遵循同源策略。因此，使用 XMLHttpRequest或 Fetch 的Web应用程序只能将HTTP请求发送到其自己的域；这种安全机制是为避免出现类似CSRF 跨站攻击等问题。";

                Console.WriteLine(str);

                Console.WriteLine("分词结果如下：");
                Console.WriteLine("============================================");


                var segs = SeachHelper.Segment(str);

                foreach (var item in segs)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("============================================");
                #endregion

                #region 索引测试
                Console.WriteLine("分词测试完成，按回车进入索引测试");
                Console.ReadLine();
                Console.WriteLine("============================================");
                SeachHelper.CleanIndex();

                var list = new List<ISearchData>();

                list.Add(new SearchData(Guid.NewGuid().ToString("N"), "javascript之ProtoBuf在websocket中的使用", "摘要: 因为ProtoBuf的序列化效率和大小都非常好，所以它在网络通信上面应用越来越多；而webosocket也随着web3.0应用越来越广泛，而将这两个结合在一起的也会慢慢形成一种趋势；本人是为了测试自已写的一个C# websocket，所以在web上面结合pb也写了一个js实例: 1.首先下载prot阅读全文", "protobuf, pb, websocket, javascript protobuf, js protobuf", "http://www.cnblogs.com/yswenli/p/7099809.html", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));

                list.Add(new SearchData(Guid.NewGuid().ToString("N"), "跨域CORS", "摘要: 一、跨域CORS是什么 当一个资源从与该资源本身所在的服务器的域或端口不同的域或不同的端口请求一个资源时，浏览器会发起一个跨域 HTTP 请求。出于安全考虑，浏览器会限制从脚本内发起的跨域HTTP请求或者拦截了服务器返回内容。例如，XMLHttpRequest 和 Fetch 遵循同源策略。因此，使阅读全文", "WCF跨域, 跨域, ajax跨域, CORS, js跨域", "http://www.cnblogs.com/yswenli/p/7053964.html", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));

                list.Add(new SearchData(Guid.NewGuid().ToString("N"), "C# 输入法", "摘要: C# 输入法 虽说输入法不是什么新事物，各种语言版本都有，不过在C#不常见；这就会给人一种误会：C#不能做！其实C#能不能做呢，答案是肯定的——三种方式都行：IMM、TSF以及外挂式。IMM这种就是调windows的一些底层api，不过在新版本的windows中基本上已经不能用了，属于一种过时的操作阅读全文", "C# 输入法, 外挂输入法, 五笔输入法, 拼音输入法", "http://www.cnblogs.com/yswenli/p/6528447.html", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));

                list.Add(new SearchData(Guid.NewGuid().ToString("N"), "C#如何使用ES", "摘要: Elasticsearch简介 Elasticsearch （ES）是一个基于Apache Lucene(TM)的开源搜索引擎，无论在开源还是专有领域，Lucene可以被认为是迄今为止最先进、性能最好的、功能最全的搜索引擎库。 但是，Lucene只是一个库。想要发挥其强大的作用，你需使用C#将其集成阅读全文", "C#, Elasticsearch, Full-text Search, 全文搜索, 搜索引擎, Distributed", "http://www.cnblogs.com/yswenli/p/6266569.html", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));

                list.Add(new SearchData(Guid.NewGuid().ToString("N"), "redis成长之路", "摘要: 为什么使用redis Redis适合所有数据in-momory的场景，虽然Redis也提供持久化功能，但实际更多的是一个disk-backed的功能，跟传统意义上的持久化有比较大的差别，那么可能大家就会有疑问，似乎Redis更像一个加强版的Memcached. 上面描述说的过于泛了，很多初次接触的码阅读全文", "C#, Redis, StackExchange.Redis, Wenli.Drive.Redis", "http://www.cnblogs.com/yswenli/p/6235765.html", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));

                SeachHelper.CreateIndex(list);

                Console.WriteLine("============================================");
                #endregion



                #region 查询测试               
                Console.WriteLine("索引测试完成，按回车进入查询测试");
                Console.ReadLine();
                Console.WriteLine("============================================");

                var result = SeachHelper.Search("摘要");

                result.Data.ForEach((item) =>
                {
                    Console.WriteLine("id:{0} title:{1}", item.id, item.title);

                });
                Console.WriteLine("============================================");
                Console.WriteLine("搜索【摘要】完成，查询结果：{0} 条，按回车进入下次查询测试", result.Count);
                Console.ReadLine();
                Console.WriteLine("============================================");

                result = SeachHelper.Search("ES");

                result.Data.ForEach((item) =>
                {
                    Console.WriteLine("id:{0} title:{1}", item.id, item.title);

                });
                Console.WriteLine("============================================");
                #endregion

                #region 多次查询测试
                Console.WriteLine("搜索【ES】完成，查询结果：{0} 条，按回车进入多次查询测试", result.Count);
                Console.ReadLine();
                Console.WriteLine("============================================");
                Console.WriteLine("正在进行多项查询测试，请稍候...");

                Stopwatch sw = new Stopwatch();
                sw.Start();

                Parallel.For(0, 10000, (i) =>
                {
                    SeachHelper.Search("的");
                });
                Console.WriteLine("============================================");
                Console.WriteLine("10000次【的】查询测试已完成，用时：{0}", sw.Elapsed.ToString());
                sw.Stop();
                #endregion
                Console.WriteLine("wenli.Search 测试完成");

            }

        }
    }
}
