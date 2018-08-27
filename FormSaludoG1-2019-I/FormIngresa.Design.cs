using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormSaludoG1_2019_I
{
    partial class FormIngresa : Form
    {

        #region Atributos
        private Label etIntroduceNombreM;
        private TextBox txtbNombre;
        private Button btnAceptar;
        #endregion
        #region Método Iniciar
        private void IniciarComponentes()
        {
            //Definiendo las propiedades del Formulario
            this.Text = "Ingresa";
            this.Size = new Size(400, 300);
            //  this.Location = new Point(400, 100);
            this.StartPosition = FormStartPosition.CenterScreen;

            //Construir los atributos, etiqueta
            etIntroduceNombreM = new Label();
            etIntroduceNombreM.Text = "Introduce tu nombre";
            etIntroduceNombreM.Location = new Point(10, 20);
            etIntroduceNombreM.Size = new Size(180, 35);
            etIntroduceNombreM.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            etIntroduceNombreM.TextAlign = ContentAlignment.MiddleCenter;

            //Construir Textbox 
            txtbNombre = new TextBox();
            txtbNombre.Location = new Point(10, 59);
            txtbNombre.Size = new Size(180, 35);
            txtbNombre.TextAlign = HorizontalAlignment.Right;

            //Construir Button
            btnAceptar = new Button();
            btnAceptar.Location = new Point(60,100);
            btnAceptar.Size = new Size(100,20);
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleCenter;
            btnAceptar.Click += new EventHandler(btnAceptar_Click);


            this.Controls.Add(etIntroduceNombreM);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(txtbNombre);

        }

        #endregion
    }
}

