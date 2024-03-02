using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Farmacias.Model;
using Api_Farmancias.Repositorio.InterFace;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Api_Farmacias.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class FarmaciaControllers:ControllerBase
    {
        protected readonly IFarmaciaRepisitory _farmfonte;
        private readonly IMapper _mapper;
        public FarmaciaControllers(IFarmaciaRepisitory farmfonte,IMapper mapper)//Imaper adiciona a injecao de dpeendencia do automaper no controlleer
        {
            _farmfonte=farmfonte;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Farmacia>>> BuscartodasFarmacia()
        {
            List<Farmacia> farmacias = await _farmfonte.Farmancias();
           
            var FarmaciaRetorno = _mapper.Map<FarmaciaDTO>(farmacias);


            return FarmaciaRetorno != null
            ? Ok(FarmaciaRetorno)
            :BadRequest("Ainda não possui farmacias cadastradas.");
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Farmacia>> Buscarfarmacia(int id)
        {       
            Farmacia farmacias = await _farmfonte.BuscarFarmacia(id);
            
            var FarmaciaRetorno = _mapper.Map<FarmaciaDTO>(farmacias);


            return FarmaciaRetorno != null
            ? Ok(FarmaciaRetorno)
            :BadRequest("Farmacia não encontrada");
            
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<ActionResult<Farmacia>>Adicionarfarm([FromBody] Farmacia farmacia)
        {
            Farmacia farmacias = await _farmfonte.AdicionarFarmacia(farmacia);
           
          // var Farmaciacriada = _mapper.Map<FarmaciaDTO>(farmacias);


            return Ok(farmacia);
            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Farmacia>> Atualiza([FromBody] Farmacia farmacia1, int id)
        {
            farmacia1.Id = id;
            Farmacia farmacia = await _farmfonte.Atualizar(farmacia1, id);
            return Ok(farmacia);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Farmacia>> Deletar(int id)
        {
            bool apagado = await _farmfonte.Apagar(id);
            return Ok(apagado); 
        }
    }
}