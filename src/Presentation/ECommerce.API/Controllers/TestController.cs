using ECommerce.Application.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public TestController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            #region SaveChangeAsync Interceptor UpdatedDate
            //Order order = await _orderReadRepository.GetByIdAsync("4254923f-82ed-48c0-9b9d-d3d000b89810");
            //order.Address = "İstanbul";
            //await _orderWriteRepository.SaveAsync();
            #endregion

            #region SaveChangeAsync Interceptor CreatedDate
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "necessary" });
            //await _orderWriteRepository.AddAsync(new() { Address = "Osmangazi/Bursa", Description = "test test test", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Address = "Nilüfer/Bursa", Description = "testTestTest", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();
            #endregion

            #region Tracking Test
            //Product productTest = await _productReadRepository.GetByIdAsync("aba0ccaa-a202-4bcd-959a-999ed755e9ed");             // default → tracking = true;
            //productTest.Name = "testDemo";
            //await _productWriteRepository.SaveAsync();

            //Product productTest = await _productReadRepository.GetByIdAsync("aba0ccaa-a202-4bcd-959a-999ed755e9ed", false);        // tracking = false;
            //productTest.Name = "newTestDemo";                                                                                      // ilgili değişiklik veri tabanına yansıtılmayacaktır.
            //await _productWriteRepository.SaveAsync();
            #endregion

            #region First Test → Add Operation
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA", Stock = 250, Price = 19.90, },
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA", Stock = 250, Price = 20.90, },
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA Product", Stock = 250, Price = 21.90, },
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA Product", Stock = 250, Price = 22.90, },
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA Product", Stock = 250, Price = 23.90, },
            //    new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "AAA Product", Stock = 250, Price = 24.90, }
            //});
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new() { Name = "D Product", Price = 1.500, Stock = 10, CreatedDate = DateTime.UtcNow });
            //await _productWriteRepository.SaveAsync();
            #endregion
        }
    }
}
