using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Keyboard;

namespace SoundAndDance_v2.Services.KeyboardServices
{
    public interface IKeyboardService : IDeleteConfirmation
    {
        public KeyboardTotalModel AllKeyboards();

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice);

        public void Delete(int id, int categoryId);

        public MainModel EditKeyboard(int id, int categoryId);

        public void EditKeyboardPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);

        //-----------------------------------------------------------------------------------

        public KeyboardTotalModel AllMidiControllers();

        public MainModel EditMidiController(int id, int categoryId);

        public void EditMidiControllerPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId);
    }
}