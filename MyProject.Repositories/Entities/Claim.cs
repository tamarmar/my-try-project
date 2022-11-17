using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum Epolicy { Allow , Deny}
    public class Claim
    {
        public string Id { get; set; }

        public string RoleId { get; set; }

        public string PermissionId { get; set; }

        public Epolicy Policy { get; set; }
    }
}
