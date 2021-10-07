using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WaterBillAppCore.Models
{
    public class QueryType
    {
        [Key]
        public int QueryTypeId { get; set; }

        [Display(Name = "Query Type Name")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

    }
}
