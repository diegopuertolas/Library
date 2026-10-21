# Library

Crear una clase abstracta:

```csharp
Publicacion
```

con:

- Título.
- Año de publicación.

Crear:

```csharp
Publicacion
 |
 +-- Libro
 |
 +-- Revista
 |
 +-- Comic
```

Añadir una propiedad específica a cada clase.

Por ejemplo:

- Libro: Autor.
- Revista: Número.
- Comic: Dibujante.

Todas las publicaciones deberán implementar:

```csharp
ObtenerDescripcion()
```

Crear diferentes objetos y almacenarlos en:

```csharp
List<Publicacion>
```

Mostrar posteriormente todas las publicaciones.

## Publicaciones por año

Solicitar:

```csharp
Mostrar publicaciones posteriores al año:
```

Validar el dato mediante:

```csharp
int.TryParse()
```

Mostrar solamente las publicaciones cuyo año sea superior al indicado.

Si el usuario introduce un valor que no sea un número, mostrar un mensaje de error.