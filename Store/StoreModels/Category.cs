using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nmae { get; set; }
        [DisplayName("DisplayOrder")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }=DateTime.Now;
    }
}
