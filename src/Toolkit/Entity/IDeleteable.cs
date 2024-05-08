using System;
using System.Collections.Generic;
using System.Text;

namespace Sharemee.Toolkit.Entity;

public interface IDeleteable
{
    /// <summary>
    /// Soft delete
    /// </summary>
    /// <remarks>If true is deleted</remarks>
    bool IsDeleted { get; set; }
}
