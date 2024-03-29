﻿global using Swashbuckle.AspNetCore.SwaggerGen;
global using System.Collections.Generic;
global using System.Data.Common;
global using System.Data.SqlClient;
global using System.IdentityModel.Tokens.Jwt;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Reflection;
global using System.Runtime.Serialization;
global using System.Threading.Tasks;
global using System.Threading;
global using System;
global using TestManagement.Infrastructure;
global using Serilog;
global using Serilog.Context;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Data.SqlClient;
global using Microsoft.AspNetCore;
global using TestManagement.API;
global using TestManagement.API.Extensions;
global using TestManagement.API.Filter;
global using TestManagement.Domain.Common;
global using TestManagement.Infrastructure.Context;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using MediatR;
global using TestManagement.Application.Commands.TestCenter;
global using TestManagement.Application;
global using TestManagement.Application.Queries.TestCenter;
global using TestManagement.Application.Commands.Booking;
global using TestManagement.Application.Queries.Booking;
global using TestManagement.Application.Commands;
global using TestManagement.Application.Commands.SpecimenInformation;
global using TestManagement.Application.Commands.Result;
global using System.Text.Json.Serialization;