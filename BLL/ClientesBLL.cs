 using Microsoft.EntityFrameworkCore;
using Sistema_Guarderia.Models;
using Sistema_Guarderia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sistema_Guarderia.BLL;
public class ClienteBLL
{
    private ApplicationDbContext contexto;

    public ClienteBLL(ApplicationDbContext _contexto)
    {
        contexto = _contexto;
    }

    private bool Existe(int id)
    {
        return contexto.Cliente.Any(o => o.ClienteId == id);
    }

    public Cliente ExisteNombreServicio(string Nombre)
    {
        Cliente existe;

        try
        {
            existe = contexto.Cliente
           .Where(p => p.Nombre
           .ToLower() == Nombre.ToLower())
           .AsNoTracking()
           .SingleOrDefault();

        }
        catch
        {
            throw;
        }
        return existe!;
    }

    public bool Guardar(Cliente cliente)
    {
        if (!Existe(cliente.ClienteId))
            return Insertar(cliente);
        else
            return Modificar(cliente);
    }

    private bool Insertar(Cliente cliente)
    {
        bool Insertado = false;

        try
        {
            if (contexto.Cliente.Add(cliente) != null)
            {
                Insertado = contexto.SaveChanges() > 0;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return Insertado;
    }

    private bool Modificar(Cliente cliente)
    {
        contexto.Entry(cliente).State = EntityState.Modified;
        return contexto.SaveChanges() > 0;
    }

    public Cliente? Buscar(int id)
    {
        return contexto.Cliente
            .Where(s => s.ClienteId == id && s.Visible == true)
            .SingleOrDefault();
    }

    public bool Eliminar(int id)
    {
        bool Eliminado = false;

        try
        {
            var cliente = Buscar(id);

            if (cliente != null)
            {
                cliente.Visible = false;
                Eliminado = contexto.SaveChanges() > 0;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return Eliminado;
    }

    public List<Cliente> GetList(Expression<Func<Cliente, bool>> cliente)
    {
        return contexto.Cliente
            .AsNoTracking()
            .Where(cliente)
            .ToList();
    }
}
