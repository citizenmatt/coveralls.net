﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coveralls.Lib
{
    public interface IFileSystem
    {
        string LoadFileText(string path);
    }
}