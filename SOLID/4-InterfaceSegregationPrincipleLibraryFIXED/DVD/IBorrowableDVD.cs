﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegregationPrincipleLibraryFIXED
{
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}