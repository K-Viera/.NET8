using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder.ConcreteBuilders
{
    public class IndividualBuilder : IProfileBuilder
    {
        private string? Name;

        public IndividualBuilder SetName(string name)
        {
            Name = name;
            return this;
        }
        public SocialMediaProfile Build()
        {
            if (Name == null)
                throw new EmptyNameException();

            var profile = new SocialMediaProfile(Name);
            profile.SocialMediaType = SocialMediaType.Individual;
            return new SocialMediaProfile(Name);
        }
    }
    public class CompanyBuilder : IProfileBuilder
    {
        private string? Name;

        public CompanyBuilder SetName(string name)
        {
            Name = String.Concat("@", name);
            return this;
        }
        public SocialMediaProfile Build()
        {
            if (Name == null)
                throw new EmptyNameException();

            var profile = new SocialMediaProfile(Name);
            profile.SocialMediaType = SocialMediaType.Company;
            return new SocialMediaProfile(Name);
        }
    }
    public class EmptyNameException : Exception { }
}
