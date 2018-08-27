using System;
using System.Windows.Forms;
namespace FormSaludoG1_2019_I
{
    partial class FormIngresa
    {
        
        public FormIngresa()
        {
            IniciarComponentes();
        }

        private void btnAceptar_Click(object sender, EventArgs e )
        {
            //Asignando texto del textbox
            string nombre = txtbNombre.Text;

            MessageBox.Show("Hola " + nombre, "Saludo!!!!");
            
        }

    }
}
