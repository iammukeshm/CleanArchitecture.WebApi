using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.UnitTesting
{
    public class DoNotFillCollectionProperties : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new CollectionPropertyOmitter());
        }
    }
}
