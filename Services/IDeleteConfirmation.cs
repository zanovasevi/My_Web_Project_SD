using SoundAndDance_v2.Models;

namespace SoundAndDance_v2.Services
{
    public interface IDeleteConfirmation
    {
        public DeleteViewModel DeleteConfirmation(int id, int categoryId);
    }
}