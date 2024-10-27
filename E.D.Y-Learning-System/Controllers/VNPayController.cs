﻿using E.D.Y_Serivce.Interfaces;
using E.D.Y_Serivce.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E.D.Y_Learning_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VNPayController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public VNPayController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("vnpay-return")]
        public async Task<IActionResult> CreateVNPayPayment([FromQuery] PaymentRequest parameters)
        {
            try
            {
                string appScheme = "rolexauthorizedstore";

                if (parameters.vnp_BankTranNo == null)
                {
                    string redirectUrl = $"{appScheme}://payment-failed?orderId={parameters.vnp_TxnRef}";

                    return Redirect(redirectUrl);
                }
                var result = await _paymentService.CreateVNPayPayment(parameters);

                if (result != null)
                {
                    string redirectUrl = $"{appScheme}://payment-success?status={result.TransactionStatus}&orderId={result.OrderId}";

                    return Redirect(redirectUrl);
                }
                else
                {
                    return NotFound("Order does not created");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}