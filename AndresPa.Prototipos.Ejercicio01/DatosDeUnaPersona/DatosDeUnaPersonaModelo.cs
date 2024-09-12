using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresPa.Prototipos.Ejercicio01.DatosDeUnaPersona;
internal class DatosDeUnaPersonaModelo
{
    private List<Persona> personas = new();

    public string PersonaIngresada(Persona persona)
    {
        //Si está mal...
        if (persona.DNI < 1_000_000 || persona.DNI > 99_999_999)
        {
            return "El dni debe tener 7-8 digitos.";
        }

        if (string.IsNullOrWhiteSpace(persona.Nombre))
        {
            return "El nombre es requerido";
        }

        if (persona.Nombre.Length > 50)
        {
            return "El nombre debe tener hasta 50 caracteres.";
        }  

        if (string.IsNullOrWhiteSpace(persona.Apellido))
        {
            return "El apellido es requerido.";
        }

        if (persona.Apellido.Length > 50)
        {
            return "El apellido debe tener hasta 50 caracteres.";
        }


        if (persona.FechaNacimiento > DateTime.Now)
        {
            return "La fecha de nacimiento no puede ser mayor a la actual.";
        }

        //"no quiero personas repetidas."
        //=> no pueden haber dos personas con el mismo DNI.
        foreach (var personaGuardada in personas)
        {
            if (personaGuardada.DNI == persona.DNI)
            {
                return $"Ya se ha ingresado una persona con DNI {persona.DNI}";
            }
        }

        //guardo los datos en una lista
        personas.Add(persona);

        return null;
    }

}
