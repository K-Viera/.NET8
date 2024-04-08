using PatternsClasses.Builder;
using PatternsClasses.Builder.ConcreteBuilders;
using System;
using System.Collections.Generic;

namespace PatternsClasses
{
    public static class Logic
    {
        public static void Execute() {
            PizzaLogic();
        }
        private static void PizzaLogic()
        {
            var classicBuilder = new ClassicPizzaBuilder();
            var classicPizza1 = classicBuilder.AddSauce().AddDough().CreatePizzaBase();
            var classicPizza2 = classicBuilder.AddSauce().AddDough().CreatePizzaBase();

            var spicyBuilder = new SpicyPizzaBuilder();
            var spicyPizza1 = spicyBuilder.AddDough().AddSauce().CreatePizzaBase();
            var spicyPizza2 = spicyBuilder.AddSauce().AddDough().CreatePizzaBase();

            var pizzaList = new List<Pizza>() {classicPizza1,classicPizza2,spicyPizza1,spicyPizza2 };

            foreach (var p in pizzaList)
            {
                p.Print();
            }
        }
        private static void ProfileLogic() {
            var individualProfileBuilder = new IndividualBuilder();
            SocialMediaProfile profile1 = individualProfileBuilder.SetName("kevin").Build();
            SocialMediaProfile profile2 = individualProfileBuilder.SetName("isabella").Build();

            var companyProfileBuilder = new CompanyBuilder();
            SocialMediaProfile company1 = companyProfileBuilder.SetName("GoDataFeed").Build();
            SocialMediaProfile company2 = companyProfileBuilder.SetName("KViera").Build();

            var profilesList = new List<SocialMediaProfile>() { profile1, profile2, company1, company2 };
        }
    }
}
