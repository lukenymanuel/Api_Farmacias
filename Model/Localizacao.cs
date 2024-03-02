using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Api_Farmacias.Model;

namespace Api_Farmancias.Model
{
    [Table("localizacao")]
    public class Localizacao
    {
        [Key]
        [Column("id")]
        public int Id {get;set;}
        [Column("codigo_ip")]
        public int Codigo_ip{get;set;}
        [Column("id_farmacia")]
        public int Id_farmacia{get;set;}


    }
}