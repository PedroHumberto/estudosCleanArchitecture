﻿using Amigos.Application.Interfaces;
using Amigos.Data.Data;
using Amigos.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos.Data.InversionOfControl
{
    public class DependencyInjection
    {
        public static void Inject(IServiceCollection services, ConfigurationManager configuration)
        {
            //DbContext
            services.AddDbContext<FriendsDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));

            //Interfaces Injections
            services.AddScoped<IFriendRepository, FriendRepository>();

        }
    }
}