﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Contato
/// </summary>
public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public override string ToString()
    {
        return Nome;
    }
}