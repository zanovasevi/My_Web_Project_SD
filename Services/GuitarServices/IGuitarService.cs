using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Guitar;

namespace SoundAndDance_v2.Services.GuitarServices
{
    public interface IGuitarService : IDeleteConfirmation
    {
        public GuitarTotalModel AllGuitarAmplifiers();

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice);

        public void Delete(int id, int categoryId);

        public MainModel EditGuitarAmplifier(int id, int categoryId);

        public void EditGuitarAmplifierPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);

        //-----------------------------------------------------------------------------------

        public GuitarTotalModel AllGuitarCabinets();

        public MainModel EditGuitarCabinet(int id, int categoryId);

        public void EditGuitarCabinetPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);
    }
}