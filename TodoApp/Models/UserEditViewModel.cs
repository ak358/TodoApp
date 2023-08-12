using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class UserEditViewModel
    {
        public int Id { get; set; }

        [DisplayName("ユーザー名")]
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [DisplayName("新しいパスワード")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("ロール")]
        public List<int> RoleIds { get; set; }
    }
}