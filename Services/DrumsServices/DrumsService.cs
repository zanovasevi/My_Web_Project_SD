using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.Drums;
using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Drums;
using SoundAndDance_v2.Services.CategoryServices;

namespace SoundAndDance_v2.Services.DrumsServices
{
    public class DrumsService : IDrumsService
    {
        private readonly SDDbContext data;
        private readonly ICategoryService category;

        public DrumsService(SDDbContext data, ICategoryService category)
        {
            this.data = data;
            this.category = category;
        }

        public IEnumerable<AcousticDrumKitViewModel> AllDrumKits()
        {
            var drums = data.AcousticDrumKits
                .Select(x => new AcousticDrumKitViewModel
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Model = x.Model,
                    Kick1 = x.Kick1,
                    SNKick1 = x.SNKick1,
                    Kick2 = x.Kick2,
                    SNKick2 = x.SNKick2,
                    Kick3 = x.Kick3,
                    SNKick3 = x.SNKick3,
                    Kick4 = x.Kick4,
                    SNKick4 = x.SNKick4,
                    RackTom1 = x.RackTom1,
                    SNRackTom1 = x.SNRackTom1,
                    RackTom2 = x.RackTom2,
                    SNRackTom2 = x.SNRackTom2,
                    RackTom3 = x.RackTom3,
                    SNRackTom3 = x.SNRackTom3,
                    RackTom4 = x.RackTom4,
                    SNRackTom4 = x.SNRackTom4,
                    FloorTom1 = x.FloorTom1,
                    SNFloorTom1 = x.SNFloorTom1,
                    FloorTom2 = x.FloorTom2,
                    SNFloorTom2 = x.SNFloorTom2,
                    FloorTom3 = x.FloorTom3,
                    SNFloorTom3 = x.SNFloorTom3,
                    FloorTom4 = x.FloorTom4,
                    SNFloorTom4 = x.SNFloorTom4,
                    Notes = x.Notes,
                    UnitPrice = x.Price.UnitPrice,
                    TotalPrice = x.Price.TotalPrice,
                    CategoryId = x.CategoryId
                })
                .ToList();

            return drums;
        } 

        public void Create(int categoryId, AddDrumKitFormModel drumModel, CymbalViewModel cymbalModel)
        {
            if (categoryId == 1)
            {
                var drum = new AcousticDrumKit
                {
                    Brand = drumModel.Brand,
                    Model = drumModel.Model,
                    Kick1 = drumModel.Kick1,
                    SNKick1 = drumModel.SNKick1,
                    Kick2 = drumModel.Kick2,
                    SNKick2 = drumModel.SNKick2,
                    Kick3 = drumModel.Kick3,
                    SNKick3 = drumModel.SNKick3,
                    Kick4 = drumModel.Kick4,
                    SNKick4 = drumModel.SNKick4,
                    RackTom1 = drumModel.RackTom1,
                    SNRackTom1 = drumModel.SNRackTom1,
                    RackTom2 = drumModel.RackTom2,
                    SNRackTom2 = drumModel.SNRackTom2,
                    RackTom3 = drumModel.RackTom3,
                    SNRackTom3 = drumModel.SNRackTom3,
                    RackTom4 = drumModel.RackTom4,
                    SNRackTom4 = drumModel.SNRackTom4,
                    FloorTom1 = drumModel.FloorTom1,
                    SNFloorTom1 = drumModel.SNFloorTom1,
                    FloorTom2 = drumModel.FloorTom2,
                    SNFloorTom2 = drumModel.SNFloorTom2,
                    FloorTom3 = drumModel.FloorTom3,
                    SNFloorTom3 = drumModel.SNFloorTom3,
                    FloorTom4 = drumModel.FloorTom4,
                    SNFloorTom4 = drumModel.SNFloorTom4,
                    Notes = drumModel.Notes,
                    Price = new Price
                    {
                        UnitPrice = (decimal)drumModel.UnitPrice,
                        TotalPrice = (decimal)drumModel.UnitPrice
                    },
                    CategoryId = categoryId
                };

                data.AcousticDrumKits.Add(drum);
            }
            else if (categoryId == 2)
            {
                var cymbal = new Cymbal
                {
                    Brand = cymbalModel.Brand,
                    Model = cymbalModel.Model,
                    Kind = cymbalModel.Kind,
                    Size = cymbalModel.Size,
                    SerialNumber = cymbalModel.SerialNumber,
                    Notes = cymbalModel.Notes,
                    Count = (int)cymbalModel.Count,
                    Price = new Price
                    {
                        UnitPrice = (decimal)cymbalModel.UnitPrice,
                        TotalPrice = cymbalModel.TotalPrice
                    },
                    CategoryId = categoryId
                };

                data.Cymbals.Add(cymbal);
            }

            data.SaveChanges();
        }

        public DeleteViewModel DeleteConfirmation(int id, int categoryId)
        {
            DeleteViewModel deleteModel = category.DeleteModel(id, categoryId);

            return deleteModel;
        }

        public void Delete(int id, int categoryId)
        {
            if (categoryId == 1)
            {
                var deletingObject = data.AcousticDrumKits.Find(id);

                data.AcousticDrumKits.Remove(deletingObject);
            }
            else if(categoryId == 2)
            {
                var deletingObject = data.Cymbals.Find(id);

                data.Cymbals.Remove(deletingObject);
            }
            
            this.data.SaveChanges();
        }

        public AddDrumKitFormModel EditDrumKit(int id, int categoryId)
        {
             var currentDrums = data.AcousticDrumKits
             .Where(x => x.Id == id)
             .Select(x => new AddDrumKitFormModel
             {
                 Brand = x.Brand,
                 Model = x.Model,
                 Kick1 = x.Kick1,
                 SNKick1 = x.SNKick1,
                 Kick2 = x.Kick2,
                 SNKick2 = x.SNKick2,
                 Kick3 = x.Kick3,
                 SNKick3 = x.SNKick3,
                 Kick4 = x.Kick4,
                 SNKick4 = x.SNKick4,
                 RackTom1 = x.RackTom1,
                 SNRackTom1 = x.SNRackTom1,
                 RackTom2 = x.RackTom2,
                 SNRackTom2 = x.SNRackTom2,
                 RackTom3 = x.RackTom3,
                 SNRackTom3 = x.SNRackTom3,
                 RackTom4 = x.RackTom4,
                 SNRackTom4 = x.SNRackTom4,
                 FloorTom1 = x.FloorTom1,
                 SNFloorTom1 = x.SNFloorTom1,
                 FloorTom2 = x.FloorTom2,
                 SNFloorTom2 = x.SNFloorTom2,
                 FloorTom3 = x.FloorTom3,
                 SNFloorTom3 = x.SNFloorTom3,
                 FloorTom4 = x.FloorTom4,
                 SNFloorTom4 = x.SNFloorTom4,
                 Notes = x.Notes,
                 PriceId = x.PriceId,
                 UnitPrice = x.Price.UnitPrice,
                 TotalPrice = x.Price.TotalPrice,
                 CategoryId = x.CategoryId
             })
             .FirstOrDefault();
            
            return currentDrums;
        }

        public void EditDrumKitPost(int id, AddDrumKitFormModel drumModel, int priceId)
        {
            var drums = data.AcousticDrumKits
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            drums.Brand = drumModel.Brand;
            drums.Model = drumModel.Model;

            drums.Kick1 = drumModel.Kick1;
            drums.SNKick1 = drumModel.SNKick1;
            drums.Kick2 = drumModel.Kick2;
            drums.SNKick2 = drumModel.SNKick2;
            drums.Kick3 = drumModel.Kick3;
            drums.SNKick3 = drumModel.SNKick3;
            drums.Kick4 = drumModel.Kick4;
            drums.SNKick4 = drumModel.SNKick4;

            drums.RackTom1 = drumModel.RackTom1;
            drums.SNRackTom1 = drumModel.SNRackTom1;
            drums.RackTom2 = drumModel.RackTom2;
            drums.SNRackTom2 = drumModel.SNRackTom2;
            drums.RackTom3 = drumModel.RackTom3;
            drums.SNRackTom3 = drumModel.SNRackTom3;
            drums.RackTom4 = drumModel.RackTom4;
            drums.SNRackTom4 = drumModel.SNRackTom4;

            drums.FloorTom1 = drumModel.FloorTom1;
            drums.SNFloorTom1 = drumModel.SNFloorTom1;
            drums.FloorTom2 = drumModel.FloorTom2;
            drums.SNFloorTom2 = drumModel.SNFloorTom2;
            drums.FloorTom3 = drumModel.FloorTom3;
            drums.SNFloorTom3 = drumModel.SNFloorTom3;
            drums.FloorTom4 = drumModel.FloorTom4;
            drums.SNFloorTom4 = drumModel.SNFloorTom4;

            drums.Notes = drumModel.Notes;
            drums.Price.UnitPrice = (decimal)drumModel.UnitPrice;
            drums.Price.TotalPrice = (decimal)drumModel.UnitPrice;
            drums.CategoryId = drumModel.CategoryId;

            data.SaveChanges();
        }

        //----------------------------------------------------------------------------------------------

        public TotalModel AllCymbals()
        {
            var dict = new Dictionary<string, List<CymbalViewModel>>();

            foreach (var cymbal in this.data.Cymbals
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new CymbalViewModel
                {
                    Id = cymbal.Id,
                    Brand = cymbal.Brand,
                    Model = cymbal.Model,
                    Kind = cymbal.Kind,
                    Size = cymbal.Size,
                    SerialNumber = cymbal.SerialNumber,
                    Count = cymbal.Count,
                    Notes = cymbal.Notes,
                    PriceId = cymbal.PriceId,
                    UnitPrice = cymbal.Price.UnitPrice
                };

                if (!dict.ContainsKey(cymbal.Brand))
                {
                    dict.Add(cymbal.Brand, new List<CymbalViewModel>());

                    dict[cymbal.Brand].Add(item);
                }
                else
                {
                    dict[cymbal.Brand].Add(item);
                }
            }

            var ids = data.Cymbals.Select(x => x.Id).ToList();

            var totalModel = new TotalModel
            {
                dict = dict,
                allIds = ids
            };

            return totalModel;
        }

        public CymbalViewModel EditCybal(int id, int categoryId)
        {
            var currentCymbal = data.Cymbals
                    .Where(x => x.Id == id)
                    .Select(x => new CymbalViewModel
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Kind = x.Kind,
                        Size = x.Size,
                        SerialNumber = x.SerialNumber,
                        Notes = x.Notes,
                        Count = x.Count,
                        PriceId = x.PriceId,
                        UnitPrice = x.Price.UnitPrice,
                        TotalPrice = x.Price.TotalPrice,
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

            return currentCymbal;
        }

        public void EditCymbalPost(int id, CymbalViewModel cymbalModel, int priceId)
        {
            var cymbal = data.Cymbals
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            cymbal.Brand = cymbalModel.Brand;
            cymbal.Model = cymbalModel.Model;
            cymbal.Kind = cymbalModel.Kind;
            cymbal.Size = cymbalModel.Size;
            cymbal.SerialNumber = cymbalModel.SerialNumber;
            cymbal.Notes = cymbalModel.Notes;
            cymbal.Count = (int)cymbalModel.Count;
            cymbal.Price.UnitPrice = (decimal)cymbalModel.UnitPrice;
            cymbal.Price.TotalPrice = (decimal)cymbalModel.UnitPrice;
            cymbal.CategoryId = cymbalModel.CategoryId;

            data.SaveChanges();
        }

    }
}