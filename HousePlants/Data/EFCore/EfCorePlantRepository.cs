using HousePlants.Models;
using HousePlants.Data.EFCore;

namespace HousePlants.Data.EFCore
{
    public class EfCorePlantRepository : EfCoreRepository<Plant, HousePlantsContext>
    {
        public EfCorePlantRepository(HousePlantsContext context) : base(context)
        {

        }
        // We can add new methods specific to the plant repository here in the future
    }
}
