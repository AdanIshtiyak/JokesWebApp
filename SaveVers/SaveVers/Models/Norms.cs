using System.ComponentModel.DataAnnotations.Schema;

namespace SaveVers.Models
{
    public class Norms
    {
        public int ID { get; set; }
        public int AnalyzesID { get; set; }
        public string Name { get; set; }
        public int MinValue1 { get; set; }
        public int MaxValue1 { get; set; }
        public int MinValue2 { get; set; }
        public int MaxValue2 { get; set; }

        [ForeignKey("AnalyzesID")]
        public Analyzes Analyzes { get; set; }
    }
}
 