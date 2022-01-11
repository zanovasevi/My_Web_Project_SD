using System.Linq;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Models;

namespace SoundAndDance_v2.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly SDDbContext data;

        public CategoryService(SDDbContext data)
        {
            this.data = data;
        }

        public DeleteViewModel DeleteModel(int id, int categoryId)
        {
            DeleteViewModel currentType = new DeleteViewModel();

            if (categoryId == 1)
            {
                var drumKit = data.AcousticDrumKits
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = drumKit.Id;
                currentType.Brand = drumKit.Brand;
                currentType.Model = drumKit.Model;
                currentType.Category = drumKit.Category;
                currentType.CategoryId = drumKit.CategoryId;
            }
            else if (categoryId == 2)
            {
                var cymbal = data.Cymbals
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = cymbal.Id;
                currentType.Brand = cymbal.Brand;
                currentType.Model = cymbal.Model;
                currentType.Category = cymbal.Category;
                currentType.CategoryId = cymbal.CategoryId;
            }
            else if (categoryId == 3)
            {
                var bassAmp = data.BassAmplifiers
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = bassAmp.Id;
                currentType.Brand = bassAmp.Brand;
                currentType.Model = bassAmp.Model;
                currentType.Category = bassAmp.Category;
                currentType.CategoryId = bassAmp.CategoryId;
            }
            else if (categoryId == 4)
            {
                var bassCab = data.BassCabinets
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = bassCab.Id;
                currentType.Brand = bassCab.Brand;
                currentType.Model = bassCab.Model;
                currentType.Category = bassCab.Category;
                currentType.CategoryId = bassCab.CategoryId;
            }
            else if (categoryId == 5)
            {
                var guitarAmp = data.GuitarAmplifiers
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = guitarAmp.Id;
                currentType.Brand = guitarAmp.Brand;
                currentType.Model = guitarAmp.Model;
                currentType.Category = guitarAmp.Category;
                currentType.CategoryId = guitarAmp.CategoryId;
            }
            else if (categoryId == 6)
            {
                var guitarCab = data.GuitarCabinets
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = guitarCab.Id;
                currentType.Brand = guitarCab.Brand;
                currentType.Model = guitarCab.Model;
                currentType.Category = guitarCab.Category;
                currentType.CategoryId = guitarCab.CategoryId;
            }
            else if (categoryId == 7)
            {
                var key = data.Keyboards
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = key.Id;
                currentType.Brand = key.Brand;
                currentType.Model = key.Model;
                currentType.Category = key.Category;
                currentType.CategoryId = key.CategoryId;
            }
            else if (categoryId == 8)
            {
                var midi = data.MidiControllers
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = midi.Id;
                currentType.Brand = midi.Brand;
                currentType.Model = midi.Model;
                currentType.Category = midi.Category;
                currentType.CategoryId = midi.CategoryId;
            }
            else if (categoryId == 9)
            {
                var acGuitar = data.AcousticGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = acGuitar.Id;
                currentType.Brand = acGuitar.Brand;
                currentType.Model = acGuitar.Model;
                currentType.Category = acGuitar.Category;
                currentType.CategoryId = acGuitar.CategoryId;
            }
            else if (categoryId == 10)
            {
                var bassGuitar = data.BassGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = bassGuitar.Id;
                currentType.Brand = bassGuitar.Brand;
                currentType.Model = bassGuitar.Model;
                currentType.Category = bassGuitar.Category;
                currentType.CategoryId = bassGuitar.CategoryId;
            }
            else if (categoryId == 11)
            {
                var elGuitar = data.ElectricGuitars
                    .Where(x => x.Id == id)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Brand = x.Brand,
                        Model = x.Model,
                        Category = x.Category.Name + "All",
                        CategoryId = x.CategoryId
                    })
                    .FirstOrDefault();

                currentType.Id = elGuitar.Id;
                currentType.Brand = elGuitar.Brand;
                currentType.Model = elGuitar.Model;
                currentType.Category = elGuitar.Category;
                currentType.CategoryId = elGuitar.CategoryId;
            }

            return currentType;
        }
    }
}