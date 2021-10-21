﻿namespace Payment.PaymentRequests
{
    public static class PaymentRequestConsts
    {
        public static int MaxCustomerIdLength { get; set; } = 100;
        public static int MaxProductIdLength { get; set; } = 100;
        public static int MaxProductNameLength { get; set; } = 200;
    }
}