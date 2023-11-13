using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Test
{
    public class Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
//guide = string de 16 caractere random used for IDs
        public string MyProperty2 { get; set; }

        
    }
}
