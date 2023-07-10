using Cinema.Domain.DomainModels;
using Cinema.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cinema.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public AdminController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpGet("[action]")]
        public List<Order> GetAllActiveOrders()
        {
            return this._orderService.GetAllOrders();
        }
    }
}
