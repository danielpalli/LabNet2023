namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "El nombre de la categoria es obligatorio")]
        [StringLength(15, ErrorMessage = "El nombre de la categoria debe tener al menos 15 caracteres")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "La descricion de la categoria es obligatorio")]
        [Column(TypeName = "ntext")]
        [StringLength(300, ErrorMessage = "La descripcion no puede tener mas de 300 caracteres")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
