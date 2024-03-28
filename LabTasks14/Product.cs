namespace LabTasks14
{
    internal class Product
    {
        private int _id;
        private string _brandName;
        private string _model;
        private int _price;
        private int _cost;
        private int _inCome;
        private int _count;

        public Product(int id, string brandName, string model, int price, int cost, int availableCount, int saleCount)
        {
            _id = id;
            _brandName = brandName;
            _model = model;
            _price = price;
            _cost = cost;

            if (availableCount < 0)
                _count = 0;
            else
                _count = availableCount;

            Sale(saleCount);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id = {_id}, BrandName = {_brandName}, Model = {_model}, Price = {_price}, Cost = {_cost}, " +
                $"InCome = {_inCome}, Count = {_count}");
        }

        public void Sale(int count)
        {
            if (_count - count >= 0)
            {
                _count -= count;
                _inCome = _price * count - _cost;
            }
            else
            {
                Console.WriteLine("Not enough available product");
            }
        }
    }
}
