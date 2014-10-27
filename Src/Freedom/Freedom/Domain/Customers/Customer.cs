using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Domain.Customers
{
    public partial class Customer : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public Guid Guid { get; set; }
        public string Password { get; set; }
        public PasswordFormat PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        /// <summary>
        /// 在是系统帐号下才使用
        /// </summary>
        public string SystemName { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime LastActivityDateUtc { get; set; }
    }
}
