using System.Data;
using Contracts;
using Dapper;
using Entities.Models;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Repository.DapperMapping;

namespace Repository;

public class RepositoryBase
{
    private string _connSting;

    public RepositoryBase(IConfiguration configuration)
    {
        _connSting = configuration.GetConnectionString("PostgreSQL");
        Dapper.SqlMapper.SetTypeMap(
            typeof(Token),
            new ColumnAttributeTypeMapper<Token>());
        Dapper.SqlMapper.SetTypeMap(
            typeof(Tweet),
            new ColumnAttributeTypeMapper<Tweet>());
    }
    public IDbConnection Connection
    {
        get => new NpgsqlConnection(_connSting);
    }
}