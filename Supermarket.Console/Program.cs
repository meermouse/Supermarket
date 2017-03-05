﻿using Supermarket.Data.Implementation;
using Supermarket.Data.Interface;
using StructureMap;
using System;
using Supermarket.BusinessLogic.Interface;
using Supermarket.BusinessLogic.Implementation;
using SuperMarket.Controllers.Interface;
using Supermarket.Controllers;

namespace Supermarket.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = Container.For<ConsoleRegistery>();
                var instance = container.GetInstance<SuperMarketController>();
                System.Console.WriteLine(instance.ProcessCheckout(string.Join(string.Empty,args)));
                System.Console.ReadKey();
            }
            catch(Exception ex)
            {
                ErrorHandling.ProcessException(ex);
            }
        }
    }

    public class ConsoleRegistery : Registry
    {
        public ConsoleRegistery()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            For<IDataAccess>().Use<DataAccess>();
            For<ISupermarketBusinessLogic>().Use<SupermarketBusinessLogic>();
            For<ISuperMarketController>().Use<SuperMarketController>();
        }
    }
}
