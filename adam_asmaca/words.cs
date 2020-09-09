using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adam_asmaca
{
    public class Words
    {
        public List<Datum> Data{ get; set; }
    }

    public class Datum
    {
        public Word Word { get; set; }
    }

    public class Word
    {
        public string Value { get; set; }
        public int NumSyllables { get; set; }
    }
}
