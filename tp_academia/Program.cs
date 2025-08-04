using Dominio;
using System.Diagnostics;
using System.Text.Json;
using tp_academia.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:5170");
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/users", () =>
{
    var userList = User.Lista.Where(user => user.Deleted == false).Select(user => new UserGetAllDto { 
        IdUsuario = user.IdUsuario,
        NombreUsuario = user.NombreUsuario,
        Apellido = user.Apellido,
        Nombre = user.Nombre,
        Email = user.Email,
        Clave = user.Clave,
        CambiaClave = user.CambiaClave,
        Habilitado = user.Habilitado,
        IdPersona = user.IdPersona
    }).ToList();
    return Results.Ok(userList);
});

app.MapGet("/users/{id}", (int id) =>
{
    User? userSearched = User.Lista.FirstOrDefault(user => user.IdUsuario == id);
    if (userSearched is null)
    {
        return Results.NotFound();
    }
    var dto = new UserGetAllDto
    {
        IdUsuario = userSearched.IdUsuario,
        NombreUsuario = userSearched.NombreUsuario,
        Clave = userSearched.Clave,
        Habilitado = userSearched.Habilitado,
        Nombre = userSearched.Nombre,
        Apellido = userSearched.Apellido,
        Email = userSearched.Email,
        CambiaClave = userSearched.CambiaClave,
        IdPersona = userSearched.IdPersona
    };
    return Results.Ok(dto);
});

app.MapPost("/users", (UserCreateDto dto) =>
{
    var newUser = new User(
        dto.NombreUsuario,
        dto.Clave,
        dto.Habilitado,
        dto.Nombre,
        dto.Apellido,
        dto.Email,
        dto.IdPersona
    );
    User.AddUser(newUser);
    return Results.Created($"/users/{newUser.IdUsuario}", newUser);
});

app.MapPut("/users/{id}", (int id, UserUpdateDto userUpdated) =>
{
    User? userToUpdate = User.Lista.FirstOrDefault(user => user.IdUsuario == id);
    if (userToUpdate is null)
    {
        return Results.NotFound();
    }
    if ((string.IsNullOrWhiteSpace(userUpdated.NombreUsuario) ||
    string.IsNullOrWhiteSpace(userUpdated.Clave) ||
    string.IsNullOrWhiteSpace(userUpdated.Nombre) ||
    string.IsNullOrWhiteSpace(userUpdated.Apellido) ||
    string.IsNullOrWhiteSpace(userUpdated.Email) ||
    !userUpdated.Habilitado.HasValue ||
    !userUpdated.CambiaClave.HasValue ||
    !userUpdated.IdPersona.HasValue))
    {
        return Results.BadRequest("Faltan datos obligatorios.");
    }
    userToUpdate.UpdateUser(
            userUpdated.NombreUsuario,
            userUpdated.Clave,
            userUpdated.Nombre,
            userUpdated.Apellido,
            userUpdated.Email,
            userUpdated.Habilitado.Value,
            userUpdated.CambiaClave.Value,
            userUpdated.IdPersona.Value);
    return Results.Ok(userToUpdate);
});

app.MapPatch("/users/{id}", (int id) =>
{
    User? userSearched = User.Lista.FirstOrDefault(user => user.IdUsuario == id);
    if (userSearched is null)
    {
        return Results.NotFound();
    }
    userSearched.DeleteUser();
    return Results.Ok(userSearched);
});

app.Run();
