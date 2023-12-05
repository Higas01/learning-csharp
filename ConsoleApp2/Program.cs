using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Enums;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        }

    }
}