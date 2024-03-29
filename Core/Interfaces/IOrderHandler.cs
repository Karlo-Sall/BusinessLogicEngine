﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IOrderHandler
    {
        Task<IOrderHandler> SetNext(IOrderHandler handle);

        Task<Order> HandleOrder(Order order);
    }
}
