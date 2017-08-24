using System.Collections.Generic;
using MongoDB.Helper.Repositorio;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Helper.Interfaces;
using Gamification.DAL.Entidades;
using Gamification.DAL;

namespace Gamification.DAL.Repositorio
{
    public class GrupoRepositorio : RepositorioBase<Grupo>
    {
        public List<Usuario> GetIntegrantes(string codigo)
        {
            Grupo grupo = GetById(codigo);
            return grupo.Integrantes;
        }

    }
}
