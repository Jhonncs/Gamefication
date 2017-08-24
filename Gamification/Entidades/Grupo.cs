using MongoDB.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gamification.DAL;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Gamification.DAL.Entidades;

namespace Gamification.DAL.Entidades
{
    public class Grupo : IEntity
    {
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public List<Usuario> Integrantes { get; set; }
        
    }
}
