﻿using System;

namespace Cynthia.Card.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的名称~:");
            var name = Console.ReadLine();
            var content = "";
            //------------------------------------------------
            var client = new SignalRTest("http://cynthia.ovyno.com/test");
            client.GetCacheMessage().Wait();
            while (true)
            {
                content = Console.ReadLine();
                client.SendMessage(name, content);
            }
        }
    }
}