using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;
using Newtonsoft.Json;

//Purpose: tracks and stores users' nutrition information for each meal 
//Use: works alongside the USDA FoodData API


namespace HealthWatch360.Models
{
    public class NutritionLog
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class FoodCategory
        {
            public string? description { get; set; }
            public int id { get; set; }
            public string? code { get; set; }
        }

        public class FoodNutrient
        {
            public string? type { get; set; }
            public int id { get; set; }
            public Nutrient? nutrient { get; set; }
            public int dataPoints { get; set; }
            public FoodNutrientDerivation? foodNutrientDerivation { get; set; }
            public double median { get; set; }
            public double amount { get; set; }
            public double? max { get; set; }
            public double? min { get; set; }
        }

        public class FoodNutrientDerivation
        {
            public string? code { get; set; }
            public string? description { get; set; }
            public FoodNutrientSource? foodNutrientSource { get; set; }
        }

        public class FoodNutrientSource
        {
            public int id { get; set; }
            public string? code { get; set; }
            public string? description { get; set; }
        }

        public class FoodPortion
        {
            public int id { get; set; }
            public double value { get; set; }
            public MeasureUnit? measureUnit { get; set; }
            public string? modifier { get; set; }
            public double gramWeight { get; set; }
            public int minYearAcquired { get; set; }
            public double amount { get; set; }
            public int sequenceNumber { get; set; }
            public string? portionDescription { get; set; }
        }

        public class FoundationFood
        {
            public string? foodClass { get; set; }
            public string? description { get; set; }
            public List<FoodNutrient>? foodNutrients { get; set; }
            public List<object>? foodAttributes { get; set; }
            public List<NutrientConversionFactor>? nutrientConversionFactors { get; set; }
            public bool isHistoricalReference { get; set; }
            public int ndbNumber { get; set; }
            public string? dataType { get; set; }
            public FoodCategory? foodCategory { get; set; }
            public int fdcId { get; set; }
            public List<FoodPortion>? foodPortions { get; set; }
            public string? publicationDate { get; set; }
            public List<InputFood>? inputFoods { get; set; }
            public string? scientificName { get; set; }
        }

        public class InputFood
        {
            public int id { get; set; }
            public string foodDescription { get; set; }
            public InputFood inputFood { get; set; }
        }

        public class InputFood2
        {
            public string foodClass { get; set; }
            public string description { get; set; }
            public string dataType { get; set; }
            public FoodCategory foodCategory { get; set; }
            public int fdcId { get; set; }
            public string publicationDate { get; set; }
        }

        public class MeasureUnit
        {
            public int id { get; set; }
            public string name { get; set; }
            public string abbreviation { get; set; }
        }

        public class Nutrient
        {
            public int id { get; set; }
            public string number { get; set; }
            public string name { get; set; }
            public int rank { get; set; }
            public string? unitName { get; set; }
        }

        public class NutrientConversionFactor
        {
            public string? type { get; set; }
            public double proteinValue { get; set; }
            public double fatValue { get; set; }
            public double carbohydrateValue { get; set; }
            public double? value { get; set; }
        }

        public class Root
        {
            public List<FoundationFood>? FoundationFoods { get; set; }
        }

        //NutritionLog <-> User Relationship
        public User? User { get; set; }
        public int? UserID { get; set; }

        ////NutritionLog <-> Goal Relationship
        //public Goal? Goal { get; set; }
        //public int? GoalID { get; set; }

    }

}
