using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialNetworkSite
{
    public class SavedAccount
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string UserEmail { get; set; }
    }
}
