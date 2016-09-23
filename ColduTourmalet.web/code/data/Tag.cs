using System.ComponentModel.DataAnnotations;

namespace ColduTourmalet.web.code.data
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}