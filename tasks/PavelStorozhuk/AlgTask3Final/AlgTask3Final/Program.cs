using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgTask3Final
{
    class Program
    {
        static void Main(string[] args)
        {
           Justification justification = new Justification();
          
            var text = "fdsf ffffffff ddsdsd" +
                          " quasi signum absolvere. Nobis aliter videtur," +
                          " recte secusne, postea; Hic, qui utrumque probat, " +
                          "ambobus debuit uti, sicut facit re, neque tamen dividit " +
                          "verbis. Tollenda est atque extrahenda radicitus. " +
                          "Itaque e contrario moderati aequabilesque habitus," +
                          " affectiones ususque corporis apti esse ad naturam videntur. " +
                          "De maximma autem re eodem modo, divina mente atque natura mundum universum " +
                          "et eius maxima partis administrari. Reicietur etiam Carneades, nec ulla de summo bono ratio aut voluptatis non dolendive particeps aut honestatis expers probabitur. Ut etiam contendant et elaborent, si efficere possint, ut aut non appareat corporis vitium aut quam minimum appareat? Duo Reges: constructio interrete. Quamquam scripsit artem rhetoricam Cleanthes, Chrysippus etiam, sed sic, ut, si quis obmutescere concupierit, nihil aliud legere debeat. Est tamen ea secundum naturam multoque nos ad se expetendam magis hortatur quam superiora omnia.";
            var justify=justification.TextJustify(text, 20);
            Console.WriteLine(justify);

            Console.ReadKey();
        }
    }
}
