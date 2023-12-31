﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyCRM.Application.Common.DTOs;
using TinyCRM.Application.Modules.Contact.DTOs;
using TinyCRM.Application.Modules.Contact.Services.Interfaces;
using TinyCRM.Domain.Constants;

namespace TinyCRM.API.Controllers;

[ApiController]
[Route("api/contacts")]
public class ContactController : Controller
{
    private readonly IContactService _service;

    public ContactController(IContactService contactService)
    {
        _service = contactService;
    }

    [HttpGet]
    [Authorize(Policy = Permission.Contact.View)]
    public async Task<ActionResult<PaginationResponseDto<GetContactDto>>> GetAllAsync([FromQuery] ContactQueryDto query)
    {
        return Ok(await _service.GetAllAsync(query));
    }

    [HttpGet("{id:guid}")]
    [ActionName(nameof(GetByIdAsync))]
    [Authorize(Policy = Permission.Contact.View)]
    public async Task<ActionResult<GetContactDto>> GetByIdAsync(Guid id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]
    [Authorize(Policy = Permission.Contact.Create)]
    public async Task<ActionResult<GetContactDto>> CreateAsync([FromBody] AddOrUpdateContactDto model)
    {
        var newContact = await _service.AddAsync(model);

        return CreatedAtAction(nameof(GetByIdAsync), new { id = newContact.Id }, newContact);
    }

    [HttpPut("{id:guid}")]
    [Authorize(Policy = Permission.Contact.Update)]
    public async Task<ActionResult<GetContactDto>> UpdateAsync(Guid id, [FromBody] AddOrUpdateContactDto model)
    {
        var updatedContact = await _service.UpdateAsync(model, id);

        return Ok(updatedContact);
    }

    [HttpDelete("{id:guid}")]
    [Authorize(Policy = Permission.Contact.Delete)]
    public async Task<ActionResult> DeleteAsync(Guid id)
    {
        await _service.DeleteAsync(id);

        return Ok();
    }

    [HttpGet("account/{accountId:guid}/contacts")]
    [Authorize(Policy = Permission.Contact.View)]
    public async Task<ActionResult<PaginationResponseDto<GetContactDto>>> GetAllByAccountIdAsync(Guid accountId,
        [FromQuery] ContactQueryDto query)
    {
        return Ok(await _service.GetAllByAccountIdAsync(accountId, query));
    }
}