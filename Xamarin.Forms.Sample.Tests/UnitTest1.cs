using System.Threading.Tasks;
using NUnit.Framework;
using Xamarim.Forms.Sample.Services;

namespace Xamarin.Forms.Sample.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            var service = new PetStoreService();
            var petsByStatus =await service.GetPetsByStatus();
        }
    }
}