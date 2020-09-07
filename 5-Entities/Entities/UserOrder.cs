using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Entities.Enums;
using Entities.Notifications;

namespace Entities.Entities
{
    [Table("UserOrder")]
    public class UserOrder : Notifies
    {
        [Column("UOR_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("UOR_ESTADO")]
        [Display(Name = "Estado")]
        public OrderStatus Estado { get; set; }

        [Column("UOR_QTD")]
        [Display(Name = "Quantidade")]
        public int QtdCompra { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}