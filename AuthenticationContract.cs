using System;
using System.Runtime.Serialization;
using Utilities.Crypto;

namespace Mozu
{
    [DataContract]
    public class AuthenticationContract
    {
        private Encryption _secret;

        [DataMember(Name="ApplicationId"         )] public string ApplicationId          { get { return Mozu.Settings["applicationkey"]; } set { } }
        [DataMember(Name="SharedSecret"          )] public string SharedSecret           { get { /*if (_secret == null) _secret = new AES(Mozu.Settings["secret"]); return _secret.Decrypt(); } set { throw new InvalidOperationException("Not Allowed to set Secret Key");*/ return "e5a16e65f3c7434dbbb3f166a191d71a"; } set { } }
        [DataMember(Name="refreshToken"          )] public string RefreshToken           ;
        [DataMember(Name="accessToken"           )] public string AccessToken            ;
        [DataMember(Name="accessTokenExpiration" )] public string AccessTokenExpiration  ;
        [DataMember(Name="refreshTokenExpiration")] public string RefreshTokenExpiration ;
    }


    [DataContract]
    public class TenantContract : AuthenticationContract
    {
        public static string EmailAddress;
        public static string Password;
        /*private Encryption _password;
        private string _email;

        [DataMember(Name="EmailAddress"    )] public string EmailAddress  { 
            get { 
                return _email;
                //return Mozu.Settings["user"]; 
            } 
            set { 
                _email = value;
            } 
        }
        [DataMember(Name="Password"        )] public string Password      { 
            get { 
                return _password.Decrypt();
                //if (_password == null) _password = new AES(Mozu.Settings["password"]); return _password.Decrypt(); 
            } 
            set { 
                _password = new AES(value);
            } 
        }*/
        [DataMember(Name="createdOn"       )] public string Created       ;
        [DataMember(Name="user"            )] public User   user          ;
        [DataMember(Name="tenant"          )] public Tenant tenant        ;
        [DataMember(Name="availableTenants")] public Tenant[] AvailableTenants;
        [DataMember(Name="grantedBehaviors")] public int[]  Granted       ;
        


        [DataContract]
        public class User
        {
            [DataMember(Name="userId"      )] public string Id       ;
            [DataMember(Name="userName"    )] public string UserName ;
            [DataMember(Name="firstName"   )] public string FirstName;
            [DataMember(Name="lastName"    )] public string LastName ;
            [DataMember(Name="emailAddress")] public string Email    ;
        }


        [DataContract]
        public class Tenant
        {
            [DataMember(Name="id"            )] public int    Id                     ;
            [DataMember(Name="name"          )] public string Name                   ;
            [DataMember(Name="domain"        )] public string Domain                 ;
            [DataMember(Name="isDevTenant"   )] public bool            isDevelopment ;
            [DataMember(Name="sites"         )] public Site         [] Sites         ;
            [DataMember(Name="masterCatalogs")] public MasterCatalog[] MasterCatalogs;


            [DataContract]
            public class Site
            {
                [DataMember(Name="id"          )] public int    Id;
                [DataMember(Name="tenantId"    )] public int    TenantId;
                [DataMember(Name="catalogId"   )] public int    CatalogId;
                [DataMember(Name="name"        )] public string Name;
                [DataMember(Name="localeCode"  )] public string LocaleCode;
                [DataMember(Name="countryCode" )] public string CountryCode;
                [DataMember(Name="currencyCode")] public string CurrencyCode;
                [DataMember(Name="domain"      )] public string Domain;
            }


            [DataContract]
            public class MasterCatalog
            {
                [DataMember(Name="id"                 )] public int    Id;
                [DataMember(Name="tenantId"           )] public int    TenantId;
                [DataMember(Name="name"               )] public string Name;
                [DataMember(Name="defaultLocaleCode"  )] public string LocaleCode;
                [DataMember(Name="defaultCurrencyCode")] public string CurrencyCode;
                [DataMember(Name="catalogs")] public Catalog[] Catalogs;


                [DataContract]
                public class Catalog
                {
                    [DataMember(Name="id"             )] public int    Id;
                    [DataMember(Name="tenantId"       )] public int    TenantId;
                    [DataMember(Name="masterCatalogId")] public int    MasterCatalogId;
                    [DataMember(Name="name"           )] public string Name;
                }
            }

        }

    }

}
