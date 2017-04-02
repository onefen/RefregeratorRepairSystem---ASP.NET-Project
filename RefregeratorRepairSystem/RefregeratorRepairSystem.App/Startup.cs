﻿using System;
using Microsoft.Owin;
using Owin;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RefregeratorRepairSystem.Data;
using RefregeratorRepairSystem.Models.BindingModels;
using RefregeratorRepairSystem.Models.EntityModels;
using RefregeratorRepairSystem.Models.ViewModels.Account;
using RefregeratorRepairSystem.Models.ViewModels.Customers;

[assembly: OwinStartupAttribute(typeof(RefregeratorRepairSystem.App.Startup))]
namespace RefregeratorRepairSystem.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAutommapper();
            ConfigureAuth(app);
        }

        private void ConfigureAutommapper()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<RegisterViewModel, Customer>();
                expression.CreateMap<Customer, ListCustomerViewModel>();
                expression.CreateMap<Customer, CustomerToEmployeeViewModel>();
                expression.CreateMap<CreateEmployeeBindingModel, Employee>();
            });
        }
    }
}
