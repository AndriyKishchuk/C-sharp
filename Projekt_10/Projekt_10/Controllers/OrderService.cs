using Projekt_10.Models;
namespace Projekt_10
{
    public class OrderService : IOrderService
    {
        private static List<DTOModel> _orders = [
            new DTOModel { Id = 1, CustomerName = "Андрій", Product = "Ноутбук", Quantity = 1 },
            new DTOModel { Id = 2, CustomerName = "Марія", Product = "Телефон", Quantity = 2 },
            new DTOModel { Id = 3, CustomerName = "Олег", Product = "Навушники", Quantity = 5 }
        ];
        private static int _nextId = 4;

        public Task<List<DTOModel>> GetAllAsync()
        {
            return Task.FromResult(_orders);
        }

        public Task<DTOModel?> GetByIdAsync(int id)
        {
            var order = _orders.FirstOrDefault(u => u.Id == id);
            return Task.FromResult(order);
        }

        public Task<DTOModel> CreateAsync(DTOModel order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
            return Task.FromResult(order);
        }

        public Task<DTOModel?> UpdateAsync(int id, DTOModel order)
        {
            var existingOrder = _orders.FirstOrDefault(u => u.Id == id);
            if (existingOrder == null) return Task.FromResult<DTOModel?>(null);

            existingOrder.CustomerName = order.CustomerName;
            existingOrder.Product = order.Product;
            existingOrder.Quantity = order.Quantity;
            return Task.FromResult(existingOrder);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var order = _orders.FirstOrDefault(u => u.Id == id);
            if (order == null) return Task.FromResult(false);
            _orders.Remove(order);
            return Task.FromResult(true);
        }

    }
}
