using DB_Relations_Examples.Models;
using DB_Relations_Examples.Repositories;
using DB_Relations_Examples.Repositories.Interfaces;
using DB_Relations_Examples.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DB_Relations_Examples
{
    class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER02;Database=HotelDataBaseFixed;Trusted_Connection=True;");
            });
            services.AddScoped<IFacilityRepository, FacilityRepository>();
            services.AddScoped<IHotelFacilityRepository, HotelFacilityRepository>();
            ServiceProvider = services.BuildServiceProvider();
            DbInitializer.Seed(ServiceProvider.GetRequiredService<ApplicationDbContext>());

            var _facilityRepository = ServiceProvider.GetRequiredService<IFacilityRepository>();
            var _hotelFacilityRepository = ServiceProvider.GetRequiredService<IHotelFacilityRepository>();
            string[] command = Console.ReadLine().Split("/").ToArray();
            while(command[0] != "End")
            {
                if(command[0] == "Facility")
                {
                    if(command[1] == "Add")
                    {
                        string inputName = command[2];
                        string inputDescription = command[3];
                        if (inputName.Length > 1 && inputDescription.Length > 1)
                        {
                            Facility facility = new Facility { Name = inputName, Description = inputDescription };
                            _facilityRepository.AddFacility(facility);
                            Console.WriteLine("Successfully created");
                        }
                        else
                        {
                            Console.WriteLine("Please Give Values for Name and Description");
                        }
                    }
                    else if(command[1] == "Update")
                    {
                        int inputId = int.Parse(command[2]);
                        string inputName = command[3];
                        string inputDescription = command[4];
                        Facility facility = new Facility { Id = inputId, Name = inputName, Description = inputDescription };
                        _facilityRepository.UpdateFacility(facility);
                        Console.WriteLine("Successfully updated");
                    }
                    else if(command[1] == "Delete")
                    {
                        int inputId = int.Parse(command[2]);
                        _facilityRepository.DeleteFacility(inputId);
                        Console.WriteLine("Successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("The Command is Not Existing!");
                    }
                

                }
                else if(command[0] == "Hotel")
                {

                }
                else if(command[0] == "TypeHotel")
                {

                }
                else if(command[0] == "HotelFacility")
                {
                    if (command[1] == "Delete")
                    {
                        int hotelId = int.Parse(command[2]);
                        int facilityId = int.Parse(command[3]);
                        _hotelFacilityRepository.DeleteHotelFacility(hotelId, facilityId);
                        Console.WriteLine("Deleted!");
                    }
                }
                else
                {
                    Console.WriteLine("This Entitity is not existing");
                }
                command = Console.ReadLine().Split("/").ToArray();
            }
            foreach (var currentFacility in _facilityRepository.GetAllFacilities)
            {
                Console.WriteLine($"{currentFacility.Id} - {currentFacility.Name} -> {currentFacility.Description}");
            }
        }
    }
}
