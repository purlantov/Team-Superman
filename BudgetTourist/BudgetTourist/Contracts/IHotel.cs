﻿namespace BudgetTourist.Contracts
{
    public interface IHotel
    {
        double NumberOfStars { get; }  //??? maybe we'll have hotels with like 4.5 stars... i don't know?!!?!? double/int/string??
        int NumberOfRooms { get; }
        string Breakfast { get; }

    }
}
