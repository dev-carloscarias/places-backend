using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Dtos.Site;

/// <summary>
/// DTO para actualizar los precios de un sitio incluyendo precios base, costos adicionales, 
/// opciones de transporte (vehículos) y paquetes especiales
/// </summary>
public class PricesDto
{
    /// <summary>
    /// Precio por adulto
    /// </summary>
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "El precio de adulto debe ser mayor o igual a 0")]
    public decimal AdultPrice { get; set; }

    /// <summary>
    /// Precio por niño
    /// </summary>
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "El precio de niño debe ser mayor o igual a 0")]
    public decimal ChildPrice { get; set; }

    /// <summary>
    /// Lista de opciones de transporte/vehículos disponibles para el sitio
    /// </summary>
    public List<TransportOptionDto> TransportOptions { get; set; } = new List<TransportOptionDto>();

    /// <summary>
    /// Lista de costos adicionales del sitio
    /// </summary>
    public List<AdditionalCostDto> AdditionalCosts { get; set; } = new List<AdditionalCostDto>();

    /// <summary>
    /// Paquete especial opcional del sitio
    /// </summary>
    public SpecialPackageDto? SpecialPackage { get; set; }
}

/// <summary>
/// DTO para las opciones de transporte/vehículos en el contexto de actualización de precios
/// </summary>
public class TransportOptionDto
{
    /// <summary>
    /// ID de la opción de transporte
    /// </summary>
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Nombre del tipo de transporte/vehículo
    /// </summary>
    [Required]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Precio de la opción de transporte
    /// </summary>
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
    public decimal Price { get; set; }

    /// <summary>
    /// Indica si esta opción de transporte está seleccionada/disponible para el sitio
    /// </summary>
    public bool Selected { get; set; }
}

/// <summary>
/// DTO para los costos adicionales en el contexto de actualización de precios
/// </summary>
public class AdditionalCostDto
{
    /// <summary>
    /// Nombre del costo adicional
    /// </summary>
    [Required]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Precio del costo adicional
    /// </summary>
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
    public decimal Price { get; set; }
}

/// <summary>
/// DTO para el paquete especial en el contexto de actualización de precios
/// </summary>
public class SpecialPackageDto
{
    /// <summary>
    /// Nombre del paquete especial
    /// </summary>
    [Required]
    [StringLength(200, ErrorMessage = "El nombre no puede exceder 200 caracteres")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Precio del paquete especial
    /// </summary>
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
    public decimal Price { get; set; }

    /// <summary>
    /// Lista de elementos incluidos en el paquete
    /// </summary>
    public List<string> Includes { get; set; } = new();
}

