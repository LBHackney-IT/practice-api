using System.Collections.Generic;
using practiceApi.V1.Domain;

namespace practiceApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
