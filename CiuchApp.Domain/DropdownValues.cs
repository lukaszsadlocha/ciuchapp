using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace CiuchApp.Domain
{
    [DebuggerDisplay("Name={Name} Id={Id}")]
    public abstract class DropDownValueBase : CiuchAppBaseModel
    {
        [Required]
        public string Name { get; set; }
    }

    public class Color : DropDownValueBase { }

    public class TopCategory : DropDownValueBase {}

    public class MainCategory : DropDownValueBase
    {
        public int TopCategoryId { get; set; }
        
        [JsonIgnore]
        public TopCategory TopCategory { get; set; }

    }
    public class Group : DropDownValueBase
    {
        public string GroupCode { get; set; }
        public string CnCode { get; set; }
        public int MainCategoryId { get; set; }
        [JsonIgnore]
        public MainCategory MainCategory { get; set; }
    }
    public class Component : DropDownValueBase { }
    public class CountryOfOrigin : DropDownValueBase
    {
        public string CountryOfOriginCode { get; set; }
    }
    public class Supplier : DropDownValueBase { }
    public class Size : DropDownValueBase { }
    public class CodeCn : DropDownValueBase { }
    public class Set : DropDownValueBase { }
    public class ColorName : DropDownValueBase { }

    public class PieceType : DropDownValueBase { }

    //BusinessTrip Values

    public class Country : DropDownValueBase { }
    public class City : DropDownValueBase
    {
        public int CountryId { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }
    }
    public class Season : DropDownValueBase { }
    public class Currency : DropDownValueBase { }






}
