using AutoFixture;
using AutoFixture.AutoMoq;
using Moq.AutoMock;
using System.Linq;

namespace Base.UnitTesting
{
    
    public class UnitTestBase
    {
        protected readonly IFixture Fixture;

        public readonly AutoMocker Mocker = new AutoMocker();

        protected UnitTestBase()
        {
            Fixture = new Fixture();
            Fixture.OmitAutoProperties = true;
            Fixture.Customize(new DoNotFillCollectionProperties());
            Fixture.Customize(new AutoMoqCustomization());
            Fixture.Customize(new SupportMutableValueTypesCustomization());
            Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(delegate (ThrowingRecursionBehavior b)
            {
                Fixture.Behaviors.Remove(b);
            });
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

    }
}