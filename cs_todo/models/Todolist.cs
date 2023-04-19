﻿using System;
using System.Collections.Generic;

namespace TodoList.Models;

public partial class Todolist
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Desc { get; set; }

    public ulong? IsComplated { get; set; }
}
