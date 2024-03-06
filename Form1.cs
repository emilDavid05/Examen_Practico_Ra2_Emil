using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_practico_ra2_Alan
{

    public partial class Form1 : Form
    {

        int Matricula, Telefono;

        string Nombre, Email, Direccion, Maestro_Titular;

        string Genero, Área_Tecnica, curso, seccion;

        public Form1()
        {
            InitializeComponent();

            txt_Matricula.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Email.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Maestro_Titular.Enabled = false;

            cbo_area.Enabled = false;
            cbo_curso.Enabled = false;
            cbo_genero.Enabled = false;
            cbo_seccion.Enabled = false;

            btn_agregar.Enabled = false;
            btn_Cerrar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Cerrar.Enabled = false;


        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            txt_Matricula.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Email.Enabled = true;
            txt_Direccion.Enabled = true;
            txt_Maestro_Titular.Enabled = true;

            cbo_area.Enabled = true;
            cbo_curso.Enabled = true;
            cbo_genero.Enabled = true;
            cbo_seccion.Enabled = true;

            btn_Eliminar.Enabled = true;

        }

        private void cbo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {


            int Indice = cbo_genero.SelectedIndex;

            Genero = cbo_genero.Items[Indice].ToString();

        }

        private void cbo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Indice = cbo_curso.SelectedIndex;

            curso = cbo_curso.Items[Indice].ToString();

        }

        private void cbo_area_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Indice = cbo_area.SelectedIndex;

            Área_Tecnica = cbo_area.Items[Indice].ToString();

        }

        private void cbo_seccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Indice = cbo_seccion.SelectedIndex;

            seccion = cbo_seccion.Items[Indice].ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {




            Matricula = Convert.ToInt32( txt_Matricula.Text);

            Telefono = Convert.ToInt32( txt_Telefono.Text);

            Nombre = txt_Nombre.Text;

            Email = txt_Email.Text;

            Direccion = txt_Direccion.Text;

            Maestro_Titular = txt_Maestro_Titular.Text;




            dgv_datos.Rows.Add(Matricula,Nombre,Direccion,Telefono,Email,Maestro_Titular,Genero,curso,Área_Tecnica,seccion);




        } 
        
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            int indice = dgv_datos.SelectedRows.Count;

            dgv_datos.Rows.RemoveAt(indice);


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            btn_agregar.Enabled = false;

            btn_agregar.Enabled = false;
            btn_Cerrar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Cerrar.Enabled = false;

        }


    }
}
