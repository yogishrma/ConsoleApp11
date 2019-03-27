using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("downloading file");

            Download();

            Console.ReadLine();



        }



        static void Download()

        {

            Network.Download((message) => Console.WriteLine("Download complete " + message));

        }

    }



    // Imaginary external network library



    class Network

    {

        static public void Download(Action callback)

        {

            Task.Run(() => {

                Thread.Sleep(3000);

                callback("completed");

            });

        }

    }

}