using MongoDB.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gamification.ObjetoDeValor;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Helper.Interfaces;
using Gamification.Entidades;

namespace Gamification.Entidades
{
    public class Grupo : IEntity
    {
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        
    }
}
