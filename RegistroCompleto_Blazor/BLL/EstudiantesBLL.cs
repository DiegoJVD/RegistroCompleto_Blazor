using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroCompleto_Blazor.Models;
using RegistroCompleto_Blazor.DAL;
using Microsoft.EntityFrameworkCore;

namespace RegistroCompleto_Blazor.BLL
{
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante )
        {
            if (!Existe(estudiante.EstudianteID))
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }
        private static bool Insertar(Estudiantes estudiante)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Estudiante.Add(estudiante);
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static bool Modificar(Estudiantes estudiante)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Entry(estudiante).State = EntityState.Modified;
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static bool Eliminar(int id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                var estudiante = context.Estudiante.Find(id);

                if (estudiante != null)
                {
                    context.Estudiante.Remove(estudiante);
                    found = context.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static Estudiantes Buscar(int id)
        {
            Contexto context = new Contexto();
            Estudiantes estudiante;

            try
            {
                estudiante = context.Estudiante.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return estudiante;
        }
        public static bool Existe(int id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                found = context.Estudiante.Any(p => p.EstudianteID == id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }

        
    }
}
