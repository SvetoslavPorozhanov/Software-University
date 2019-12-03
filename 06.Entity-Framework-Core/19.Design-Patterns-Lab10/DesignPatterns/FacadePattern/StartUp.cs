﻿using System;

namespace FacadePattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("BMW")
                    .WithColor("Black")
                    .WithNumberOfDoors(5)
                .Built
                    .InCity("Leipzig ")
                    .AtAddress("SomeAddress 254")
                .Build();

            Console.WriteLine(car);
        }
    }
}