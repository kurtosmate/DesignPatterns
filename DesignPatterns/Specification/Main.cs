using System;
/// <summary>
/// In computer programming, the specification pattern is a particular software design pattern,
/// whereby business rules can be recombined by chaining the business rules together using boolean logic.
/// The pattern is frequently used in the context of domain-driven design.
/// </summary>
namespace DesignPatterns.Specification
{
    public class Main : IPattern
    {
        public void Start()
        {
            var currencySpec = new EurCurrencySpecification(); //Currency is "Eur"
            var totlaPriceSpec = new BasketTotalPriceSpecification(); //TotalPrice > 100
            var ageSpec = new AgeSpecification(); //Age > 18
            var deniedSpec = new DeniedSpecification(); //Blocked or too young; age < 14
            
            // Setup the rule of discount 
            var discountRule = currencySpec.And(totlaPriceSpec).And(ageSpec).AndNot(deniedSpec);

            Model mich = new Model { UserName = "Mich", Age = 19, Currency = "Usd", BasketTotalPrice = 58, Blocked = false };
            GetDiscount(mich, discountRule);

            Model jess = new Model { UserName = "Jess", Age = 20, Currency = "Eur", BasketTotalPrice = 150, Blocked = true };
            GetDiscount(jess, discountRule);

            Model john = new Model { UserName = "John", Age = 19, Currency = "Eur", BasketTotalPrice = 102, Blocked = false };
            GetDiscount(john, discountRule);
        }

        private void GetDiscount(Model model, ISpecification specification)
        {
            if (specification.IsSatisfiedBy(model))
            {
                Console.WriteLine($"{model.UserName} has discount");
            }
            else
            {
                Console.WriteLine($"{model.UserName} has no discount");
            }
        }
    }


}
