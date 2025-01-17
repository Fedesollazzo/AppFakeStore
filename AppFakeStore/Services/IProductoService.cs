﻿using AppFakeStore.Models;

namespace AppFakeStore.Services;

public interface IProductoService
{
    Task<IEnumerable<Producto>> GetProductsAsync();
    Task<IEnumerable<Usuarios>> GetUserAsync();
}
