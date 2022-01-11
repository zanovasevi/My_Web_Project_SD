using System.Collections.Generic;
using SoundAndDance_v2.Models.Drums;

namespace SoundAndDance_v2.Services.DrumsServices
{
    public interface IDrumsService : IDeleteConfirmation
    {
        public IEnumerable<AcousticDrumKitViewModel> AllDrumKits();

        public void Create(int categoryId, AddDrumKitFormModel drumModel, CymbalViewModel cymbalModel);

        public void Delete(int id, int categoryId);

        public AddDrumKitFormModel EditDrumKit(int id, int categoryId);

        public void EditDrumKitPost(int id, AddDrumKitFormModel drumModel, int priceId);

        //--------------------------------------------------------------------------------------------

        public TotalModel AllCymbals();

        public CymbalViewModel EditCybal(int id, int categoryId);

        public void EditCymbalPost(int id, CymbalViewModel cymbalModel, int priceId);
    }
}