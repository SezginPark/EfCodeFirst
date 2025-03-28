﻿using DataAccess.Abstract;
using DataAccess.EntityFramework;
using DataAccessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IRoomDa, EfRoomDa>();
        services.AddScoped<IHotelDa, EfHotelDa>();
        services.AddScoped<IReservationDa, EfReservationDa>();


    } 
}
