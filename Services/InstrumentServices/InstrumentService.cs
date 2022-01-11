using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.GuitarAndBassInstruments;
using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.GuitarAndBassInstrument;
using SoundAndDance_v2.Services.CategoryServices;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Services.InstrumentServices
{
    public class InstrumentService : IInstrumentService
    {
        private readonly SDDbContext data;
        private readonly ICategoryService category;

        public InstrumentService(SDDbContext data, ICategoryService category)
        {
            this.data = data;
            this.category = category;
        }

        public InstrumentTotalModel AllAcousticGuitars()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var acGuitar in data.AcousticGuitars
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = acGuitar.Id,
                    Brand = acGuitar.Brand,
                    Model = acGuitar.Model,
                    SerialNumber = acGuitar.SerialNumber,
                    Count = acGuitar.Count,
                    Notes = acGuitar.Notes,
                    PriceId = acGuitar.PriceId,
                    UnitPrice = acGuitar.Price.UnitPrice
                };

                if (!dict.ContainsKey(acGuitar.Brand))
                {
                    dict.Add(acGuitar.Brand, new List<MainServiceModel>());

                    dict[acGuitar.Brand].Add(item);
                }
                else
                {
                    dict[acGuitar.Brand].Add(item);
                }
            }

            var ids = data.AcousticGuitars.Select(x => x.Id).ToList();

            var instrumentTotalModel = new InstrumentTotalModel
            {
                dictAcousticGuitarViewModel = dict,
                allIds = ids
            };

            return instrumentTotalModel;
        }

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice)
        {
            if (categoryId == 9)
            {
                var acGuitar = new AcousticGuitar
                {
                    Brand = brand,
                    Model = model,
                    SerialNumber = serialNumber,
                    Notes = notes,
                    Count = count,
                    Price = new Price
                    {
                        UnitPrice = unitPrice,
                        TotalPrice = totalPrice
                    },
                    CategoryId = categoryId
                };

                data.AcousticGuitars.Add(acGuitar);
            }
            else if (categoryId == 10)
            {
                var bassGuitar = new BassGuitar
                {
                    Brand = brand,
                    Model = model,
                    SerialNumber = serialNumber,
                    Notes = notes,
                    Count = count,
                    Price = new Price
                    {
                        UnitPrice = unitPrice,
                        TotalPrice = totalPrice
                    },
                    CategoryId = categoryId
                };

                data.BassGuitars.Add(bassGuitar);
            }
            else if (categoryId == 11)
            {
                var elGuitar = new ElectricGuitar
                {
                    Brand = brand,
                    Model = model,
                    SerialNumber = serialNumber,
                    Notes = notes,
                    Count = count,
                    Price = new Price
                    {
                        UnitPrice = unitPrice,
                        TotalPrice = totalPrice
                    },
                    CategoryId = categoryId
                };

                data.ElectricGuitars.Add(elGuitar);
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
            if (categoryId == 9)
            {
                var deletingObject = data.AcousticGuitars.Find(id);

                data.AcousticGuitars.Remove(deletingObject);
            }
            else if (categoryId == 10)
            {
                var deletingObject = data.BassGuitars.Find(id);

                data.BassGuitars.Remove(deletingObject);
            }
            else if (categoryId == 11)
            {
                var deletingObject = data.ElectricGuitars.Find(id);

                data.ElectricGuitars.Remove(deletingObject);
            }

            this.data.SaveChanges();
        }

        public MainModel EditAcousticGuitar(int id, int categoryId)
        {
            var currentAcGuitar = data.AcousticGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new AcousticGuitarViewModel
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        SerialNumber = x.SerialNumber,
                        Notes = x.Notes,
                        Count = x.Count,
                        PriceId = x.PriceId,
                        UnitPrice = x.Price.UnitPrice,
                        TotalPrice = x.Price.TotalPrice,
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

            return currentAcGuitar;
        }

        public void EditAcousticGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var key = data.AcousticGuitars
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            key.Brand = brand;
            key.Model = model;
            key.SerialNumber = serialNumber;
            key.Notes = notes;
            key.Count = count;
            key.Price.UnitPrice = unitPrice;
            key.Price.TotalPrice = unitPrice;
            key.CategoryId = categoryId;

            data.SaveChanges();
        }

        //-----------------------------------------------------------------------------------

        public InstrumentTotalModel AllBassGuitars()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var bassGuitar in data.BassGuitars
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = bassGuitar.Id,
                    Brand = bassGuitar.Brand,
                    Model = bassGuitar.Model,
                    SerialNumber = bassGuitar.SerialNumber,
                    Count = bassGuitar.Count,
                    Notes = bassGuitar.Notes,
                    PriceId = bassGuitar.PriceId,
                    UnitPrice = bassGuitar.Price.UnitPrice
                };

                if (!dict.ContainsKey(bassGuitar.Brand))
                {
                    dict.Add(bassGuitar.Brand, new List<MainServiceModel>());

                    dict[bassGuitar.Brand].Add(item);
                }
                else
                {
                    dict[bassGuitar.Brand].Add(item);
                }
            }

            var ids = data.BassGuitars.Select(x => x.Id).ToList();

            var instrumentTotalModel = new InstrumentTotalModel
            {
                dictBassGuitarViewModel = dict,
                allIds = ids
            };

            return instrumentTotalModel;
        }

        public MainModel EditBassGuitar(int id, int categoryId)
        {
            var currentBassGuitar = data.BassGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new MainModel
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        SerialNumber = x.SerialNumber,
                        Notes = x.Notes,
                        Count = x.Count,
                        PriceId = x.PriceId,
                        UnitPrice = x.Price.UnitPrice,
                        TotalPrice = x.Price.TotalPrice,
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

            return currentBassGuitar;
        }

        public void EditBassGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var bassGuitar = data.BassGuitars
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            bassGuitar.Brand = brand;
            bassGuitar.Model = model;
            bassGuitar.SerialNumber = serialNumber;
            bassGuitar.Notes = notes;
            bassGuitar.Count = count;
            bassGuitar.Price.UnitPrice = unitPrice;
            bassGuitar.Price.TotalPrice = unitPrice;
            bassGuitar.CategoryId = categoryId;

            data.SaveChanges();
        }

        //-----------------------------------------------------------------------------------

        public InstrumentTotalModel AllElectricGuitars()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var elGuitar in data.ElectricGuitars
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = elGuitar.Id,
                    Brand = elGuitar.Brand,
                    Model = elGuitar.Model,
                    SerialNumber = elGuitar.SerialNumber,
                    Count = elGuitar.Count,
                    Notes = elGuitar.Notes,
                    PriceId = elGuitar.PriceId,
                    UnitPrice = elGuitar.Price.UnitPrice
                };

                if (!dict.ContainsKey(elGuitar.Brand))
                {
                    dict.Add(elGuitar.Brand, new List<MainServiceModel>());

                    dict[elGuitar.Brand].Add(item);
                }
                else
                {
                    dict[elGuitar.Brand].Add(item);
                }
            }

            var ids = data.ElectricGuitars.Select(x => x.Id).ToList();

            var instrumentTotalModel = new InstrumentTotalModel
            {
                dictElectricGuitarViewModel = dict,
                allIds = ids
            };

            return instrumentTotalModel;
        }

        public MainModel EditElectricGuitar(int id, int categoryId)
        {
            var currentElGuitar = data.ElectricGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new MainModel
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        SerialNumber = x.SerialNumber,
                        Notes = x.Notes,
                        Count = x.Count,
                        PriceId = x.PriceId,
                        UnitPrice = x.Price.UnitPrice,
                        TotalPrice = x.Price.TotalPrice,
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

            return currentElGuitar;
        }

        public void EditElectricGuitarPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var elGuitar = data.ElectricGuitars
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            elGuitar.Brand = brand;
            elGuitar.Model = model;
            elGuitar.SerialNumber = serialNumber;
            elGuitar.Notes = notes;
            elGuitar.Count = count;
            elGuitar.Price.UnitPrice = unitPrice;
            elGuitar.Price.TotalPrice = unitPrice;
            elGuitar.CategoryId = categoryId;

            data.SaveChanges();
        }
    }
}