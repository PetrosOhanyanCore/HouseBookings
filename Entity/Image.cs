using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Image<T> where T : class
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public T Property { get; set; }
        public int PropertyId { get; set; }
    }
}