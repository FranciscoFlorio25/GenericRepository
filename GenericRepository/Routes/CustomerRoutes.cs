using GenericRepository.Application.DTO;
using GenericRepository.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Api.Routes
{
    public static class CustomerRoutes
    {
        public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder builder)
        {
            builder.MapGet(pattern: "/Customers", async ([FromServices] ICustomerService Service) =>
            {
                var result = await Service.GetAllCustomerAync();

                return Results.Ok(result);
            })
            .WithName(endpointName: "GetCustomers")
            .Produces<IEnumerable<ICustomerService>>(StatusCodes.Status200OK, contentType: "application/json");

            builder.MapPost(pattern: "/Customer", async ([FromServices] ICustomerService Service, [FromBody] CustomerDTO producto)
            =>
            {
                await Service.CreateNewCustomerAync(producto);

                return Results.Ok(producto);
            })
            .WithName(endpointName: "CreateCustomer")
            .Produces<ICustomerService>(StatusCodes.Status200OK, contentType: "application/json");

            return builder;
        }
    }
}
