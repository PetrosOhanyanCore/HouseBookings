using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.IService;
using Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace HouseBooking.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    //[Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("AddPayment")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDTO paymentDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _paymentService.AddPaymentAsync(paymentDTO);
                return Ok("Payment added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("GetPayments")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> GetAllPayments()
        {
            try
            {
                var payments = await _paymentService.GetAllPaymentsAsync();
                return Ok(payments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("GetPayment")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            try
            {
                var payment = await _paymentService.GetPaymentByIdAsync(id);

                if (payment == null)
                {
                    return NotFound("Payment not found");
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPut("UpdatePayment")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> UpdatePayment(int id, [FromBody] PaymentDTO paymentDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var existingPayment = await _paymentService.GetPaymentByIdAsync(id);

                if (existingPayment == null)
                {
                    return NotFound("Payment not found");
                }

                await _paymentService.UpdatePaymentAsync(paymentDTO);
                return Ok("Payment updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete("DeletePayment")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> DeletePayment(int id)
        {
            try
            {
                var existingPayment = await _paymentService.GetPaymentByIdAsync(id);

                if (existingPayment == null)
                {
                    return NotFound("Payment not found");
                }

                await _paymentService.RemovePaymentAsync(id);
                return Ok("Payment deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }

}
