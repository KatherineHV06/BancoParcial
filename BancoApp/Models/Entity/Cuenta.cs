using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BancoApp.Models.Entity
{

    [Table("t_cuenta")]
    public class Cuenta
    {

        //EL SIGNO DE INTERROGACION ES PARA DEJAR VALORES NULOS

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Nombre")]
        public string? Nombre { get; set; }

         [Column("Tipo")]
        public string? TipoC { get; set; }

         [Column("Saldo")]
        public int SaldoI { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

       

       

    }
}