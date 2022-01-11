using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.Bass;
using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Bass;
using SoundAndDance_v2.Services.CategoryServices;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Services.BassServices
{
    public class BassService : IBassService
    {
        private readonly SDDbContext data;
        private readonly ICategoryService category;

        public BassService(SDDbContext data, ICategoryService category)
        {
            this.data = data;
            this.category = category;
        }

        public BassTotalModel AllBassAmplifiers()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var bassAmp in data.BassAmplifiers
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = bassAmp.Id,
                    Brand = bassAmp.Brand,
                    Model = bassAmp.Model,
                    SerialNumber = bassAmp.SerialNumber,
                    Count = bassAmp.Count,
                    Notes = bassAmp.Notes,
                    PriceId = bassAmp.PriceId,
                    UnitPrice = bassAmp.Price.UnitPrice
                };

                if (!dict.ContainsKey(bassAmp.Brand))
                {
                    dict.Add(bassAmp.Brand, new List<MainServiceModel>());

                    dict[bassAmp.Brand].Add(item);
                }
                else
                {
                    dict[bassAmp.Brand].Add(item);
                }
            }

            var ids = data.BassAmplifiers.Select(x => x.Id).ToList();

            var bassTotalModel = new BassTotalModel
            {
                dictBassAmplifierViewModel = dict,
                allIds = ids
            };

            return bassTotalModel;
        }

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice)
        {
            if (categoryId == 3)
            {
                var bassAmp = new BassAmplifier
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

                data.BassAmplifiers.Add(bassAmp);
            }
            else if (categoryId == 4)
            {
                var bassCab = new BassCabinet
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

                data.BassCabinets.Add(bassCab);
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
            if (categoryId == 3)
            {
                var deletingObject = data.BassAmplifiers.Find(id);

                data.BassAmplifiers.Remove(deletingObject);
            }
            else if (categoryId == 4)
            {
                var deletingObject = data.BassCabinets.Find(id);

                data.BassCabinets.Remove(deletingObject);
            }

            data.SaveChanges();
        }

        public MainModel EditBassAmplifier(int id, int categoryId)
        {
            var currentBassAmp = data.BassAmplifiers
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

            return currentBassAmp;
        }

        public void EditBassAmplifierPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var bassAmp = data.BassAmplifiers
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            bassAmp.Brand = brand;
            bassAmp.Model = model;
            bassAmp.SerialNumber = serialNumber;
            bassAmp.Notes = notes;
            bassAmp.Count = count;
            bassAmp.Price.UnitPrice = unitPrice;
            bassAmp.Price.TotalPrice = unitPrice;
            bassAmp.CategoryId = categoryId;

            data.SaveChanges();
        }

        //-----------------------------------------------------------------------------------

        public BassTotalModel AllBassCabinets()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var bassCabinet in data.BassCabinets
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = bassCabinet.Id,
                    Brand = bassCabinet.Brand,
                    Model = bassCabinet.Model,
                    SerialNumber = bassCabinet.SerialNumber,
                    Count = bassCabinet.Count,
                    Notes = bassCabinet.Notes,
                    PriceId = bassCabinet.PriceId,
                    UnitPrice = bassCabinet.Price.UnitPrice
                };

                if (!dict.ContainsKey(bassCabinet.Brand))
                {
                    dict.Add(bassCabinet.Brand, new List<MainServiceModel>());

                    dict[bassCabinet.Brand].Add(item);
                }
                else
                {
                    dict[bassCabinet.Brand].Add(item);
                }
            }

            var ids = data.BassCabinets.Select(x => x.Id).ToList();

            var bassTotalModel = new BassTotalModel
            {
                dictBassCabinetViewModel = dict,
                allIds = ids
            };

            return bassTotalModel;
        }

        public MainModel EditBassCabinet(int id, int categoryId)
        {
            var currentBassCab = data.BassCabinets
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

            return currentBassCab;
        }

        public void EditBassCabinetPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var bassCab = data.BassCabinets
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            bassCab.Brand = brand;
            bassCab.Model = model;
            bassCab.SerialNumber = serialNumber;
            bassCab.Notes = notes;
            bassCab.Count = count;
            bassCab.Price.UnitPrice = unitPrice;
            bassCab.Price.TotalPrice = unitPrice;
            bassCab.CategoryId = categoryId;

            data.SaveChanges();
        }
    }
}