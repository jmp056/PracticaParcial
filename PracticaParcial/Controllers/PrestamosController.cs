using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaParcial.DAL;
using PracticaParcial.Entidades;

namespace PracticaParcial.Controllers
{
    public class PrestamosController
    {
        Contexto contexto = new Contexto();

        public bool Guardar(Prestamos Prestamo)
        {
            bool paso = false;

            try
            {
                contexto.Prestamos.Add(Prestamo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public bool Modificar(Prestamos Prestamo)
        {
            bool paso = false;

            try
            {
                contexto.Entry(Prestamo).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            
            return paso;
        }

        public bool Eliminar(int Id)
        {
            bool paso = false;

            try
            {
                Prestamos Prestamo = contexto.Prestamos.Find(Id);
                contexto.Entry(Prestamo).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public Prestamos Buscar(int Id)
        {
            Prestamos Prestamo = new Prestamos();
            Contexto contexto = new Contexto();
            try
            {
                Prestamo = contexto.Prestamos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Prestamo;
        }
    }
}