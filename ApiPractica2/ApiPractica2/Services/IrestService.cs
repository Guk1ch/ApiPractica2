using System;
using System.Collections.Generic;
using System.Text;
using ApiPractica2.Models;
using System.Threading.Tasks;

namespace ApiPractica2.Services
{
    public interface IRestService
    {
        Task<List<CatModel>> GetCatItemAsync();
        Task SaveCatItemAsync(CatModel item, bool isNewItem);
        Task DeleteCatItemAsync(CatModel item);
    }
}
