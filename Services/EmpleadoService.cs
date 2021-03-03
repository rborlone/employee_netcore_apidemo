using System.Collections.Generic;
using System.Linq;
using Models;
using Services.Interfaces;

namespace Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private List<Empleado> empleados = new List<Empleado>(){
            new Empleado(){
                IdEmpleado = 1,
                Nombre = "Rodrigo Borlone"
            },
            new Empleado(){
                IdEmpleado = 2,
                Nombre = "Lucero Aquino"
            }
        };
        
        public Empleado AddEmpleado(Empleado empleado)
        {
            empleado.IdEmpleado = empleados.LastOrDefault().IdEmpleado + 1;
            empleados.Add(empleado);

            return empleado;
        }

        public void DeleteEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }

        public Empleado EditEmpleado(Empleado empleado)
        {
           var empleadoExistente = GetEmpleado(empleado.IdEmpleado);
           empleadoExistente.Nombre = empleado.Nombre;

           return empleadoExistente;
        }

        public Empleado GetEmpleado(int id)
        {
            return this.empleados.SingleOrDefault(x => x.IdEmpleado == id);
        }

        public List<Empleado> GetEmpleados()
        {
            return this.empleados;           
        }
    }
}