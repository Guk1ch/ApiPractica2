using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiPractica2.Models;

namespace ApiPractica2.Services
{
     public class CatManager
    {
        IRestService service;

        public CatManager(IRestService restService)
        {
            service = restService;
        }
        public Task<List<CatModel>> GetCatItemModels()
        {
            return service.GetCatItemAsync();
        }

        public Task DeleteTodoAsync(CatModel item)
        {
            return service.DeleteCatItemAsync(item);
        }

        public Task SaveItemAsync(CatModel todoItem, bool isNewItem)
        {
            return service.SaveCatItemAsync(todoItem, isNewItem);
        }
    }
}
