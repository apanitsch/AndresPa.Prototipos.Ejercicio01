using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndresPa.Prototipos.Ejercicio01.DatosDeUnaPersona;
public partial class DatosDeUnaPersonaForm : Form
{
    private DatosDeUnaPersonaModelo modelo = new();

    public DatosDeUnaPersonaForm()
    {
        InitializeComponent();
    }

    private void DatosDeUnaPersonaForm_Load(object sender, EventArgs e)
    {
        //Cualquier preparacion necesaria ANTES de que el 
        //formulario se muestre.
        //EJ: Cargar datos en listas, establecer el estado visible / invisible por defecto de algunos 
        //controles, enable/disable
    }

    private void AceptarButton_Click(object sender, EventArgs e)
    {
        var persona = new Persona();

        //si algo está mal...
        if (!int.TryParse(DNIText.Text, out int dni))
        {
            //error y corto.
            MessageBox.Show("Ingresee un DNI válido.");
            return;
        }

        persona.DNI = dni;
        persona.Apellido = ApellidoText.Text;
        persona.Nombre = NombreText.Text;

        if (!DateTime.TryParse(FechaNacText.Text, out DateTime fechaNac))
        {
            MessageBox.Show("La fecha de nacimiento no es válida.");
            return;
        }

        persona.FechaNacimiento = fechaNac;

        var error = modelo.PersonaIngresada(persona);

        if (error != null)
        {
            MessageBox.Show(error);
        }
        else
        {
            MessageBox.Show("Los datos se han ingresado correctamente.");
            //preparar el formulario para un nuevo ingreso
            DNIText.Text = string.Empty;
            ApellidoText.Text = string.Empty;
            NombreText.Text = string.Empty;
            FechaNacText.Text = string.Empty;
        }

    }
}
