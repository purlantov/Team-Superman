﻿namespace BudgetTourist.Models.TransportModels
{
    using System;
    using System.Collections.Generic;

    using BudgetTourist.TransportEnums.Enum;
    using BudgetTourist.TransportContracts.Contracts;

    public abstract class RentACar : IVehicles
    {
        public RentACar(string model, int year, decimal priceForDay)
        {
            this.Model = model;
            this.Year = year;
            this.PricePerDay = priceForDay;
        }

        public string Model { get; private set; }

        public int Year { get; private set; }

        public decimal PricePerDay { get; private set; }

        public VehiclesType Type { get; protected set; }

        public override string ToString()
        {
            return string.Format("Model: {0} Year: {1} Price: {2}lv.", this.Model, this.Year, this.PricePerDay);
        }
    }
}