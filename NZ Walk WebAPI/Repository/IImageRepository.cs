using NZ_Walk_WebAPI.Models.Domain;

namespace NZ_Walk_WebAPI.Repository
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);

    }
}
 