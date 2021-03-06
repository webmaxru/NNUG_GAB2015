namespace GAB.Services.OrderProducer
{
    using System;
    using System.Collections.Generic;

    using FizzWare.NBuilder;

    using GAB.Core;

    public class RandomOrdersProducer
    {
        public IList<Order> Produce(int numberOfOrders)
        {
            UniqueRandomGenerator uniqueRandomGenerator = new UniqueRandomGenerator();
            
            return
                Builder<Order>.CreateListOfSize(numberOfOrders)
                              .All()
                              .With(o => o.OrderNo = uniqueRandomGenerator.Next(0, 999999999))
                              .With(o => o.Customer.No = uniqueRandomGenerator.Next(0, 999999999))
                              .With(o => o.Customer.Name = RandomStringGenerator.GetRandomString())
                              .With(o => o.OrderItem.No = uniqueRandomGenerator.Next(0, 999999999))
                              .With(o => o.OrderItem.Name = RandomStringGenerator.GetRandomString())
                              .With(o => o.Created = DateTime.Now)
                              .Build();
        }
    }
}