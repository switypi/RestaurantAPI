using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.EntityRepository
{
    public class MenuRepository : RepositoryBase<Infrastructure.Entities.Menu>, IMenuRepository
    {
        private RestaurentDbContext context;
        public MenuRepository(RestaurentDbContext repositoryContext)
    : base(repositoryContext)
        {
            context = repositoryContext;
        }

        public void BulkInsertMenu(List<Menu> dt)
        {
            using (var db = new SqliteConnection(context.Database.GetConnectionString()))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var command = db.CreateCommand();
                        command.CommandText =
                        @" INSERT INTO Menu(Category,IsVeg,Name,Price,ServingType,MenuCode)  VALUES ($Category,$IsVeg,$Name,$Price,$ServingType,$MenuCode)";

                        //var parameter12 = command.CreateParameter();
                        //parameter12.ParameterName = "MenuId";
                        //command.Parameters.Add(parameter12);

                        var parameter = command.CreateParameter();
                        parameter.ParameterName = "$Name";
                        command.Parameters.Add(parameter);

                        var parameter1 = command.CreateParameter();
                        parameter1.ParameterName = "$MenuCode";
                        command.Parameters.Add(parameter1);

                        var parameter2 = command.CreateParameter();
                        parameter2.ParameterName = "$Price";
                        command.Parameters.Add(parameter2);

                        var parameter3 = command.CreateParameter();
                        parameter3.ParameterName = "$ServingType";
                        command.Parameters.Add(parameter3);

                        var parameter4 = command.CreateParameter();
                        parameter4.ParameterName = "$Category";
                        command.Parameters.Add(parameter4);

                        var parameter5 = command.CreateParameter();
                        parameter5.ParameterName = "$IsVeg";
                        command.Parameters.Add(parameter5);

                        foreach (var items in dt)
                        {
                            //parameter12.Value = items.MenuId;
                            parameter.Value = items.Name;
                            parameter1.Value = items.MenuCode;
                            parameter2.Value = items.Price;
                            parameter3.Value = items.ServingType;
                            parameter4.Value = items.Category;
                            parameter5.Value = items.IsVeg;

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw;
                    }   
                   
                }
            }
        }
    }
}
