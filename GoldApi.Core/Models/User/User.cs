using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoldApi.Core.Enums;

namespace GoldApi.Core.Models;

public class User
{
    public int MemberId { get; set; }
    public int PersonId {get; set; }
    public Person Demographics { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public AuthenticationType AuthenticationType { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DisabledDate { get; set; }
    public bool isActive { get; set; } = true;
    public UserSettings Settings { get; set; }
    public UserPreferences Preferences { get; set; }
    public List<UserGoals> Goals { get; set; }

}

// password?
// social media connections
// 3rd party app connections
// connections?
// User Type:
//Permissions based on type?
//Metrics
