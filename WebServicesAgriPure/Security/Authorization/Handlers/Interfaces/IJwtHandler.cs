﻿using WebServicesAgriPure.Security.Domain.Models;

namespace WebServicesAgriPure.Security.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(User user);
    public int? ValidateToken(string token);

}