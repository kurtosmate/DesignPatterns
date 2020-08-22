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

            var discountCondition = currencySpec.And(totlaPriceSpec.And(ageSpec));
            
            Model john = new Model {UserName="John", Age = 19, Currency = "Eur", BasketTotalPrice = 102 };
            
            if (discountCondition.IsSatisfiedBy(john))
            {
                Console.WriteLine("John has discount");
            }
            else
            {
                Console.WriteLine("John has no discount");
            }

            Model mich = new Model { UserName = "Mich", Age = 19, Currency = "Usd", BasketTotalPrice = 58 };

            if (discountCondition.IsSatisfiedBy(mich))
            {
                Console.WriteLine("Mich has discount");
            }
            else
            {
                Console.WriteLine("Mich has no discount");
            }
        }
    }


}
