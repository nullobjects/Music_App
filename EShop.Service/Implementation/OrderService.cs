﻿using MusicApp.Domain.Domain;
using MusicApp.Repository.Interface;
using MusicApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetDetailsForOrder(BaseEntity model)
        {
            return _orderRepository.GetDetailsForOrder(model);
        }
    }
}
