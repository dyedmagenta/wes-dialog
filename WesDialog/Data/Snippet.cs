using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesDialog.Data
{
    public class Snippet
    {
        public string Text { get; set; }

        public string ReplacementText { get; set; }

        public int StartsAtCharacter { get; set; }

        public long LineIndex { get; set; }

        public bool IsReplacement { get; set; }
    }
}