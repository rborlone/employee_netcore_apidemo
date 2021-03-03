using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    public class EmpleadosController: ControllerBase {

        private IEmpleadoService empleadoService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="empleadoService">Inyectamos la dependencia pasada por el starup</param>
        public EmpleadosController(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmpleados(){
            try{
                return Ok(this.empleadoService.GetEmpleados());
            }catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmpleados(int id){
            try{
                var empleado = this.empleadoService.GetEmpleado(id);

                if (empleado != null)
                    return Ok(empleado);
             
                return NotFound($"El empleado con el id: {id} no fue encontrado");
            }catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult postEmpleado([FromBodyAttribute] Empleado empleado){
            try{
                this.empleadoService.AddEmpleado(empleado);

                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + empleado.IdEmpleado, empleado);
            } catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult deleteEmpleado(int id){
            try{
                var empleado = this.empleadoService.GetEmpleado(id);

                if (empleado != null){
                    this.empleadoService.DeleteEmpleado(empleado);
                    
                    return Ok();
                }
             
                return NotFound($"El empleado con el id: {id} no fue encontrado");
            } catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult putEmpleado(int id, [FromBodyAttribute] Empleado empleado){
            try
            {
                var empleadExistente = this.empleadoService.GetEmpleado(id);

                if (empleadExistente != null){
                    empleado.IdEmpleado = empleadExistente.IdEmpleado;
                    empleadoService.EditEmpleado(empleado);

                    return Ok(empleado);
                }

                 return NotFound($"El empleado con el id: {id} no fue encontrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}