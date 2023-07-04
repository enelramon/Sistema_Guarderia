
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sistema_Guarderia.Data;
using Sistema_Guarderia.Models;
#nullable disable // Para quitar el aviso de nulls

public class ServiciosBLL
{
    
        private ApplicationDbContext contexto;

        public ServiciosBLL(ApplicationDbContext _contexto)
        {
            contexto = _contexto;
        }

        private bool Existe(int id)
        {
            bool existe = false;

            try
            {
                existe = contexto.Servicio.Any(c => c.ServicioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return existe;
        }

        public Servicio ExisteNombreServicio(string Nombre)
        {
            Servicio existe;

            try
            {
                existe = contexto.Servicio              
                .Where( p => p.NombreServicio
                .ToLower() == Nombre.ToLower())
                .AsNoTracking()
                .SingleOrDefault();

            }catch
            {
                throw;
            }
            return existe;
        }

        public bool Guardar(Servicio servicios)
        {
            if (!Existe(servicios.ServicioId))
                return Insertar(servicios);
            else
                return Modificar(servicios);
        }

        private bool Insertar(Servicio servicios)
        {
            bool Insertado = false;

            try
            {
                contexto.Servicio.Add(servicios);
                Insertado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        private bool Modificar(Servicio servicios)
        {
            bool Insertado = false;

            try
            {
                contexto.Entry(servicios).State = EntityState.Modified;
                Insertado =  contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return Insertado;
        }

        public Servicio Buscar(int id)
        {
            return contexto.Servicio
                .Where(s => s.ServicioId == id && s.Estado == true)
                .SingleOrDefault();
        }
 
        public bool Eliminar(int id)
        {
            bool Eliminado = false;

            try
            {
                var servicios = Buscar(id);

                if (servicios != null)
                {
                    servicios.Estado = false;
                    Eliminado = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Eliminado;
        }

        public List<Servicio> GetList(Expression<Func<Servicio, bool>> servicios)
        {
            List<Servicio> Lista = new List<Servicio>();
            try
            {
                Lista = contexto.Servicio
                .Where(c => c.Estado == true)
                .Where(servicios)
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
