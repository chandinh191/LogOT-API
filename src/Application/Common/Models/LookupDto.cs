﻿using LogOT.Application.Common.Mappings;
using LogOT.Domain.Entities;
using LogOT.Domain.Entities;

namespace LogOT.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public string? Title { get; init; }
}
