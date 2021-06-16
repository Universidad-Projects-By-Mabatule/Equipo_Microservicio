using EquipoAPI.Exceptions;
using EquipoAPI.Models;
using EquipoAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Controllers
{
    [Route("api/[controller]")]
    public class EquipoController:Controller
    {
        private IEquiposService _equiposService;

        public EquipoController(IEquiposService equiposService)
        {
            this._equiposService = equiposService;
        }

        //api/chocolates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipoModel>>> GetTorneos(string orderBy = "Id")
        {
            try
            {
                var teams = await _equiposService.GetEquipoModels(orderBy);
                return Ok(teams);
            }
            catch (BadRequestOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }

        // api/teams/2
        [HttpGet("{torneoId:int}")]
        public async Task<ActionResult<EquipoModel>> GetTorneo(int torneoId)
        {
            try
            {
                var team = await _equiposService.GetEquipo(torneoId);
                return Ok(team);
            }
            catch (BadRequestOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }









       //*************************************
        [HttpPost]
        public async Task<ActionResult<EquipoModel>> CreateEquipo([FromBody] EquipoModel equipoModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var torneo = await _equiposService.CreateEquipo(equipoModel);
                return Created($"/api/torneos/{torneo.Id}", torneo);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        } 

        [HttpPut("{torneoId:int}")]
        public async Task<ActionResult<EquipoModel>> DeleteEquipo(int equipoId)
        {
            try
            {

                var team = await _equiposService.DeleteEquipo(equipoId);
                return Ok(team);
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }
    }
}
