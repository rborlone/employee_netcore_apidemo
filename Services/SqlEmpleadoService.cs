using System.Collections.Generic;
using Models;
using Services.Interfaces;
using System.Linq;

namespace Services
{
    public class SqlEmpleadoService : IEmpleadoService
    {

        private DataBaseContext dataBaseContext;
        public SqlEmpleadoService(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public Empleado AddEmpleado(Empleado empleado)
        {
            this.dataBaseContext.Empleados.Add(empleado);
            this.dataBaseContext.SaveChanges();

            return empleado;
        }

        public void DeleteEmpleado(Empleado empleado)
        {
                this.dataBaseContext.Empleados.Remove(empleado);
                this.dataBaseContext.SaveChanges();
        }

        public Empleado EditEmpleado(Empleado empleado)
        {
            var empleadoExistente = this.dataBaseContext.Empleados.Find(empleado.IdEmpleado);

            if (empleadoExistente != null){
                this.dataBaseContext.Empleados.Update(empleado);
                this.dataBaseContext.SaveChanges();
            }

             return empleado;
        }

        public Empleado GetEmpleado(int id)
        {
            //se puede ocupar tambien
            //var empleado = this.dataBaseContext.Empleados.Find(id);
            return this.dataBaseContext.Empleados.SingleOrDefault(x => x.IdEmpleado == id);
        }

        public List<Empleado> GetEmpleados()
        {
           return this.dataBaseContext.Empleados.ToList();
        }
    }
}