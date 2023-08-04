﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyCRM.Application.Common.Constants;
using TinyCRM.Application.Common.DTOs;
using TinyCRM.Application.Modules.Account.DTOs;
using TinyCRM.Application.Modules.Account.Services.Interfaces;

namespace TinyCRM.API.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    [Authorize(Roles = Role.Admin)]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService accountService)
        {
            _service = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationResponseDTO<GetAccountDTO>>> GetAllAsync([FromQuery] AccountQueryDTO query)
        {
            return Ok(await _service.GetAllAsync(query));
        }

        [HttpGet("{id:guid}")]
        [ActionName(nameof(GetByIdAsync))]
        public async Task<ActionResult<GetAccountDTO>> GetByIdAsync(Guid id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<GetAccountDTO>> CreateAsync([FromBody] AddOrUpdateAccountDTO model)
        {
            var newAccount = await _service.AddAsync(model);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = newAccount.Id }, newAccount);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<GetAccountDTO>> UpdateAsync(Guid id, [FromBody] AddOrUpdateAccountDTO model)
        {
            var updatedAccount = await _service.UpdateAsync(model, id);

            return Ok(updatedAccount);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _service.DeleteAsync(id);

            return Ok();
        }
    }
}