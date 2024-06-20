﻿using System;
using System.Collections.Generic;

public class Authenticator2
{
    // TODO: Implement the Authenticator.Admin property
    public Identity2 Admin
    {
        get
        {
            return new Identity2 {Email = "admin@ex.ism", FacialFeatures = new FacialFeatures { EyeColor = "green",  PhiltrumWidth = 0.9m }, NameAndAddress = new List<string>() { "Chanakya", "Mumbai", "India" } };
        }
    }

    // TODO: Implement the Authenticator.Developers property
    public IDictionary<string, Identity2> Developers 
    { 
        get
        {
            return new Dictionary<string, Identity2>()
            {
                ["Bertrand"] = new Identity2 
                    { 
                        Email = "bert@ex.ism",
                        FacialFeatures = new FacialFeatures 
                            { 
                                EyeColor = "blue", 
                                PhiltrumWidth = 0.8m
                        }, 
                        NameAndAddress = new List<string>() 
                            { "Bertrand", "Paris", "France" } 
                    },
                ["Anders"] = new Identity2
                    {
                        Email = "anders@ex.ism",
                        FacialFeatures = new FacialFeatures 
                            {
                                EyeColor = "brown", 
                                PhiltrumWidth = 0.85m
                        }, 
                        NameAndAddress = new List<string>() 
                            { "Anders", "Redmond", "USA" } 
                    }
            };
        }
    }
}

//**** please do not modify the FacialFeatures class ****
public class FacialFeatures
{
    public string EyeColor { get; set; }
    public decimal PhiltrumWidth { get; set; }
}

//**** please do not modify the Identity class ****
public class Identity2
{
    public string Email { get; set; }
    public FacialFeatures FacialFeatures { get; set; }
    public IList<string> NameAndAddress { get; set; }
}
