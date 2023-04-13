namespace excelUpdate50kUsers.Countries;


public class Canada
{
    // States in Canada
    public enum Canadian_States
    {
        Ontario,
        Quebec,
        
        [Display(Name = "British Columbia")]
        BritishColumbia,
        
        Alberta,
        Saskatchewan,
        Manitoba,
        
        [Display(Name = "Nova Scotia")]
        NovaScotia,
        
        [Display(Name = "New Brunswick")]
        NewBrunswick,
        
        [Display(Name = "Newfoundland and Labrador")]
        NewfoundlandandLabrador,
        
        [Display(Name = "Prince Edward Island")]
        PrinceEdwardIsland
    }

    
    // Cities in Ontario
    public enum Ontario_Cities
    {
        Toronto,
        Ottawa,
        Hamilton,
        London,
        
        [Display(Name = "Kitchener-Waterloo-Cambridge")]
        KitchenerWaterlooCambridge,
        Windsor,
        Kingston,
        
        [Display(Name = "Thunder Bay")]
        ThunderBay,
        Sudbury,
        Mississauga,
    }
    
    // Cities in Quebec
    public enum Quebec_Cities
    {
        Montreal,
        Mirabel,
        Laval,
        Gatineau,
        Longueuil,
        Sherbrooke,
        Saguenay,
        Terrebonne,
        Repentigny,
        Brossard,
    }
    
    // Cities in British Columbia
    public enum BritishColumbia_Cities
    {
        Vancouver,
        Victoria,
        Abbotsford,
        Kelowna,
        Nanaimo,
        Kamloops,
        Chilliwack,
        Vernon,
        Courtenay,
        Penticton
    }
    
    // Cities in Alberta
    public enum Alberta_Cities
    {
        Calgary,
        Edmonton,
        Lethbridge,
        Airdrie,
        SpruceGrove,
        Lloydminster,
        Camrose,
        Wetaskiwin,
        Cochrane,
        Brooks
    }
    
    // Cities in Saskatchewan
    public enum Saskatchewan_Cities
    {
        Saskatoon,
        Regina,
        Yorkton,
        Estevan,
        Weyburn,
        Humboldt,
        Melfort,
        Lloydminster,
        Martensville,
        Warman
    }
    
    // Cities in Manitoba
    public enum Manitoba_Cities
    {
        Winnipeg,
        Brandon,
        Steinbach,
        Thompson,
        Selkirk,
        Winkler,
        Dauphin,
        Morden,
        Beausejour,
        Niverville
    }
    
    // Cities in Nova Scotia
    public enum NovaScotia_Cities
    {
        Halifax,
        Sydney,
        Truro,
        Amherst,
        Kentville,
        Bridgewater,
        Yarmouth,
        Digby,
        Middleton,
        Wolfville
    }
    
    // Cities in New Brunswick
    public enum NewBrunswick_Cities
    {
        Fredericton,
        Moncton,
        Miramichi,
        Edmundston,
        Dieppe,
        Campbellton,
        Oromocto,
        Shediac,
        Quispamsis,
        Sussex
    }
    
    // Cities in Newfoundland and Labrador
    public enum NewfoundlandandLabrador_Cities
    {
        MountPearl,
        CornerBrook,
        Gander,
        LabradorCity,
        Stephenville,
        Marystown,
        BayRoberts,
        Carbonear,
        Paradise,
        Torbay
    }
    
    // Cities in Prince Edward Island
    public enum PrinceEdwardIsland_Cities
    {
        Charlottetown,
        Summerside,
        Stratford,
        Cornwall,
        Montague,
        Souris,
        Alberton,
        Tignish,
        Georgetown,
        Cavendish
    }
}
