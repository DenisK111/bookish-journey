namespace BookishJourney.Models.Entities;

public enum Category
{
    None = 0,
    // Fiction
    Action,
    Adventure,
    Drama,
    Comedy,
    ComingOfAge,
    SocialIssues,
    Fantasy,
    SciFi,
    // ReSharper disable once InconsistentNaming
    YA,
    Mystery,
    Thriller,
    Erotic,
    Realism,
    Classics,
    MagicalRealism,
    Historical,
    // NonFiction
    Math,
    Biology,
    Chemistry,
    Physics,
    History,
    Geography,
    Literature,
    Language,
    PhilosophyAndEthics,
    ComputerScience,
    Psychology,
    Religion,
    Engineering,
}

public enum BookType
{
    None = 0,
    Fiction,
    NonFiction,
}