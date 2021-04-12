using DB_Relations_Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Relations_Examples.Seed
{
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if(!context.TypeHotels.Any())
            {
                context.TypeHotels.AddRange(TypeHotels.Select(c => c.Value));
            }
            context.SaveChanges();

            if (!context.Facilities.Any())
            {
                context.Facilities.AddRange(Facilities.Select(c => c.Value));
            }
            context.SaveChanges();
        }
        private static Dictionary<string, TypeHotel> typehotels;
        public static Dictionary<string, TypeHotel> TypeHotels 
        {
            get
            {
                if (typehotels == null)
                {
                    var typeHotelList = new TypeHotel[]
                    {
                    new TypeHotel { Name = "Hotel" , Description = "Good choice for a couple"},
                    new TypeHotel { Name = "Appartament" , Description = "Very cheap for close friends"},
                    new TypeHotel { Name = "GuestHouse" , Description = "Very good for big parties"}
                    };
                    typehotels = new Dictionary<string, TypeHotel>();
                    foreach (TypeHotel typeHotel in typeHotelList)
                    {
                        typehotels.Add(typeHotel.Name, typeHotel);
                    }
                }
                return typehotels;
            }
        }

        private static Dictionary<string, Facility> facilities;
        public static Dictionary<string, Facility> Facilities
        {
            get
            {
                if (facilities == null)
                {
                    var facilitiyList = new Facility[]
                    {
                    new Facility { Name = "Swimming Pool" , Description = "Good for swimming"},
                    new Facility { Name = "Air Conditioner" , Description = "Good if you like to be in your house"},
                    new Facility { Name = "Gym" , Description = "Very good for making muscles"}
                    };
                    facilities = new Dictionary<string, Facility>();
                    foreach (Facility facility in facilitiyList)
                    {
                        facilities.Add(facility.Name, facility);
                    }
                }
                return facilities;
            }
        }
    }
}
