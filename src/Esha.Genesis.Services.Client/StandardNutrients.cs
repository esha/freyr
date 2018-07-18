using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum StandardNutrients
    {
        /// <remarks />
        TotalWeight,

        /// <remarks />
        Calories,

        /// <remarks />
        None,

        /// <remarks />
        CaloriesFromFat,

        /// <remarks />
        CaloriesFromSaturatedFat,

        /// <remarks />
        CaloriesFromTransFat,

        /// <remarks />
        Protein,

        /// <remarks />
        Carbohydrates,

        /// <remarks />
        Starch,

        /// <remarks />
        TotalDietaryFiber,

        /// <remarks />
        TotalSolubleFiber,

        /// <remarks />
        TotalInsolubleFiber,

        /// <remarks />
        TotalSugars,

        /// <remarks />
        Monosaccharides,

        /// <remarks />
        Galactose,

        /// <remarks />
        Glucose,

        /// <remarks />
        Fructose,

        /// <remarks />
        Disaccharides,

        /// <remarks />
        Lactose,

        /// <remarks />
        Sucrose,

        /// <remarks />
        Maltose,

        /// <remarks />
        OtherCarbohydrates,

        /// <remarks />
        NetCarbohydrates,

        /// <remarks />
        Fat,

        /// <remarks />
        SaturatedFat,

        /// <remarks />
        MonounsaturatedFat,

        /// <remarks />
        PolyunsaturatedFat,

        /// <remarks />
        TransFattyAcid,

        /// <remarks />
        Cholesterol,

        /// <remarks />
        Water,

        /// <remarks />
        Ash,

        /// <remarks />
        Kilojoules,

        /// <remarks />
        VitaminA,

        /// <remarks />
        AlphaCarotene,

        /// <remarks />
        BetaCarotene,

        /// <remarks />
        BetaCaroteneEquivalent,

        /// <remarks />
        VitaminB1,

        /// <remarks />
        VitaminB2,

        /// <remarks />
        VitaminB3,

        /// <remarks />
        VitaminB3NiacinEquivalent,

        /// <remarks />
        VitaminB6,

        /// <remarks />
        VitaminB12,

        /// <remarks />
        Biotin,

        /// <remarks />
        VitaminC,

        /// <remarks />
        VitaminD,

        /// <remarks />
        VitaminE,

        /// <remarks />
        Folate,

        /// <remarks />
        FolicAcid,

        /// <remarks />
        FolateDFE,

        /// <remarks />
        FolateFood,

        /// <remarks />
        Cryptoxanthin,

        /// <remarks />
        VitaminK,

        /// <remarks />
        PantothenicAcid,

        /// <remarks />
        Boron,

        /// <remarks />
        Calcium,

        /// <remarks />
        Chloride,

        /// <remarks />
        Chromium,

        /// <remarks />
        Copper,

        /// <remarks />
        Fluoride,

        /// <remarks />
        Iodine,

        /// <remarks />
        Iron,

        /// <remarks />
        Magnesium,

        /// <remarks />
        Manganese,

        /// <remarks />
        Molybdenum,

        /// <remarks />
        Phosphorus,

        /// <remarks />
        Potassium,

        /// <remarks />
        Selenium,

        /// <remarks />
        Sodium,

        /// <remarks />
        Zinc,

        /// <remarks />
        Butyric,

        /// <remarks />
        Caprioc,

        /// <remarks />
        Caprylic,

        /// <remarks />
        Capric,

        /// <remarks />
        Lauric,

        /// <remarks />
        Myristic,

        /// <remarks />
        Pentadecanoic,

        /// <remarks />
        Palmitic,

        /// <remarks />
        Heptadecanoic,

        /// <remarks />
        Stearic,

        /// <remarks />
        Arachidic,

        /// <remarks />
        Behenic,

        /// <remarks />
        Tetracosanoic,

        /// <remarks />
        Myristoleic,

        /// <remarks />
        Pentadecenoic,

        /// <remarks />
        Palmitoleic,

        /// <remarks />
        Heptadecenoic,

        /// <remarks />
        Oleic,

        /// <remarks />
        Eicosenoic,

        /// <remarks />
        Erucic,

        /// <remarks />
        Nervonic,

        /// <remarks />
        Linoleic,

        /// <remarks />
        Linolenic,

        /// <remarks />
        Stearidonic,

        /// <remarks />
        Eicosatrienoic,

        /// <remarks />
        Arachidonic,

        /// <remarks />
        Epa,

        /// <remarks />
        Dpa,

        /// <remarks />
        Dha,

        /// <remarks />
        Omega3FattyAcid,

        /// <remarks />
        Omega6FattyAcid,

        /// <remarks />
        Alanine,

        /// <remarks />
        Arginine,

        /// <remarks />
        AsparticAcid,

        /// <remarks />
        Cystine,

        /// <remarks />
        GlutamicAcid,

        /// <remarks />
        Glycine,

        /// <remarks />
        Histidine,

        /// <remarks />
        Isoleucine,

        /// <remarks />
        Leucine,

        /// <remarks />
        Lysine,

        /// <remarks />
        Methionine,

        /// <remarks />
        Phenylalanine,

        /// <remarks />
        Proline,

        /// <remarks />
        Serine,

        /// <remarks />
        Threonine,

        /// <remarks />
        Tryptophan,

        /// <remarks />
        Tyrosine,

        /// <remarks />
        Valine,

        /// <remarks />
        Alcohol,

        /// <remarks />
        Caffeine,

        /// <remarks />
        ArtificialSweetener,

        /// <remarks />
        Aspartame,

        /// <remarks />
        Saccharin,

        /// <remarks />
        SugarAlcohol,

        /// <remarks />
        Glycerol,

        /// <remarks />
        Inositol,

        /// <remarks />
        Mannitol,

        /// <remarks />
        Sorbitol,

        /// <remarks />
        Xylitol,

        /// <remarks />
        OrganicAcids,

        /// <remarks />
        AceticAcid,

        /// <remarks />
        CitricAcid,

        /// <remarks />
        LacticAcid,

        /// <remarks />
        MalicAcid,

        /// <remarks />
        Choline,

        /// <remarks />
        Taurine,

        /// <remarks />
        LuteinAndZeaxanthin,

        /// <remarks />
        Lycopene,

        /// <remarks />
        Cost,

        /// <remarks />
        GlycemicIndex,

        /// <remarks />
        GlycemicLoad,

        /// <remarks />
        ExchangeFat,

        /// <remarks />
        ExchangeFruit,

        /// <remarks />
        ExchangeMedFatMeat,

        /// <remarks />
        ExchangeNonFatMilk,

        /// <remarks />
        ExchangeOtherCarbs,

        /// <remarks />
        ExchangeStarch,

        /// <remarks />
        ExchangeVegetables,

        /// <remarks />
        ExchangeLeanMeat,

        /// <remarks />
        ExchangeRedFatMilk,

        /// <remarks />
        ExchangeWholeMilk,

        /// <remarks />
        ExchangeHighFatMeat,

        /// <remarks />
        ExchangePlantProtein,

        /// <remarks />
        ExchangeAlcohol,

        /// <remarks />
        Polysaccharides,

        /// <remarks />
        Polyphenols,

        /// <remarks />
        MyPlateGrainTotal,

        /// <remarks />
        MyPlateVegetableTotal,

        /// <remarks />
        MyPlateFruit,

        /// <remarks />
        MyPlateDairy,

        /// <remarks />
        MyPlateProteinTotal,

        /// <remarks />
        SolubleFiber,

        /// <remarks />
        OtherSolubleFiber,

        /// <remarks />
        OtherInsolubleFiber,

        /// <remarks />
        OtherFiber,

        /// <remarks />
        DietaryFiber,

        /// <remarks />
        InsolubleFiber,

        /// <remarks />
        AddedSugar
    }
}