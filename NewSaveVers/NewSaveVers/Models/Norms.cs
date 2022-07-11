using System.ComponentModel.DataAnnotations.Schema;

namespace NewSaveVers.Models
{
    public class Analyzes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Norms> Norms { get; set; }
    }
    public class Norms
    {
        public int ID { get; set; }
        public int AnalyzID { get; set; }
        public string Name { get; set; }
        public double MinValue1 { get; set; }
        public double MaxValue1 { get; set; }
        public double MinValue2 { get; set; }
        public double MaxValue2 { get; set; }

        [ForeignKey("AnalyzesID")]
        public Analyzes Analyzes { get; set; }
    }
}
