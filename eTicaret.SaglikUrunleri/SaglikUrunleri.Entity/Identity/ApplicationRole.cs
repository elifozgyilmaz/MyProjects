using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.Entity.Identity
{
    public class ApplicationRole :IdentityRole /* **** nugetten asp.net.identity.entity indirdik **** */
    {
        [StringLength(200)]
        public string Description { get; set; }

    }
}
