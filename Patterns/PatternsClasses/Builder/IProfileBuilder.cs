using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsClasses.Builder
{
    public interface IProfileBuilder
    {
        SocialMediaProfile Build();
    }
}
