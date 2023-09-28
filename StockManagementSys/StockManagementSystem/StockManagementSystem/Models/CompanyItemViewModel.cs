using AutoMapper;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;

namespace StockManagementSystem.Models
{
    public class CompanyItemViewModel
    {
        private readonly IItemServices _itemServices;
        private IMapper _mapper;
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<Item> Items { get; set; }

        public CompanyItemViewModel()
        {

        }
        public Item SelectedItem { get; set; } = new Item();
        public CompanyItemViewModel(IItemServices itemServices,IMapper mapper)
        {
            _itemServices = itemServices;
            _mapper = mapper;
            SelectedItem = new Item();

            if (SelectedItemId > 0)
            {
                var item =_itemServices.GetById(SelectedItemId);
                Item item2=_mapper.Map<Item>(item);
                SelectedItem= item2;
            }
        } 
        public int SelectedCompanyId { get; set; }
        public int SelectedItemId { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }

    }
}
