﻿namespace BashSoft.Contracts
{
    public interface IOrderedTaker
    {
        void OrderAndTake(string courseName, string comparison, int? studentToTake = null);
    }
}
