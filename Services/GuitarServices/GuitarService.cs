using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.GuitarAmpsAndCabs;
using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Guitar;
using SoundAndDance_v2.Services.CategoryServices;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Services.GuitarServices
{
    public class GuitarService : IGuitarService
    {
        private readonly SDDbContext data;
        private readonly ICategoryService category;

        public GuitarService(SDDbContext data, ICategoryService category)
        {
            this.data = data;
            this.category = category;
        }

        public GuitarTotalModel AllGuitarAmplifiers()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var guitarAmp in data.GuitarAmplifiers
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = guitarAmp.Id,
                    Brand = guitarAmp.Brand,
                    Model = guitarAmp.Model,
                    SerialNumber = guitarAmp.SerialNumber,
                    Count = guitarAmp.Count,
                    Notes = guitarAmp.Notes,
                    PriceId = guitarAmp.PriceId,
                    UnitPrice = guitarAmp.Price.UnitPrice
                };

                if (!dict.ContainsKey(guitarAmp.Brand))
                {
                    dict.Add(guitarAmp.Brand, new List<MainServiceModel>());

                    dict[guitarAmp.Brand].Add(item);
                }
                else
                {
                    dict[guitarAmp.Brand].Add(item);
                }
            }

            var ids = data.GuitarAmplifiers.Select(x => x.Id).ToList();

            var guitarTotalModel = new GuitarTotalModel
            {
                dictGuitarAmplifierViewModel = dict,
                allIds = ids
            };

            return guitarTotalModel;
        }

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice)
        {
            if (categoryId == 5)
            {
                var guitarAmp = new GuitarAmplifier
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

                data.GuitarAmplifiers.Add(guitarAmp);
            }
            else if (categoryId == 6)
            {
                var guitarCab = new GuitarCabinet
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

                data.GuitarCabinets.Add(guitarCab);
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
            if (categoryId == 5)
            {
                var deletingObject = data.GuitarAmplifiers.Find(id);

                data.GuitarAmplifiers.Remove(deletingObject);
            }
            else if (categoryId == 6)
            {
                var deletingObject = data.GuitarCabinets.Find(id);

                data.GuitarCabinets.Remove(deletingObject);
            }

            this.data.SaveChanges();
        }

        public MainModel EditGuitarAmplifier(int id, int categoryId)
        {
            var currentGuitarAmp = data.GuitarAmplifiers
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

            return currentGuitarAmp;
        }

        public void EditGuitarAmplifierPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var guitarAmp = data.GuitarAmplifiers
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            guitarAmp.Brand = brand;
            guitarAmp.Model = model;
            guitarAmp.SerialNumber = serialNumber;
            guitarAmp.Notes = notes;
            guitarAmp.Count = count;
            guitarAmp.Price.UnitPrice = unitPrice;
            guitarAmp.Price.TotalPrice = unitPrice;
            guitarAmp.CategoryId = categoryId;

            data.SaveChanges();
        }

        //----------------------------------------------------------------------------------------------------

        public GuitarTotalModel AllGuitarCabinets()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var guitarCabinet in data.GuitarCabinets
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = guitarCabinet.Id,
                    Brand = guitarCabinet.Brand,
                    Model = guitarCabinet.Model,
                    SerialNumber = guitarCabinet.SerialNumber,
                    Count = guitarCabinet.Count,
                    Notes = guitarCabinet.Notes,
                    PriceId = guitarCabinet.PriceId,
                    UnitPrice = guitarCabinet.Price.UnitPrice
                };

                if (!dict.ContainsKey(guitarCabinet.Brand))
                {
                    dict.Add(guitarCabinet.Brand, new List<MainServiceModel>());

                    dict[guitarCabinet.Brand].Add(item);
                }
                else
                {
                    dict[guitarCabinet.Brand].Add(item);
                }
            }

            var ids = data.GuitarCabinets.Select(x => x.Id).ToList();

            var guitarTotalModel = new GuitarTotalModel
            {
                dictGuitarCabinetViewModel = dict,
                allIds = ids
            };

            return guitarTotalModel;
        }

        public MainModel EditGuitarCabinet(int id, int categoryId)
        {
            var currentGuitarCab = data.GuitarCabinets
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

            return currentGuitarCab;
        }

        public void EditGuitarCabinetPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var guitarCab = data.GuitarCabinets
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            guitarCab.Brand = brand;
            guitarCab.Model = model;
            guitarCab.SerialNumber = serialNumber;
            guitarCab.Notes = notes;
            guitarCab.Count = count;
            guitarCab.Price.UnitPrice = unitPrice;
            guitarCab.Price.TotalPrice = unitPrice;
            guitarCab.CategoryId = categoryId;

            data.SaveChanges();
        }
    }
}