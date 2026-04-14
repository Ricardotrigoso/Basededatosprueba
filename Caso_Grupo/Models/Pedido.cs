using System;
using System.Collections.Generic;

namespace Caso_Grupo.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public DateTime Fecha { get; set; }

    public int IdProveedor { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
