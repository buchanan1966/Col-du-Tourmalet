using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColduTourmalet.web.code.data
{
    public class JournalEntryTag
    {
        [Key]
        [Column(Order = 0)]
        public int JournalEntryId { get; set; }
        public virtual JournalEntry JournalEntry { get; set; }
        [Key]
        [Column(Order = 1)]
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}