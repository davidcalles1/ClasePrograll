using CLASE02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLASE02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            // para mostrar los elementos de la base de datos 
            using (EMPLEADOEntities empleado = new EMPLEADOEntities())
            {
                var listaempleado = empleado.Tbl_empleado.ToList();
                return View(listaempleado);
            }


        }
        //estoes para eliminar un dato de una tabla conectada a una base de datos 
        public ActionResult Delete(int id) {
            using (EMPLEADOEntities empleado = new EMPLEADOEntities())
            {
                Tbl_empleado EliminarEmpleado = empleado.Tbl_empleado.Where
                    (x => x.Id_empleado == id).FirstOrDefault();
                empleado.Tbl_empleado.Remove(EliminarEmpleado);

                empleado.SaveChanges();

            }

            //lo tengo que redireccionar con "Redirect" y seleccionar el controlador 
            // y el controlador es el que esta con las "//" y el otro es la vista 
            return Redirect("/Empleado/Empleado");
        }

        public ActionResult Registro(string nombre, int id=0)
        {
            ViewBag.id = id;
            ViewBag.nombre = nombre;

            _= id;

            return View();
        }


        [HttpPost]
       public ActionResult save(string nombre, string apellido, string dui,string direccion, string telefono, string correo,string cargo,int id)
        {
            _ = id;
            using (EMPLEADOEntities emp = new EMPLEADOEntities())
            {
                Tbl_empleado empleao = new Tbl_empleado();
                if (id == 0)
                {
                    empleao.Empl_nombre = nombre;
                    empleao.Empl_apellido = apellido;
                    empleao.Empl_DUI = dui;
                    empleao.Empl_dirreccion = direccion;
                    empleao.Empl_tel = telefono;
                    empleao.Empl_email = correo;
                    empleao.Empl_cargo = cargo;
                    emp.Tbl_empleado.Add(empleao);
                    emp.SaveChanges();

                }
                else
                {
                    int idupdate = id;
                    Tbl_empleado editar = emp.Tbl_empleado.Where(x => x.Id_empleado == idupdate).FirstOrDefault();
                    editar.Empl_nombre = nombre;
                    emp.SaveChanges();
                }

                

            }

            return Redirect("/Empleado/Empleado");
        }


        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            _ = id;

            return View();
        }

    }   

}