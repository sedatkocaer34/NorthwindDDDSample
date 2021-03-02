﻿using NorthwindApi.Domain.Validation.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindApi.Domain.Commands.Orders
{
    public class OrderRemoveCommand:OrderCommand
    {
        public OrderRemoveCommand(Guid orderID)
        {
            Id = orderID;
        }

        public override bool IsValid()
        {
            ValidationResult = new OrderRemoveValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}