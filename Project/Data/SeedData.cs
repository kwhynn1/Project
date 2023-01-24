using Microsoft.EntityFrameworkCore;

namespace Project.Data
{
    public class SeedData
    {
        public static void Initialize(ProjectContext context)
        {
                if (context == null || context.Product == null)
                {
                    throw new ArgumentNullException("Null Context");
                }

                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange
                    (

                    new Models.Product
                    {
                        ProductName = "Winter Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 2,
                        ImageName = "2.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "Ellese Coat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 2,
                        ImageName = "3.jpg"
                    },
                    new Models.Product
                    {

                        ProductName = "North FaceCoat",
                        ProductDescription = "Coat In Winter",
                        Category = "Coat",
                        Price = 2,
                        ImageName = "1.jpg"
                    }

                    );

                context.SaveChanges();
            }
    }

}

