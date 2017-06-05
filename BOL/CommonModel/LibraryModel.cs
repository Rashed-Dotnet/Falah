using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonModel
{

    public partial class LibraryModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Contact { get; set; }

        public List <LibraryModel> LibraryModelList { get; set; }
    }
}
