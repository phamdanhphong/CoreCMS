using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Utilities.Dtos;

namespace CoreCMS.Application.Interfaces
{
    public interface IItemService :IDisposable
    {
        List<ItemViewModel> GetAll();

        //PagedResult<ItemViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

        ItemViewModel Add(ItemViewModel item);

        void Update(ItemViewModel product);

        void Delete(int id);

        ItemViewModel GetById(int id);

        void ImportExcel(string filePath, int groupId);


        void Save();

        List<ItemViewModel> GetLastest(int top);

        List<ItemViewModel> GetHotProduct(int top);
        List<ItemViewModel> GetRelatedProducts(int id, int top);

        List<ItemViewModel> GetUpsellProducts(int top);

        PagedResult<ItemViewModel> GetAllPaging(string app, int? groupId, string key, int page, int pageSize);

        bool CheckAvailability(int itemId, int size, int color);
    }
}
