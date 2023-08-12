using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("ユーザー名")]
        [Required]
        [Index(IsUnique = true)]
        [StringLength(256)]
        public string UserName { get; set; }
        [DisplayName("パスワード")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        [NotMapped]
        [DisplayName("ロール")]
        public List<int> RoleIds { get; set; }

        public virtual ICollection<Todo> Todoes { get; set; }
    }
}