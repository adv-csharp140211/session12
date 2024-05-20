using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace app07.Model
{
    public class PermissionRoleConfig : IEntityTypeConfiguration<PermissionRole>
    {
        public void Configure(EntityTypeBuilder<PermissionRole> builder)
        {
            builder.HasKey(e => new { e.RoleId, e.PermissionId });
        }
    }
}
