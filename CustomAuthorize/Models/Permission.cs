using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomAuthorize.Models
{
    [Table("Permission")]
    public class Permission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string ListPermission { get; set; }
        public virtual Role Role { get; set; }
    }
}