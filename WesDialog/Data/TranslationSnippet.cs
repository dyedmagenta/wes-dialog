using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesDialog.Data
{
    public class TranslationSnippet
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public bool IsReplacement { get; set; }
        public string TextReplacement { get; set; }
        public List<string> TagInfo { get; set; }
        public List<string> References { get; set; }
    }
}
