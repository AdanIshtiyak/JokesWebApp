using SaveVers.Models;

namespace SaveVers
{
    public class FillData
    {
        DB setData = new DB();
        public void FillTableAnalyzes(string str)
        {
            setData._analyzes.Add(new Analyzes()
            {
                Name = str
            });
        }
        public void FillTableNorms(int _AnalyzID, string _Name, double _MinValue1, double _MaxValue1, double _MinValue2, double _MaxValue2)
        {
            setData._norms.Add(new Norms()
            {
                AnalyzID = _AnalyzID,
                Name = _Name,
                MinValue1 = _MinValue1,
                MaxValue1 = _MaxValue1,
                MinValue2 = _MinValue2,
                MaxValue2 = _MaxValue2
            });
        }
        
        protected void Main()
        {
            FillTableAnalyzes("OAK");
            FillTableAnalyzes("OAM");
            FillTableAnalyzes("OAC");
            FillTableNorms(1,"Гемоглобин", 1.2,1.5,1.7,1.9);
            FillTableNorms(1, "Гемоглобин", 1.3, 1.9, 1.3, 1.9);
            FillTableNorms(1, "Гемоглобин", 1.2, 1.5, 1.6, 1.7);
        }


    }
}
