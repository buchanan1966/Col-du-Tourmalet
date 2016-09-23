using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColduTourmalet.web.code.data
{
    public class JournalEntryTag
    {
        [Key]
        [Column(Order = 0)]
        public int JournalEntryId { get; set; }
        public JournalEntry JournalEntry { get; set; }
        [Key]
        [Column(Order = 1)]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}