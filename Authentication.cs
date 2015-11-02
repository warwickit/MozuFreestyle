using System;

namespace Mozu
{
    
    public class Authentication
    {
        private AuthenticationContract _ticket;
        private TenantContract _tenant;
        public AuthenticationContract Ticket { get { if (_ticket == null) _ticket = new AuthenticationContract(); return _ticket; } }
        public TenantContract Tenant { get { if (_tenant == null) _tenant = new TenantContract(); return _tenant; } }


        public void Authenticate()
        {
            /** grab an authentication ticket */
            _ticket = (AuthenticationContract) Mozu.Request(this.Ticket);

            /** grab tenant information */
            _tenant = (TenantContract) Mozu.Request(this.Tenant);
        }
        
    }
}
