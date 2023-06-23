
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sistema_Guarderia.Data;
using Sistema_Guarderia.Models;
#nullable disable // Para quitar el aviso de nulls

public class InscripcionBLL
{
    
        private ApplicationDbContext contexto;

        public InscripcionBLL(ApplicationDbContext _contexto)
        {
            contexto = _contexto;
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = contexto.Inscripcion.Any(c => c.InscripcionId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        public Inscripcion ExisteNombreIncripcion(string Nombre)
        {
            Inscripcion existe;

            try
            {
                existe = contexto.Inscripcion              
                .Where( p => p.Nombre
                .ToLower() == Nombre.ToLower())
                .AsNoTracking()
                .SingleOrDefault();

            }catch
            {
                throw;
            }
            return existe;
        }

        public bool Guardar(Inscripcion inscripcion)
        {
            if (!Existe(inscripcion.InscripcionId))
                return Insertar(inscripcion);
            else
                return Modificar(inscripcion);
        }

        private bool Insertar(Inscripcion inscripcion)
        {
            bool Insertado = false;

            try
            {
                contexto.Inscripcion.Add(inscripcion);
                Insertado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private bool Modificar(Inscripcion inscripcion)
        {
            bool Insertado = false;

            try
            {
                contexto.Entry(inscripcion).State = EntityState.Modified;
                Insertado =  contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        public Inscripcion Buscar(int id)
        {
            return contexto.Inscripcion
                .Where(s => s.InscripcionId == id && s.Estado == true)
                .SingleOrDefault();
        }
 
        public bool Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var inscripcion = Buscar(id);

                if (inscripcion != null)
                {
                    inscripcion.Estado = false;
                    Eliminado = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> inscripcion)
        {
            List<Inscripcion> Lista = new List<Inscripcion>();
            try
            {
                Lista = contexto.Inscripcion
                .Where(c => c.Estado == true)
                .Where(inscripcion)
                .AsNoTracking()
                .ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
}
