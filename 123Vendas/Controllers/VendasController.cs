using _123Vendas.Domain;
using _123Vendas.Service;
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
        private readonly IVendasService _vendasService;
        

        public VendasController(IMapper mapper,IVendasService vendasService)
        {
            _mapper = mapper;
            _vendasService = vendasService;
        }


        [HttpPost]
        public async Task<ActionResult<VendaViewModel>> Adicionar(VendaViewModel vendaViewModel)
        {    

            var venda = _mapper.Map<Venda>(vendaViewModel);
            var vendaAdicionada=await _vendasService.Adicionar(venda);
            return Ok(vendaAdicionada);        

        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<VendaViewModel>> ObterPorId(int id)
        {
            var vendaRetorno = await _vendasService.ObterPorId(id);           
            var vendaParaVisualizar = _mapper.Map<VendaViewModel>(vendaRetorno);
            if (vendaParaVisualizar == null) return NotFound();           
            return Ok(vendaParaVisualizar);
        }



        [HttpPut()]
        public async Task<ActionResult<VendaViewModel>> Atualizar(VendaViewModel vendaViewModel)
        {
            var vendaAtualizar = _mapper.Map<Venda>(vendaViewModel);
            var vendaAlterada = await _vendasService.AlterarVenda(vendaAtualizar);
            return Ok(vendaAlterada);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<VendaViewModel>> Excluir(int id)
        {
          
            var vendaFoiRemovida = await _vendasService.ExcluirVenda(id);
            if (vendaFoiRemovida) return Ok(vendaFoiRemovida);
            else return BadRequest("Não foi possível Remover a Venda Informada");            
        }



    }
}
