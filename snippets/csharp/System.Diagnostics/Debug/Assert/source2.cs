﻿using System;
using System.Data;
using System.Diagnostics;

public class Form3
{
    // <Snippet1>
    public static void MyMethod(Type type, Type baseType)
    {
        Debug.Assert(type != null, "Type parameter is null",
           "Can't get object for null type");

        // Perform some processing.
    }
    // </Snippet1>
}
