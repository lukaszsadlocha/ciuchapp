﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Reflection;

namespace CiuchApp.Domain
{
    public class BusinessTrip : CiuchAppBaseModel
    {
        #region Domain Properties
        [DisplayName("Data od")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [Required]
        public DateTime DateFrom { get; set; }

        [DisplayName("Data do")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [Required]
        public DateTime DateTo { get; set; }
        [DisplayName("Kraj")]
        public virtual Country Country { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int CountryId { get; set; }
        [DisplayName("Miasto")]
        public virtual City City { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int CityId { get; set; }
        [DisplayName("Sezon")]
        public virtual Season Season { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int SeasonId { get; set; }
        [DisplayName("Waluta")]
        public virtual Currency Currency { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int CurrencyId { get; set; }

        public virtual ICollection<Piece> Pieces { get; set; }
        #endregion

        public static string JsonKey => nameof(BusinessTrip) + "Json";
        public static string JsonListKey => nameof(BusinessTrip) + "List" + "Json";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static string SerializeList(List<BusinessTrip> businessTrips)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(businessTrips);
        }
        public static BusinessTrip Deserialize(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessTrip>(json);
        }

        public static List<BusinessTrip> DeserializeList(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BusinessTrip>>(json);
        }
    }
}
