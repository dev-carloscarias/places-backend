# Guía de Pruebas - Actualización de Precios de Sitios

## Descripción
Esta guía explica cómo probar la funcionalidad mejorada de actualización de precios que incluye manejo seguro de:
- Precios base (adultos y niños)
- Costos adicionales
- Opciones de transporte/vehículos
- Paquetes especiales

## Mejoras Implementadas

### 1. **Manejo Seguro de Opciones de Transporte**
- ✅ Actualización de precios sin eliminar registros referenciados
- ✅ Manejo correcto del estado `Selected` para vehículos
- ✅ Preservación de IDs existentes para evitar errores FK

### 2. **Cálculo Correcto del Precio Total**
- ✅ Incluye precio base (adultos + niños)
- ✅ Suma costos adicionales
- ✅ Suma opciones de transporte seleccionadas
- ✅ Incluye paquete especial si existe

### 3. **Manejo de Errores Mejorado**
- ✅ Logging detallado de errores
- ✅ Excepciones específicas con contexto
- ✅ Transacciones seguras

## Casos de Prueba

### Caso 1: Actualización Básica de Precios
```json
{
  "adultPrice": 150.00,
  "childPrice": 75.00,
  "transportOptions": [],
  "additionalCosts": [],
  "specialPackage": null
}
```
**Resultado Esperado:** `TotalPrice = 225.00`

### Caso 2: Con Opciones de Transporte
```json
{
  "adultPrice": 150.00,
  "childPrice": 75.00,
  "transportOptions": [
    {
      "id": 1,
      "name": "Automóvil",
      "price": 50.00,
      "selected": true
    },
    {
      "id": 2,
      "name": "Minivan",
      "price": 80.00,
      "selected": false
    }
  ],
  "additionalCosts": [],
  "specialPackage": null
}
```
**Resultado Esperado:** `TotalPrice = 275.00` (solo incluye el automóvil seleccionado)

### Caso 3: Con Costos Adicionales
```json
{
  "adultPrice": 150.00,
  "childPrice": 75.00,
  "transportOptions": [],
  "additionalCosts": [
    {
      "name": "Guía Turístico",
      "price": 30.00
    },
    {
      "name": "Almuerzo",
      "price": 25.00
    }
  ],
  "specialPackage": null
}
```
**Resultado Esperado:** `TotalPrice = 280.00`

### Caso 4: Con Paquete Especial
```json
{
  "adultPrice": 150.00,
  "childPrice": 75.00,
  "transportOptions": [],
  "additionalCosts": [],
  "specialPackage": {
    "name": "Paquete Premium",
    "price": 100.00,
    "includes": ["Guía", "Almuerzo", "Transporte"]
  }
}
```
**Resultado Esperado:** `TotalPrice = 325.00`

### Caso 5: Escenario Completo
```json
{
  "adultPrice": 150.00,
  "childPrice": 75.00,
  "transportOptions": [
    {
      "id": 1,
      "name": "Automóvil",
      "price": 50.00,
      "selected": true
    }
  ],
  "additionalCosts": [
    {
      "name": "Seguro",
      "price": 15.00
    }
  ],
  "specialPackage": {
    "name": "Paquete VIP",
    "price": 200.00,
    "includes": ["Guía Premium", "Cena Gourmet"]
  }
}
```
**Resultado Esperado:** `TotalPrice = 490.00`

## Cómo Probar

### 1. **Usando Postman/Insomnia**
```
PUT /api/sites/{siteId}/prices
Content-Type: application/json
Authorization: Bearer {token}

{JSON del caso de prueba}
```

### 2. **Verificaciones a Realizar**
- ✅ El precio total se calcula correctamente
- ✅ Las opciones de transporte se actualizan sin errores FK
- ✅ Los costos adicionales se mantienen o actualizan según corresponde
- ✅ El paquete especial se crea/actualiza/elimina correctamente
- ✅ Los timestamps se actualizan apropiadamente

### 3. **Verificación en Base de Datos**
```sql
-- Verificar el sitio actualizado
SELECT * FROM Sites WHERE Id = {siteId};

-- Verificar opciones de transporte
SELECT * FROM SelectedTransportOptions WHERE SiteId = {siteId};

-- Verificar costos adicionales
SELECT * FROM AdditionalCosts WHERE SiteId = {siteId};

-- Verificar paquete especial
SELECT sp.*, pi.* 
FROM SpecialPackages sp
LEFT JOIN PackageItems pi ON sp.Id = pi.SpecialPackageId
WHERE sp.SiteId = {siteId};
```

## Solución de Problemas

### Error FK Constraint
**Problema:** Error de restricción de clave foránea
**Solución:** La nueva implementación maneja esto actualizando registros existentes en lugar de eliminarlos

### Precio Total Incorrecto
**Problema:** El precio total no coincide con la suma esperada
**Solución:** Verificar que todos los componentes estén incluidos en el cálculo:
- Precio base (adultos + niños)
- Costos adicionales
- Opciones de transporte seleccionadas
- Paquete especial

### Opciones de Transporte No Se Actualizan
**Problema:** Los vehículos no se marcan como seleccionados/no seleccionados
**Solución:** Verificar que el campo `selected` esté correctamente establecido en el JSON

## Notas Técnicas

- **Multitenancy:** Todos los registros se filtran automáticamente por `tenant_id`
- **RBAC:** Se requieren permisos apropiados para actualizar precios
- **Transacciones:** Las operaciones se realizan en transacciones para garantizar consistencia
- **Logging:** Todos los errores se registran con contexto detallado 