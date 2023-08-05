﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TinyCRM.Domain.Enums;

namespace TinyCRM.Application.Modules.Lead.DTOs
{
    public class AddLeadDTO
    {
        public string Title { get; set; } = null!;

        public Guid CustomerId { get; set; }

        public string? Description { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [EnumDataType(typeof(LeadSourceEnum))]
        public LeadSourceEnum? Source { get; set; }
    }
}