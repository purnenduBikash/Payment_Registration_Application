using System;
using System.Collections.Generic;

namespace Payment_Registration_Application.Models;

public partial class PaymentDetail
{
    public int PaymentDetailsId { get; set; }

    public string CardOwnerName { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public int Cvv { get; set; }

    public string ExpiryDate { get; set; } = null!;
}
