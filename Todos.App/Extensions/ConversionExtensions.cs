﻿namespace Todos.App.Extensions;

public static class ConversionExtensions
{
    public static bool ToBool(this object? value) => value != null && (bool)value;
}
