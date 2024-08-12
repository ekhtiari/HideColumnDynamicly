using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class Main
{
    
    public History History { get; set; }
    [Display(Name = "Main Title")]
    public MainTitle MainTitle { get; set; }
    [Display(Name = "Extra Data")]
    public ExtraData ExtraData { get; set; }
    public int Bid { get; set; }
    public MoreInfo MoreInfo { get; set; }
}


public class History
{
    [Display(Name = "Sub Title 1")]
    public string SubTitle1 { get; set; }
    [Display(Name = "Sub Title 2")]
    public string SubTitle2 { get; set; }
    [Display(Name = "Sub Title 3")]
    public string SubTitle3 { get; set; }
    [Display(Name = "Sub Title 4")]
    public string SubTitle4 { get; set; }
    [Display(Name = "Sub Title 5")]
    public string SubTitle5 { get; set; }
}

public class MainTitle
{
    [Display(Name = "Sub Title 1")]
    public bool SubTitle1 { get; set; }
    [Display(Name = "Sub Title 2")]
    public string SubTitle2 { get; set; }
    [Display(Name = "Sub Title 3")]
    public string SubTitle3 { get; set; }
}
public class ExtraData
{
    [Display(Name = "Sub Title 1")]
    public string SubTitle1 { get; set; }
    [Display(Name = "Sub Title 2")]
    public string SubTitle2 { get; set; }
    [Display(Name = "Sub Title 3")]
    public string SubTitle3 { get; set; }
    [Display(Name = "Sub Title 4")]
    public string SubTitle4 { get; set; }
    [Display(Name = "Sub Title 5")]
    public string SubTitle5 { get; set; }
}

public class MoreInfo
{
    [Display(Name = "Sub 1")]
    public string Sub1 { get; set; }
    [Display(Name = "Sub 2")]
    public string Sub2 { get; set; }
    [Display(Name = "Sub 3")]
    public string Sub3 { get; set; }
}