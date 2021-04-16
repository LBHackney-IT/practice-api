using practiceApi.V1.Boundary.Response;

namespace practiceApi.V1.UseCase.Interfaces
{
    public interface IGetByIdUseCase
    {
        ResponseObject Execute(int id);
    }
}
