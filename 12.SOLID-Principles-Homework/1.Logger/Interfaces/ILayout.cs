using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Logger.Interfaces
{
    public interface ILayout
    {
        string FormatMessage(params string[] arguments);
    }
}