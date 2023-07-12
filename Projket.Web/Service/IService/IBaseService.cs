using Projekt.Web.Models;
using Projket.Web.Models;

namespace Projket.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
