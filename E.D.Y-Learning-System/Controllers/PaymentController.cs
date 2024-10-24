﻿using E.D.Y_Serivce.Interfaces;
using E.D.Y_Serivce.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E.D.Y_Learning_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _PaymentService;

        public PaymentController(IPaymentService PaymentService)
        {
            _PaymentService = PaymentService;
        }

        // GET: api/<PaymentController>
        [HttpGet("all-Payment")]
        public async Task<IActionResult> GetPayments()
        {
            var users = await _PaymentService.GetAllPaymentAsync();
            if (users == null)
                return NotFound();

            return Ok(users);
        }

        [HttpGet("all-Payment-byUID")]
        public async Task<IActionResult> GetPaymentsByUID(string uid)
        {
            var users = await _PaymentService.GetAllPaymentByUIDAsync(uid);
            if (users == null)
                return NotFound();

            return Ok(users);
        }

        // GET api/<PaymentController>
        [HttpGet("get-Payment-by-id")]
        public async Task<IActionResult> GetPaymentByID(int id)
        {
            try
            {
                var users = await _PaymentService.GetPaymentByIdAsync(id);
                if (users == null)
                    return NotFound();

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<PaymentController>
        [HttpPost("add-Payment")]
        public async Task<IActionResult> AddPayment(PaymentViewModel Payment)
        {
            try
            {
                var result = await _PaymentService.CreatePaymentAsync(Payment);
                if (result != true)
                {
                    return NotFound();
                }
                return Ok("Create Payment Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PaymentController>
        [HttpPut("update-Payment")]
        public async Task<IActionResult> UpdatePayment(PaymentViewModel Payment)
        {
            try
            {
                var result = await _PaymentService.UpdatePaymentAsync(Payment);
                if (result != true)
                {
                    return NotFound();
                }
                return Ok("Update Payment Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PaymentController>
        [HttpDelete("delete-Payment")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            try
            {
                var result = await _PaymentService.GetPaymentByIdAsync(id);
                return Ok("Delete Payment Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
