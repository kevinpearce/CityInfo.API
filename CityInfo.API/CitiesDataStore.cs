using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore() //not in the tutorial but if this is a Singleton, why was this Constructor not Private in the first place??
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Bristol",
                    Description = "The home of TripHop",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "The Hippodrome",
                            Description = "Theatre"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "St Georges Park",
                            Description = "Old School Snake Run"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Exeter",
                    Description = "Memories of Flowerpot",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Flowerpot",
                            Description = "Modern Concrete"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Ikea",
                            Description = "To lose the Wife in"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Glastonbury",
                    Description = "Never a dull moment",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Town Centre",
                            Description = "Cafe delight"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Somerton Road",
                            Description = "Long gone wooden park"
                        }
                    }
                }
            };
        }
    }
}
