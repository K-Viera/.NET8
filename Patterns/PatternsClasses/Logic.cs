using PatternsClasses.Builder;
using PatternsClasses.Builder.ConcreteBuilders;
using System;
using System.Collections.Generic;

namespace PatternsClasses
{
    public class Logic
    {
        public void Execute() {
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
