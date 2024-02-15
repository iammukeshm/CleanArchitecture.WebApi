using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Base.UnitTesting
{
    public class CollectionPropertyOmitter : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            PropertyInfo propertyInfo = request as PropertyInfo;
            if (propertyInfo != null && propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
            {
                return new OmitSpecimen();
            }

            return new NoSpecimen();
        }
    }
}
