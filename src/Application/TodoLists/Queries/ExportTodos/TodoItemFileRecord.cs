using LogOT.Application.Common.Mappings;
using LogOT.Domain.Entities;
using LogOT.Domain.Entities;

namespace LogOT.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
