﻿using System;
using System.Collections.Generic;

namespace MVCReactApp.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Dirección { get; set; }

    public string? Teléfono { get; set; }
}
