﻿using AutoMapper;
using NorthwindApi.Application.Commands.AccountCommands;
using NorthwindApi.Application.Commands.CategoriesCommands;
using NorthwindApi.Application.Commands.CustomersCommands;
using NorthwindApi.Application.Commands.EmployeesCommands;
using NorthwindApi.Application.Commands.Orders;
using NorthwindApi.Application.Commands.ProductsCommands;
using NorthwindApi.Application.Commands.ShipperCommands;
using NorthwindApi.Application.Commands.SuppliersCommands;
using NorthwindApi.Application.ViewModels;
using NorthwindApi.Application.ViewModels.AccountViewModels;
using NorthwindApi.Domain.Domain.OrderDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindApi.Application.AutoMapper
{
    public class ViewModelToDomainMapping:Profile
    {
        public ViewModelToDomainMapping()
        {

            //Order Detail Mapping 
            CreateMap<OrderDetailViewModel, OrderDetail>();

            // Customer Mapping
            CreateMap<CustomerViewModel, CustomerAddCommand>()
               .ConstructUsing(c => new CustomerAddCommand(c.CompanyName, c.ContactName, c.ContactTitle,c.Email, c.Address, c.City,
               c.PostalCode, c.Country, c.Phone));

            CreateMap<CustomerViewModel, CustomerUpdateCommand>()
               .ConstructUsing(c => new CustomerUpdateCommand(c.Id,c.CompanyName, c.ContactName, c.ContactTitle, c.Email, c.Address, c.City,
               c.PostalCode, c.Country, c.Phone));

            // Employee Mapping
            CreateMap<EmployeeViewModel, EmployeeAddCommand>()
              .ConstructUsing(c => new EmployeeAddCommand(c.FirstName,c.LastName,c.Title,c.BirthDate,c.HireDate,c.Address,
              c.City,c.PostalCode,c.Country));

            CreateMap<EmployeeViewModel, EmployeeUpdateCommand>()
             .ConstructUsing(c => new EmployeeUpdateCommand(c.Id,c.FirstName, c.LastName, c.Title, c.BirthDate, c.HireDate, c.Address,
             c.City, c.PostalCode, c.Country));


            // Orders Mapping
            CreateMap<OrderViewModel, OrderAddCommand>()
              .ConstructUsing(c => new OrderAddCommand(c.CustomerID,c.EmployeeID,c.OrderDate,c.RequiredDate,c.ShippedDate,
              c.ShipName,c.ShipAddress,c.ShipCity,c.ShipPostalCode,c.ShipCountry, c.ShipVia));

            CreateMap<OrderViewModel, OrderUpdateCommand>()
             .ConstructUsing(c => new OrderUpdateCommand(c.Id,c.CustomerID, c.EmployeeID, c.OrderDate, c.RequiredDate, c.ShippedDate,
              c.ShipName, c.ShipAddress, c.ShipCity, c.ShipPostalCode, c.ShipCountry,c.ShipVia));


            // Product Mapping
            CreateMap<ProductViewModel, ProductAddCommand>()
              .ConstructUsing(c => new ProductAddCommand(c.ProductName,c.SupplierID,c.CategoryID,c.QuantityPerUnit,
              c.UnitPrice,c.UnitsInStock));

            CreateMap<ProductViewModel, ProductUpdateCommand>()
             .ConstructUsing(c => new ProductUpdateCommand(c.Id, c.ProductName, c.SupplierID, c.CategoryID, c.QuantityPerUnit,
              c.UnitPrice, c.UnitsInStock));


            // Shipper Mapping
            CreateMap<ShipperViewModel, ShipperAddCommand>()
              .ConstructUsing(c => new ShipperAddCommand( c.CompanyName,c.Phone));

            CreateMap<ShipperViewModel, ShipperUpdateCommand>()
             .ConstructUsing(c => new ShipperUpdateCommand(c.Id, c.CompanyName,c.Phone));


            // Category Mapping
            CreateMap<CategoryViewModel, CategoryAddCommand>()
              .ConstructUsing(c => new CategoryAddCommand(c.Name, c.Description,c.Picture));

            CreateMap<CategoryViewModel, CategoryUpdateCommand>()
             .ConstructUsing(c => new CategoryUpdateCommand(c.Id, c.Name, c.Description, c.Picture));


            // Supplier Mapping
            CreateMap<SupplierViewModel, SupplierAddCommand>()
              .ConstructUsing(c => new SupplierAddCommand(c.CompanyName,c.ContactName,c.ContactTitle,c.Adress,
              c.City,c.Country,c.Phone));

            CreateMap<SupplierViewModel, SupplierUpdateCommand>()
             .ConstructUsing(c => new SupplierUpdateCommand(c.Id,c.CompanyName, c.ContactName, c.ContactTitle, c.Adress,
              c.City, c.Country, c.Phone));

            // Account Mapping
            CreateMap<AccountRegisterViewModel, AccountRegisterCommand>()
              .ConstructUsing(c => new AccountRegisterCommand(c.Name, c.SurName, c.Email,c.Password));

            CreateMap<AccountViewModel, AccountUpdateCommand>()
             .ConstructUsing(c => new AccountUpdateCommand(c.Id, c.Name, c.SurName, c.Email));

        }
    }
}
