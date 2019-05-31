using System;
using System.Collections.Generic;
using System.Text;
using CoreCMS.Application.ViewModels.Item;

namespace CoreCMS.Application.Interfaces
{
    public interface IItemService 
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

      

        bool CheckAvailability(int itemId, int size, int color);
    }
}
