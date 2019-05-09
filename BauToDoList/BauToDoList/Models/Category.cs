using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BauToDoList.Models
{
    public class Category : BaseEntity /*BaseEntity tablo miras alındı.*/
    {
        [DisplayName("Kategori Adı")] /*Kullanıcının göreceği tablo adı*/
        [Required(ErrorMessage="Bu alanı doldurmak zorunludur.")] /*Boş giriş olmaması için*/
        [StringLength(200)] /* Alan boyutu belirledik nvarchar(10) yazmak gibi */
        public string Name { get; set; }


        public virtual ICollection<ToDoItem> ToDoItems { get; set; }
    }
}