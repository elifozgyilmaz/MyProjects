using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BauToDoList.Models
{
    public enum Status /*BaseEntity olmayacak// Sabit olayları veriyoruz burda*/
    {
        New=0,
        Waiting=1,
        Complate=2,
    }
}