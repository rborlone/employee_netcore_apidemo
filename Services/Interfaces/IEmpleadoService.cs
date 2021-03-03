using System.Collections.Generic;
using Models;

namespace Services.Interfaces
{
    public interface IEmpleadoService
    {
        List<Empleado> GetEmpleados();
        Empleado GetEmpleado(int id);
        Empleado AddEmpleado(Empleado empleado);
        void DeleteEmpleado(Empleado empleado);
        Empleado EditEmpleado(Empleado empleado);
    }
}