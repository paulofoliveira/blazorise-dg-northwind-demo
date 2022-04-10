﻿using NorthwindDemo.Client.Components;
using NorthwindDemo.Client.Services;
using NorthwindDemo.Models;

namespace NorthwindDemo.Client.Pages
{
    public class OrdersComponent : DataGridComponent<OrderDto, IOrderDataService>
    {
        protected override string Title => "Orders";
    }
}
