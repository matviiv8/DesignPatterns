namespace Strategy
{
    public class PriceCalculator
    {
        private IDiscountStrategy _discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculatePrice(decimal basePrice)
        {
            if (_discountStrategy == null)
            {
                throw new InvalidOperationException("Discount strategy is not set.");
            }

            return _discountStrategy.ApplyDiscount(basePrice);
        }
    }
}
