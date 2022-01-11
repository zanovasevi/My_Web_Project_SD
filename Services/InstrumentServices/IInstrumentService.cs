using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.GuitarAndBassInstrument;

namespace SoundAndDance_v2.Services.InstrumentServices
{
    public interface IInstrumentService : IDeleteConfirmation
    {
        public InstrumentTotalModel AllAcousticGuitars();

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice);

        public void Delete(int id, int categoryId);

        public MainModel EditAcousticGuitar(int id, int categoryId);

        public void EditAcousticGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);

        //-----------------------------------------------------------------------------------

        public InstrumentTotalModel AllBassGuitars();

        public MainModel EditBassGuitar(int id, int categoryId);

        public void EditBassGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);

        //-----------------------------------------------------------------------------------

        public InstrumentTotalModel AllElectricGuitars();

        public MainModel EditElectricGuitar(int id, int categoryId);

        public void EditElectricGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);
    }
}