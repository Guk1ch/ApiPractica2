using System;
using System.Collections.Generic;
using System.Text;
using ApiPractica2.Models;
using System.Threading.Tasks;

namespace ApiPractica2.Services
{
    public class IrestService
    {
        Task<List<CatModel>> GetTodoItemAsync();
        Task SaveTodoItemAsync(CatModel item, bool isNewItem);
        Task DeleteTodoItemAsync(CatModel item);
    }
}
