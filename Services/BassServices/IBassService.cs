using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Bass;

namespace SoundAndDance_v2.Services.BassServices
{
    public interface IBassService : IDeleteConfirmation
    {
        public BassTotalModel AllBassAmplifiers();

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice);

        public void Delete(int id, int categoryId);

        public MainModel EditBassAmplifier(int id, int categoryId);

        public void EditBassAmplifierPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);

        //-----------------------------------------------------------------------------------

        public BassTotalModel AllBassCabinets();

        public MainModel EditBassCabinet(int id, int categoryId);

        public void EditBassCabinetPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);
    }
}