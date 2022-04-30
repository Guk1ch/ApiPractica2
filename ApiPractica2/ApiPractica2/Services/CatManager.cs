using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiPractica2.Models;

namespace ApiPractica2.Services
{
    class CatManager
    {
        IrestService service;

        public CatManager(IrestService restService)
        {
            service = restService;
        }
        public Task<List<CatModel>> GetTodoItemModels()
        {
            return service.GetTodoItemAsync();
        }

        public Task DeleteTodoAsync(CatModel item)
        {
            return service.DeleteTodoItemAsync(item);
        }
        public Task SaveItemAsync(CatModel todoItem, bool isNewItem = false)
        {
            return service.SaveTodoItemAsync(todoItem, isNewItem);
        }
    }
}
