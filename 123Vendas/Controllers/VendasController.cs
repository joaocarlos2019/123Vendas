using _123Vendas.Data.Interfaces;
using _123Vendas.Domain;
using _123Vendas.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _123Vendas.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVendaRepository _vendaRepository;

        public VendasController(IMapper mapper,IVendaRepository vendaRepository)
        {
            _mapper = mapper;
            _vendaRepository = vendaRepository;
        }


        [HttpPost]
        public async Task<ActionResult<VendaViewModel>> Adicionar(VendaViewModel vendaViewModel)
        {    

            var venda = _mapper.Map<Venda>(vendaViewModel);
            await _vendaRepository.AdicionarVenda(venda);
            return Ok(vendaViewModel);        

        }
    }
}
