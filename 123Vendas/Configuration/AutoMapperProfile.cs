using _123Vendas.Domain;
using _123Vendas.ViewModels;
using AutoMapper;

namespace _123Vendas.Configuration
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();
            CreateMap<VendaItemViewModel, VendaItem>().ReverseMap();
            CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            CreateMap<VendaViewModel, Venda>().ReverseMap();            
        }        
    }
}
