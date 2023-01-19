using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UsuarioPipeDriveAmbient
{
    public int Id { get; set; }

    public int UserPipeDriveId { get; set; }

    public int UserAmbientId { get; set; }
}
