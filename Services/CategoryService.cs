using ProtoDevMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProtoDevMaui.Services
{
    public class CategoryService
    {
        private IEnumerable<Category>? _categories;
       
        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            _categories = new List<Category>();
            if (_categories is not null)
            {
                var categories = new List<Category>();
                

                var microcontroladores = new List<Category>
            {
                new (1,"Micros",0,"arduinonano.jpg"),
                new (2,"Bajo Consumo",1,"bajoconsumo.jpg"),
                new (3,"Inalámbricos",1,"arduinonano.jpg")
            };
                categories.AddRange(microcontroladores);

                var sbc = new List<Category>
            {
                 new (4,"SBC´s",0,"sbcinicio2.jpg"),
                 new (5,"Básico",4,"basico.jpg"),
                 new (6,"Intermedio",4,"intermedio.jpg"),
                 new (7,"Alto Rendimiento",4,"avanzado.jpg"),
            };
                categories.AddRange(sbc);

                var accesorios = new List<Category>
            {
                 new (8,"Varios",0,"proto.jpg"),
                 new (9,"Cables",7,"cables.jpg"),
                 new (10,"Modulos de Comunicación",7,"nic.jpg"),
                 new (11,"Kits de Herramientas",7,"kitherramientas.jpg"),
            };
                categories.AddRange(accesorios);
                _categories = categories;
            }
            return _categories;
        }

        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
           (await GetCategoriesAsync())
           .Where(c => c.ParentId == 0);
    }
}
