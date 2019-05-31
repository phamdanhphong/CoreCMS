using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using OfficeOpenXml;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreCMS.Application.Interfaces;
using CoreCMS.Application.ViewModels.Item;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Enums;
using CoreCMS.Infrastructure.Interfaces;

namespace CoreCMS.Application.Implementation
{
    public class ItemService : IItemService
    {
        private IRepository<Item, int> _itemRepository;

        private IUnitOfWork _unitOfWork;


        public ItemService(IRepository<Item, int> itemRepository, IUnitOfWork unitOfWork)
        {
            _itemRepository = itemRepository;
            _unitOfWork = unitOfWork;
        }

        public ItemViewModel Add(ItemViewModel itemViewModel)
        {
            var group = Mapper.Map<ItemViewModel, Item>(itemViewModel);
            _itemRepository.Add(group);
            return itemViewModel;
        }

        public bool CheckAvailability(int itemId, int size, int color)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _itemRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ItemViewModel> GetAll()
        {
            return _itemRepository.FindAll(x => x.Group).ProjectTo<ItemViewModel>().ToList();
        }

        public ItemViewModel GetById(int id)
        {
            return Mapper.Map<Item, ItemViewModel>(_itemRepository.FindById(id));
        }

        public List<ItemViewModel> GetHotProduct(int top)
        {
            throw new NotImplementedException();
        }

        public List<ItemViewModel> GetLastest(int top)
        {
            throw new NotImplementedException();
        }

        public List<ItemViewModel> GetRelatedProducts(int id, int top)
        {
            throw new NotImplementedException();
        }

        public List<ItemViewModel> GetUpsellProducts(int top)
        {
            throw new NotImplementedException();
        }

        public void ImportExcel(string filePath, int groupId)
        {
            //using (var package = new ExcelPackage(new FileInfo(filePath)))
            //{
            //    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
            //    Item item;
            //    for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
            //    {
            //        item = new Item();
            //        item.GroupId = groupId;
            //        item.Name = workSheet.Cells[i, 1].Value.ToString();
            //        item.Description = workSheet.Cells[i, 2].Value.ToString();
            //        decimal.TryParse(workSheet.Cells[i, 3].Value.ToString(), out var salesPrice);
            //        item.SalesPrice = salesPrice;
            //        decimal.TryParse(workSheet.Cells[i, 4].Value.ToString(), out var price);
            //        item.Price = price;
            //        decimal.TryParse(workSheet.Cells[i, 5].Value.ToString(), out var promotionPrice);
            //        item.Content = workSheet.Cells[i, 6].Value.ToString();
            //        item.SeoKeywords = workSheet.Cells[i, 7].Value.ToString();
            //        item.SeoDescription = workSheet.Cells[i, 8].Value.ToString();
            //        bool.TryParse(workSheet.Cells[i, 9].Value.ToString(), out var hotFlag);
            //        bool.TryParse(workSheet.Cells[i, 10].Value.ToString(), out var homeFlag);
            //        item.Status = Status.Active;

            //        _itemRepository.Add(item);
            //    }
            //}
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ItemViewModel itemViewModel)
        {
            var item = Mapper.Map<ItemViewModel, Item>(itemViewModel);
            _itemRepository.Update(item);
        }
    }
}
