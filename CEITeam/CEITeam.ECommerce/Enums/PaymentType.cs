using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Enums
{
    [Flags]
    public enum PaymentType
    {
        DirectBankTransfer = 1,
        Paypal = 2,
        Mastercard = 4,
        ChequePayment = 8,
        Visa = 16,
        OnDelivery = 32
    }
}
