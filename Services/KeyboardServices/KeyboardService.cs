using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Data.Models;
using SoundAndDance_v2.Data.Models.Keyboards;
using SoundAndDance_v2.Models;
using SoundAndDance_v2.Models.Keyboard;
using SoundAndDance_v2.Services.CategoryServices;
using SoundAndDance_v2.Services.ServiceModels;

namespace SoundAndDance_v2.Services.KeyboardServices
{
    public class KeyboardService : IKeyboardService
    {
        private readonly SDDbContext data;
        private readonly ICategoryService category;

        public KeyboardService(SDDbContext data, ICategoryService category)
        {
            this.data = data;
            this.category = category;
        }

        public KeyboardTotalModel AllKeyboards()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var key in data.Keyboards
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = key.Id,
                    Brand = key.Brand,
                    Model = key.Model,
                    SerialNumber = key.SerialNumber,
                    Count = key.Count,
                    Notes = key.Notes,
                    PriceId = key.PriceId,
                    UnitPrice = key.Price.UnitPrice
                };

                if (!dict.ContainsKey(key.Brand))
                {
                    dict.Add(key.Brand, new List<MainServiceModel>());

                    dict[key.Brand].Add(item);
                }
                else
                {
                    dict[key.Brand].Add(item);
                }
            }

            var ids = data.Keyboards.Select(x => x.Id).ToList();

            var keyboardTotalModel = new KeyboardTotalModel
            {
                dictKeyboardViewModel = dict,
                allIds = ids
            };

            return keyboardTotalModel;
        }

        public void Create(int categoryId, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, decimal totalPrice)
        {
            if (categoryId == 7)
            {
                var key = new Keyboard
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

                data.Keyboards.Add(key);
            }
            else if (categoryId == 8)
            {
                var midi = new MidiController
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

                data.MidiControllers.Add(midi);
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
            if (categoryId == 7)
            {
                var deletingObject = data.Keyboards.Find(id);

                data.Keyboards.Remove(deletingObject);
            }
            else if (categoryId == 8)
            {
                var deletingObject = data.MidiControllers.Find(id);

                data.MidiControllers.Remove(deletingObject);
            }

            this.data.SaveChanges();
        }

        public MainModel EditKeyboard(int id, int categoryId)
        {
            var currentKeyboard = data.Keyboards
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

            return currentKeyboard;
        }

        public void EditKeyboardPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var key = data.Keyboards
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            key.Brand = brand;
            key.Model = model;
            key.SerialNumber = serialNumber;
            key.Notes = notes;
            key.Count = count;
            key.Price.UnitPrice = unitPrice;
            key.Price.TotalPrice = (unitPrice);
            key.CategoryId = categoryId;

            data.SaveChanges();
        }

        //-----------------------------------------------------------------------------------

        public KeyboardTotalModel AllMidiControllers()
        {
            var dict = new Dictionary<string, List<MainServiceModel>>();

            foreach (var midi in data.MidiControllers
                        .Include(c => c.Price)
                        .Where(c => c.PriceId == c.Price.Id))
            {
                var item = new MainServiceModel
                {
                    Id = midi.Id,
                    Brand = midi.Brand,
                    Model = midi.Model,
                    SerialNumber = midi.SerialNumber,
                    Count = midi.Count,
                    Notes = midi.Notes,
                    PriceId = midi.PriceId,
                    UnitPrice = midi.Price.UnitPrice
                };

                if (!dict.ContainsKey(midi.Brand))
                {
                    dict.Add(midi.Brand, new List<MainServiceModel>());

                    dict[midi.Brand].Add(item);
                }
                else
                {
                    dict[midi.Brand].Add(item);
                }
            }

            var ids = data.MidiControllers.Select(x => x.Id).ToList();

            var keyboardTotalModel = new KeyboardTotalModel
            {
                dictMidiControllerViewModel = dict,
                allIds = ids
            };

            return keyboardTotalModel;
        }

        public MainModel EditMidiController(int id, int categoryId)
        {
            var currentMidi = data.MidiControllers
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

            return currentMidi;
        }

        public void EditMidiControllerPost(int id, string brand, string model, string serialNumber, string notes, int count, decimal unitPrice, int categoryId)
        {
            var midi = data.MidiControllers
                .Include(x => x.Price)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            midi.Brand = brand;
            midi.Model = model;
            midi.SerialNumber = serialNumber;
            midi.Notes = notes;
            midi.Count = count;
            midi.Price.UnitPrice = unitPrice;
            midi.Price.TotalPrice = unitPrice;
            midi.CategoryId = categoryId;

            data.SaveChanges();
        }
    }
}