using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class CustomerUpdateDto
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public decimal AccountBalance { get; set; } //bakiye için
        public int UserId { get; set; }
    }
}
