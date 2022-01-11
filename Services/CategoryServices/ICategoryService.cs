using SoundAndDance_v2.Models;

namespace SoundAndDance_v2.Services.CategoryServices
{
    public interface ICategoryService
    {
        public DeleteViewModel DeleteModel(int id, int categoryId);
    }
}