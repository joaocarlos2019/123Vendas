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


        [HttpGet("{id:int}")]
        public async Task<ActionResult<VendaViewModel>> ObterPorId(int id)
        {
            var vendaRetorno = _vendaRepository.ObterVenda(id);            
            var fornecedor = _mapper.Map<VendaViewModel>(await _vendaRepository.ObterVenda(id));
            if (fornecedor == null) return NotFound();           
            return Ok(fornecedor);
        }



        [HttpPut()]
        public async Task<ActionResult<VendaViewModel>> Atualizar(VendaViewModel vendaViewModel)
        {
            var vendaAtualizar = _mapper.Map<Venda>(vendaViewModel);
            var vendaFoiAlterada = await _vendaRepository.AtualizarVenda(vendaAtualizar);           
            if (vendaFoiAlterada)
            {
                var vendaAlterada = await _vendaRepository.ObterVenda(vendaViewModel.NumeroDaVenda);
                return Ok(vendaAlterada);
            }
               
            else return BadRequest("Não foi possível Atualizar a Venda Informada");

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<VendaViewModel>> Excluir(int id)
        {
          
            var vendaFoiRemovida = await _vendaRepository.ExcluirVenda(id);
            if (vendaFoiRemovida) return Ok(vendaFoiRemovida);
            else return BadRequest("Não foi possível Remover a Venda Informada");            
        }



    }
}
